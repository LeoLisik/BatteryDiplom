<?php
session_start();
if (isset($_POST['phone'])) {
    //TODO: валидация (Не забыть проверить уже зареганый телефон)
    $serverName = "26.159.241.191";
    $uid = "da";
    $pwd = "da";
    $connectionInfo = array(
        "UID" => $uid,
        "PWD" => $pwd,
        "Database" => "Batteries",
        "CharacterSet" => "UTF-8"
    );
    $conn = sqlsrv_connect($serverName, $connectionInfo);
    if ($conn === false) {
        echo "Ошибка, сервис временно недоступен.</br>";
        die(print_r(sqlsrv_errors(), true));
    }

    // Получение пользователя
    if (isset($_COOKIE['idUser'])) {
        $idUser = $_COOKIE['idUser'];
    }
    if (!isset($_COOKIE['idUser'])) {
        $tsql = "SELECT idUser FROM [user] WHERE phoneNumber = '" . $_POST['phone'] . "'";
        $stmt = sqlsrv_query($conn, $tsql);
        if ($stmt === false) {
            echo "Ошибка, сервис временно недоступен";
            die();
        }
        $row = sqlsrv_fetch_array($stmt);
        if ($row) {
            // Извлечение существующего пользователя
            $idUser = $row[0];
            sqlsrv_free_stmt($stmt);
        } else {
            // Создание пользователя
            if ($_POST['email'] != "") {
                $email = "'" . $_POST['email'] . "'";
            } else {
                $email = "NULL";
            }
            $tsql = "INSERT INTO [user] ([name], phoneNumber, [login], [status], [role]) VALUES ('" . $_POST['name'] . "', '" . $_POST['phone'] . "', " . $email . ", 'Активен', 'Пользователь');";
            $stmt = sqlsrv_query($conn, $tsql);
            if ($stmt === false) {
                echo "Ошибка, сервис временно недоступен.</br>";
                die(print_r(sqlsrv_errors(), true));
            }
            sqlsrv_free_stmt($stmt);

            // Получение id созданного пользователя
            $tsql = "SELECT idUser FROM [user] WHERE phoneNumber = '" . $_POST['phone'] . "'";
            $stmt = sqlsrv_query($conn, $tsql);
            if ($stmt === false) {
                echo "Ошибка, сервис временно недоступен.</br>";
                die(print_r(sqlsrv_errors(), true));
            }
            $row = sqlsrv_fetch_array($stmt);
            $idUser = $row[0];
            sqlsrv_free_stmt($stmt);
        }
    }

    // Создание заказа
    $orderDate = substr(date(DATE_ATOM), 0, -6);
    $tsql = "INSERT INTO [order] (idUser, idShop, [status], totalPrice, orderDate) 
            VALUES (" . $idUser . ", 4, 'Активен', 0, '" . $orderDate . "')";
    $stmt = sqlsrv_query($conn, $tsql);
    if ($stmt === false) {
        echo "Ошибка, сервис временно недоступен.</br>";
        die(print_r(sqlsrv_errors(), true));
    }
    sqlsrv_free_stmt($stmt);

    // Получение id созданного заказа
    $tsql = "SELECT idOrder FROM [order] WHERE orderDate = '" . $orderDate . "'";
    $stmt = sqlsrv_query($conn, $tsql);
    if ($stmt === false) {
        echo "Ошибка, сервис временно недоступен.</br>";
        die(print_r(sqlsrv_errors(), true));
    }
    $row = sqlsrv_fetch_array($stmt);
    $idOrder = $row[0];
    sqlsrv_free_stmt($stmt);

    // Создание товаров в заказе
    $cart = unserialize($_COOKIE['cart']);
    $tsql = "INSERT INTO batteriesBucket (idOrder, idBatteries, count) 
            VALUES (";
    foreach ($cart as $key => $value) {
        $tsql .= $idOrder . ", " . $key . ", " . $value . "), (";
    }
    $tsql = substr($tsql, 0, -3); // Удалить последнюю запятую
    $stmt = sqlsrv_query($conn, $tsql);
    if ($stmt === false) {
        echo "Ошибка, сервис временно недоступен.</br>";
        die(print_r(sqlsrv_errors(), true));
    }

    // Подсчет и запись суммы
    $tsql = "SELECT SUM(priceBatteries * [count]) FROM menu JOIN [batteriesBucket] AS cart ON cart.idBatteries = menu.idBatteries WHERE cart.idOrder = " . $idOrder . ";";
    $stmt = sqlsrv_query($conn, $tsql);
    if ($stmt === false) {
        echo "Ошибка, сервис временно недоступен.</br>";
        die(print_r(sqlsrv_errors(), true));
    }
    $row = sqlsrv_fetch_array($stmt);
    $tsql = "UPDATE [order] SET totalPrice = " . $row[0] . " WHERE idOrder = " . $idOrder . ";";
    $stmt = sqlsrv_query($conn, $tsql);
    if ($stmt === false) {
        echo "Ошибка, сервис временно недоступен.</br>";
        die(print_r(sqlsrv_errors(), true));
    }

    sqlsrv_free_stmt($stmt);
    sqlsrv_close($conn);
    setcookie("cart", "", time() - 3600);
    echo '<script>alert("Ваш заказ принят! В ближайшее время наш менеджер свяжется с вами.");</script>';
}
?>
<?php // ! Эти действия дублируются в середине страницы на клиенте (При редактировании менять и там)
if (isset($_GET['action']) and isset($_GET['product']) and $_GET['action'] == "remove") {
    if (isset($_COOKIE['cart'])) {
        $cart = unserialize($_COOKIE['cart']);
        unset($cart[$_GET['product']]);
        setcookie('cart', serialize($cart));
    }
}
?>
<?php // ! Эти действия дублируются в середине страницы на клиенте (При редактировании менять и там)
if (isset($_GET['action']) and isset($_GET['product']) and $_GET['action'] == "changeAmount") {
    if (isset($_COOKIE['cart'])) {
        $cart = unserialize($_COOKIE['cart']);
        $cart[$_GET['product']] = $_GET['amount'];
        setcookie('cart', serialize($cart));
    }
}
?>
<!DOCTYPE html>
<html lang="ru">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link type="text/css" rel="stylesheet" href="../css/index.css">
    <link type="text/css" rel="stylesheet" href="../css/cart.css">
    <title>Cart</title>
</head>

<body>
    <header>
        <div class="dropdown">
            <a id="menu-button"><img width="68px" height="58px" src="../images/header/Menu.png" alt="menu"></a>
            <div class="dropdown-options">
                <a href="index.php">Главная</a>
                <a href="katalog.php">Каталог</a>
                <a href="#">Корзина</a>
                <a href="profile.php">Профиль</a>
                <a href="orders.php">История заказов</a>
            </div>
        </div>
        <a href="index.php" id="header-logo"><img width="200px" height="60px" src="../images/logo.svg" alt="logo"></a>
        <!-- Подкачка фото -->
        <a href="profile.php" id="user-button"><img width="55px" height="55px" src="../images/header/UserPhoto.png" alt="user-icon"></a>
        <a href="#" id="cart-button"><img width="50px" height="50px" src="../images/header/Cart.png" alt="cart"></a>
    </header>

    <main>
        <?php
        // * Повторение действий с куки на клиенте
        if (isset($_GET['action']) and isset($_GET['product']) and isset($_COOKIE['cart']) and $_GET['action'] == "remove") {
            $cart = unserialize($_COOKIE['cart']);
            unset($cart[$_GET['product']]);
        } else if (isset($_GET['action']) and isset($_GET['product']) and $_GET['action'] == "changeAmount") {
            $cart = unserialize($_COOKIE['cart']);
            $cart[$_GET['product']] = $_GET['amount'];
        } else {
            $cart = unserialize($_COOKIE['cart']);
        }
        if (isset($_POST['phone'])) {
            $cart = array();
        }
        $serverName = "26.159.241.191";
        $uid = "da";
        $pwd = "da";
        $connectionInfo = array(
            "UID" => $uid,
            "PWD" => $pwd,
            "Database" => "Batteries",
            "CharacterSet" => "UTF-8"
        );
        $conn = sqlsrv_connect($serverName, $connectionInfo);
        if ($conn === false) {
            echo "Ошибка, сервис временно недоступен.</br>";
            die(print_r(sqlsrv_errors(), true));
        }
        $sum = 0;
        if (empty($cart)) {
            echo '
                        <h2>Корзина пуста и готова к вашим покупкам</h2>
                        ';
        } else {
            echo '
                <div class="stuffs">
                    <h2>Оформление заказа</h2>
                    <table>
                    <tr class="title">
                        <th></th>
                        <th>Наименование</th>
                        <th>Цена</th>
                        <th>Количество</th>
                        <th>Сумма </th>
                        <th></th>
                    </tr>
            ';
            foreach ($cart as $key => $item) {
                $tsql = "SELECT idBatteries, nameBatteries, priceBatteries, photoBatteries FROM menu WHERE idBatteries = " . $key;
                $stmt = sqlsrv_query($conn, $tsql);
                if ($stmt === false) {
                    echo "Ошибка, сервис временно недоступен.</br>";
                    die(print_r(sqlsrv_errors(), true));
                }
                $row = sqlsrv_fetch_array($stmt);
                $sum += $row[2] * $item;
                echo '
                        <tr>
                        <td><img width="100px" height="100px" src="data:image/jpeg;base64,' . base64_encode($row[3]) . '"></td>
                        <td><a href="card.php?product=' . $row[0] . '">' . $row[1] . '</td></a>
                        <td>' . $row[2] . ' руб.</td>
                        <td><div class="number">
                            <button class="number-minus" type="button" onclick="this.nextElementSibling.stepDown(); this.nextElementSibling.onchange();">-</button> <!-- Убрать кнопки или реализовать их использование -->
                            <input name="amount" type="number" min="1" onchange="window.location.href = `?action=changeAmount&product=' . $key . '&amount=${this.value}`" value="' . $item . '">
                            <button class="number-plus" type="button" onclick="this.previousElementSibling.stepUp(); this.previousElementSibling.onchange();">+</button>
                        </div></td>
                        <td>' . $row[2] * $item . ' руб.</td>
                        <td><a href="?action=remove&product=' . $row[0] . '"><button class="delete"></button></a></td>
                        </tr>
                        ';
            }
            echo '
                    <tr>
                        <td id="price" colspan="6">Итого: ' . $sum . ' руб.</td>
                    </tr>
                    </table>
                    </div>
                        <div class="contact-info">
                            <h2>Контактная информация</h2>
                ';
            if (!isset($_COOKIE['idUser'])) {
            echo '
                <form method="post">
                    <div class="contact-block">
                        <div class="form-field">
                            <div class="obligatory-field"><p class="warning">*</p>
                                <p>Ваше имя:</p></div>
                                <input name="name" type="text">
                        </div>
                        <div class="form-field">
                            <div class="obligatory-field"><p class="warning">*</p>
                                <p>Номер телефона:</p></div>
                                <input name="phone" type="text">
                        </div>
                    </div>
                    <div class="contact-block" id="right-block">
                            <div class="form-field">
                                <p>Электронная почта:</p>
                                <input name="email" type="email">
                            </div>
                            
                            <div class="form-field">
                                <p>Промокод:</p>
                                <input name="promo" type="text">
                            </div>
                    </div>
                    <div>
                        <button type="submit">Отправить</button>
                    </div>
                </form>
                </div>
                ';
            }
            if (isset($_COOKIE['idUser'])) {
                echo '
                <form method="post">
                    <div>
                        <h3>Ваши контактные данные будут взяты из вашего профиля</h3>
                        <button type="submit">Оформить заказ</button>
                    </div>
                </form>
                </div>
                ';
            }
            sqlsrv_free_stmt($stmt);
        }
        sqlsrv_close($conn);
        ?>
    </main>

    <footer>
        <div id="left-footer">
            <p>Задать вопрос:</p>
            <p>8 (903) 963-08-61</p>
            <p>trufelnaisveni@gmail.com</p>
        </div>
        <div id="center-footer">
            <img width="100px" height="30px" src="../images/logo.svg">
        </div>
        <div id="right-footer">
            <p>Мы в социальных сетях:</p>
            <a href="https://ok.ru/"><img width="40px" height="40px" src="../images/footer/OKIcon.png"></a>
            <a href="https://vk.com/"><img width="40px" height="40px" src="../images/footer/VKIcon.png"></a>
            <a href="https://web.telegram.org/"><img width="40px" height="40px" src="../images/footer/TelegramIcon.png"></a>
            <a href="https://www.youtube.com/"><img width="40px" height="40px" src="../images/footer/YoutubeIcon.png"></a>
        </div>
        <div id="botton-footer">
            <p>Обращаем Ваше внимание на то, что все объявления о
                моделях аккумуляторов, размещенные на настоящем интернет-сайте,
                носят исключительно информационный характер и ни при каких условиях не являются публичной офертой,
                определяемой положениями Статьи 437 Гражданского кодекса Российской Федерации.
                Для получения точной информации о наличии модели с требуемой комплектацией и техническими
                характеристиками, пожалуйста, обращайтесь к менеджерам по продажам. <br><br>
                Вы принимаете условия политики конфиденциальности и пользовательского соглашения каждый раз,
                когда оставляете свои данные в любой форме обратной связи.</p>
        </div>
    </footer>
</body>

</html>
<?php
if (isset($_GET['action']) and isset($_GET['product']) and $_GET['action'] == "remove") {
    session_start();
    if (isset($_COOKIE['cart'])) {
        $cart = unserialize($_COOKIE['cart']);
        unset($cart[array_search($_GET['product'], $cart)]);
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
                <a href="index.html">Главная</a>
                <a href="katalog.php">Каталог</a>
                <a href="cart.php">Корзина</a>
                <a href="profile.php">Профиль</a>
                <a href="orders.php">История заказов</a>
            </div>
        </div>
        <a href="index.html" id="header-logo"><img width="200px" height="60px" src="../images/logo.svg" alt="logo">
            <a href="profile.php" id="user-button"><img width="55px" height="55px" src="../images/header/UserPhoto.png" alt="user-icon"></a>
            <a href="cart.php" id="cart-button"><img width="50px" height="50px" src="../images/header/Cart.png" alt="cart"></a>
    </header>

    <main>
        <?php
        session_start();
        if (isset($_GET['action']) and isset($_GET['product']) and isset($_COOKIE['cart']) and $_GET['action'] == "remove") {
            $cart = unserialize($_COOKIE['cart']);
            unset($cart[array_search($_GET['product'], $cart)]);
            setcookie('cart', serialize($cart));
        } else {
            $cart = unserialize($_COOKIE['cart']);
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
            foreach ($cart as $item) {
                $tsql = "SELECT idBatteries, nameBatteries, priceBatteries, photoBatteries FROM menu WHERE idBatteries = " . $item;
                $stmt = sqlsrv_query($conn, $tsql);
                if ($stmt === false) {
                    echo "Ошибка, сервис временно недоступен.</br>";
                    die(print_r(sqlsrv_errors(), true));
                }
                $row = sqlsrv_fetch_array($stmt);
                $sum += $row[2];
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
                        <tr>
                        <td><img width="100px" height="100px" src="data:image/jpeg;base64,' . base64_encode($row[3]) . '"></td>
                        <td>' . $row[1] . '</td>
                        <td>' . $row[2] . ' руб.</td>
                        <td><div class="number">
                            <button class="number-minus" type="button" onclick="this.nextElementSibling.stepDown(); this.nextElementSibling.onchange();">-</button>
                            <input type="number" min="1" value="1">
                            <button class="number-plus" type="button" onclick="this.previousElementSibling.stepUp(); this.previousElementSibling.onchange();">+</button>
                        </div></td>
                        <td>2000 руб.</td> <!-- $row[цена]*$row[кол-во] -->
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
                            <form>
                                <div class="contact-block">
                                    <div class="form-field">
                                        <div class="obligatory-field"><p class="warning">*</p>
                                            <p>Ваше имя:</p></div>
                                            <input type="text">
                                    </div>
                                    <div class="form-field">
                                        <div class="obligatory-field"><p class="warning">*</p>
                                            <p>Номер телефона:</p></div>
                                            <input type="text">
                                    </div>
                                </div>
                                <div class="contact-block" id="right-block">
                                        <div class="form-field">
                                            <p>Электронная почта:</p>
                                            <input type="email">
                                        </div>
                                        
                                        <div class="form-field">
                                            <p>Промокод:</p>
                                            <input type="text">
                                        </div>
                                </div>
                                <div>
                                    <button type="submit">Отправить</button>
                                </div>
                            </form>
                        </div>
                    ';
        }
        if ($stmt != null) {
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
            <a href="#"><img width="40px" height="40px" src="../images/footer/OKIcon.png"></a>
            <a href="#"><img width="40px" height="40px" src="../images/footer/VKIcon.png"></a>
            <a href="#"><img width="40px" height="40px" src="../images/footer/TelegramIcon.png"></a>
            <a href="#"><img width="40px" height="40px" src="../images/footer/YoutubeIcon.png"></a>
        </div>
        <div id="botton-footer">
            <p>Обращаем Ваше внимание на то, что все объявления о
                моделях аккумуляторов, размещенные на настоящем интернет-сайте,
                носят исключительно информационный характер и ни при каких условиях не являются публичной офертой,
                определяемой положениями Статьи 437 Гражданского кодекса Российской Федерации.
                Для получения точной информации о наличии модели с требуемой комплектацией и техническими характеристиками,
                пожалуйста, обращайтесь к менеджерам по продажам. <br><br>
                Вы принимаете условия политики конфиденциальности и пользовательского соглашения каждый раз,
                когда оставляете свои данные в любой форме обратной связи.</p>
        </div>
    </footer>
</body>

</html>
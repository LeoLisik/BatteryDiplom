<!DOCTYPE html>
<html lang="ru">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link type="text/css" rel="stylesheet" href="../css/index.css">
    <link type="text/css" rel="stylesheet" href="../css/order.css">
    <title>Заказ 10000001</title>
</head>

<body>
    <header>
        <div class="dropdown">
            <a id="menu-button"><img width="68px" height="58px" src="../images/header/Menu.png" alt="menu"></a>
            <div class="dropdown-options">
                <a href="index.php">Главная</a>
                <a href="katalog.php">Каталог</a>
                <a href="cart.php">Корзина</a>
                <a href="profile.php">Профиль</a>
                <a href="orders.php">История заказов</a>
            </div>
        </div>
        <a href="index.php" id="header-logo"><img width="200px" height="60px" src="../images/logo.svg" alt="logo">
            <!-- Выгрузка картинок -->
            <a href="profile.php" id="user-button"><img width="55px" height="55px" src="../images/header/UserPhoto.png" alt="user-icon"></a>
            <a href="cart.php" id="cart-button"><img width="50px" height="50px" src="../images/header/Cart.png" alt="cart"></a>
    </header>

    <div class="wrapper">
        <nav>
            <ul>
                <li>
                    <h3>Информация покупателя</h3>
                </li>
                <li> <a href="profile.php">Мой профиль</a> </li>
                <li> <a href="orders.php">Мои заказы</a> </li>
                <li>
                    <h3>Помощь</h3>
                </li>
                <li> <a href="#">Служба поддержки</a> </li>
            </ul>
        </nav>
        <main>
            <?php
            if (!isset($_GET['order'])) {
                echo "<h2>Ошибка, как вы сюда попали?</h2>";
                die(print_r(sqlsrv_errors(), true));
            }
            session_start();
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

            $tsql = "SELECT idOrder, orderDate, totalPrice, [status], idUser FROM [order] WHERE idOrder = " . $_GET['order'];
            $stmt = sqlsrv_query($conn, $tsql);
            if ($stmt === false) {
                echo "Ошибка, сервис временно недоступен.</br>";
                die(print_r(sqlsrv_errors(), true));
            }
            $row = sqlsrv_fetch_array($stmt);
            if (!$row) {
                echo "<h2>Ошибка, как вы сюда попали?</h2>";
                die(print_r(sqlsrv_errors(), true));
            }
            if ($row[4] != $_COOKIE['idUser']) { //Проверка, что заказ принадлежит нужному пользователю
                echo "<h2>Ошибка, как вы сюда попали?</h2>";
                die();
            }
            $totalPrice = $row[2];
            echo '
                    <h2>Заказ ' . $row[0] . ' от ' . $row[1]->format('Y-m-d H:i:s') . ' Статус: ' . $row[3] . '</h2>
                    <table>
                    <tr>
                        <th>№</th>
                        <th>Изображение</th>
                        <th>Артикул</th>
                        <th>Товар</th>
                        <th>Цена</th>
                        <th>Кол-во</th>
                        <th>Стоимость</th>
                    </tr>
                ';
            $tsql = "SELECT menu.idBatteries, nameBatteries, priceBatteries, photoBatteries, [count] FROM menu JOIN batteriesBucket as bu ON menu.idBatteries = bu.idBatteries WHERE idOrder = " . $_GET["order"] . ";";
            $stmt = sqlsrv_query($conn, $tsql);
            if ($stmt === false) {
                echo "Ошибка, сервис временно недоступен.</br>";
                die(print_r(sqlsrv_errors(), true));
            }
            $productCounter = 0;
            $sum = 0;
            do {
                $productCounter++;
                $row = sqlsrv_fetch_array($stmt);
                if ($row) {
                    $sum += $row[2] * $row[4];
                    echo '
                        <tr>
                        <td>' . $productCounter . '</td>
                        <td><img width="90px" height="90px" src="data:image/jpeg;base64,' . base64_encode($row[3]) . '"></td>
                        <td>' . $row[0] . '</td>
                        <td>' . $row[1] . '</td>
                        <td>' . $row[2] . ' руб.</td>
                        <td>' . $row[4] . '</td>
                        <td>' . $row[2] * $row[4] . ' руб.</td>
                        </tr>
                        ';
                }
            } while ($row);
            echo '
                    <tr>
                    <td id="price" colspan="7">Итого: ' . $sum . ' руб.</td>
                    </tr>
                    </table>
                ';
            ?>
        </main>
    </div>

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
                Для получения точной информации о наличии модели с требуемой комплектацией и техническими характеристиками,
                пожалуйста, обращайтесь к менеджерам по продажам. <br><br>
                Вы принимаете условия политики конфиденциальности и пользовательского соглашения каждый раз,
                когда оставляете свои данные в любой форме обратной связи.</p>
        </div>
    </footer>
</body>

</html>
<!DOCTYPE html>
<html lang="ru">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link type="text/css" rel="stylesheet" href="../css/index.css">
    <link type="text/css" rel="stylesheet" href="../css/orders.css">
    <title>Мой профиль</title>
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
            <!-- Выгрузка картинки -->
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
            <h2>Мои заказы</h2>
            <?php
            if (isset($_COOKIE['idUser'])) {
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
                $tsql = "SELECT idOrder, orderDate, totalPrice, [status] FROM [order] WHERE idUser = " . $_COOKIE['idUser']; //Проверка на вход в акк
                $stmt = sqlsrv_query($conn, $tsql);
                if ($stmt === false) {
                    echo "Ошибка, сервис временно недоступен.</br>";
                    die(print_r(sqlsrv_errors(), true));
                }
                echo '
                <table>
                <tr id="title">
                <th>Номер заказа</th>
                <th>Дата и время</th>
                <th>Цена</th>
                <th>Статус</th>
                </tr>
                ';
                do {
                    $row = sqlsrv_fetch_array($stmt);
                    if ($row) {
                        echo '
                        <tr>
                        <td> <a href="order.php?order=' . $row[0] . '">' . $row[0] . '</a> </td>
                        <td>' . $row[1]->format('Y-m-d H:i:s') . '</td>
                        <td>' . $row[2] . ' руб</td>
                        <td>' . $row[3] . '</td>
                        </tr>
                    ';
                    }
                } while ($row);
                echo '</table>';
            };
            if (!isset($_COOKIE['idUser'])) {
                echo '<h3>Для просмотра своих заказов войдите в аккаунт</h3>';
            }
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
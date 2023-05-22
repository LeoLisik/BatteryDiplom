<?php
if (isset($_GET['action']) and $_GET['action'] == "add") {
    session_start();
    if (isset($_COOKIE['cart'])) {
        $cookie = unserialize($_COOKIE['cart']);
    } else {
        $cookie = array();
    }
    array_push($cookie, $_GET['product']);
    setcookie('cart', serialize($cookie));
}
?>
<!DOCTYPE html>
<html lang="ru">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link type="text/css" rel="stylesheet" href="../css/index.css">
    <link type="text/css" rel="stylesheet" href="../css/katalog.css">
    <title>Katalog</title>
</head>

<body>
    <header>
        <div class="dropdown">
            <a id="menu-button"><img width="68px" height="58px" src="../images/header/Menu.png" alt="menu"></a>
            <div class="dropdown-options">
                <a href="index.html">Главная</a>
                <a href="katalog.html">Каталог</a>
                <a href="cart.html">Корзина</a>
                <a href="profile.html">Профиль</a>
                <a href="orders.html">История заказов</a>
            </div>
        </div>
        <a href="index.html" id="header-logo"><img width="200px" height="60px" src="../images/logo.svg" alt="logo">
            <a href="profile.html" id="user-button"><img width="55px" height="55px" src="../images/header/UserPhoto.png" alt="user-icon"></a>
            <a href="cart.html" id="cart-button"><img width="50px" height="50px" src="../images/header/Cart.png" alt="cart"></a>
    </header>

    <main>
        <div class="cards-header">
            <form action="#" method="get">
                <div class="sort">
                    <p>Сортировать по </p>
                    <select onchange="form.submit()" name="sort">
                        <option value="1">алфавиту (А-Я)</option>
                        <option <?php if ($_GET['sort'] == 2) {
                                    echo "selected";
                                } ?> value="2">алфавиту (Я-А)</option>
                        <option <?php if ($_GET['sort'] == 3) {
                                    echo "selected";
                                } ?> value="3">возрастанию цены</option>
                        <option <?php if ($_GET['sort'] == 4) {
                                    echo "selected";
                                } ?> value="4">убыванию цены</option>
                    </select>
                </div>
                <div class="search">
                    <button type="submit"> <img width="19px" height="19px" src="../images/katalog/SearchIcon.png"> </button>
                    <input type="text" name="search" <?php echo "value=" . $_GET['search'] ?>>
                </div>
            </form>
        </div>
        <div class="cards">
            <?php
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

            if (!isset($_GET['sort']) or $_GET['sort'] == 1) {
                $tsql = "SELECT idBatteries, nameBatteries, priceBatteries, photoBatteries FROM menu WHERE (lower(nameBatteries) LIKE '%" . $_GET["search"] . "%') ORDER BY nameBatteries ASC";
            } else if ($_GET['sort'] == 2) {
                $tsql = "SELECT idBatteries, nameBatteries, priceBatteries, photoBatteries FROM menu WHERE (lower(nameBatteries) LIKE '%" . $_GET["search"] . "%') ORDER BY nameBatteries DESC";
            } else if ($_GET['sort'] == 3) {
                $tsql = "SELECT idBatteries, nameBatteries, priceBatteries, photoBatteries FROM menu WHERE (lower(nameBatteries) LIKE '%" . $_GET["search"] . "%') ORDER BY priceBatteries ASC";
            } else if ($_GET['sort'] == 4) {
                $tsql = "SELECT idBatteries, nameBatteries, priceBatteries, photoBatteries FROM menu WHERE (lower(nameBatteries) LIKE '%" . $_GET["search"] . "%') ORDER BY priceBatteries DESC";
            }
            $stmt = sqlsrv_query($conn, $tsql);
            if ($stmt === false) {
                echo "Ошибка, сервис временно недоступен.</br>";
                die(print_r(sqlsrv_errors(), true));
            }

            do {
                $row = sqlsrv_fetch_array($stmt);
                if ($row) {
                    echo '
                            <div class="card">
                                <img width="298px" height="298px" src="data:image/jpeg;base64,' . base64_encode($row[3]) . '">
                                <a href="card.php?product=' . $row[0] . '"><p class="stuff-name">' . $row[1] . '</p></a>
                                <p class="price">' . $row[2] . ' руб.</p>
                                <a href="?action=add&product=' . $row[0] . '"><button id="add">В корзину</button></a>
                            </div>
                        ';
                }
            } while ($row);
            sqlsrv_free_stmt($stmt);
            sqlsrv_close($conn);
            ?>
        </div>
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
                моделях автомобилей, размещенные на настоящем интернет-сайте,
                носят исключительно информационный характер и ни при каких условиях не являются публичной офертой,
                определяемой положениями Статьи 437 Гражданского кодекса Российской Федерации.
                Для получения точной информации о наличии моделей с требуемой комплектацией и техническими характеристиками,
                пожалуйста, обращайтесь к менеджерам по продажам. <br><br>
                Вы принимаете условия политики конфиденциальности и пользовательского соглашения каждый раз,
                когда оставляете свои данные в любой форме обратной связи.</p>
        </div>
    </footer>
</body>

</html>
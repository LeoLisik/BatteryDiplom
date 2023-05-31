<?php
if (isset($_GET['action']) and $_GET['action'] == "account") {
    if (isset($_COOKIE["idUser"])) {
        echo "<script>window.location.href = 'profile.php';</script>";
    } else {
        echo "<script>window.location.href = 'authorization.php';</script>";
    }
}
?>
<?php
if (isset($_GET['action']) and $_GET['action'] == "add") {
    session_start();
    if (isset($_COOKIE['cart'])) {
        $cookie = unserialize($_COOKIE['cart']);
    } else {
        $cookie = array();
    }
    if (array_key_exists($_GET['product'], $cookie)) {
        echo '<script>alert("Товар уже в корзине. Изменить количество товара можно в корзине.");</script>';
    } else {
        $cookie[$_GET['product']] = 1;
        //array_push($cookie, $_GET['product']);
        setcookie('cart', serialize($cookie));
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
    <link type="text/css" rel="stylesheet" href="../css/katalog.css">
    <title>Katalog</title>
</head>

<body>
    <header>
        <div class="dropdown">
            <a id="menu-button"><img width="68px" height="58px" src="../images/header/Menu.png" alt="menu" ></a>
            <div class="dropdown-options">
                <a href="index.php">Главная</a>
                <a href="#">Каталог</a>
                <a href="cart.php">Корзина</a>
                <a href="index.php?action=account">Профиль</a>
                <a href="orders.php">История заказов</a>
            </div>
        </div>
        <a href="index.php" id="header-logo"><img width="200px" height="60px" src="../images/logo.svg" alt="logo">
        <?php
            if (isset($_COOKIE["idUser"])) {
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
                $tsql = "SELECT userPhoto FROM [user] WHERE idUser =" . $_COOKIE["idUser"];
                $stmt = sqlsrv_query($conn, $tsql);
                if ($stmt === false) {
                    echo "Ошибка, сервис временно недоступен.</br>";
                    die(print_r(sqlsrv_errors(), true));
                }
                $row = sqlsrv_fetch_array($stmt);
                if ($row[0] != false) {
                    echo ' <a alt="user-icon" href="index.php?action=account" id="user-button"><img width="55px" height="55px" src="data:image/ ;base64,' . $row[0] . '"></a>';
                } else {
                    echo ' <a href="index.php?action=account" id="user-button"><img width="55px" height="55px" src="../images/header/UserPhoto.png" alt="user-icon"></a>';
                }
                sqlsrv_close($conn);
            } else {
                echo ' <a href="index.php?action=account" id="user-button"><img width="55px" height="55px" src="../images/header/UserPhoto.png" alt="user-icon"></a>';
            }
            ?>
        <a href="cart.php" id="cart-button"><img width="50px" height="50px" src="../images/header/Cart.png" alt="cart"></a>
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

            $row = sqlsrv_fetch_array($stmt);
            if ($row) {
                while ($row) {
                    echo '
                            <div class="card">
                                <img width="298px" height="298px" src="data:image/jpeg;base64,' . base64_encode($row[3]) . '">
                                <a href="card.php?product=' . $row[0] . '"><p class="stuff-name">' . $row[1] . '</p></a>
                                <p class="price">' . $row[2] . ' руб.</p>
                        ';
                    if (isset($_GET['sort'])) {
                        echo '<a href="?action=add&product=' . $row[0] . '&sort=' . $_GET['sort'] . '&search=' . $_GET["search"] . '"><button id="add">В корзину</button></a>';
                    } else {
                        echo '<a href="?action=add&product=' . $row[0] . '"><button id="add">В корзину</button></a>';
                    }
                    echo '
                        </div>
                    ';
                    $row = sqlsrv_fetch_array($stmt);
                }
            } else {
                echo '<h3>Товаров по вашим фильтрам не найдено</h3>';
            }
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
            <a href="https://ok.ru/"><img width="40px" height="40px" src="../images/footer/OKIcon.png"></a>
            <a href="https://vk.com/"><img width="40px" height="40px" src="../images/footer/VKIcon.png"></a>
            <a href="https://web.telegram.org/"><img width="40px" height="40px" src="../images/footer/TelegramIcon.png"></a>
            <a href="https://www.youtube.com/"><img width="40px" height="40px" src="../images/footer/YoutubeIcon.png"></a>
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
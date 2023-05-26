<?php
    if (!isset($_GET['product'])) {
        echo "<center><h1>Упс, товар не найден =(</h1></center>";  
        die();  
    }
    if (isset($_GET['action']) and $_GET['action'] == "add") {
        session_start();
        if (isset($_COOKIE['cart'])) {
            $cookie = unserialize($_COOKIE['cart']);
        } else {
            $cookie = array();
        }
        if (in_array($_GET['product'], $cookie)) {
            echo '<script>alert("Товар уже в корзине");</script>';
        } else {
            array_push($cookie, $_GET['product']);
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
    <link type="text/css" rel="stylesheet" href="../css/card.css">
    <title>Товар</title>  
</head>
<body>
    <header>
        <div class="dropdown">
            <a id="menu-button"><img width="68px" height="58px" src="../images/header/Menu.png" alt="menu" ></a>
            <div class="dropdown-options">
                <a href="index.php">Главная</a>
                <a href="katalog.php">Каталог</a>
                <a href="cart.php">Корзина</a>
                <a href="profile.php">Профиль</a>
                <a href="orders.php">История заказов</a>
            </div>
        </div>
        <a href="index.php" id="header-logo"><img width="200px" height="60px" src="../images/logo.svg" alt="logo">
        <a href="profile.php" id="user-button"><img width="55px" height="55px" src="../images/header/UserPhoto.png" alt="user-icon"></a>
        <a href="cart.php" id="cart-button"><img width="50px" height="50px" src="../images/header/Cart.png" alt="cart"></a>
    </header>
    
    <main>
        <?php
            $serverName = "26.159.241.191";
            $uid = "da";
            $pwd = "da";
            $connectionInfo = array( "UID"=>$uid,  
                                    "PWD"=>$pwd,  
                                    "Database"=>"Batteries",
                                    "CharacterSet"=>"UTF-8"
                                    );
            $conn = sqlsrv_connect( $serverName, $connectionInfo);  
            if( $conn === false )  
            {  
                echo "Ошибка, сервис временно недоступен.</br>";  
                die( print_r( sqlsrv_errors(), true));  
            }
            $tsql = "SELECT nameBatteries, descriptionBatteries, priceBatteries, photoBatteries FROM menu WHERE idBatteries = ".$_GET['product'];
            $stmt = sqlsrv_query($conn, $tsql);
            if( $stmt === false )  
            {  
                echo "Ошибка, сервис временно недоступен.</br>";  
                die( print_r( sqlsrv_errors(), true));  
            }
            $row = sqlsrv_fetch_array($stmt);
            if ($row) {
                echo '
                    <h2>'.$row[0].'</h2>
                    <div id="staff"><img width="300px" height="300px" src="data:image/jpeg;base64,'.base64_encode($row[3]).'"></div>
                    <div id="card-info">
                        <p id="price">'.$row[2].' руб.</p>
                        <p id="discription">'.$row[1].'</p>
                        <a href="?action=add&product=' . $_GET['product'] . '"><button id="add">Добавить в корзину</button></a>
                        <button id="pay">Купить в один клик</button>
                    </div>
                    ';
            } else {
                echo "<center><h1>Упс, товар не найден =(</h1></center>";  
                die();  
            }
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
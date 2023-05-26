<?php
session_start();
if (isset($_GET['action']) and $_GET['action'] == "account") {
    if (isset($_COOKIE["idUser"])) {
        echo "<script>window.location.href = 'profile.php';</script>";
    } else {
        echo "<script>window.location.href = 'authorization.php';</script>";
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
    <link type="text/css" rel="stylesheet" href="../css/itc-slider.css">
    <script src="../js/itc-slider.js" defer></script>
    <title>Battery</title>
</head>

<body>
    <header>
        <div class="dropdown">
            <a id="menu-button"><img width="68px" height="58px" src="../images/header/Menu.png" alt="menu"></a>
            <div class="dropdown-options">
                <a href="#">Главная</a>
                <a href="katalog.php">Каталог</a>
                <a href="cart.php">Корзина</a>
                <a href="index.php?action=account">Профиль</a>
                <a href="orders.php">История заказов</a>
            </div>
        </div>
        <a href="#" id="header-logo"><img width="200px" height="60px" src="../images/logo.svg" alt="logo">
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
                    echo ' <a alt="user-icon" href="index.php?action=account" id="user-button"><img width="55px" height="55px" src="data:image/jpeg;base64,' . base64_encode($row[0]) . '"></a>';
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
        <div class="itc-slider" data-slider="itc-slider" data-loop="true" data-autoplay="false" data-interval="7000">
            <div class="itc-slider-wrapper">
                <div class="itc-slider-items">
                    <div class="itc-slider-item" id="slider-item-1">
                        <div class="content">
                        </div>
                    </div>
                    <div class="itc-slider-item" id="slider-item-2">
                        <div class="content">
                        </div>
                    </div>
                </div>
            </div>
            <ol class="itc-slider-indicators">
                <li class="itc-slider-indicator" data-slide-to="0"></li>
                <li class="itc-slider-indicator" data-slide-to="1"></li>
            </ol>
            <!-- Кнопки для перехода к предыдущему и следующему слайду -->
            <button class="itc-slider-btn itc-slider-btn-prev"></button>
            <button class="itc-slider-btn itc-slider-btn-next"></button>
        </div>
        <div class="preferences">
            <div class="line">
                <div class="preference-item">
                    <img src="../images/index/battery.png" alt="icon" width="110px" height="110px">
                    <h2>Качественные аккумуляторы</h2>
                    <p>На всём рынке наши аккумуляторы самые надежные, прочные и долгосрочные.</p>
                </div>
                <div class="preference-item right-item">
                    <img src="../images/index/Guarantee.png" alt="icon" alt="icon" width="110px" height="110px">
                    <h2>Гарантия качества на аккумуляторы</h2>
                    <p>Даем гарантию от магазина как на саму батарею, так и на все работы.</p>
                </div>
            </div>
            <div class="line">
                <div class="preference-item">
                    <img src="../images/index/gratis.png" alt="icon" width="110px" height="110px">
                    <h2>Бесплатная диагностика аккумулятора </h2>
                    <p>Диагностика и плановая замена деталей и расходных материалов до устранения серьёзных поломок двигателя.</p>
                </div>
                <div class="preference-item right-item">
                    <img src="../images/index/Round-clock.png" alt="icon" width="110px" height="110px">
                    <h2>Работаем круглосуточно каждый день</h2>
                    <p>Наши специалисты обладают всеми необходимыми знаниями и справляются с ремонтом аккумулятора любой сложности.</p>
                </div>
            </div>
        </div>
        <div class="about">
            <img width="500px" height="150px" src="../images/logo.svg">
            <p>Всё, за что берётся компания АКМ БАГ, делается серьёзно и обстоятельно. <br><br>
                Наши сервисные центры – это команда профессионалов, современное оборудование и широкий выбор дополнительных услуг.</p>
        </div>
    </main>
    <hr>

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
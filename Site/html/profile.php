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
$tsql = "SELECT name, surname, patronymic, login, [userPhoto] FROM [user] WHERE idUser = " . $_COOKIE["idUser"];
$stmt = sqlsrv_query($conn, $tsql);
if ($stmt === false) {
    echo "Ошибка</br>";
    die(print_r(sqlsrv_errors(), true));
}
$row = sqlsrv_fetch_array($stmt);

if (isset($_GET['action']) and $_GET['action'] == "exit") {
    setcookie("idUser", "", time() - 3600);
    echo "<script>window.location.href = 'index.php';</script>";
} elseif (isset($_POST["name"])) { //Сохранение
    if (ctype_space($_POST['name']) or ctype_space($_POST['surname']) or ctype_space($_POST['patronymic'])) {
        $error = "Поля должны быть пустыми или чем-то заполнены";
    } else {
        if ($_POST['mail'] == "") {
            $mail = "NULL";
            $falseMail = "falseMail";
        } else {
            $mail = "'" . $_POST['mail'] . "'";
            $falseMail = $_POST['mail'];
        }

        $tsql = "SELECT [idUser] FROM [dbo].[user] WHERE [idUser] = 1 AND NOT EXISTS(SELECT [idUser] FROM [dbo].[user] WHERE [login] = '" . $falseMail . "' AND [idUser] <> ". $_COOKIE["idUser"] ." AND NOT [role] = 'Гость');";
        $stmt = sqlsrv_query($conn, $tsql);
        if ($stmt === false) {
            echo "Ошибка, сервис временно недоступен.</br>";
            die(print_r(sqlsrv_errors(), true));
        }
        $row1 = sqlsrv_fetch_array($stmt);
        if ($row1) {
            if ($_POST['surname'] == "") {
                $surname = "NULL";
            } else {
                $surname = "'" . $_POST['surname'] . "'";
            }

            if ($_POST['patronymic'] == "") {
                $patronymic = "NULL";
            } else {
                $patronymic = "'" . $_POST['patronymic'] . "'";
            }
            if (!$_FILES['photoUser']['tmp_name'][0]) {
                $tsql = "UPDATE [dbo].[user] set login = " . $mail . ", name = '" . $_POST['name'] . "', patronymic = " . $patronymic . ", surname = " . $surname . " WHERE idUser = " . $_COOKIE["idUser"] .  ";";
                $stmt = sqlsrv_query($conn, $tsql);
                if ($stmt === false) {
                    echo "Ошибка</br>";
                    die(print_r(sqlsrv_errors(), true));
                }
                echo "<script>window.location.href = 'profile.php';</script>";
            } else {
                $name = $_FILES['photoUser']['name'];
                $tmp = $_FILES['photoUser']['tmp_name'];
                $data = file_get_contents($tmp);
                $test = mb_convert_encoding($data, "UTF-8");
                $tsql = "UPDATE [dbo].[user] set login = " . $mail . ", name = '" . $_POST['name'] . "', patronymic = " . $patronymic . ", surname = " . $surname . ", [userPhoto] = CAST('". base64_encode($data) 
                     . "' AS image) WHERE idUser = " . $_COOKIE["idUser"] .  ";";
                $stmt = sqlsrv_query($conn, $tsql);
                if ($stmt === false) {
                    echo "Ошибка1</br>";
                    die(print_r(sqlsrv_errors(), true));
                }
                echo "<script>window.location.href = 'profile.php';</script>";
            }
        } else {
            $error = "Почта занята";
        }
    }
}
sqlsrv_close($conn);
?>
<!DOCTYPE html>
<html lang="ru">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link type="text/css" rel="stylesheet" href="../css/index.css">
    <link type="text/css" rel="stylesheet" href="../css/profile.css">
    <link type="text/css" rel="stylesheet" href="../css/photo.css">
    <script src="../js/itc-photo.js" defer></script>
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
                <a href="#">Профиль</a>
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
                $row2 = sqlsrv_fetch_array($stmt);
                if ($row2[0] != false) {
                    echo ' <a alt="user-icon" href="index.php?action=account" id="user-button"><img width="55px" height="55px" src="data:image/ ;base64,' . $row2[0] . '"></a>';
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
            <h2>Мой профиль</h2> <!-- Изменение данных -->
            <form method="POST" enctype="multipart/form-data">
            <?php echo "<p id='error'>" . $error . "</p>"; ?>
                <?php
                if ($row[4] == null) {
                    echo '<style type="text/css">
                    #photo{
                        background-image: url("../images/authorization/download.png");
                    }
                    </style>
                    <div id="form-img">
                    <label for="pct" name="test" id="photo"></label>
                    <input name="photoUser" type="file" accept="image/jpeg,image/png" id="pct">
                </div>';
                }
                else{
                    echo '<style type="text/css">
                    #photo{
                        background-image: url("data:image/ ;base64,' . $row[4] . '");
                    }
                    </style>
                    <div id="form-img">
                    <label for="pct" name="test" id="photo"></label>
                    <input name="photoUser" type="file" accept="image/jpeg,image/png" id="pct">
                </div>';
                }
                echo '
                <div class="form-item">
                    <label>Имя:<span class="warning">*</span></label>
                    <input name="name" type="text" value="' . $row[0] . '" required></input>
                </div>
                <div class="form-item">
                    <label>Фамилия:</label>
                    <input name="surname" type="text" value="' . $row[1] . '"></input>
                </div>
                <div class="form-item">
                    <label>Отчество:</label>
                    <input name="patronymic" type="text" value="' . $row[2] . '"></input>
                </div>
                <div class="form-item">
                    <label>E-mail:</label>
                    <input type="email" name="mail" type="text" value="' . $row[3] . '"></input>
                </div>';
                ?>
                <div class="form-button">
                    <a href="?action=save"><button>Сохранить</button></a>
                </div>
            </form>
            <a href="?action=exit"><button id="exit">Выход</button></a>
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
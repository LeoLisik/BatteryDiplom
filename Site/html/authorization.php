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
if (isset($_POST["loginAuth"])) {
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
    $tsql = "SELECT idUser, userPhoto FROM [user] WHERE (login='" . $_POST['loginAuth'] . "' OR phoneNumber='" . $_POST['loginAuth'] . "') AND password='" . $_POST['passwordAuth'] . "' AND status='Активен'";
    $stmt = sqlsrv_query($conn, $tsql);
    if ($stmt === false) {
        echo "Ошибка, сервис временно недоступен.</br>";
        die(print_r(sqlsrv_errors(), true));
    }
    $row = sqlsrv_fetch_array($stmt);
    if ($row) {
        setcookie("idUser", $row[0]);
        echo "<script>window.location.href = 'index.php';</script>";
    } else {
        $error = "Введены неверные логин и/или пароль";
    }

    sqlsrv_close($conn);
} elseif (isset($_POST["name"])) { //Если нажата кнопка регистрации
    //Если в необязательных полях аходятся не толькок пробелы
    if (ctype_space($_POST['name']) or ctype_space($_POST['surname']) or ctype_space($_POST['patronymic']) or ctype_space($_POST['password'])) {
        $error = "Поля должны быть пустыми или чем-то заполнены";
    } else {
        //Если пароли совпадают
        if ($_POST['password'] == $_POST['repeat']) {
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
            if ($_POST['mail'] == "") {
                $mail = "NULL";
                $falseMail = "falseMail";
            } else {
                $mail = "'" . $_POST['mail'] . "'";
                $falseMail = $_POST['mail'];
            }

            $tsql = "SELECT [idUser] FROM [dbo].[user] WHERE [idUser] = 1 AND NOT EXISTS(SELECT [idUser] FROM [dbo].[user] WHERE [phoneNumber] = '" . $_POST['phone'] . "' AND NOT [role] = 'Гость') 
            AND NOT EXISTS(SELECT [idUser] FROM [dbo].[user] WHERE [login] = '" . $falseMail . "' AND NOT [role] = 'Гость');";
            $stmt = sqlsrv_query($conn, $tsql);
            if ($stmt === false) {
                echo "Ошибка, сервис временно недоступен.</br>";
                die(print_r(sqlsrv_errors(), true));
            }
            $row = sqlsrv_fetch_array($stmt);
            if ($row) {
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
                    $tsql = "INSERT INTO [user] (login, password, gender, surname, name, patronymic, role, birthday, phoneNumber, status) OUTPUT Inserted.[idUser]
                    VALUES (" . $mail . ", '" . $_POST['password'] . "', '" . $_POST['gender'] . "'," . $surname . ", '" . $_POST['name'] . "'," . $patronymic . ", 'Пользователь', '" .
                        $_POST['birhday'] . "', '" . $_POST['phone'] . "', 'Активен')";
                    $stmt = sqlsrv_query($conn, $tsql);
                    if ($stmt === false) {
                        echo "Ошибка</br>";
                        die(print_r(sqlsrv_errors(), true));
                    }
                    $row = sqlsrv_fetch_array($stmt);
                    setcookie("idUser", $row[0]);
                    echo "<script>window.location.href = 'index.php';</script>";
                } else {
                    $name = $_FILES['photoUser']['name'];
                    $tmp = $_FILES['photoUser']['tmp_name'];
                    $data = file_get_contents($tmp);
                    $test = mb_convert_encoding($data, "UTF-8");
                    $tsql = "INSERT INTO [user] (login, password, gender, surname, name, patronymic, role, birthday, phoneNumber, status, userPhoto) OUTPUT Inserted.[idUser]
                    VALUES (" . $mail . ", '" . $_POST['password'] . "', '" . $_POST['gender'] . "', " . $surname . ", '" . $_POST['name'] . "', " . $patronymic . ", 'Пользователь', '" .
                        $_POST['birhday'] . "', '" . $_POST['phone'] . "', 'Активен', CAST('" . base64_encode($data) . "' AS image))";
                    $stmt = sqlsrv_query($conn, $tsql);
                    if ($stmt === false) {
                        echo "Ошибка1</br>";
                        die(print_r(sqlsrv_errors(), true));
                    }
                    $row = sqlsrv_fetch_array($stmt);
                    setcookie("idUser", $row[0]);
                    echo "<script>window.location.href = 'index.php';</script>";
                }
            } else {
                $error = "Почта или телефон заняты";
            }
            sqlsrv_close($conn);
        } else {
            $error = "Пароли не совпадают";
        }
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
    <link type="text/css" rel="stylesheet" href="../css/authorization.css   ">
    <link type="text/css" rel="stylesheet" href="../css/itc-slider.css">
    <link type="text/css" rel="stylesheet" href="../css/photo.css">
    <script src="../js/itc-slider.js" defer></script>
    <script src="../js/itc-tabs.js" defer></script>
    <script src="../js/itc-photo.js" defer></script>
    <script src="../js/itc-password.js" defer></script>
    <title>Battery</title>
</head>

<body>
    <header>
        <div class="dropdown">
            <a id="menu-button"><img width="68px" height="58px" src="../images/header/Menu.png" alt="menu"></a>
            <div class="dropdown-options">
                <a href="index.php">Главная</a>
                <a href="katalog.php">Каталог</a>
                <a href="cart.php">Корзина</a>
                <a href="index.php?action=account">Профиль</a>
                <a href="orders.php">История заказов</a>
            </div>
        </div>
        <a href="index.php" id="header-logo"><img width="200px" height="60px" src="../images/logo.svg" alt="logo">
            <a href="#" id="user-button"><img width="55px" height="55px" src="../images/header/UserPhoto.png" alt="user-icon"></a>
            <a href="cart.php" id="cart-button"><img width="50px" height="50px" src="../images/header/Cart.png" alt="cart"></a>
    </header>

    <main>
        <?php echo "<p id='error'>" . $error . "</p>"; ?>
        <div class="tabs">
            <div class="tabs__nav">
                <button class="tabs__btn tabs__btn_active">Регистрация</button>
                <button class="tabs__btn">Авторизация</button>
            </div>
            <div class="tabs__content">
                <div class="tabs__pane tabs__pane_show">
                    <!-- первая страница -->
                    <form method="post" enctype="multipart/form-data">
                        <div id="form-img">
                            <label for="pct" name="test" id="photo"></label>
                            <input name="photoUser" type="file" accept="image/jpeg,image/png" id="pct">
                        </div>
                        <div class="form-item">
                            <p>Номер телефона:<span class="warning">*</span></p>
                            <input name="phone" type="phone" placeholder="8(965)111-2233" pattern="\d{1}[(][0-9]{2,3}[)]\d{3}-\d{4}" value="<?= @$_POST['phone'] ?>" required></input>
                        </div>
                        <div class="form-item">
                            <p>Имя:<span class="warning">*</span></p>
                            <input name="name" type="text" value="<?= @$_POST['name'] ?>" required></input>
                        </div>
                        <div class="form-item">
                            <p>Фамилия:</p>
                            <input name="surname" type="text" value="<?= @$_POST['surname'] ?>"></input>
                        </div>
                        <div class="form-item">
                            <p>Отчество:</p>
                            <input name="patronymic" type="text" value="<?= @$_POST['patronymic'] ?>"></input>
                        </div>
                        <div id="check">
                            <p>Пол:</p>
                            <input type="radio" id="man" name="gender" value='Мужской' checked>
                            <label for="man"> Муж</label>
                            <input type="radio" id="woman" name="gender" value='Женский'>
                            <label for="woman"> Жен</label>
                        </div>
                        <div class="form-item">
                            <p>E-mail:</p>
                            <input name="mail" type="email" value="<?= @$_POST['mail'] ?>"></input>
                        </div>
                        <div class="form-item">
                            <p>Дата рождения:</p>
                            <script>
                                window.addEventListener('load',
                                    function(e) {
                                        var d = new Date();
                                        var day = d.getDate();
                                        if (day < 10) day = '0' + day;
                                        var month = d.getMonth() + 1;
                                        if (month < 10) month = '0' + month;
                                        var year = d.getFullYear();
                                        document.getElementById("mydate").max = year + "-" + month + "-" + day;
                                        document.getElementById("mydate").value = (year - 18) + "-" + month + "-" + day;
                                    }, false);
                            </script>
                            <input type="date" name="birhday" id="mydate">
                        </div>
                        <div class="form-item">
                            <p>Пароль:<span class="warning">*</span></p>
                            <input name="password" type="password" id="password" required>
                            <button class="btn btn-primary btn-md" id="show"><img src="../images/authorization/closeEye.png" id="show-img" class="show-img" width="15px" height="15px" alt="Кнопка «button»"></button>
                        </div>
                        <div class="form-item">
                            <p>Повторите пароль:<span class="warning">*</span></p>
                            <input name="repeat" type="password" id="password1" required>
                            <button class="btn btn-primary btn-md" id="show1"><img src="../images/authorization/closeEye.png" id="show-img1" class="show-img" alt="Кнопка «button»"></button>
                        </div>
                        <div class="form-button">
                            <button id="atuin-btn">Зарегистрироваться</button>
                        </div>
                    </form>
                </div>
                <div class="tabs__pane">
                    <!-- вторая страница -->
                    <form method="post">
                        <div class="form-item">
                            <p><span class="warning">*</span>Почта/номер телефона:</p>
                            <input type="text" name="loginAuth" value="<?= @$_POST['loginAuth'] ?>" required></input>
                        </div>
                        <div class="form-item">
                            <p><span class="warning">*</span>Пароль:</label>
                                <input type="password" id="password2" name="passwordAuth" required>
                                <button class="btn btn-primary btn-md" id="show2"><img src="../images/authorization/closeEye.png" id="show-img2" class="show-img" width="15px" height="15px" alt="Кнопка «button»"></button>
                        </div>
                        <div class="form-button">
                            <a><button id="atuin-btn">Войти</button></a>
                        </div>
                    </form>
                </div>
            </div>
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
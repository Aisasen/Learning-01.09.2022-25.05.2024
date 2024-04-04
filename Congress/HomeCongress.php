<head>
  <title>Congress - Главная</title>
  <link rel="stylesheet" type="text/css" href="style.css">
</head>
<body>
  <header>
    <nav>
      <a href="HomeCongress.php">Главная</a>
      <a href="AboutUs.php">О нас</a>
      <a href="Store.php">Продукция</a>
      <a href="Forum.php">Форум</a>
      <a href="Contacts.php">Контакты</a>
    </nav>
  </header>
  <main>
    <section>
      <h1>Congress</h1>
      <p>Лучшие официальные технологии по самым сасным меркам, не именно что в хлам ушлепально убитые. Реально официально с конвейера сошедшие именно что сейчас.</p>
      <form action="#" method="post" class="login">
        <label for="email">Email  </label>
        <input type="email" id="email" name="email" required>
        <br><br>
        <label for="password">Пароль  </label>
        <input type="password" id="password" name="password" required>
        <br><br>
        <button type="submit" class="login-button">Войти в Мир Конгресса</button>
      </form>
      <a href="Registration.php"><button class="register-button">Зарегистрироваться</button></a>
    </section>
  </main>
  <br>
  <footer>
    <div class="container">
      <div class="row">
        <div class="col-md-4">
          2023 Congress INC LIMITED
        </div>
      </div>
      <div class="row">
        <div class="col-md-12">
          Все права защищены
        </div>
      </div>
    </div>
  </footer>
  <?php
session_start(); // Начинаем сессию

if (isset($_POST['login'])) { // Проверяем, нажата ли кнопка "Войти"
    $email = $_POST['email'];
    $password = $_POST['password'];

    $conn = mysqli_connect('localhost', 'root', '', 'mydatabase');

    if (!$conn) {
        die("Connection failed: " . mysqli_connect_error());
    }

    // Выполняем запрос на поиск пользователя в таблице users
    $query = "SELECT * FROM users WHERE email='$email' AND password='$password'";
    $result = mysqli_query($conn, $query);

    if (mysqli_num_rows($result) == 1) { // Если пользователь найден
        $row = mysqli_fetch_assoc($result);
        $_SESSION['user_id'] = $row['id']; // Сохраняем ID пользователя в сессии
        echo "string";
    } else { // Если пользователь не найден
        echo "<p>Неправильный email или пароль</p>";
    }

    mysqli_close($conn);
}
?>
</body>

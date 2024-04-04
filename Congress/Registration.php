 <head>
    <title>Регистрация - Congress</title>
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
        <h1>Регистрация</h1>
        <form action="#" method="post" class="registraton">
          <label for="name">Имя  </label>
          <input type="text" id="name" name="name" required>
          <br><br>
      <label for="email">Email  </label>
      <input type="email" id="email" name="email" required>
      <br><br>
      <label for="password">Пароль  </label>
      <input type="password" id="password" name="password" required>
      <br><br>
      <label for="confirm-password">Подтвердите пароль  </label>
      <input type="password" id="confirm-password" name="confirm-password" required>
      <br><br>
      <button type="submit" class="register-button">Зарегистрироваться</button>
    </form>
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
  </body>
  <?php
// Подключение к базе данных
$conn = mysqli_connect('localhost', 'root', '', 'mydatabase');
if (!$conn) {
    die("Connection failed: " . mysqli_connect_error());
}

// Получение данных из формы
if ($_SERVER['REQUEST_METHOD'] == 'POST') {
    $name = mysqli_real_escape_string($conn, $_POST['name']);
    $email = mysqli_real_escape_string($conn, $_POST['email']);
    $password = mysqli_real_escape_string($conn, $_POST['password']);
    $confirm_password = mysqli_real_escape_string($conn, $_POST['confirm-password']);

    // Дополнительные проверки и обработка данных

    // Добавление данных в базу данных
    $sql = "INSERT INTO users (name, email, password) VALUES ('$name', '$email', '$password')";
    if (mysqli_query($conn, $sql)) {
        echo "Регистрация прошла успешно!";
    } else {
        echo "Ошибка: " . mysqli_error($conn);
    }
}

// Закрытие соединения с базой данных
mysqli_close($conn);
?>
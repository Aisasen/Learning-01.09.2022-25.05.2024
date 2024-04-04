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
</body>
<br><br>
<?php
// Подключение к базе данных
$conn =mysqli_connect('localhost', 'root', '', 'mydatabase');
if (!$conn) {
    die("Connection failed: " . mysqli_connect_error());
}

// Получение данных о товаре
if (isset($_GET['id'])) {
    $id = mysqli_real_escape_string($conn, $_GET['id']);
    $sql = "SELECT * FROM products WHERE id={$id}";
    $result = mysqli_query($conn, $sql);
    $row = mysqli_fetch_assoc($result);
}

// Обработка добавления товара в корзину
if (isset($_POST['add_to_cart'])) {
    // Добавление товара в корзину
    // ...
    // Перенаправление на страницу корзины
    header('Location: cart.php');
    exit();
}

// Отображение товара и кнопки "Добавить в корзину"
if ($row) {
    echo "<div class='product'>";
    echo "<h2>{$row['name']}</h2>";
    echo "<img src={$row['img_src']}>";
    echo "<p>{$row['description']}</p>";
    echo "<p>{$row['price']}</p>";
    echo "<form method='post'>";
    echo "<input type='submit' name='add_to_cart' value='Добавить в корзину'>";
    echo "</form>";
    echo "</div>";
} else {
    echo "<p>Товар не найден</p>";
}

// Закрытие соединения с базой данных
mysqli_close($conn);
?>
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
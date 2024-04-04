<head>
    <title>Congress - Магазин</title>
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
    <br><br><br><br>
    <div class="sidebar">
        <form method="get" action="">
            <input type="text" name="search" placeholder="Поиск товаров">
            <button type="submit">Искать</button>
        </form>
        <h2>Сортировать по:</h2>
        <ul>
            <li><a href="?sort=name_asc">Названию (по возрастанию)</a></li>
            <li><a href="?sort=name_desc">Названию (по убыванию)</a></li>
            <li><a href="?sort=price_asc">Цене (по возрастанию)</a></li>
            <li><a href="?sort=price_desc">Цене (по убыванию)</a></li>
        </ul>
    </div>
    <div class="content">
        <?php include 'product_list.php'; ?>
    </div>
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
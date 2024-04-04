<?php
// Подключение к базе данных
$conn =mysqli_connect('localhost', 'root', '', 'mydatabase');
if (!$conn) {
    die("Connection failed: " . mysqli_connect_error());
}

// Получение данных из базы данных
$sql = "SELECT * FROM products";
$result = mysqli_query($conn, $sql);

// Обработка поискового запроса
if (isset($_GET['search'])) {
    $search = mysqli_real_escape_string($conn, $_GET['search']);
    $sql .= " WHERE name LIKE '%{$search}%'";
    $result = mysqli_query($conn, $sql);
}

// Обработка сортировки товаров
if (isset($_GET['sort'])) {
    $sort = $_GET['sort'];
    switch ($sort) {
        case 'name_asc':
            $sql .= " ORDER BY name ASC";
            break;
        case 'name_desc':
            $sql .= " ORDER BY name DESC";
            break;
        case 'price_asc':
            $sql .= " ORDER BY price ASC";
            break;
        case 'price_desc':
            $sql .= " ORDER BY price DESC";
            break;
        default:
            break;
    }
    $result = mysqli_query($conn, $sql);
}

// Отображение товаров
while ($row = mysqli_fetch_assoc($result)) 
{
    echo "<div class='product'>";
    echo "<h2><a href='product.php?id={$row['id']}'>{$row['name']}</a></h2>";
    echo "<img src={$row['img_src']}>";
    echo "<p>{$row['description']}</p>";
    echo "<p>{$row['price']}</p>";
    echo "</div>";
}

// Закрытие соединения с базой данных
mysqli_close($conn);
?>
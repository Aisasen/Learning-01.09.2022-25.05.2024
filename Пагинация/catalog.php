<?php
require('produts_db.php');
$day=date('j');
$month=date('n');
$year=date('Y');
$page=intval($_GET['page'])?:1;
$products = get_products();
$limit = 6;
$offset = ($page - 1) * $limit;
$months = [1 => 'января', 2 => 'февраля', 3 => 'марта', 4 => 'апреля', 5 => 'мая', 6 => 'июня', 7 => 'июля', 8 => 'августа', 9 => 'сентября', 10 => 'октября', 11 => 'ноября', 12 => 'декабря'];
$products_on_page = array_slice($products, $offset, $limit, true);
$products_quantity = count($products);
$pages = ceil($products_quantity / $limit);
$today=$day.' '.$months[$month].' '.$year;
require('components/header.php');
require('components/products_list.php');
require('components/footer.php');
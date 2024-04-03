<?php
require('products_db.php');
require('components/header.php');
$items = get_products();
$type= $_GET['product_type'];
$id=1;
require('components/products_list.php');
require('components/footer.php');
?>

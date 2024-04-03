<?php
require('produts_db.php');

$order = [2, 7, 15, 16];

function get_final_price($price, $discount) 
{ 
	return $price - $discount;
}


require('components/header.php');
require('components/delivery_info.php');
require('components/footer.php');

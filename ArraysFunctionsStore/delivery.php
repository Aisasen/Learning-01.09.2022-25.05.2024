<?php
require('produts_db.php');
$order = [2, 7, 15, 16];
$id = $order[1];
function get_final_price($id) 
{
	$price = get_product_price($id);
	$discount = get_product_discount($id);
	return $price-$discount;
}
function get_delivery_cost($id)
{
	$price = get_product_price($id);
	$discount = get_product_discount($id);
	$is_new = get_product_is_new($id);
	$final_price = get_final_price($id);
	if ($is_new && $final_price < 2000) 
	{
	  $delivery_cost = $final_price;
	} 
	else 
	{
	  $delivery_cost = $final_price / 20;
	}
	return $delivery_cost;
}
require('components/header.php');
require('components/delivery_info.php');
require('components/footer.php');

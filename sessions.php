<?php session_start();
?>
<form action="" method="post">
	<input type="text" name="country" placeholder="Ваша страна">
	<input type="text" name="email" placeholder="Ваш email">
	<input type="submit" name="">
</form>
<?php
if(isset($_POST['country']))
{
	$_SESSION['country']=$_POST['country'];
}
if(isset($_POST['email']))
{
	$_SESSION['email']=$_POST['email'];
}
if (!isset($_SESSION['counter'])) 
{
	$_SESSION['counter'] = 1; } 
	else { $_SESSION['counter'] = $_SESSION['counter'] + 1; 
} 
echo 'Вы обновили эту страницу '.$_SESSION['counter'].' раз!'.'<br>';
?>
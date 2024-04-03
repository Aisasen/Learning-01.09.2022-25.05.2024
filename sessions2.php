<?php session_start();
?>
<form action="" method="post">
	<input type="text" name="country" placeholder="Ваша страна" value=<?php echo $_SESSION['country']; ?>>
	<input type="text" name="email" placeholder="Ваш email" value=<?php echo $_SESSION['email']; ?>>
	<input type="text" name="name" placeholder="Ваше имя">
	<input type="text" name="password" placeholder="Ваш пароль">
</form>
<?php
if (!isset($_SESSION['counter'])) 
{
	$_SESSION['counter'] = 1; } 
	else { $_SESSION['counter'] = $_SESSION['counter'] + 1; 
}
echo 'Вы обновили эту страницу '.$_SESSION['counter'].' раз!'.'<br>';
?>
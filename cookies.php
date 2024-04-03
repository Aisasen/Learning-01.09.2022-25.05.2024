<form action="" method="post">
	<input type="text" name="numbers" placeholder="Ваше имя.">
</form>
<form action="" method="post">
	<input type="submit" name="delete" value="delete">
</form>
<form action="" method="post">
	<input type="text" name="birthday" placeholder="Ваш день рождения.">
</form>
<?php
setcookie('count', $_COOKIE['count']+1, time()+3600);
if(isset($_POST['numbers']))
{
	setcookie('test', $_POST['numbers'],time()+3600);
}
if(isset($_POST['delete']))
{
	setcookie('test', '');
}
if (isset($_COOKIE['test']))
{
	echo "Ваше имя: ".$_COOKIE['test']."<br>";
}
if (isset($_COOKIE['count']))
{
	echo "Вы посетили сайт:".$_COOKIE['count']." раз"."<br>";
}
if(isset($_POST['birthday']))
{
	$bd = explode('.', $_POST['birthday']);
	$bd = mktime(0, 0, 0, $bd[1], $bd[0], date('Y') + ($bd[1].$bd[0] <= date('md')));
	$days_until = ceil(($bd - time()) / 86400);
	setcookie('DaysUntilBirthday', $days_until, time()+3600);
}
if (isset($_COOKIE['DaysUntilBirthday']))
{
	if ($_COOKIE['DaysUntilBirthday']==365) 
	{
		echo "Поздраляем с днём рождения!";
	}
	else
		echo "Дней до вашего дня рождения:".$_COOKIE['DaysUntilBirthday'];
}
?>
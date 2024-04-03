<form action="" method="post">
<input type="text" name="name" placeholder="Введите ваше имя">
<input type="submit">
</form>
<form action="" method="post">
<input type="text" name="name2" placeholder="Введите ваше имя">
<input type="text" name="age" placeholder="Введите ваш возраст">
<input type="text" name="city" placeholder="Введите ваш город">
<br>
<textarea name="message"></textarea>
<input type="submit">
</form>
<form action="" method="post">
<input type="text" name="login" placeholder="Введите логин">
<input type="password" name="pass" placeholder="Введите пароль">
<input type="submit">
</form>
<?php
$login='login';
$pass='pass';
if (!empty($_REQUEST['name']))
{
	$name=$_POST['name'];
	echo 'Ваше имя:'.$name.'<br>';
}
if (!empty($_REQUEST['name2']))
{
	$name2=$_POST['name2'];
	echo 'Ваше имя:'.$name2.'<br>';
}
if (!empty($_REQUEST['age']))
{
	$age=$_POST['age'];
	echo 'Ваш возраст:'.$age.'<br>';
}
if (!empty($_REQUEST['city']))
{
	$city=$_POST['city'];
	echo 'Ваш город:'.$city.'<br>';
}
if (!empty($_REQUEST['message']))
{
	$message=$_POST['message'];
	echo 'Ваше сообщение:'.$message.'<br>';
}
if (isset($_REQUEST['login']) and trim($_REQUEST['login'])==$login and isset($_REQUEST['pass']) and trim($_REQUEST['pass'])==$pass)
{
	echo 'Доступ разрешён!';
}
else 
	echo 'Доступ запрещён!';
?>

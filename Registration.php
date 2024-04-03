<?php
	$link=mysqli_connect('localhost', 'root', '', 'users');
	if (!empty($_POST['login']) and !empty($_POST['password'])) 
	{
		$login = $_POST['login'];
		$password = password_hash($_POST['password'], PASSWORD_DEFAULT);
		$birthday = $_POST['birthday'];
		$email = $_POST['email'];
		$date = date('Y-m-d');
		$query = "INSERT INTO users SET login='$login', password='$password', Birthday='$birthday', Email='$email', registration_date='$date'";
		mysqli_query($link, $query);
	}
	//Если форма авторизации отправлена...
	if ( !empty($_POST['AuthPassword']) and !empty($_POST['AuthLogin']) ) 
	{
 		$AuthLogin = $_POST['AuthLogin'];
 		$hashQuery = mysqli_query($link, 'SELECT password from users WHERE login = "'.$AuthLogin.'"');
 		for ($hashArray = []; $row = mysqli_fetch_assoc($hashQuery); $hashArray = $row);
 		$hash = $hashArray['password'];
 		if(password_verify($_POST['AuthPassword'], $hash))
 		{
 			$AuthPassword = $_POST['AuthPassword'];
 			$queryAuth = 'SELECT*FROM users WHERE login="'.$AuthLogin.'"';
 			$result = mysqli_query($link, $queryAuth); 
 			$user = mysqli_fetch_assoc($result); 
			if (!empty($user)) 
			{ 
				session_start(); 
				$_SESSION['auth'] = true;
				$_SESSION['id'] = $user['id']; 
				$_SESSION['login'] = $user['login'];
				echo "<style type='text/css'>
				#authform {visibility: hidden}";
 			}
 		}
 		else 
 		{ 
			echo "<center><big>Неправильный логин или пароль!";
 		} 
 	}
 	if (isset($_POST['AuthCheck'])) 
	{
		if ($_SESSION['id'] = true)
		{
			echo "<center><big>Авторизовано!";
		}
		else
			echo "<center><big>Не авторизовано!";
	}
?>
<center><form action="" method="POST">
	<big><p>Форма регистрации</p></big>
	<input name="login" placeholder="Логин"><br><br>
	<input name="password" type="password" placeholder="Пароль"><br><br>
	<input name="birthday" placeholder="День рождения"><br><br>
	<input name="email" placeholder="Емейл"><br><br>
	<input type="submit" value="Регистрация">
</form>
<br>
</center>
<!-- Это форма авторизации: --> 
<center><form action='' method='POST' id="authform">
	<big><p>Форма авторизации</p></big>
	<input name='AuthLogin' placeholder="Логин"><br><br>
	<input name='AuthPassword' type='password' placeholder="Пароль"><br><br>
	<input type='submit' value='Отправить'>
</form>
<form action="" method="POST">
	<input type="submit" name="AuthCheck" value="Проверка на авторизацию">
</form>
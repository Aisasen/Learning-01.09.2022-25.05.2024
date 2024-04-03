<form action="" method="post">
	<input type="text" name="name">
	<input type="submit">
	<input type="hidden" name="check" value="false">
	<input type="checkbox" name="check" value="true">
</form>
<br>
<form action="" method="post">
	html<input type="checkbox" name="lang[]" value="html">
	css<input type="checkbox" name="lang[]" value="css">
	php<input type="checkbox" name="lang[]" value="php">
	javascript<input type="checkbox" name="lang[]" value="javascript">
	<br><br>
	<input type="submit">
</form>
<form action="" method="post">
	Не знаете PHP<input type="radio" name="php" value="No" checked>
	Знаете PHP<input type="radio" name="php" value="Yes">
	<br><br>
	<input type="submit">
</form>
<form action="" method="post">
	Ваш возраст<br>
	20 лет<input type="radio" name="age" value="20"><br>
	21-25 лет<input type="radio" name="age" value="21-25"><br>
	26-30<input type="radio" name="age" value="26-30"><br>
	30+<input type="radio" name="age" value="30+">
	<br><br>
	<input type="submit">
</form>
<form action="" method="post">
<select name="ages">
	<option value="" style="display:none">Выбери возраст</option>
	<option value="20">20 лет</option>
	<option value="21-25">21-25 лет</option>
	<option value="26-30">26-30 лет</option>
	<option value="30+">30+ лет</option>
	<input type="submit">
</select>
</form>
<form action="" method="post">
	Известные языки<br>
<select multiple name="langs[]">
	<option value="html">html</option>
	<option value="css">css</option>
	<option value="php">php</option>
	<option value="javascript">javascript</option>
	<input type="submit">
</select>
</form>
<?php
if (isset($_POST['name']))
{
	$name=$_POST['name'];
	if ($_POST['check']=="true") 
	{
		echo 'Добро пожаловать, '.$name.'<br>';
	}
	else
		echo 'До свидания, '.$name.'<br>';
}
if(isset($_POST['lang']))
{
	echo 'Вы знаете: ' . implode(', ', $_REQUEST['lang']);
}
if(isset($_POST['php']))
{
	if ($_POST['php']=="Yes") 
	{
		echo 'Вы знаете PHP.';
	}
	else
	echo "Вы не знаете PHP.";
}
if(isset($_POST['age']))
{
	echo 'Вам: '.$_POST['age'].' лет';
}
if(isset($_POST['ages']))
{
	echo 'Вам: '.$_POST['ages'].' лет';
}
if(isset($_POST['langs']))
{
	echo 'Вы знаете: ' . implode(', ', $_REQUEST['langs']);
}
function input($type, $name, $value)
{
	if (isset($_REQUEST[$name]))
	{
		$value=$_REQUEST[$name];
	}
	return '<input type="text" name="'.$name.'" value="'.$value.'">';
}
echo input('text', 'input', '2');
function check($name)
{
	if(isset($_REQUEST[$name]) and $_REQUEST[$name] == 1) 
	{
		$value = 'checked';
	} 
	else 
	{
		$value = '';
	}
	return '<input type="hidden" name="'.$name.'" value="0">
	<input type="checkbox" name="'.$name.'" value="1" '.$value.'>';
}
echo check('checkbox');
?>
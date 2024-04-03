<?php
$a='test';
if ($a=='test')
{
	echo 'Верно';
}
else
	echo 'Неверно';
?>
<br>
<?php
$a1=1;
if ($a1===1)
{
	echo 'Верно';
}
else
	echo 'Неверно';
?>
<br>
<?php
$a3=3;
if(empty($a3))
{
	echo 'Неверно';
}
else
	echo 'Верно';
?>
<br>
<?php
$a4=5;
$b=7;
if ($a>2 and $a<11 or $b>=6 and $b<14)
{
	echo 'Верно';
}
else
	echo 'Неверно';
$str = '569087';
	if (($str[0]+$str[1]+$str[2]) == ($str[3]+$str[4]+$str[5]))
		echo 'Верно';
	else
		echo '<br>Неверно<br>';
$str2 = '12345';
	if ($str2[0] == 1 or $str2[0] == 2 or $str2[0] == 3)
		echo 'Верно';
	else
		echo 'Неверно';
	echo '<br/>';
?>
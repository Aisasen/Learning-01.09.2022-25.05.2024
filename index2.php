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
?>
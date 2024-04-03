<?php
$str='';
for ($i = 1; $i<= 9; $i++) 
{
    $str=$str.'-'.$i;
}
echo $str.'-'.'<br>';
for ($i=0; $i <=20; $i++) 
{
	for ($i2=0; $i2 < $i; $i2++) 
	{ 
		echo 'x';
	}
	echo '<br>';
}
for ($i=0; $i <=9; $i++) 
{
	for ($i2=0; $i2 < $i; $i2++) 
	{ 
		echo $i;
	}
	echo '<br>';
}
for ($i=0; $i <=5; $i++) 
{
	for ($i2=0; $i2 < $i; $i2++) 
	{ 
		echo 'xx';
	}
	echo '<br>';
}
?>
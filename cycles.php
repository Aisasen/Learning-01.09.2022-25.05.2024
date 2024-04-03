<?php
$arr=[2,5,9,15,0,4];
foreach ($arr as $value) {
 	if ($value>3 and $value<10)
 		echo $value;
 }
echo "<br>";
$arr2=[1,-4,2,-98,-56,-26,1,87,-7,92];
foreach ($arr2 as $value) {
	if ($value>0)
		echo $value;
}
$arr3=['green'=>'зелёный','red'=>'красный','blue'=>'голубой'];
foreach ($arr3 as $key => $value) {
	$en[]=$key;
	$ru[]=$value;
}
echo "<br>";
foreach ($en as $value) {
	echo $value.', ';
}
echo "<br>";
foreach ($ru as $value) {
	echo $value.', ';
}
echo "<br>";
$num=1000;
$i=0;
while ($num>=50) {
	$num=$num/2;
	echo $num.'<br>';
	$i++;
}
echo 'Колво итераций: '.$i;
?>
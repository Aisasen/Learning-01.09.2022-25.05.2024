<?php
echo round(sqrt(379)).', ';
echo round(sqrt(379),1).', ';
echo round(sqrt(379),2).'<br>';
$a=ceil(sqrt(379));
$b=floor(sqrt(379));
echo $a.', ';
echo $b.'<br>';
$arr=[$a=>$b];
$arr2=[];
for ($i=0; $i<10; $i++)
{
	$arr2[$i]=mt_rand(0,100000);
}
for ($i=0; $i<10; $i++)
{
	echo $arr2[$i].', ';
}
echo "<br>";
$arr3=[1, 2, -1, -2, 3, -3];
for ($i=0; $i<count($arr3); $i++)
{
	echo abs($arr3[$i]).', ';
}
$x=666;
$arr4=[];
for ($i=1; $i<$x; $i++)
{
	if ($x%$i==0)
	{
		array_push($arr4, $i);
	}
}
echo "<br>";
for ($i=0; $i<count($arr4); $i++)
{
	echo $arr4[$i].', ';
}
echo "<br>";
$arr5=[1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
$sum=0;
for ($i=0; $i<count($arr5); $i++)
{
	$sum=$sum+$arr5[$i];
	if ($sum>10)
	{
		echo $i+1;
		break;
	}
}
?>
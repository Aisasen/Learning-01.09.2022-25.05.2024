<?php
function isNumberInRange($x)
{
	if ($x>0 and $x<10) 
	{
		return true;
	}
}
isNumberInRange(5);
$arr=[1,22,3,4,51,36,7,8,49,10];
$arr2=[];
for ($i=0; $i < 10; $i++) 
{ 
	if (isNumberInRange($arr[$i])==true)
	{
		array_push($arr2, $arr[$i]);
	}
}
for ($i=0; $i < count($arr2); $i++) 
{ 
	echo $arr2[$i];
}
echo "<br><br>";
function sumOfStr($str)
{
	return array_sum(str_split($str));
}
for ($i=1; $i < 2022; $i++) 
{ 
	if (sumOfStr($i)==13) 
	{
		echo $i."<br>";
	}
}
echo "<br>";
function isEven ($chislo)
{
	if ($chislo%2==0) {
		return true;
	}
	else
		return false;
}
$arr3=[1,2,3,4,5,6,7,8,9];
$arr4=[];
for ($i=0; $i<count($arr3); $i++) 
{
	if (isEven($arr3[$i])==true) 
	{
		array_push($arr4, $arr3[$i]);
	}
}
for ($i=0; $i <count($arr4) ; $i++) 
{ 
	echo $arr4[$i].',';
}
echo "<br><br>";
function getDivisors ($chislo)
{
	$arrDeliteli=[];
	for ($i=1; $i < $chislo; $i++) { 
		if ($chislo%$i==0) 
		{
			array_push($arrDeliteli, $i);
		}
	}
	return $arrDeliteli;
}
function getCommonDivisors ($chislo1, $chislo2)
{
	var_dump (array_intersect(getDivisors($chislo1), getDivisors($chislo2)));
}
getCommonDivisors(2048, 4096)
?>
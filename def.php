<?php
function chet ($chislo)
{
	if ($chislo%2==0) {
		return "True";
	}
	else
		return "False";
}
chet(4);
function chetArr ($arr)
{
	$arr2=[];
	for ($i=0; $i<count($arr); $i++) 
	{
		if (chet($arr[$i])=="True") 
		{
			array_push($arr2, $arr[$i]);
		}
	}
	for ($i=0; $i <count($arr2) ; $i++) 
	{ 
		echo $arr2[$i].',';
	}
}
$arr=[1,2,3,4,5,6,7,8,9];
chetArr($arr);
echo "<br>";
function deliteli ($chislo)
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
deliteli(666);
function obshieDeliteli ($chislo1, $chislo2)
{
	var_dump (array_intersect(deliteli($chislo1), deliteli($chislo2)));
}
obshieDeliteli(234,828);
?>
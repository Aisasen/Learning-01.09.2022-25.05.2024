<?php
$arr=[1,2,3,4,5,6];
$sum=0;
$i=0;
while ($sum<=10) 
{
	$sum=$sum+$arr[$i];
	$i++;
}
echo $i.'<br>';
$arr2=[];
$elem='';
for ($i=0; $i<=9; $i++) 
{ 
	for ($i2=0; $i2<$i; $i2++) 
	{ 
		$elem .=$i;
	}
	array_push($arr2, $elem);
	$elem='';
}
for ($i=0; $i <= 9; $i++) 
{ 
	echo $arr2[$i].'<br>';
}
echo "<br>";
function arrayFill($x, $amount)
{
	$arr3=[];
	for ($i=0; $i < $amount; $i++) 
	{ 
		array_push($arr3, $x);
	}
	for ($i=0; $i < $amount; $i++) 
	{ 
		echo $arr3[$i];
	}
	echo "<br><br>";
}
arrayFill(0, 10);
$sum2=0;
$arr4=[[1, 2, 3], [4, 5], [6]];
for ($i=0; $i < count($arr4); $i++) 
{ 
	for ($i2=0; $i2 < count($arr4[$i]); $i2++) 
	{ 
		$sum2=$sum2+$arr4[$i][$i2];
	}
}
echo $sum2.'<br><br>';
$sum3=0;
$arr5=[[[1, 2], [3, 4]], [[5, 6], [7, 8]]];
for ($i=0; $i < count($arr5); $i++) 
{ 
	for ($i2=0; $i2 < count($arr5[$i]); $i2++) 
	{ 
		for ($i3=0; $i3 < count($arr5[$i][$i2]); $i3++) 
		{ 
			$sum3=$sum3+$arr5[$i][$i2][$i3];
		} 
	}
}
echo $sum3."<br><br>";
$arr6=[[]];
$ik=1;
for ($i=0; $i < 3; $i++) 
{ 
	for ($i2=0; $i2 < 3; $i2++) 
	{
		$arr6[$i][$i2]=$ik;
		$ik=$ik+1;
	}
}
for ($i=0; $i < 3; $i++) 
{ 
	for ($i2=0; $i2 < 3; $i2++) 
	{ 
		echo $arr6[$i][$i2];
	}
	echo "<br>";
}
?>
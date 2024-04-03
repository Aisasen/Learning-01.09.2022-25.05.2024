<?php
$arr=[1,2,3];
echo $arr[count($arr)-1].'<br>';
for ($i=0; $i < count($arr); $i++) { 
	if ($arr[$i]==3) {
		echo "Есть".'<br>';
		break;
	}
}
echo array_sum($arr)/count($arr).'<br>';
$arr2=range(1, 9);
echo implode('-', $arr2);
$arr3=[1,2,3,4,5];
$arr4=[3,4,5,6,7];
$arr5=array_intersect($arr3, $arr4);
var_dump($arr5);
echo "<br><br>";
$arr6=array_diff($arr3, $arr4);
$arr62=array_diff($arr4, $arr3);
var_dump($arr6);
var_dump($arr62);
echo "<br><br>";
$arr7=range('a', 'z');
$arr8=range(1, 26);
$arr9=array_combine($arr7, $arr8);
var_dump($arr9);
echo "<br><br>";
$arr10=['<b>php<b>', '<i>html<i>'];
var_dump(array_map('strip_tags', $arr10));
echo "<br><br>";
$arr11=['p', 'b', 'c', 'b', 'p'];
var_dump(array_count_values($arr11));
?>
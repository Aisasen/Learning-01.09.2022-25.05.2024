<?php
$date='2019-12-31';
echo str_replace('-','.',$date).'<br>';
$ssylka='http://google.com';
$proverka=strpos($ssylka,'http://');
if ($proverka==0) 
{
	echo "Да".'<br>';
}
else {
	echo "Нет".'<br>';
}
$str='hn2wecf0pu2348cmi43wymd43yfh43o7r';
$arr_numbers=['1','2','3','4','5','6','7','8','9','0'];
echo str_replace($arr_numbers, '', $str).'<br>';
$string='nfq293yn239db';
$len=strlen($string);
if ($len>5) 
{
	$string=substr($string, 1, 5).'...';
	echo $string.'<br>';
}
else
	echo $string.'<br>';
$arr2=['662','423','1047','2006','27','2855','123','9467','251','64','285','283'];
for ($i=0; $i<count($arr2);$i++)
{
	$arr3=str_split($arr2[$i]);
	for ($i2=0; $i2<count($arr3);$i2++)
	{
		if ($arr3[$i2]==3) {
			echo $arr2[$i].',';
			break;
		}
	}
}
echo "<br>";
$password='172yhd023';
if (strlen($password)>5 and strlen($password)<10)
{
	echo "Пароль подходит";
}
else
	echo "Пароль не подходит";
?>
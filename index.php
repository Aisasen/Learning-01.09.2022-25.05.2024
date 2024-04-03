<?php
$arr=['a','b','c','d'];
var_dump($arr);
echo $arr[0];
echo $arr[1];
echo $arr[2];
echo $arr[0].'+'.$arr[1].', '.$arr[2].'+'.$arr[3].' ';
$arr1=[2,5,3,9];
$result=$arr1[0]*$arr1[1]+$arr1[2]*$arr1[3].' ';
echo $result.' ';
$arr2[] = 1;
$arr2[] = 2;
$arr2[] = 3;
$arr2[] = 4;
$arr2[] = 5;
$arr3=['a'=>1, 'b'=>2, 'c'=>3];
echo $arr3['c'].' ';
echo $arr3['a']+$arr3['b']+$arr3['c'].' ';
$arr4=['Коля'=>'1000$','Вася'=>'500$','Петя'=>'200$'];
echo $arr4['Коля'].' '.$arr4['Петя'].' ';
$arr5 = [1 => 'Понедельник', 'Вторник', 'Среда', 'Четверг', 'Пятница', 'Суббота', 'Воскресенье'];
echo $arr5[2].' ';
$day=2;
echo $arr5[$day].' ';
$arr6 = [
    'cms' => ['joomla', 'wordpress', 'drupal'],
    'colors' => ['blue' => 'Синий', 'red' => 'Красный', 'green' => 'Зеленый'],
];
echo $arr6['cms'][0].' ';
echo $arr6['cms'][2].' ';
echo $arr6['colors']['green'].' ';
echo $arr6['colors']['red'].' ';
$arr7 = [
    'ru' => [1 => 'понедельник', 'вторник', 'среда', 'четверг', 'пятница', 'суббота', 'воскресенье'],
    'en' => [1 => 'monday', 'tuesday', 'wednesday', 'thursday', 'friday', 'saturday', 'sunday']
];
echo $arr7['ru'][1].' ';
echo $arr7['en'][3].' ';
$lan = 'ru';
$day = 3;
echo $arr7[$lan][$day];
?>
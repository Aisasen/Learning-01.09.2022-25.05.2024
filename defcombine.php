<?php
echo implode(range(1,100), '<br>').'<br>';
$arr2=range(20, 35);
shuffle($arr2);
echo implode($arr2, ',').'<br>';
var_dump(array_combine(range('a', 'z'), range(1, 26)));
echo "<br>";
echo implode(array_map('sqrt', range(1, 10)), ',').'<br>';
echo array_product(range(1, 10)).'<br>';
echo array_sum(str_split('123456789',2));
?>
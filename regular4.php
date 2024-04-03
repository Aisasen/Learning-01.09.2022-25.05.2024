<?php
//1
echo preg_replace('#(\w+)@(\w+)#', '$2@$1', 'aaa@bbb eee7@kkk').'<br>';
//2
echo preg_replace('#(\w)\1#', '!', 'aae xxz 33a').'<br>';
//3
preg_match_all('#[a-z0-9.-_]+@\w+\.[a-z]{2,3}#', 'mymail@mail.ru, my.mail@mail.ru, my-mail@mail.ru, my_mail@mail.ru, mail@mail.com, mail@mail.by, mail@yandex.ru.', $matches).'<br>';
var_dump($matches);
echo "<br>";
//4
echo preg_replace('#(\d{2})-(\d{2})-(\d{4})#', '$3.$2.$1', '31-12-2014').'<br>';
?>
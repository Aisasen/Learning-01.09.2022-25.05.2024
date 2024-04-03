<?php
//1
echo preg_replace('#(\d+)#', '$1$1', 'a1b2c3').'<br>';
//2
echo preg_replace('#(\w+)\1\1#', '!', 'aaa bcd xxx efg').'<br>';
//3
echo preg_replace('#[a-z0-9-]+\.[a-z0-9-]+\.[a-z]{2,3}#','!', 'hello.site.ru, hello.site.com, hello.my-site.com').'<br>';
//4,5,6,11
echo preg_replace('#https?://[a-z]+\.([a-z]{2,3})/?#', '!', 'http://site.ru, http://site.com, https://site.com, , https://site.ru/').'<br>';
//7,8
echo preg_replace('#[a-z0-9A-Z-]+\.(php|html|txt|jpeg|jpg)#', '!', 'sub.php, iner.html, rash.txt, sub.jpeg, sub.jpg').'<br>';
//9
echo preg_replace('#[0-9]{1,12}#', '!', '1234567890').'<br>';
//10
preg_match_all('#\d+#', 'uasdh8 7asdas hd 1298 h3189h2c 3819', $matches).'<br>';
for ($i=0; $i <count($matches[0]) ; $i++) 
{ 
	$matches[0][$i]=intval($matches[0][$i]);
}
var_dump($matches);
echo "<br>";
echo array_sum($matches[0]).'<br>';
//12
echo preg_replace('#https?://([a-z0-9-]+\.[a-z]{2,})#', '<a href="$0">$1</a>', 'http://site.ru, http://site.com, https://site.info');
?>
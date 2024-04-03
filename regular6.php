<?php
//1
echo preg_replace('#(?<=b)aaa#', '!', 'baaa').'<br>';
//2
echo preg_replace('#(?<!b)aaa#', '!', 'baaa waaa').'<br>';
//3
echo preg_replace('#aaa(?=b)#', '!', 'aaab').'<br>';
//4
echo preg_replace('# \*{2} #', '!', 'aaa * bbb ** eee *** kkk ****').'<br>';
//5
echo preg_replace('#([a-zA-Z])(?=\1)#', '!', 'aa').'<br>';
//6
echo preg_replace('#(?<=([a-z]))\1#', '!', 'aabbccdefffgh').'<br>';
//7
echo preg_replace_callback('#\d+#', 'powmatch', '1 2 3 4 5 6 7 8 9').'<br>';
function powmatch ($matches)
{
	for ($i=0; $i < count($matches); $i++) 
	{ 
		return pow($matches[$i], 2);
	}
}
//8
echo preg_replace_callback("#'(\d+)'#", 'multikav', "1 2 '3' 4 '5' 6 '7' 8 9"); 
function multikav ($matches)
{
	return $matches[1]*2; //почему-то не работает в цикле
}
?>
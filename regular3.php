<?php
//1
echo preg_replace('#a[^e^x]*a#', '!', 'aba aea aca aza axa a-a a#a').'<br>';
//2
echo preg_replace('#w[а-яё]*w#', '!', 'wйw wяw wёw wqw').'<br>';
//3
echo preg_replace('#a[a-z]*a#', '!', 'aAXa aeffa aGha aza ax23a a3sSa').'<br>';
//4
echo preg_replace('#a[a-zA-Z]*a#', '!', 'aAXa aeffa aGha aza ax23a a3sSa').'<br>';
//5
echo preg_replace('#a[a-z0-9]*a#', '!', 'aAXa aeffa aGha aza ax23a a3sSa').'<br>';
//6
echo preg_replace('#^aaa#', '!', 'aaa aaa aaa').'<br>';
//7
echo preg_replace('#aaa$#', '!', 'aaa aaa aaa').'<br>';
//8
echo preg_replace('#[|ae*a||ax*a|]#', '!', 'aeeea aeea aea axa axxa axxxa').'<br>';
//9
echo preg_replace('#[|ae{2}a||ax*a|]#', '!', 'aeeea aeea aea axa axxa axxxa').'<br>';
//10
echo preg_replace('#\b#', '!', 'aeeea aeea aea axa axxa axxxa').'<br>';
//11
echo preg_replace('#a\\\a#', '!', 'a\a abc').'<br>';
//12
echo preg_replace('#a\\\*a#', '!', 'a\a a\\a a\\\a').'<br>';
//13
echo preg_replace('#/...\\\#', '!', 'bbb /aaa\ bbb /ccc\\').'<br>';
//14
echo preg_replace('#<b>.*</b>#', '!', 'bbb <b> hello </b>, <b> world </b> eee').'<br>';
?>
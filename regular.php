<?php
//1
echo preg_replace('#a.b#', '!', 'ahb acb aeb aeeb adcb axeb').'<br>';
//2
echo preg_replace('#a..b#', '!', 'aba aca aea abba adca abea').'<br>';
//3
echo preg_replace('#ab.a#', '!', 'aba aca aea abba adca abea').'<br>';
//4
echo preg_replace('#ab*a#', '!', 'aa aba abba abbba abca abea').'<br>';
//5
echo preg_replace('#ab*a#', '!', 'aa aba abba abbba abca abea').'<br>';
//6
echo preg_replace('#ab?a#', '!', 'aa aba abba abbba abca abea').'<br>';
//7
echo preg_replace('#ab+#', '!', 'ab abab abab abababab abea').'<br>';
//8
echo preg_replace('#a\.a#', '!', 'a.a aba aea').'<br>';
//9
echo preg_replace('#2\+3#', '!', '2+3 223 2223').'<br>';
//10
echo preg_replace('#2\++3#', '!', '23 2+3 2++3 2+++3 345 567').'<br>';
//11
echo preg_replace('#2.*3#', '!', '23 2+3 2++3 2+++3 445 677').'<br>';
//12
echo preg_replace('#\*q.*\+#', '!', '*+ *q+ *qq+ *qqq+ *qqq qqq+').'<br>';
//13
echo preg_replace('#\*q*\+#', '!', '*+ *q+ *qq+ *qqq+ *qqq qqq+').'<br>';
//14
echo preg_replace('#a.*?a#', '!', 'aba accca azzza wwwwa').'<br>';
?>
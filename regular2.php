<?php
//1
echo preg_replace('#ab{2,4}a#', '!', 'aa aba abba abbba abbbba abbbbba').'<br>';
//2
echo preg_replace('#ab{0,3}a#', '!', 'aa aba abba abbba abbbba abbbbba').'<br>';
//3
echo preg_replace('#ab{4,}a#', '!', 'aa aba abba abbba abbbba abbbbba').'<br>';
//4
echo preg_replace('#a\da#', '!', 'a1a a2a a3a a4a a5a aba aca').'<br>';
//5
echo preg_replace('#a\d+a#', '!', 'a1a a22a a333a a4444a a55555a aba aca').'<br>';
//6
echo preg_replace('#a\d*a#', '!', 'aa a1a a22a a333a a4444a a55555a aba aca').'<br>';
//7
echo preg_replace('#a\D*b#', '!', 'avb a1b a2b a3b a4b a5b abb acb').'<br>';
//8
echo preg_replace('#a\W*b#', '!', 'b a$b a4b a5b a-b acb').'<br>';
//9
echo preg_replace('#\s#', '!', 'ave a#a a2a a$a a4a a5a a-a aca').'<br>';
//10
echo preg_replace('#a[a-w]a#', '!', 'aba aea aca aza axa').'<br>';
//11
echo preg_replace('#a[b.+*]a#', '!', 'aba aea aca aza axa a.a a+a a*a').'<br>';
//12
echo preg_replace('#a[3-7]a#', '!', 'a6a a7a a1a a9a').'<br>';
//13
echo preg_replace('#a[a-g]a#', '!', 'aha aya aja ara ala aba aqa ana ama aca aba').'<br>';
//14
echo preg_replace('#a[a-fj-z]a#', '!', 'aha aya aja ara ala aba aqa ana ama aca aba').'<br>';
?>
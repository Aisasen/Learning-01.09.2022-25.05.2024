<?php
function ploshad ($katet1, $katet2)
{
	$s=($katet1*$katet2)/2;
	return $s;
}
$a=ploshad(3,4);
$b=ploshad(5,6);
$c=ploshad(7,8);
echo max($a,$b,$c).'<br>';
function dlina ($x,$y,$x1,$y1)
{
	$dlina=sqrt(pow($x1-$x, 2)+pow($y1-$y, 2));
	return $dlina;
}
$a1=dlina(3,10,6,7);
$b1=dlina(3,10,6,7);
$c1=dlina(9,5,2,7);
if ($a1==$b1 or $a1==$c1 or $b1=$c1) 
{
	echo "Есть отрезки равной длины".'<br>';
}
function chance ($k)
{
	$P=pow(3,$k)*pow(2.72,-3)/array_sum(range(1, $k));
	return $P;
}
echo chance(2).'<br>';
echo chance(4).'<br>';
function equation ($a, $b, $c) 
{
    if ($a==0) return false;

    if ($b==0) 
    {
        if ($c<0) 
        {
            $x1 = sqrt(abs($c/$a));
            $x2 = sqrt(abs($c/$a));
        }
        elseif ($c==0) 
        {
            $x1 = $x2 = 0;
        } 
        else 
        {
            $x1 = sqrt($c/$a).'i';
            $x2 = -sqrt($c/$a).'i';
        }
    }
    else 
    {
        $d = $b*$b-4*$a*$c;
        if ($d>0) 
        {
            $x1 = (-$b+sqrt($d))/2*$a;
            $x2 = (-$b-sqrt($d))/2*$a;
        } 
        elseif ($d==0) 
        {
            $x1 = $x2 = (-$b)/2*$a;
        } 
        else 
        {
            $x1 = -$b . '+' . sqrt(abs($d)) . 'i';
            $x2 = -$b . '-' . sqrt(abs($d)) . 'i';
        }
    }
    return array($x1, $x2);
}
echo (array_sum(equation(4,2,3))+array_sum(equation(10,7,4))+array_sum(equation(1,6,5)))/3;
echo "<br>";
function vychitaniePiramidy ($a_piramidy,$h_piramidy,$a_kuba,$b_kuba,$c_kuba)
{
	return ($a_kuba*$b_kuba*$c_kuba)-((1/3)*$h_piramidy*pow($a_piramidy,2));
}
echo vychitaniePiramidy(5,5,5,5,5);
?>
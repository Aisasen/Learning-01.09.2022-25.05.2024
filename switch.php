<?php
$enty=['Крыса', 'Бык', 'Тигр', 'Кролик', 'Дракон', 'Змея', 'Лошадь', 'Коза' , 'Обезьяна', 'Петух', 'Собака', 'Свинья'];
$elem=['Дерево', 'Огонь', 'Земля', 'Металл', 'Вода'];
$i2=0;
$year=2004;
for ($cycle=0;$cycle<5;$cycle++)
{
	for ($i=0;$i<12;$i++)
	{
		if ($year>2004 and $year%2==0)
		{
			$i2=$i2+1;
			if ($i2==5)
			{
				$i2=0;
			}
		}
		echo 'В '.$year.' году '.$enty[$i].' и '.$elem[$i2].'<br>';
		$year=$year+1;
		if ($year==2064) 
		{
			break;
		}
	}
}
echo "<br>";
$weight=[1=>1, 2=>0.00001, 3=>0.001, 4=>1000, 5=>10];
$mass=65;
$key=3;
switch ($key)
{
	case 1:
	echo 'Вы ввели '. $mass.' кг';
	break;
	case 2:
	echo 'Вы ввели '.$mass.' милиграмм, в системе СИ будет: '.$mass*$weight[2].' кг'.'<br>';
	break;
	case 3:
	echo 'Вы ввели '.$mass.' грамм, в системе СИ будет: '.$mass*$weight[3].' кг'.'<br>';
	break;
	case 4:
	echo 'Вы ввели '.$mass.' тонн, в системе СИ будет: '.$mass*$weight[4].' кг'.'<br>';
	break;
	case 5:
	echo 'Вы ввели '.$mass.' центнеров, в системе СИ будет: '.$mass*$weight[5].' кг'.'<br>';
	break;
}
$k=41;
switch ($k) 
{
	case ($k>0 and $k<5):
		echo "$k год";
		break;
	case ($k>4 and $k<21):
		echo "$k лет";
		break;
	case ($k>20 and ($k%10==2 or $k%10==3 or $k%10==4)):
		echo "$k года";
		break;
	case ($k>20 and ($k%10==5 or $k%10==6 or $k%10==7 or $k%10==8 or $k%10==9 or $k%10==0)):
		echo "$k лет";
		break;
	case ($k>20 and ($k%10==1)):
		echo "$k год";
}
?>
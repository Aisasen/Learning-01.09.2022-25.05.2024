<form action="" method="post">
	<input type="text" name="count" placeholder="Введите колличество студентов">
	<input type="submit">
</form>
<form action="" method="post">
	<input type="text" name="grade" placeholder="Введите 4 оценки через запятую">
	<input type="submit">
</form>

<?php
$arr=[1,2,3,4,5,6,7,8,9,10];
for ($i=0; $i < count($arr); $i++) 
{ 
	if ($arr[$i]==3) 
	{
		echo "Есть".'<br>';
		break;
	}
}
$x=31;
$arr2=[];
for ($i=1; $i<$x; $i++)
{
	if ($x%$i==0)
	{
		array_push($arr2, $i);
	}
}
if (count($arr2)<3) 
{
	echo "Нет".'<br>';
}
$arr3=[1,2,62,7,2,6,67,3,7,6,1,3,7,7,1,23,7,0];
for ($i=0; $i <count($arr3)-1; $i++) 
{ 
	if ($arr3[$i]==$arr3[$i+1]) 
	{
		echo "Да".'<br>';
	}
}

if (!empty($_REQUEST['count'])) 
{
	$n=$_REQUEST['count'];
}

$count=0;
$countst=0;
if (!empty($_REQUEST['grade'])) 
{
	$grades=explode(',', $_REQUEST['grade']);
	for ($i=0; $i < 4; $i++) 
	{ 
		if ($grades[$i]==2 or $grades[$i]==3) 
		{
			break;
		}
		else
		{
			$countst++;
		}
	$count++;
		if ($count==4) 
		{
			break;
		}
	}
}
echo $countst;
?>
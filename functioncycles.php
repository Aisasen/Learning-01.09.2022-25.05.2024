<form action="" method="post">
	<input type="text" name="colvo" placeholder="Первая строка">
	<input type="submit">
</form>
<?php
function zamena($text)
{
	$newstr='';
	for ($i=0; $i < strlen($text); $i++) 
	{
		if ($i%2!=1) 
		{
			$newstr.=$text[$i+1];
		}
		if ($i%2==1) 
		{
			$newstr.=$text[$i-1];
		}
	}
	echo $newstr.'<br>';
}
zamena('12345678');
$chislo=666;
$deliteli=[];
for ($i=1; $i < $chislo; $i++) 
{ 
	if ($chislo%$i==0) 
	{
		array_push($deliteli, $i);
	}
}
if (count($deliteli)>1) 
{
	echo "Не простое число".'<br>';
}
else
	echo "Простое число".'<br>';
if(isset($_POST['colvo']))
{
	$firstline=$_POST['colvo'];
	$i=$firstline;
	for ($i; $i > 0; $i=$i-1) 
	{ 
		for ($i2=0; $i2 < $i; $i2++) 
		{ 
			echo "x";
		}
		echo "<br>";
	}
}
function multiElement(array $arr)
{
	$array=[];
	for ($i=0; $i < count($arr); $i++) 
	{
		for ($i2=0; $i2 < $arr[$i]; $i2++) 
		{ 
			array_push($array, $arr[$i]);
		}
	}
	var_dump($array);
}
multiElement([1,2,3,4]);
echo "<br>";
function strreverse($text)
{
	$newStr='';
	$i2=0;
	for ($i=strlen($text)-1; $i>-1; $i=$i-1) 
	{
		$newStr[$i2]=$text[$i];
		$i2++;
	}
	echo $newStr;
}
strreverse('asdfg')
?>
<form action="" method="post">
	<input type="text" name="year">
	<input type="submit">
</form>
<form action="" method="post">
	<input type="text" name="year2">
	<input type="submit">
</form>
<form action="" method="post" >
	<input type="text" name="year3">
	<input type="submit">
</form>
<form action="" method="POST">
    <input type="text" name="date">
    <input type="submit">
</form>
</form>
<form action="" method="POST">
    <input type="text" name="text">
    <input type="submit">
</form>
<form action="" method="post">
    <textarea name="text2"></textarea>
    <input type="submit">
</form>
<?php
if(isset($_POST['year']))
{
	if ($_POST['year']%4==0) 
	{
		echo "Год високосный.";
	}
	else
		echo "Год не високосный.";
}
if(isset($_POST['year2']))
{
	$days = array( 1 =>'Понедельник' ,'Вторник' ,'Среда','Четверг','Пятница','Суббота','Воскресенье');
	echo $days[date('w', strtotime($_POST['year2']))];
}
echo date('d F Y'),' year<br><br>';
if(isset($_POST['year3']))
{
	$bd = explode('.', $_POST['year3']);
	$bd = mktime(0, 0, 0, $bd[1], $bd[0], date('Y') + ($bd[1].$bd[0] <= date('md')));
	$days_until = ceil(($bd - time()) / 86400);
	echo $days_until;
}
$signs = [1 => "Козерог", "Водолей", "Рыбы", "Овен", "Телец", "Близнецы", "Рак", "Лев", "Девы", "Весы", "Скорпион", "Стрелец"];
$signs_date = [1 => 21, 20, 20, 20, 20, 20, 21, 22, 23, 23, 23, 23];
if (isset($_REQUEST['date'])) 
{
    $date = $_REQUEST['date'];
    $date = explode('.', $date);
    $day = $date[0];
    $month = $date[1];

    if (substr($month, 0, 1) == 0) {
        $month = substr($month, 1, 2);
    }
    if ($day > $signs_date[$month]) {
        if ($month == "12")
        {
            $month = "0";
        }
        $a = $signs[$month + 1];
    } 
    else  
    {
        $a = $signs[$month];
    }
    if ($a == 13) 
    {
        echo $signs[1];
    } 
    else 
    {
        echo $a;
    }
}
if (isset($_REQUEST['text'])) 
{
    $str = $_REQUEST['text'];
    $strLen = strlen($str);
    $wordsCount = count(explode(' ', $str));
    $spaceCount = $wordsCount - 1;
    echo 'В тексте '.$wordsCount.' слов, '.$strLen.' символов, '.$spaceCount . ' пробелов.';
}
if (isset($_REQUEST['text2'])) {
    $abv = ['а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м',
        'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ы', 'э', 'ю', 'я'];
    $words = explode(' ', $_REQUEST['text2']);
    $res = [];
    foreach ($abv as $item) {
        foreach ($words as $word) {
            $word = mb_strtolower($word);
            if (mb_substr($word, 0, 1) == $item) {
                $res[$item][] = $word;
            }
        }
    }
    foreach ($res as $key => $item2) {
        echo 'Слова на букву '.$key.'<br>';
        foreach ($item2 as $subItem) {
            echo $subItem.'<br>';
        }
        echo '<br>';
    }
 
}
?>
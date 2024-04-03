<form action="" method="post">
<input type="text" name="date" placeholder="Введите год">
<input type="submit">
</form>
<?php
echo time().'<br>';
echo mktime(0, 0, 0, 1, 1, 2025).'<br>';
echo mktime(0, 0, 0, 12, 31);
echo time()-mktime(13, 12, 59, 3, 15, 2000).'<br>';
$sec = time() - mktime(7,23,48);
$hours = $sec/60;
echo round($hours).'<br>';
echo date('d.m.Y', mktime(0, 0, 0, 2, 12, 2025)).'<br>';
$week = array('Sun', 'Mon', 'Tue', 'Wed', 'Thur', 'Fri', 'Sat');
$day = date('w');
echo $week[$day].'<br>';
$day1 = date('w', mktime(0, 0, 0, 6, 6, 2006));
echo $week[$day1].'<br>';
$months = array('Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec');
$m = date('n');
echo $months[$m-1].'<br>';
$newyear = mktime(0, 0, 0, 1, 1, date('Y') + 1);
$sec = $newyear - time();
$days = floor($sec / (60*60*24)).'<br>';
echo "До нового года осталось: $days дней".'<br>';
$year='';
if (!empty($_REQUEST['date']))
{
	$year=$_POST['date'];
}
$friday = 0;
for($month = 1; $month <= 12; $month++){
	$days_in_month = date('t', mktime(0, 0, 0, $month, 1, intval($year)));
	for($day = 1; $day <= $days_in_month; $day++){
	    $d = date('w', mktime(0, 0, 0, $month, $day, intval($year)));
	    if($d == 5){
		    if( date('d', mktime(0, 0, 0, $month, $day, intval($year))) == 13){
			   $friday++; 
			   $friday_date = date('d.m.Y', mktime(0, 0, 0, $month, $day, intval($year))).'<br>';
		    }
	    }
	}
}
echo $friday.'<br>';
$date = date_create();
date_modify($date, '- 100 day');
$day = date_format($date, 'w');
$week = ['sn', 'mn', 'tu', 'wd', 'th', 'fr', 'st'];
echo $week[$day];
?>
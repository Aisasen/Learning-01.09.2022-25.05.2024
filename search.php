<?php 
define('DB_HOST', 'localhost');
define('DB_USER', 'имя пользователя бд');
define('DB_PASS', 'пароль');
define('DB_NAME', 'имя базы данных');
$link=mysqli_connect('localhost', 'root', '', 'users');
if (!$link) 
{
    exit('Cannot connect to server');
}
if (!mysqli_select_db($link, 'users')) 
{
    exit('Cannot select database');
}

mysqli_query($link, 'SET NAMES utf8');

function search ($query) 
{
    $link=mysqli_connect('localhost', 'root', '', 'users');
    $query = trim($query); 
    $query = mysqli_real_escape_string($link, $query);
    $query = htmlspecialchars($query);

    if (!empty($query)) 
    { 
        if (strlen($query) < 3) 
        {
            $text = '<p>Слишком короткий поисковый запрос.</p>';
        }
        else if (strlen($query) > 128) 
        {
            $text = '<p>Слишком длинный поисковый запрос.</p>';
        } 
        else 
        { 
            $q = "SELECT `id`, `login`, `password`, `Birthday`, `Email`, `registration_date`
                  FROM `users` WHERE `id` LIKE '%$query%'
                  OR `login` LIKE '%$query%' OR `Birthday` LIKE '%$query%'
                  OR `registration_date` LIKE '%$query%'";

            $result = mysqli_query($link, $q);

            if (mysqli_affected_rows($link) > 0) 
            { 
                $row = mysqli_fetch_assoc($result); 
                $num = mysqli_num_rows($result);

                $text = '<p>По запросу <b>'.$query.'</b> найдено совпадений: '.$num.'</p>';

                do 
                {
                    // Делаем запрос, получающий ссылки на статьи
                    $q1 = "SELECT `id` FROM `users` WHERE `id` = '$row[id]'";
                    $result1 = mysqli_query($link, $q1);

                    if (mysqli_affected_rows($link) > 0) 
                    {
                        $row1 = mysqli_fetch_assoc($result1);
                    }

                    $text .= '<p><a> href="'.$row1['id'].'/'.$row['login'].'/'.$row['id'].'" title="'.$row['id'].'">'.$row['login'].'</a></p>
                    <p>'.$row['Birthday'].'</p>';

                } 
                while ($row = mysqli_fetch_assoc($result)); 
            }
            else 
            {
                $text = '<p>По вашему запросу ничего не найдено.</p>';
            }
        } 
    } 
    else 
    {
        $text = '<p>Задан пустой поисковый запрос.</p>';
    }

    return $text; 

}
if (!empty($_POST['query'])) 
{ 
    $search_result = search ($_POST['query']); 
    echo $search_result; 
}
?>

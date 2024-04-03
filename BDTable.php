<table>
	<tr>
		<th>id</th>
		<th>name</th>
		<th>age</th>
		<th>salary</th>
		<th>delete</th>
	</tr>
	<?php
		$link=mysqli_connect('localhost', 'root', '', 'работники');
		// Добавление
		if (!empty($_POST['add'])) 
		{
			$name = $_POST['name'];
			$age = $_POST['age'];
			$salary = $_POST['salary'];
			$AddQuery = "INSERT INTO workers SET name='$name', age='$age', salary='$salary'";
			mysqli_query($link, $AddQuery) or die(mysqli_error($link));
		}
		// Удаление по id
		if (isset($_GET['del'])) 
		{
			$del = $_GET['del'];
			$query = "DELETE FROM workers WHERE id=$del";
			mysqli_query($link, $query) or die(mysqli_error($link));
		}
		// Получение всех работников:
		$query = "SELECT * FROM workers";
		$result = mysqli_query($link, $query) or die(mysqli_error($link));
		for ($data = []; $row = mysqli_fetch_assoc($result); $data[] = $row);
		// Удаление самого молодого
		if (isset($_POST['delNew'])) 
		{
			foreach ($data as $elem) 
			{
				$delAge = min(array($elem['age']));
			}
			mysqli_query($link, "DELETE FROM workers WHERE age=$delAge") or die(mysqli_error($link));
			header("Refresh:0");
		}
		// Вывод на экран:
		$result = '';
		foreach ($data as $elem) 
		{
			$result .= '<tr>';
			$result .= '<td>' . $elem['id'] . '</td>';
			$result .= '<td>' . $elem['name'] . '</td>';
			$result .= '<td>' . $elem['age'] . '</td>';
			$result .= '<td>' . $elem['SALARY'] . '</td>';
			$result .= '<td><a href="?del=' . $elem['id'] . '">удалить</a></td>';
			$result .= '</tr>';
		}
		echo $result.'<br>';
	?>
</table>
<form action="" method="POST">
	<input name="name">
	<input name="age">
	<input name="salary">
	<input type="submit" value="добавить работника" name="add">
</form>
<form action="" method="POST">
	<input type="submit" value="удалить самого молодого" name="delNew">
</form>




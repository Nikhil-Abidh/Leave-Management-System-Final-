<?php

$con = mysqli_connect("localhost","root","","leave");
if(con) 
		echo "Connected</br>";
else 
	echo "Error ".mysqli_error($con)."</br>";

$Uname = $_POST["username"];
$Email = $_POST["email"];
$Designation = $_POST["designation"];
$Address = $_POST["address"];
$Phone_no = $_POST["phnNo"];
$Password = $_POST["pw"];

$sql ="INSERT INTO users(UserName,Email,Designation,Address,PhoneNo,Password) VALUES ($Uname,$Email,$Designation,$Address,$Phone_no,$Password) ";
if(mysqli_query($con,$sql)){
	echo "New User Added";
	header("Location : http://localhost/Leave/index.html");
	exit;
}
else{
	echo "Error Occured";
	header("Location : http://localhost/Leave/register.html");
	exit;
}


?>
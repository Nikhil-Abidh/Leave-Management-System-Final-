<?php
session_start();
$con = mysqli_connect("localhost","root","","webattend");
if(! $con)
echo "Error Occured".mysqli_error($con);
else
echo "Connected";

$userid = $_SESSION['userId'];
$value = $_POST["choise"];
$item = $_POST["editinfo"];

$query="";
if($value == "Name")
$query = "update users set Name='$item' where id='$userid' ";
else if($value == "Age")
$query = "update users set Age='$item' where id='$userid' ";
else if($value == "Email")
$query = "update users set Email='$item' where id='$userid' ";
else if($value == "Password")
$query = "update users set password='$item' where id='$userid' ";
else if($value == "Gender")
$query = "update users set Gender='$item' where id='$userid' ";
else if($value == "Phone")
$query = "update users set Phone='$item' where id='$userid' ";
else if($value == "Address")
$query = "update users set Address='$item ' where id='$userid' ";

//$result = mysqli_query($con,$query);
if($result = mysqli_query($con,$query)){
    header("Location: UserDashboard.php");
    exit;   
}
    else 
        {
    header("Location: updatememberinfo.php");
    exit;
;   


        }

?>

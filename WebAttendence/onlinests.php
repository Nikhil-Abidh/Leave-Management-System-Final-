<?php
session_start();
$con = mysqli_connect("localhost","root","","webattend");
if(! $con)
echo "Error Occured".mysqli_error($con);
else
echo "Connected";

$userid = $_SESSION['userId'];
$sts = $_SESSION["sts"];
$intime = date("H:i");
$indate = date("d/m/Y");

$result = mysqli_query($con,"select * from present where User_id='$userid' ");
$row = mysqli_fetch_assoc($result);

$query="";
if($row["Status"] == "0" && $sts = "Make Online" ){
$query = "insert into present (User_id,in_time,in_date,Status) values('$userid','$intime','$indate','1') ";
}

else //if($row["Status"] == "1" || $sts = "Make Offline"){
{	$query = "update present set out_time='$intime', out_date='$indate',Status='0' where User_id='$userid' ";
}

//$result2 = mysqli_query($con,$query);

if($res = mysqli_query($con,$query)){
    header("Location: UserDashboard.php");
    exit;   
}
    else 
        {
	echo "Error Occured".mysqli_error($con);
}

?>

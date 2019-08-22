<?php
session_start();
$con = mysqli_connect("localhost","root","","webattend");
if(! $con)
echo "Error Occured".mysqli_error($con);
else
echo "Connected";

$mail = $_POST['usermail'];
$pw = $_POST['userpw'];

$query = "select * from users where email='$mail' and password='$pw' ";
$result = mysqli_query($con,$query);

if(mysqli_num_rows($result)>0){
    $row = mysqli_fetch_assoc($result);
    $_SESSION['userId'] = $row['id'];
    $role =$row["Designation"]; 
    if($role == "Member"){
        header("Location: UserDashboard.php");
        exit;
        }
    else if($role == "Admin"){
            header("Location: AdminDashboard.php");
            exit;
        }                
}
else 
{
    header("Location: index.html");
    exit;
}

mysqli_close($con);

?>
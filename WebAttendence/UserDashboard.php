<?php
session_start();
$con = mysqli_connect("localhost","root","","webattend");
if(! $con)
echo "Error Occured".mysqli_error($con);
else
echo "Connected";
$userid = $_SESSION['userId'];

$query = "select * from users where id='$userid' ";
$query2 = "select * from present where User_id='$userid' ";
$result = mysqli_query($con,$query);
$result2 = mysqli_query($con,$query2);
$row = mysqli_fetch_assoc($result);
$row2 = mysqli_fetch_assoc($result2);

?>

<!DOCTYPE html>
<html>
<head>
    <style>
    #header{
        Color:green;
        background-color: khaki;
        font-size: 35px;
        height : 200px;
        padding-top: 20px;
        padding-left: 250px;
    }
    #footer{
        background-color: cornsilk;
        color: blueviolet;
        font-size: 30px;
        height : 40px;
        padding-left :250px; 
    }
    </style>
    <title>User Dashboard</title>
</head>
<body>
<div id="header">
<h1>Attendence Management System</h1>
</div>

<div id="content" >
<p>Date : <?php
echo date("d/m/Y");?> <br> Time: <?php  echo date("h:i"); ?></p><br>
<p>User Dashboard (<?php echo $row["Name"] ?>)</p>
<pre>
    User id     : <?php echo $row["id"] ?><br>
    Name        : <?php echo $row["Name"] ?><br>
    Email       : <?php echo $row["Email"] ?><br>
    Password    : <?php echo $row["password"] ?><br>
    Age         : <?php echo $row["Age"] ?><br>
    Gender      : <?php echo $row["Gender"] ?><br>
    Address     : <?php echo $row["Address"] ?><br>
    Phone No.   : <?php echo $row["Phone"] ?><br>
    Designation : <?php echo $row["Designation"] ?><br>
</pre>
    <p>Status : <span style="font-size: 20px;color: green;"> <?php if( $row2["Status"]=="1" ) echo "Active"; 
    else echo "Offline"; ?> </span></p>

<p>Want to go <?php if($row2["Status"]=="1") {
    $_SESSION["sts"]="Make Offline";
    echo "Offline ? ";
    }
    else {
        $_SESSION["sts"]="Make Online";
        echo "Online ? ";
    } ?>
<a href="onlinests.php">Click Here</a>
</p>

    <p>Action : <a href="updatememberinfo.php">Edit Personal Information</a> </p>
</div>

<div id="footer">
<p>Copyrights are reserved  by Nazmul Islam</p> 
</div>

</body>
</html>

<?php
mysqli_close($con);
?>
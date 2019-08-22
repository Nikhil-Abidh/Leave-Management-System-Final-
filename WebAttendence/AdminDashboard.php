<?php
session_start();
$con = mysqli_connect("localhost","root","","webattend");
if(! $con)
echo "Error Occured".mysqli_error($con);
else
echo "Connected";
$userid = $_SESSION['userId'];
$query = "select * from users ";
$result = mysqli_query($con,$query);

$query2 = "select * from present ";
$result2 = mysqli_query($con,$query2);


?>

<!DOCTYPE html>
<html>
<head>
	<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
	<link rel="stylesheet" href="https://ajax.googleapis.com/ajax/libs/jqueryui/1.12.1/themes/smoothness/jquery-ui.css">
	<script src="https://ajax.googleapis.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.js"></script>
	
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
    <title>Admin Dashboard</title>
</head>
<body>
<div id="header">
<h1>Attendence Management System</h1>
</div>

<div id="content" >
<p>Welcome, Admin </p>
<p>Looking for more information ? Then Select option from here</p>
<select name="option">
	<option>User-wise status</option>
	<option>Day-wise Status</option>
	<option>Edit Role</option>
</select>

<p>All Member Information</p>
<table id="viewtable" border="2" >
    <tr>
        <td>User Id</td>
        <td>Name</td>
        <td>Email Address</td>
        <td>Password</td>
        <td>Age</td>
        <td>Gender</td>
        <td>Address</td>
        <td>Designation</td>
        <td>Phone Number</td>
        <td>Active Status</td>
    </tr>
    <?php while($row = mysqli_fetch_assoc($result)) {?>
    <tr> 
        <td><?php echo $row["id"] ?></td>
        <td><?php echo $row["Name"] ?></td>
        <td><?php echo $row["Email"] ?></td>
        <td><?php echo $row["password"] ?></td>
        <td><?php echo $row["Age"] ?></td>
        <td><?php echo $row["Gender"] ?></td>
        <td><?php echo $row["Address"] ?></td>
        <td><?php echo $row["Designation"] ?></td>
        <td><?php echo $row["Phone"] ?></td>
        <td><?php echo $row["in_sts"] ?></td>
    </tr>
    <?php } ?>    
</table>
<br>
<p>Status of Members</p>
<table id="viewsts" border="2" >
    <tr>
        <td>User Id</td>
        <td>Time of Reach</td>
        <td>Date</td>
        <td>Time of Leave</td>
        <td>Date</td>
        <td>Work Hours</td>
        <td>Status</td>
    </tr>
    <?php while($row2 = mysqli_fetch_assoc($result2)) {?>
    <tr> 
        <td><?php echo $row2["User_id"] ?></td>
        <td><?php echo $row2["in_time"] ?></td>
        <td><?php echo $row2["in_date"] ?></td>
        <td><?php echo $row2["out_time"] ?></td>
        <td><?php echo $row2["out_date"] ?></td>
        <td><?php echo $row2["work_hour"] ?></td>
        <td><?php echo $row2["Status"] ?></td>
    </tr>
    <?php } mysqli_close($con); ?>    
</table>



</div>
<p>Want to Logout ? <a id="logoutlink" href="index.html">Click Here</a></p>

<div id="footer">
<p>Copyrights are reserved  by Nazmul Islam</p> 
</div>

<script type="text/javascript">
$("document").ready(function(){
	$("#viewtable td:odd").css("background-color","pink");
	$("#viewtable td:even").css("background-color","white");
	$("#viewtable td:contains(Active)").css("background-color","green");
	
	$("#logoutlink").mouseover(function(){
		$(this).css("color","red");
	});
	
	$("#logoutlink").mouseout(function(){
		$(this).css("color","blue");
	});

});

</script>

</body>
</html>

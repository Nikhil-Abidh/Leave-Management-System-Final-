<?php
session_start();
$con = mysqli_connect("localhost","root","","webattend");
if(! $con)
echo "Error Occured".mysqli_error($con);
else
echo "Connected";

$userid = $_SESSION['userId'];
$query = "select * from users where id='$userid' ";
$result = mysqli_query($con,$query);
$row = mysqli_fetch_assoc($result);

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
    <title>Update Info</title>
</head>
<body>
<div id="header">
<h1>Attendence Management System</h1>
</div>

<div id="content" >
<p>Update User Information (<?php echo $row["Name"];  ?>)</p>
<p>Select Information to update</p>

<form method="post" action="updatemem.php">
<select name="choise">
    <option value="Name">Name</option>    
    <option value="Email">Email</option>    
    <option value="Age">Age</option>    
    <option value="Password">Password</option>    
    <option value="Gender">Gender</option>    
    <option value="Phone">Phone Number</option>    
    <option value="Address">Address</option>    
</select><br><br>
Insert New Value : <input type="text" name="editinfo"><br>
<input type="submit">
</form>

</div>

<div id="footer">
<p>Copyrights are reserved  by Nazmul Islam</p> 
</div>

</body>
</html>

<?php
mysqli_close($con);
?>
<!--Author: Mitchell Tracy
Description: This is my personal site for promoting me Also this is site is supported in mobile.--->

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html>
    <head>
        <title>Porfolio</title>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8"/>
     	<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
        <link rel="stylesheet" href="css/style.css" type="text/css" media="screen"/>
     	<link rel="stylesheet" href="../nivo-slider.css" type="text/css" media="screen" />
    </head>

    <body>
	<!--java script for mouse over and out -->
	<div id="Logo"><a href="/~200224083/Portfolio/Portfolio.html"><img onmouseover="this.src='http://webdesign4.georgianc.on.ca/~200224083/Portfolio/MitchLogo11.png'" onmouseout="this.src='http://webdesign4.georgianc.on.ca/~200224083/Portfolio/MitchLogo.png'" src="http://webdesign4.georgianc.on.ca/~200224083/Portfolio/MitchLogo11.png" border="0" alt="" /></a></div>
		<!-- end java script for mouse over and out -->
<div id="wrap"> 
<!-- my nav bar -->
<!-- my nav bar -->
   <ul id="nav">
      <li><a href="/~200224083/Portfolio/Portfolio.html">Home</a></li>
      <li><a href="/~200224083/Portfolio/AboutMe.html">About Me</a></li>
      <li><a href="/~200224083/Portfolio/Projects.html">Projects</a></li>
      <li><a href="/~200224083/Portfolio/Services.html">Services</a></li>
	  <li><a href="https://github.com/mitchtracy11">GitHub</a></li>
      <li><a href="/~200224083/Portfolio/ContactMe.html">Contact Me</a></li>
	  <li><a href="/~200224083/Portfolio/admin.php">Admin</a></li>
   </ul></div>
  <!--end my nav bar --></br></br></br></br></br></br></br></br></br></br>

<?php
  require_once('connectvars.php');

  if (isset($_POST['submit'])) {
    // Connect to the database
    $dbc = mysqli_connect(DB_HOST, DB_USER, DB_PASSWORD, DB_NAME);


    //$name = mysqli_real_escape_string($dbc, trim($_POST['name']));
    $name = $_POST['name'];
    $number  = $_POST['number'];
    $address  = $_POST['address'];
    

    if (!empty($name)&& !empty($number) && !empty($address)) {
      
            $query = "INSERT INTO Contacts (name, number, address) VALUES ('$name', '$number', '$address',0)";
            //echo $query;
            mysqli_query($dbc, $query);

            // Confirm success with the user
            echo '<p>Thanks for adding your contact information. The admin will review you submition</p>';
            echo '<p><strong>Name:</strong> ' . $name . '<br />';
            echo '<strong>Phone Number:</strong> ' . $number . '<br />';
            echo '<strong>Address:</strong> ' . $address . '</p>';
            echo '<p><a href="/~200224083/Portfolio/Portfolio.html">&lt;&lt; Back to Main Page</a></p>';

            // Clear the score data to clear the form
            $name = "";
            $number = "";
	    $address = "";
            

            mysqli_close($dbc);
          }
          else {
            echo '<p class="error">Sorry, there was a problem.</p>';
          }
        }
      
    
    else {
      echo '<p class="error">Please enter all of the information </p>';
    }
  
?>

  <hr />
  <form enctype="multipart/form-data" method="post" action="<?php echo $_SERVER['PHP_SELF']; ?>">
    <label for="name">Name:</label>
    <input type="text" id="name" name="name" value="<?php if (!empty($name)) echo $name; ?>" /><br />
    <label for="number">Phone Number:</label>
    <input type="text" id="number" name="number" value="<?php if (!empty($number)) echo $number; ?>" /><br />
        <label for="number">Address:</label>
    <input type="text" id="address" name="address" value="<?php if (!empty($address)) echo $address; ?>" /><br />
    <hr />
    <input type="submit" value="Add" name="submit" />
  </form>
</body> 
</html>

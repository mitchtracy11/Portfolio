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
   <ul id="nav">
      <li><a href="/~200224083/Portfolio/Portfolio.html">Home</a></li>
      <li><a href="/~200224083/Portfolio/AboutMe.html">About Me</a></li>
      <li><a href="/~200224083/Portfolio/Projects.html">Projects</a></li>
      <li><a href="/~200224083/Portfolio/Services.html">Services</a></li>
	  <li><a href="https://github.com/mitchtracy11">GitHub</a></li>
      <li><a href="/~200224083/Portfolio/ContactMe.html">Contact Me</a></li>
	  <li><a href="/~200224083/Portfolio/admin.php">Admin</a></li>
   </ul></div>
  <!--end my nav bar --></br></br></br></br></br></br></br></br></br></br></br></br>
  <h2>Admin</h2><br/><a href="login.php">Login admin</a> Or add a <a href="addContact.php">contact</a>
  <hr />

<?php
  
  if (isset($_COOKIE['username']))
  {
    require_once('connectvars.php');

    // Connect to the database 
    $dbc = mysqli_connect(DB_HOST, DB_USER, DB_PASSWORD, DB_NAME);

    // Retrieve the score data from MySQL
    $query = "SELECT * FROM Contact ORDER BY name";
    $data = mysqli_query($dbc, $query);

    // Loop through the array of score data, formatting it as HTML 
	echo '<a href="logout.php">Logout of Admin Account</a>';
    echo '<table>';
    echo '<tr><th>Name</th><th>Phone Number</th><th>Address</th></tr>';
    while ($row = mysqli_fetch_array($data)) { 
      // Display the score data
      echo '<tr class="info"><td><strong>' . $row['name'] . '</strong></td>';
      echo '<td>' . $row['number'] . '</td>';
      echo '<td>' . $row['address'] . '</td>';
      echo '<td><a href="removecontact.php?name=' . $row['name'] . '&amp;number=' . $row['number'] .
        '&amp;address=' . $row['address'] . '">Remove</a>';
      if ($row['approved'] == '0') {
        echo ' / <a href="approvecontact.php?name=' . $row['name'] . '&amp;number=' . $row['number'] . '&amp;address=' .
          $row['address'] . '">Approve</a>';
      }
      echo '</td></tr>';
    }
    echo '</table>';

    mysqli_close($dbc);
	}
	else
	{
	echo "You do not currently have the correct authentication to access this page. Please try again.";
	};
?>

</body> 
</html>

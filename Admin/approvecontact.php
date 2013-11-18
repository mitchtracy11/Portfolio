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
   </ul></div>
  <!--end my nav bar --></br></br></br></br></br>

<?php
  require_once('appvars.php');
  require_once('connectvars.php');

  if (isset($_GET['name']) && isset($_GET['number']) && isset($_GET['address'])) {
    // Grab the data from the GET
    $name = $_GET['name'];
    $number = $_GET['number'];
    $address = $_GET['address'];
  }
  else if (isset($_POST['name']) && isset($_POST['number']) && isset($_POST['address'])) {
    // Grab the data from the POST
    $name = $_POST['name'];
    $number = $_POST['number'];
    $address = $_POST['address'];
  }

  if (isset($_POST['submit'])) {
    if ($_POST['confirm'] == 'Yes') {
      // Connect to the database
      $dbc = mysqli_connect(DB_HOST, DB_USER, DB_PASSWORD, DB_NAME); 
      mysqli_query($dbc, $query);
      mysqli_close($dbc);

    }
  }
  else if (isset($id) && isset($name) && isset($date) && isset($location)) {
    echo '<p>Are you sure you want to approve the following pic?</p>';
    echo '<p><strong>Name: </strong>' . $name . '<br /><strong>Phone Number: </strong>' . $number .
      '<br /><strong>Address: </strong>' . $address . '</p>';
    echo '<form method="post" action="approvecontact.php">';
    echo '<input type="submit" value="Submit" name="submit" />';
    echo '<input type="hidden" name="name" value="' . $name . '" />';
    echo '<input type="hidden" name="number" value="' . $number . '" />';
    echo '<input type="hidden" name="address" value="' . $address . '" />';
    echo '</form>';
  }

  echo '<p><a href="admin.php">&lt;&lt; Back to admin page</a></p>';
?>

</body> 
</html>

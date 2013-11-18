 <!--Author: Mitchell Tracy
Description: This is my personal site for promoting me Also this is site is supported in mobile.--->

 <link rel="stylesheet" type="text/css" href="style.css" />
<?php
  session_start();

  // If the session vars aren't set, try to set them with a cookie
  if (!isset($_SESSION['username'])) {
    if (isset($_COOKIE['username'])) {
      $_SESSION['username'] = $_COOKIE['username'];
    }
  }
?>

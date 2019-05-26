<?php
	if (isset($_POST['hitung']))
	{
		$a=$_POST['watt'];
		$b=$_POST['jumlah_jam'];
		$c=$_POST['tarif_perkwh'];
		
$client = new SoapClient("http://localhost:25808/ServiceDayaListrik/Service.asmx?wsdl");
		$params=array();
		$params['watt'] = $a;
		$params['jumlah_jam'] = $b;
		$params['tarif_perkwh'] = $c;
		
		{
		$result = $client->Pemakaian_PerJam($params);
		echo "
<html>
<head>
  
      <link rel='stylesheet' href='css/style.css'>

  
</head>

<body>
  <hgroup>
  <h3>Electricity Bill Calculator</h3>
  
</hgroup>
<form method='post' action='index.php'>
  <td align='center'>";
echo "<h2 class='judul'><align='center'>Biaya Pemakaian PerJam adalah :<br><b> $result->Pemakaian_PerJamResult</b> Rupiah</td><br></h2>";
  echo "<button name='hitung' type='submit' class='button buttonBlue'>Kembali
    <div class='ripples buttonRipples'><span class='ripplesCircle'></span></div>
  </button>
</form>";
echo"
  <script src='http://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>

    <script src='js/index.js'></script>

</body>
</html>";

	} }
?>
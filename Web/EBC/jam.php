<!DOCTYPE html>
<html >
<head>
  <meta charset="UTF-8">
  <title>Material Design Login Form</title>
  
  
  
      <link rel="stylesheet" href="css/style.css">

  
</head>

<body>
  <hgroup>
  <h3>Electricity Bill Calculator</h3>
  <h1>MENGHITUNG BIAYA LISTRIK PERANGKAT ELEKTRONIK</h1>
  <h1>PEMAKAIAN PERJAM</h1>
  
</hgroup>
<form method="post" action="jamproses.php">
  <div class="group">
    <input type="text" name="watt" class="bil" autocomplete="off"><span class="highlight"></span><span class="bar"></span>
    <label>Masukan Watt</label>
  </div>
    <div class="group">
    <input type="text" name="jumlah_jam" class="bil" autocomplete="off"><span class="highlight"></span><span class="bar"></span>
    <label>Masukan Jumlah Jam</label>
  </div>
    <div class="group">
    <input type="text" name="tarif_perkwh" class="bil" autocomplete="off"><span class="highlight"></span><span class="bar"></span>
    <label>Masukan Tarif/KWH Rp</label>
  </div>
  <button name="hitung" type="submit" class="button buttonBlue">Hitung
    <div class="ripples buttonRipples"><span class="ripplesCircle"></span></div>
  </button>
</form>
  <script src='http://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>

    <script src="js/index.js"></script>

</body>
</html>

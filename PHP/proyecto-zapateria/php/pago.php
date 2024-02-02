<?php
   //$conexion = mysqli_connect("localhost","root","vegeta2412","proyec_zapateria");
   include("conexion.php");
   include("carrito.php");
   include("cabecera.php");

   if($_POST){
        $total = 0;
        $SID = session_id();
        foreach($_SESSION['CARRITO'] as $indice=>$calzado){
            $total = $total + ($calzado['PRECIO']*$calzado['CANTIDAD']);
        }
   }
?>

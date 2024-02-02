<?php
    try{
		$conexion = mysqli_connect("localhost","root","123456","zapateria");
		//echo "<script>alert('Conectado...')</script>";
	}catch(Exception $e){
		//echo "<script>alert('Error, no se pudo conectar a la base de datos...')</script>";
	}
?>
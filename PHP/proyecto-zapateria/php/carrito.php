<?php
    #Variables de sesión
    session_start();
    
    $mensaje = "";
    #Desencriptación de datos

    if(isset($_POST['btnAccion'])){
        switch($_POST['btnAccion']){
            case 'Agregar':
                if(is_numeric(openssl_decrypt($_POST['idCalzado'], 'AES-128-ECB', 'parangaricutirimicuaro'))){
                    $id = openssl_decrypt($_POST['idCalzado'], 'AES-128-ECB', 'parangaricutirimicuaro');
                } else{
                    $mensaje .= "UPPS... algo pasa con el ID "."<br/>";
                }
                if(is_string(openssl_decrypt($_POST['tipo'], 'AES-128-ECB', 'parangaricutirimicuaro'))){
                    $tipo = openssl_decrypt($_POST['tipo'], 'AES-128-ECB', 'parangaricutirimicuaro');
                } else{
                    $mensaje .= "UPPS... algo pasa con el tipo "."<br/>";
                }
                if(is_string(openssl_decrypt($_POST['genero'], 'AES-128-ECB', 'parangaricutirimicuaro'))){
                    $genero =  openssl_decrypt($_POST['genero'], 'AES-128-ECB', 'parangaricutirimicuaro');
                } else{
                    $mensaje .= "UPPS... algo pasa con el genero "."<br/>";
                }
                if(is_string(openssl_decrypt($_POST['nombre'], 'AES-128-ECB', 'parangaricutirimicuaro'))){
                    $nombre = openssl_decrypt($_POST['nombre'], 'AES-128-ECB', 'parangaricutirimicuaro');
                } else{
                    $mensaje .= "UPPS... algo pasa con el nombre "."<br/>";
                }
                if(is_numeric(openssl_decrypt($_POST['precio'], 'AES-128-ECB', 'parangaricutirimicuaro'))){
                    $precio = openssl_decrypt($_POST['precio'], 'AES-128-ECB', 'parangaricutirimicuaro');
                } else{
                    $mensaje .= "UPPS... algo pasa con el precio "."<br/>";
                }
                if(is_numeric(openssl_decrypt($_POST['cantidad'], 'AES-128-ECB', 'parangaricutirimicuaro'))){
                    $cantidad = openssl_decrypt($_POST['cantidad'], 'AES-128-ECB', 'parangaricutirimicuaro');
                } else{
                    $mensaje .= "UPPS... algo pasa con la cantidad "."<br/>";
                }

                #Agregar un nuevo producto/calzado al carrito
                if(!isset($_SESSION['CARRITO'])){
                    #Si el carrito está vacío
                    $calzado = array('ID'=>$id, 'TIPO'=>$tipo, 'GENERO'=>$genero, 'NOMBRE'=>$nombre, 'PRECIO'=>$precio, 'CANTIDAD'=>$cantidad);
                    $_SESSION['CARRITO'][0] = $calzado;
                } else{
                    #Si el carrito ya tiene productos/calzado en él
                    $numCalzado = count($_SESSION['CARRITO']);
                    $calzado = array('ID'=>$id, 'TIPO'=>$tipo, 'GENERO'=>$genero, 'NOMBRE'=>$nombre, 'PRECIO'=>$precio, 'CANTIDAD'=>$cantidad);
                    $_SESSION['CARRITO'][$numCalzado] = $calzado;
                }
                //$mensaje = "Producto agregado al carrito.";
            break;
            case 'Eliminar':
                if(is_numeric(openssl_decrypt($_POST['idCalzado'], 'AES-128-ECB', 'parangaricutirimicuaro'))){
                    $ID = openssl_decrypt($_POST['idCalzado'], 'AES-128-ECB', 'parangaricutirimicuaro');
                    foreach($_SESSION['CARRITO'] as $indice=>$calzado){
                        if($calzado['ID'] == $ID){
                            unset($_SESSION['CARRITO'][$indice]);
                            echo "<script>alert('Elemento borrado...');</script>";
                            break;
                        }
                    }
                } else{
                    $mensaje .= "UPPS... algo pasa con el ID "."<br/>";
                }
            break;
        }

    }
?>
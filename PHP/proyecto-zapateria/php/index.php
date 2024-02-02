<?php
   //$conexion = mysqli_connect("localhost","root","vegeta2412","proyec_zapateria");
   include("conexion.php");
   include("carrito.php");
   include("cabecera.php");
?>

    <div class="container">
        <br>
        <?php if($mensaje != "") { ?>
            <div class="alert alert-success" role="alert">
                <?php  echo $mensaje; ?>
                <a href="pedido.php"><span class="badge bg-success">Ver carrito</span></a>
            </div>
        <?php } ?>

        <div class="row">
            <?php
                $consulta = "SELECT * FROM productos";
                $listaCalzado = mysqli_query($conexion, $consulta);
                foreach($listaCalzado as $calzado){
                    
            ?>
            <div class="card m-3" style="max-width: 500px;">
                <div class="row">
                    <div class="col-md-7">
                        <img src="<?php echo $calzado['Imagen']; ?>" class="img-fluid rounded-start img-card" alt="..."
                        tabindex="0" data-bs-toggle="popover" data-bs-trigger="hover focus" title="<?php echo $calzado['Nombre']; ?>" data-bs-content="<?php echo $calzado['Descripcion']; ?>">
                    </div>
                    <div class="col-md-5">
                        <div class="card-body">
                            <span><?php echo $calzado['Nombre']; ?></span>
                            <h5 class="card-title">$<?php echo $calzado['Precio']; ?></h5>
                            <p class="card-text">Descripción</p>
                            <form action="" method="post">
                                <!-- Dato/Metodo de encriptación/Lllave -->
                                <input type="hidden" name="idCalzado" id="idCalzado" value="<?php echo  openssl_encrypt($calzado['IDProducto'], "AES-128-ECB", "parangaricutirimicuaro"); ?>">
                                <input type="hidden" name="tipo" id="tipo"  value="<?php echo openssl_encrypt($calzado['Tipo'], "AES-128-ECB", "parangaricutirimicuaro"); ?>">
                                <input type="hidden" name="genero" id="genero"  value="<?php echo openssl_encrypt($calzado['genero'], "AES-128-ECB", "parangaricutirimicuaro"); ?>">
                                <input type="hidden" name="nombre" id="nombre"  value="<?php echo openssl_encrypt($calzado['Nombre'], "AES-128-ECB", "parangaricutirimicuaro"); ?>">
                                <input type="hidden" name="precio" id="precio"  value="<?php echo openssl_encrypt($calzado['Precio'], "AES-128-ECB", "parangaricutirimicuaro"); ?>">
                                <input type="hidden" name="cantidad" id="cantidad"  value="<?php echo openssl_encrypt(1, "AES-128-ECB", "parangaricutirimicuaro"); ?>">
                                <button class="btn btn-primary" name="btnAccion" value="Agregar" type="submit">Agregar al carrito</button>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
            <?php
                }
            ?>
        </div>
    </div>

    <footer>
        <div class="col-12 text-center bg-footer">
            ZAPATERIA CalzaPiel 2021
        </div>
    </footer>

    <script src="../../Bootstrap/js/jquery.js"></script>
    <script src="../../Bootstrap/js/bootstrap.min.js"></script>
    <script src="../../Bootstrap/js/bootstrap.bundle.min.js"></script>
    <script src="https://kit.fontawesome.com/2c36e9b7b1.js" crossorigin="anonymous"></script>
    <script src="../js/index.js"></script>
</body>
</html>
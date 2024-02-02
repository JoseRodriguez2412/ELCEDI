<?php
    include("carrito.php");
    include("cabecera.php");
?>

    <br>
    <div class="container">
        <div class="row">
            <h3>Mi carrito</h3>
            <?php if(!empty($_SESSION['CARRITO'])) { 
                //print_r($_SESSION['CARRITO']);   
            ?>
                <div class="col-12">
                    <table class="table table-light table-bordered">
                        <tbody>
                            <tr>
                                <th width="15%" class="text-center">Tipo</th>
                                <th width="15%" class="text-center">Genero</th>
                                <th width="30%">Descripcion</th>
                                <th width="10%" class="text-center">Cantidad</th>
                                <th width="12%" class="text-center">Precio</th>
                                <th width="13%" class="text-center">SubTotal</th>
                                <th width="5%" class="text-center">--</th>
                                
                            </tr>
                            <?php $total = 0;
                                foreach($_SESSION['CARRITO'] as $indice=>$calzado){ ?>
                                <tr>
                                    <td width="15%" class="text-center"><?php echo $calzado['TIPO']; ?></td>
                                    <td width="15%" class="text-center"><?php echo $calzado['GENERO']; ?></td>
                                    <td width="30%"><?php echo $calzado['NOMBRE']; ?></td>
                                    <td width="10%" class="text-center"><?php echo $calzado['CANTIDAD']; ?></td>
                                    <td width="12%" class="text-center">$<?php echo $calzado['PRECIO']; ?></td>
                                    <td width="13%" class="text-center">$<?php echo number_format($calzado['PRECIO']*$calzado['CANTIDAD'],2); ?></td>
                                    <td width="5%" class="text-center">
                                        <form action="" method="post">
                                        <input type="hidden" name="idCalzado" id="idCalzado" value="<?php echo  openssl_encrypt($calzado['ID'], "AES-128-ECB", "parangaricutirimicuaro"); ?>">
                                            <button class="btn btn-danger" name="btnAccion" value="Eliminar" type="submit">Eliminar</button>
                                        </form>
                                    </td>
                                </tr>
                                <?php $total = $total + ($calzado['PRECIO']*$calzado['CANTIDAD']);
                                    } ?>
                            <tr>
                                <td colspan="5" align="right"><h3>Total</h3></td>
                                <td align="right"><h3>$<?php echo number_format($total,2); ?></h3></td>
                                <td></td>
                            </tr>

                            <tr>
                                <td colspan="7">
                                    <form action="pago.php" method="post">
                                        <div class="alert alert-success" role="alert">
                                            <div class="form-group">
                                                <label for="my-input">Correo electrónico:</label>
                                                <input id="correo" class="form-control" type="email" name="correo" placeholder="Ingresa tu correo electrónico" required>
                                            </div>
                                            <small id="emailHelp" class="form-text text-muted">
                                                Te mantendremos al día con la entrega de tu pedido mediante este correo.
                                            </small>
                                        </div>
                                        <div class="d-grid">
                                            <button class="btn btn-primary" type="submit" name="btnAccion" value="Pagar">Realizar Pago</button>
                                        </div>
                                    </form>
                                    
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            <?php } else{ ?>
                <div class="alert alert-info" role="alert">
                    No hay productos en el carrito...
                </div>
            <?php } ?>
        </div>
    </div>

    <footer>
        <div class="col-12 text-center bg-footer">
            ZAPATERIA CalzaPiel 2021
        </div>
    </footer>

    <script src="../../Bootstrap/js/jquery.js"></script>
    <script src="../../Bootstrap/js/bootstrap.min.js"></script>
</body>
</html>
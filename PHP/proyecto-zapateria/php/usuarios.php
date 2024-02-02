<?php
if(isset($_POST['registrar'])){
    if(strlen($_POST['nombre']) >= 1){
        if(strlen($_POST['apellidos']) >= 1){
            if(strlen($_POST['direccion']) >= 1){
                if(strlen($_POST['correo']) >= 1){
                    if(strlen($_POST['password']) >= 1 && strlen($_POST['password']) <= 10 && $_POST['password'] == $_POST['confirmar']){
                        if($_POST['terminos'] == "on"){
                            $nombre = trim($_POST["nombre"]);
                            $apellidos = trim($_POST["apellidos"]);
                            $correo = trim($_POST["correo"]);
                            $password = $_POST["password"];
                            $direccion = $_POST['direccion'];
        
                            $consulta = "INSERT INTO usuarios(NombreUsuario, Apellidos, Correo, Direccion, Pasword) VALUES('$nombre','$apellidos','$correo','$direccion','$password')";
                            $resultado = mysqli_query($conexion, $consulta);
                            if($resultado){
                                ?>
                                <script>
                                    alert("¡Registro exitoso!");
                                </script>
                                <?php
                            }else{
                                ?>
                                <script>
                                    alert("¡Ups ha ocurrido un error!");
                                </script>
                                <?php
                            }
                        } else {
                            ?>
                                <script>
                                    alert("¡No has aceptado los términos y condiciones!");
                                </script>
                                <?php
                        }
                    }else{
                        ?>
                        <script>
                            alert("¡Verifica tu contraseña!");
                        </script>
                        <?php
                    }
                }else{
                    ?>
                    <script>
                        alert("¡Por favor completa los campos!");
                    </script>
                    <?php
                }
            }else{
                ?>
                <script>
                    alert("¡Por favor completa los campos!");
                </script>
                <?php
            }
            
        }else{
            ?>
            <script>
                alert("¡Por favor completa los campos!");
            </script>
            <?php
        }
    }else{
        ?>
        <script>
            alert("¡Por favor completa los campos!");
        </script>
        <?php
    }
}
?>
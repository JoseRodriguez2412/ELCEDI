<?php

    if(isset($_POST['ingresar'])){
        foreach($usuarios as $usuario){
            if($_POST['correo'] == $usuario['Correo']){
                if($_POST['password'] == $usuario['Pasword']){
                    ?>
                    <script>
                        alert("Se ha iniciado sesión.");
                    </script>
                    <?php
                }else{
                    ?>
                    <script>
                        alert("El correo y la contraseña no coiciden.");
                    </script>
                    <?php
                }
            } else {
                ?>
                <script>
                    alert("Usuario no encontrado");
                </script>
                <?php
            }
        }
    }
?>
<?php
   include("conexion.php");
   include("cabecera.php");
?>    

    <!-- Formulario Registrar usuario -->
    <div class="container w-65 mt-5 mb-5 border-color rounded shadow">
        <div class="row align-items-stretch">
            <div class="col image-bg-register d-none d-lg-block col-md-5 col-lg-5 col-xl-6 rounded">

            </div>
            <div class="col bg-white p-5 rounded-end">
                <div class="text-end">
                    <img src="../imagenes/logo.png" alt="">
                </div>
                <h2 class="font-monospace fw-bold text-center py-3">Registrate</h2>

                <!-- REGISTRO -->

                <form action="<?php echo htmlspecialchars($_SERVER['PHP_SELF']); ?>" method = "post">
                    <div class="mb-3">
                        <label for="nombre" class="form-label">Nombre</label>
                        <input type="text" class="form-control" name="nombre" id="nombre" placeholder="Nombre completo">
                    </div>
                    <div class="mb-3">
                        <label for="apellidos" class="form-label">Apellidos</label>
                        <input type="text" class="form-control" name="apellidos" id="apellidos" placeholder="Apellidos">
                    </div>
                    <div class="mb-3">
                        <label for="direccion" class="form-label">Dirección</label>
                        <input type="text" class="form-control" name="direccion" id="direccion" placeholder="Direccion">
                    </div>
                    <div class="mb-3">
                        <label for="correo" class="form-label">Correo electrónico</label>
                        <input type="email" class="form-control" name="correo" id="correo" placeholder="Correo electrónico">
                    </div>
                    <div class="mb-3">
                        <label for="password" class="form-label">Contraseña</label>
                        <input type="password" class="form-control" name="password" id="password" placeholder="Contraseña">
                    </div>
                    <div class="mb-3">
                        <label for="confirmar" class="form-label">Confirma tu contraseña</label>
                        <input type="password" class="form-control" name="confirmar" id="password" placeholder="Contraseña">
                    </div>
                    <div class="mb-3 form-check">
                        <input type="checkbox" name="terminos" class="form-check-input" id="terminos">
                        <label for="terminos" class="form-check-label">Acepto términos y condiciones.</label>
                    </div>
                    <div class="d-grid">
                        <button type="submit" class="btn btn-outline-primary" name="registrar">Registrar</button>
                    </div>
                    <div class="my-3 text-center">
                        <span>¿Ya tienes cuenta? <a href="login.php" class="text-decoration-none">Iniciar sesión</a></span><br>
                    </div>
                </form>
            </div>
        </div>
    </div>

    <footer>
        <div class="col-12 text-center bg-footer">
            ZAPATERIA CalzaPiel 2021
        </div>
    </footer>

    <script src="https://kit.fontawesome.com/2c36e9b7b1.js" crossorigin="anonymous"></script>
    <script src="../../Bootstrap/js/bootstrap.bundle.min.js"></script>
    <script src="../js/login.js"></script>
</body>
</html>

<?php include("usuarios.php"); ?>
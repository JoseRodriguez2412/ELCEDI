<?php
    include("conexion.php");
    $seleccion = "SELECT Correo, Pasword FROM usuarios";
    $usuarios = mysqli_query($conexion, $seleccion);
    include("cabecera.php");
?>  

    <div class="container w-65 mt-5 mb-5 border-color rounded shadow">
        <div class="row align-items-stretch">
            <div class="col image-bg-login d-none d-lg-block col-md-5 col-lg-5 col-xl-6 rounded">

            </div>
            <div class="col bg-white p-5 rounded-end">
                <div class="text-end">
                    <img src="../imagenes/logo.png" alt="">
                </div>
                <h2 class="fw-bold text-center py-3">Iniciar Sesión</h2>

                <!-- LOGIN -->

                <form action="<?php echo htmlspecialchars($_SERVER['PHP_SELF']); ?>" method = "post">
                    <div class="mb-3">
                        <label for="correo" class="form-label">Correo electrónico</label>
                        <input type="email" class="form-control" name="correo" id="correo" placeholder="Correo electrónico">
                    </div>
                    <div class="mb-3">
                        <label for="password" class="form-label">Contraseña</label>
                        <input type="password" class="form-control" name="password" id="password" placeholder="Contraseña">
                    </div>
                    <!--<div class="mb-3 form-check">
                        <input type="checkbox" name="conectado" class="form-check-input" id="conectado">
                        <label for="conectado" class="form-check-label">Mantener sesión abierta.</label>
                    </div>-->

                    <div class="d-grid">
                        <button type="submit" class="btn btn-outline-primary" name="ingresar">Iniciar Sesión</button>
                    </div>
                    <div class="my-3 text-center">
                        <span>¿No tienes cuenta? <a href="registro.php" class="text-decoration-none">Registrate</a></span><br>
                        <!-- Link trigger modal -->
                        <span>¿Olvidaste tu contraseña?<a class="text-decoration-none" href="#" data-bs-toggle="modal" data-bs-target="#exampleModal">Restablecer contraseña</a></span>
                    </div>
                    
                    <!-- Modal -->
                    <div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
                        <div class="modal-dialog">
                        <div class="modal-content">
                            <div class="modal-header">
                            <h5 class="modal-title" id="exampleModalLabel">Restablecer contraseña</h5>
                            <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                            </div>
                            <div class="modal-body">
                                <form>
                                  <div class="mb-3">
                                    <label for="recipient-name" class="col-form-label">Ingresa tu dirección de correo electrónico y te enviaremos instrucciones para restablecer la contraseña:</label>
                                    <input type="text" placeholder="Correo electrónico" class="form-control" id="recipient-name">
                                  </div>
                                </form>
                              </div>
                            <div class="modal-footer">
                            <button type="button" class="btn btn-danger" data-bs-dismiss="modal">Cancelar</button>
                            <button type="button" class="btn btn-primary">Enviar</button>
                            </div>
                        </div>
                        </div>
                    </div>
                </form>

                <!-- LOGIN CON REDES SOCIALES -->
                <div class="container w-100 my-5">
                    <div class="row text-center">
                        <div class="col-12">Iniciar Sesión con:</div>
                    </div>
                    <div class="row mt-3">
                        <div class="col">
                            <a href="https://es-la.facebook.com/">
                                <button class="btn btn-outline-primary w-100 my-1">
                                    <div class="row align-items-center">
                                        <div class="col-2 d-none d-md-block">
                                            <i class="fab fa-facebook icons-redes"></i>
                                        </div>
                                        <div class="col-12 col-md-10 text-center">
                                            Facebook
                                        </div>
                                    </div>
                                </button>
                            </a>
                        </div>
                        <div class="col">
                            <a href="https://accounts.google.com/signin/v2/identifier?continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&service=mail&sacu=1&rip=1&flowName=GlifWebSignIn&flowEntry=ServiceLogin">
                                <button class="btn btn-outline-warning w-100 my-1">
                                    <div class="row align-items-center">
                                        <div class="col-2 d-none d-md-block">
                                            <i class="fab fa-google icons-redes"></i>
                                        </div>
                                        <div class="col-12 col-md-10 text-center fs-6">
                                            Google
                                        </div>
                                    </div>
                                </button>
                            </a>
                        </div>
                    </div>
                </div>

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
    <!--<script src="Bootstrap/js/jquery.js"></script>
    <script src="Bootstrap/js/bootstrap.min.js"></script>-->
    <script src="../js/login.js"></script>
</body>
</html>

<?php include("validacion.php"); ?>
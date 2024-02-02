<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Zapateria CalzaPiel</title>
    <link rel="stylesheet" href="../css/normalize.css">
    <link rel="stylesheet" href="../../Bootstrap/css/bootstrap.min.css">
    <link href="https://fonts.googleapis.com/css2?family=Roboto:wght@400;700&display=swap" rel="stylesheet"> 
    <link rel="stylesheet" href="../css/index.css">
    <link rel="stylesheet" href="../css/login.css">

</head>
<body>
<nav class="navbar navbar-expand-lg nav-propieties fixed-top">
        <a class="navbar-brand" href="index_carrito.php" style="color: white;">CalzaPiel</a>
        <button class="navbar-toggler" data-target="#my-nav" data-toggle="collapse" aria-controls="my-nav" aria-expanded="true" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div id="my-nav" class="collapse navbar-collapse">
            <ul class="navbar-nav mr-auto">
                <li class="nav-item active">
                    <a class="nav-link font-link" href="index.php">Inicio</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link font-link" href="login.php">Iniciar sesión</a>
                </li>
                <li class="nav-item dropdown">
                    <a class="nav-link font-link dropdown-toggle" href="#" id="navbarScrollingDropdown" role="button" data-bs-toggle="dropdown" aria-expanded="false">
                        Categorías
                    </a>
                    <ul class="dropdown-menu" aria-labelledby="navbarScrollingDropdown">
                        <li><a class="dropdown-item" href="#">Hombre</a></li>
                        <li><a class="dropdown-item" href="#">Mujer</a></li>
                        <li><a class="dropdown-item" href="#">Tenis</a></li>
                        <li><a class="dropdown-item" href="#">Zapatos</a></li>
                        <li><a class="dropdown-item" href="#">Zapatillas</a></li>
                        <li><a class="dropdown-item" href="#">Botas/Botines</a></li>
                    </ul>
                </li>
                <li class="nav-item">
                    <a class="nav-link font-link" href="pedido.php">
                        <div class="position-relative">
                            Carrito 
                            <span class="position-absolute top-0 start-100 translate-middle badge rounded-pill bg-danger">
                                <?php echo(empty($_SESSION['CARRITO']))?0 : count($_SESSION['CARRITO']); ?>
                            </span>
                        </div>
                    </a>
                </li>
            </ul>
        </div>
    </nav>
    <br/>
    <br/>
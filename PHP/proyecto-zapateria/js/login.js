const btnMenu = document.querySelector(".btn__menu");
const navMenu = document.querySelector(".nav__menu");

//Añadir evento click al botón Menú
btnMenu.addEventListener("click", () => {
    navMenu.classList.toggle("menu__visible");

    //Agregar texto discernible al botón (para usuarios con discapacidad)
    if (navMenu.classList.contains("menu__visible")) {
        btnMenu.setAttribute("aria-label", "Cerrar menú");
    }else {
        btnMenu.setAttribute("aria-label", "Abrir menú");
    }
})
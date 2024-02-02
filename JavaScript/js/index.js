//Definir matrices
let matriz1 = [[11,"Java"], [5,"Python"], [3, "Ruby"], [9, "Go"], [10, "Php"]];
let matriz2 = [[6,"Kotlin"], [3,"Python"], [2, "Ruby"], [1, "Go"], [1, "Haskell"]];

//Actualizar y ordenar matriz
function update_matriz(){
    //Combinar ambas matrices
    let combined_matriz = matriz1.concat(matriz2);

    //Crear objeto para almacenar las cantidades por lenguaje
    let number_per_language = {};

    //Iterar sobre la matriz combinada
    combined_matriz.forEach(([quantity, language]) => {
        //Si el lenguaje ya existe en el objeto, sumar la cantidad
        if(number_per_language[language]){
            number_per_language[language] += quantity;
        }
        else{
            //Si no existe, agregar el lenguaje al objeto junto con la cantidad
            number_per_language[language] = quantity;
        }
    });

    //Convertir el objeto de vuelta a matriz
    let updated_matrix = Object.entries(number_per_language);

    //Ordenar la matriz por la cantidad
    updated_matrix.sort((a,b) => a[1] - b[1]);

    //Retornar la matriz actualizada en consola
    return updated_matrix;

}

//Mostrar elementos de la matriz en la página web
function draw_articles(updated_matriz){
    //Obtener el contenedor
    let section_courses = document.getElementById("cursos-container");

    //Iterar sobre la matriz actualizada y agregar elementos <article> al contenedor
    updated_matriz.forEach(([quantity, language]) => {
        let article = document.createElement("article");
        let heading = document.createElement("h2");
        heading.textContent = `${language} cursos de ${quantity}`;
        article.appendChild(heading);
        section_courses.appendChild(article);
    });
}

//Llamar a la función para crear los article de la section que mostrarán los cursos de la matriz actualizada
draw_articles(update_matriz());

//Lamar a función para mostrar en consola la matriz actualizada
console.log(update_matriz());

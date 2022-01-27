//Repo
var contenu = document.querySelector(".contenu");
const requ = new XMLHttpRequest();
const requ2 = new XMLHttpRequest();

// /**** GET */
// requ.open('GET', 'https://localhost:44398/api/Departements', true);
// requ.send();

// /**** GET */    
// requ2.open('GET', 'https://localhost:44398/api/Villes', true);
// requ2.send();

// /**** GET by ID  */
// requ.open('GET', 'https://localhost:44398/api/Departements/1', true);
// requ.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
// requ.send();

// /**** GET by ID  */
// requ2.open('GET', 'https://localhost:44398/api/Villes/1', true);
// requ2.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
// requ2.send();

// /**** POST */
// requ.open('POST', 'https://localhost:44398/api/Departements', true);
// requ.setRequestHeader("Content-Type", "application/json");
// var args={
//     "idDepartement": 0,
//     "libelle": "nouveau"
// }
// requ.send(JSON.stringify(args));

// /**** POST */
// requ2.open('POST', 'https://localhost:44398/api/Villes', true);
// requ2.setRequestHeader("Content-Type", "application/json");
// var args={
//     "idVille": 0,
//     "nomVille": "toto",
//     "idDepartement": 1
// }
// requ2.send(JSON.stringify(args));

// /**** PUT */
// requ.open('PUT', 'https://localhost:44398/api/Departements/1', true);
// requ.setRequestHeader("Content-Type", "application/json");
// var args={
//     "idDepartement": 1,
//     "libelle": "jzaodjaj"
// }
// requ.send(JSON.stringify(args));

// /**** PUT */
// requ2.open('PUT', 'https://localhost:44398/api/Villes/1', true);
// requ2.setRequestHeader("Content-Type", "application/json");
// var args={
//     "idVille": 1,
//     "nomVille": "toto",
//     "idDepartement": 2,
// }
// requ2.send(JSON.stringify(args));

/**** Delete  */
// requ.open('DELETE', 'https://localhost:44398/api/Departements/16', true);
// requ.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
// requ.send();

/**** Delete  */
// requ2.open('DELETE', 'https://localhost:44398/api/Villes/14', true);
// requ2.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
// requ2.send();


requ.onreadystatechange = function(event) {
    if (this.readyState === XMLHttpRequest.DONE) {
        if (this.status === 200) {
            console.log("Réponse reçue: %s", this.responseText);;
            reponse=JSON.parse(this.responseText);
            contenu.innerHTML += "<br><br>Département :" + this.responseText;
        } else {
            console.log("Status de la réponse: %d (%s)", this.status, this.statusText);
        }
    }
};


requ2.onreadystatechange = function(event) {
    if (this.readyState === XMLHttpRequest.DONE) {
        if (this.status === 200) {
            console.log("Réponse reçue: %s", this.responseText);;
            reponse=JSON.parse(this.responseText);
            contenu.innerHTML += "<br><br>Villes :" + this.responseText;
        } else {
            console.log("Status de la réponse: %d (%s)", this.status, this.statusText);
        }
    }
};

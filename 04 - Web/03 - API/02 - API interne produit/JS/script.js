const requ = new XMLHttpRequest();
let grid = document.getElementById("donnees");

document.querySelector("button").addEventListener("click", recupProduit);
let template = document.querySelector("template");


requ.onreadystatechange = function (event) {
    // XMLHttpRequest.DONE === 4
    if (this.readyState === XMLHttpRequest.DONE) {
        if (this.status === 200) {
            console.log("Réponse reçue: %s", this.responseText);
            reponse = JSON.parse(this.responseText);
            console.log(reponse);
            grid.innerHTML = "";
            reponse.forEach(elm => {
                let ligne = template.content.cloneNode(true);
                ligne.children[0].textContent = elm.libelleProduit;
                ligne.children[1].textContent = elm.prix;
                ligne.children[2].textContent = elm.dateDePeremption;
                grid.appendChild(ligne);
            });
        }
    }
}

function recupProduit()
{
    requ.open('POST', 'index.php?page=APIPrixProduit', true);
    requ.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
    requ.send("prix="+document.querySelector("input").value);
}
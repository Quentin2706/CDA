/**
 * Initialisation / paramètres;
 */

//Taille de la grid
const taille = 5;
const randStart = 2;
var grille = document.getElementById("grid");
var lignes = [];
var cases = [];

var casesVide = document.getElementsByClassName("caseVide");
gridSettings();
/****************************/




// au chargement de la page on définit la taille de la grille en css.
function gridSettings() {
    let stringGrid = "";
    for (let i = 0; i < taille; i++) {
        stringGrid += "2fr ";
        let ligne = [];
        for (let j = 0; j < taille; j++) {
            let caseTab = document.createElement("div");
            caseTab.classList.add("caseVide");
            grille.appendChild(caseTab);
            ligne.push(caseTab);
            cases.push(caseTab);
        }
        lignes.push(ligne);
    }
    grille.style.gridTemplateColumns = stringGrid;
    // on boucle x fois pour avoir des cases pleines de 2 au départ
    // for(let i = 0; i < randStart; i++)
    // {
    //     setRandomCase();
    // }
    
}

function setRandomCase() {
    let rand = 24//Math.floor(Math.random() * (casesVide.length - 2 - 0 + 1)) + 0;
    console.log("1"+casesVide[rand]);
    casesVide[rand].textContent = "2";
    console.log("2"+casesVide[rand]);
    casesVide[rand].classList.add("case");
    console.log("3"+casesVide[rand]);
    casesVide[rand].classList.remove("caseVide");
}



// On check si la partie est terminée ou un coup est jouable.

function Result() {
    var cpt = 0;
    do {
        cpt++;
    } while (cases[cpt] != "");

    if (FlagCombinaison && cpt < cases.lenght - 1) {
        alert("Partie Terminée !");
    }
}
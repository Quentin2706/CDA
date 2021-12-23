var valide = {} // contient false si l'input ne respecte pas la regex, true sinon
var lesInputs = document.getElementsByTagName("input");
for (let i = 0; i < lesInputs.length; i++) {
    if (lesInputs[i].type != "password")
    {
    lesInputs[i].addEventListener("input", function ()
    {
        check(lesInputs[i]);
    });
    }
    // on ajoute un attribut à l'objet valide pour chaque input
    if (lesInputs[i].required)
        valide[lesInputs[i].name] = false;
    else {
        valide[lesInputs[i].name] = true;
    }
}
var boutonValider = document.querySelector("button[type=submit]");


console.log(valide);

function check(input) {
    if (input.value != "") {
        if (input.checkValidity()) {
            input.classList.remove("inputRouge");
            input.classList.add("inputVert");
            valide[input.name] = true;
        } else {
            input.classList.remove("inputVert");
            input.classList.add("inputRouge");
            valide[input.name] = false;
        }
    } else {
        input.classList.remove("inputRouge");
        input.classList.remove("inputVert");
    }
    console.log(valide);
    checkForm();
}

function checkForm() {
    boutonValider.disabled = false;
    // Object.values(valide) : transforme l'objet en tableau
    //.indexOf(false) : cherche la position de false dans le tableau
    // si Object.values(valide).indexOf(false) est different de -1, ca veut dire qu'il a trouvé un false dans le tableau
    // donc l'un des input ne respecte pas la regex
    if (Object.values(valide).indexOf(false) != -1) {
        boutonValider.disabled = true;
    }
}

/* VERIFICATION SPECIALE POUR LE MDP ET LA CONFIRMATION MDP */

var listeErreur = document.getElementById("liste");
var inputMdp = document.getElementById("mdp");

inputMdp.addEventListener("input", AideVerificationMdp);

var regex = inputMdp.getAttribute("pattern").substring(1, inputMdp.getAttribute("pattern").length - 1).split(")");
var idVerif = ["#maj", "#min", "#num", "#special", "#longueur"]


var inputConfirmMdp = document.querySelector("input[name=confirmMdp]");
inputConfirmMdp.addEventListener("input", function() {
    checkConfirmMdp(inputConfirmMdp);
});




for (let i = 0; i < regex.length; i++) {
    if (regex[i].indexOf("(") != -1) {
        regex[i] = RegExp(regex[i] += ")");
    } else {
        regex[i] = RegExp(regex[i]);
    }
}

/**
 * Cette fonction utilise le tableau avec les regex séparées du regex de mot de passe
 * et va affficher ce qu'il manque dans le mdp et ce qui est déja apparant 
 */
function AideVerificationMdp(e) {
    for (let i = 0; i < regex.length; i++) {
        if (regex[i].test(inputMdp.value)) {
            document.querySelector(`${idVerif[i]} i`).classList.remove("fauxFormSymbole");
            document.querySelector(`${idVerif[i]} i`).classList.remove("fa-times-circle");
            document.querySelector(`${idVerif[i]} i`).classList.add("vraiFormSymbole");
            document.querySelector(`${idVerif[i]} i`).classList.add("fa-check-circle");
        } else {
            document.querySelector(`${idVerif[i]} i`).classList.remove("vraiFormSymbole");
            document.querySelector(`${idVerif[i]} i`).classList.remove("fa-check-circle");
            document.querySelector(`${idVerif[i]} i`).classList.add("fauxFormSymbole");
            document.querySelector(`${idVerif[i]} i`).classList.add("fa-times-circle");
        }
    }
    check(e.target);
    checkConfirmMdp(document.querySelector("input[name=confirmMdp]"));
}


function checkConfirmMdp(input)
{
    if ((inputMdp.value == inputConfirmMdp.value) && inputMdp.checkValidity())
    {
        check(input)
        valide.confirmMdp = true;
    } else {
        if (input.value != "")
        {
        input.classList.remove("inputVert");
        input.classList.add("inputRouge");
        valide[input.name] = false;
    } else {
        input.classList.remove("inputVert");
        input.classList.remove("inputRouge");
    }
    }
    checkForm();
}
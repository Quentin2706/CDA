var menuBouton = document.querySelectorAll("nav > .boutons");
var current;
menuBouton.forEach(boutonNav => {
    boutonNav.addEventListener("click", AfficheSousMenu);
});

function AfficheSousMenu(e) {
    if (current != e.target && current != undefined) {
        current.children[0].classList.remove("fa-arrow-down");
        current.children[0].classList.add("fa-arrow-right")
        sousmenu = current.nextElementSibling;
        sousmenu.classList.add("hide");
        sousmenu.classList.remove("show")
    }
    if (e.target.nextElementSibling.classList.contains("sousmenu")) {
        var sousmenu = e.target.nextElementSibling;
        if (sousmenu.classList.contains("hide")) {
            current = e.target;
            e.target.children[0].classList.remove("fa-arrow-right");
            e.target.children[0].classList.add("fa-arrow-down")
            sousmenu.classList.add("show");
            sousmenu.classList.remove("hide")
        } else {
            e.target.children[0].classList.remove("fa-arrow-down");
            e.target.children[0].classList.add("fa-arrow-right")
            sousmenu.classList.add("hide");
            sousmenu.classList.remove("show")
        }


    }
}

/* BACK TO TOP */
var ascenseur = document.getElementById("ascenseur");
ascenseur.addEventListener("click", function () {
    window.scrollTo({ top: 0, behavior: 'smooth' });
});

var puceNav = document.querySelectorAll("nav > i");

/* ==================================================================== */

var inputs = document.getElementsByClassName("acheck");
console.log(inputs);

for (let i = 0; i < inputs.length; i++) {
    inputs[i].addEventListener("input", check);
}

function check(e) {
    if (e.target.value.length != 0) {
        mdpEqualConfirmMdp();
        if (e.target.checkValidity()) {
            e.target.style.backgroundColor = "green";
        } else {
            e.target.style.backgroundColor = "red";
        }
    } else {
        e.target.style.backgroundColor = "white";
    }
}

var mdp = document.getElementsByClassName("mdp");


mdp[1].addEventListener("change", mdpEqualConfirmMdp);
mdp[0].addEventListener("input", verifChar);


function mdpEqualConfirmMdp() {
    if (mdp[1].value != "") {

        if (mdp[0].value == mdp[1].value) {
            mdp[1].style.backgroundColor = "green";
        } else {
            mdp[1].style.backgroundColor = "red";
        }
    } else {
        mdp[1].style.backgroundColor = "white";
    }
}


var maj = new RegExp("(?=.*[A-Z])");
var min = new RegExp("(?=.*[a-z])");
var special = new RegExp("(?=.*[a-z])");
var majDiv = document.getElementById("maj");
var liste = document.getElementById("liste");


function verifChar(e)
{
    if (maj.test(e.target.value))
    {
        liste.querySelector("#maj i").classList.remove("fa-times-circle");
        liste.querySelector("#maj i").classList.add("fa-check-circle");
    } else {
        liste.querySelector("#maj i").classList.remove("fa-check-circle");
        liste.querySelector("#maj i").classList.add("fa-times-circle");
    };

    if (min.test(e.target.value))
    {
        liste.querySelector("#min i").classList.remove("fa-times-circle");
        liste.querySelector("#min i").classList.add("fa-check-circle");
    } else {
        liste.querySelector("#min i").classList.remove("fa-check-circle");
        liste.querySelector("#min i").classList.add("fa-times-circle");
    };
    
 
}
var menuBouton = document.querySelectorAll("nav > .boutons");
var current;
menuBouton.forEach(boutonNav => {
    boutonNav.addEventListener("click", AfficheSousMenu);
});

function AfficheSousMenu(e) {
        if (current != e.target && current != undefined)
        {
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
ascenseur.addEventListener("click", function(){
    window.scrollTo({top: 0, behavior: 'smooth'});
});

var puceNav = document.querySelectorAll("nav > i");

var menuBouton = document.querySelectorAll(".boutons-nav");

menuBouton.forEach(boutonNav => {
    boutonNav.addEventListener("click", AfficheSousMenu);
});

function AfficheSousMenu(e)
{
    if (e.target.nextElementSibling.classList.contains("sousmenu"))
    {
    var sousmenu = e.target.nextElementSibling;
    if (sousmenu.style.display == "flex")
    {
        sousmenu.style.display = "none";
    } else {
        sousmenu.style.display = "flex";
    }
}
}

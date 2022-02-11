<nav>
    
<div></div>
<?php 
if (isset($_SESSION['utilisateur']))
{
    if($_SESSION['utilisateur']->getRole() == 1)
    {
        echo'<div class="padding-2 boutons"><a href=\'?page=ListeLignesPaniers\'>Panier</a></div>';
        echo'<div class="padding-2 boutons"><a href=\'?page=ListeArticles\'>Catalogue</a></div>';
    } else if ($_SESSION['utilisateur']->getRole() == 2) {
        echo'<a class="padding-2 boutons" href=\'?page=#\'>Articles</a>';
        echo'<a class="padding-2 boutons" href=\'?page=ListeArticles\'>Types d\'articles</a>';
        echo'<a class="padding-2 boutons" href=\'?page=ListePaniers\'>Paniers</a>';
        echo'<a class="padding-2 boutons" href=\'?page=ListeUtilisateurs\'>Clients</a>';
        echo'<a class="padding-2 boutons" href=\'?page=ListeArticles\'>Catalogue</a>';
    }
}
?>
<div></div>
</nav>
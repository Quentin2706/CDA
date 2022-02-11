<?php
 echo '<div><div class="flex-0-1"></div><main>';
    $objets = PaniersManager::getList();
    if(!empty($objets))
    {
    
    //Création du template de la grid
    echo '<div class="grid-col-3 gridListe">';

    echo '<div class="caseListe titreListe grid-columns-span-3">Informations sur les paniers</div>';
    echo '<div class="caseListe grid-columns-span-3">
    <div></div>
    <div></div>
    <div></div>
    </div>';

    echo '<div class="caseListe titreListe">Client</div>';
    echo '<div class="caseListe"></div>';
    echo '<div class="caseListe titreListe">Nombre d\'articles</div>';

    //Remplissage de div vide pour la structure de la grid
    echo '<div class="caseListe"></div>';
    echo '<div class="caseListe"></div>';
    echo '<div class="caseListe"></div>';

    // Affichage des ennregistrements de la base de données
    foreach($objets as $unObjet)
    {
	$sommeArticles = LignesPaniersManager::getList(["SUM(quantite) as sum"],["IdPanier" => $unObjet->getIdPanier()],null,null,true);
    echo '<div class="caseListe donneeListe">'.$unObjet->getClient()->getNom().' '.$unObjet->getClient()->getPrenom().'</div>';
    echo '<div class="caseListe donneeListe"></div>';
    echo '<div class="caseListe donneeListe">'.$sommeArticles[0]["sum"].'</div>';
    }
    //Derniere ligne du tableau (bouton retour)
    echo '<div class="caseListe grid-columns-span-3">
        <div></div>
        <a href="index.php?page="><button><i class="fas fa-sign-out-alt fa-rotate-180"></i></button></a>
        <div></div>
    </div>';

    echo'</div>'; //Grid
    } else {
        echo'<div class="center">Pas de panier en cours.</div>';
    }
	echo '</main><div class="flex-0-1"></div></div>';
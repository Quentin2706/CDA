<?php

echo '<div><div class="flex-0-1"></div><main>';
 
 

$objets = LignesPaniersManager::getList();
//Création du template de la grid
echo '<div class="grid-col-5 gridListe">';

echo '<div class="caseListe titreListe grid-columns-span-5">Liste des LignesPaniers </div>';


echo '<div class="caseListe labelListe">Article</div>';
echo '<div class="caseListe labelListe">Quantite</div>';

//Remplissage de div vide pour la structure de la grid
echo '<div class="caseListe"></div>';
echo '<div class="caseListe"></div>';
echo '<div class="caseListe"></div>';

// Affichage des ennregistrements de la base de données
foreach($objets as $unObjet)
{
echo '<div class="caseListe donneeListe">'.$unObjet->getArticle()->getLibelleArticle().'</div>';
echo '<div class="caseListe donneeListe">'.$unObjet->getQuantite().'</div>';
echo '<div class="caseListe"> <a href="index.php?page=FormLignesPaniers&mode=Afficher&id='.$unObjet->getIdLignePanier().'"><i class="fas fa-file-contract"></i></a></div>';
                                                    
echo '<div class="caseListe"> <a href="index.php?page=FormLignesPaniers&mode=Modifier&id='.$unObjet->getIdLignePanier().'"><i class="fas fa-pen"></i></a></div>';
                                                    
echo '<div class="caseListe"> <a href="index.php?page=FormLignesPaniers&mode=Supprimer&id='.$unObjet->getIdLignePanier().'"><i class="fas fa-trash-alt"></i></a></div>';
}
//Derniere ligne du tableau (bouton retour)
echo '<div class="caseListe grid-columns-span-5">
	<div></div>
	<a href="index.php?page=Accueil"><button><i class="fas fa-sign-out-alt fa-rotate-180"></i></button></a>
	<div></div>
</div>';

echo'</div>'; //Grid
echo '</main><div class="flex-0-1"></div></div>';

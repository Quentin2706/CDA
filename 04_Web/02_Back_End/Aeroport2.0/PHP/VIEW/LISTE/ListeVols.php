<?php

 echo '<main>';

 echo '<div class="flex-0-1"></div>';

 echo '<div>';
 

$objets = VolsManager::getList();
//Création du template de la grid
echo '<div class="grid-col-8 gridListe">';


echo '<div class="caseListe grid-columns-span-8">
<div></div>
<div class="caseListe"><a href="index.php?page=FormVols&mode=Ajouter"><i class="fas fa-plus"></i></a></div>
<div></div>
</div>';

echo '<div class="caseListe">DateVol</div>';
echo '<div class="caseListe">AeroportArrivee</div>';
echo '<div class="caseListe">DureeVol</div>';
echo '<div class="caseListe">AeroportDepart</div>';
echo '<div class="caseListe">IdAvion</div>';

//Remplissage de div vide pour la structure de la grid
echo '<div class="caseListe"></div>';
echo '<div class="caseListe"></div>';
echo '<div class="caseListe"></div>';

// Affichage des ennregistrements de la base de données
foreach($objets as $unObjet)
{
echo '<div class="caseListe">'.$unObjet->getDateVol().'</div>';
echo '<div class="caseListe">'.$unObjet->getAeroportArrivee().'</div>';
echo '<div class="caseListe">'.$unObjet->getDureeVol().'</div>';
echo '<div class="caseListe">'.$unObjet->getAeroportDepart().'</div>';
echo '<div class="caseListe">'.$unObjet->getIdAvion().'</div>';
echo '<div class="caseListe"> <a href="index.php?page=FormVols&mode=Afficher&id='.$unObjet->getIdVol().'"><i class="fas fa-file-contract"></i></a></div>';
                                                    
echo '<div class="caseListe"> <a href="index.php?page=FormVols&mode=Modifier&id='.$unObjet->getIdVol().'"><i class="fas fa-pen"></i></a></div>';
                                                    
echo '<div class="caseListe"> <a href="index.php?page=FormVols&mode=Supprimer&id='.$unObjet->getIdVol().'"><i class="fas fa-trash-alt"></i></a></div>';
}
//Derniere ligne du tableau (bouton retour)
echo '<div class="caseListe grid-columns-span-8">
	<div></div>
	<a href="index.php?page=Accueil"><button><i class="fas fa-sign-out-alt fa-rotate-180"></i></button></a>
	<div></div>
</div>';

echo'</div>'; //Grid
echo'</div>'; //Div
echo '<div class="flex-0-1"></div>';
echo '</main>';
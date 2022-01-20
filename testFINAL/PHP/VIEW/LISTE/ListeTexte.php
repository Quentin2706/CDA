<?php

 echo '<main>';

 echo '<div class="flex-0-1"></div>';

 echo '<div>';
 

$objets = TexteManager::getList();
//Création du template de la grid
echo '<div class="grid-col-3 gridListe">';

echo '<div class="caseListe grid-columns-span-7">LISTE DES Texte </div>';
echo '<div class="caseListe grid-columns-span-7">
<div></div>
<div class="caseListe"><a href="index.php?page=FormTexte&mode=Ajouter"><i class="fas fa-plus"></i></a></div>
<div></div>
</div>';

echo '<div class="caseListe">codeTexte</div>';
echo '<div class="caseListe">fr</div>';
echo '<div class="caseListe">en</div>';

//Remplissage de div vide pour la structure de la grid
echo '<div class="caseListe"></div>';
echo '<div class="caseListe"></div>';
echo '<div class="caseListe"></div>';

// Affichage des ennregistrements de la base de données
foreach($objets as $unObjet)
{
echo '<div class="caseListe">'.$unObjet->getCodeTexte().'</div>';
echo '<div class="caseListe">'.$unObjet->getFr().'</div>';
echo '<div class="caseListe">'.$unObjet->getEn().'</div>';
echo '<div class="caseListe"> <a href="index.php?page=FormTexte&mode=Afficher&id='.$unObjet->getIdTexte().'"><i class="fas fa-file-contract"></i></a></div>';
                                                    
echo '<div class="caseListe"> <a href="index.php?page=FormTexte&mode=Modifier&id='.$unObjet->getIdTexte().'"><i class="fas fa-pen"></i></a></div>';
                                                    
echo '<div class="caseListe"> <a href="index.php?page=FormTexte&mode=Supprimer&id='.$unObjet->getIdTexte().'"><i class="fas fa-trash-alt"></i></a></div>';
}
//Derniere ligne du tableau (bouton retour)
echo '<div class="caseListe grid-columns-span-7">
	<div></div>
	<a href="index.php?page=Accueil"><i class="fas fa-sign-out-alt fa-rotate-180"></i></a>
	<div></div>
</div>';

echo'</div>'; //Grid
echo'</div>'; //Div
echo '<div class="flex-0-1"></div>';
echo '</main>';
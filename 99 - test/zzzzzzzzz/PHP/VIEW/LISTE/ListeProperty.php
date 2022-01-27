<?php

 echo '<main>';

 echo '<div class="flex-0-1"></div>';

 echo '<div>';
 

$objets = PropertyManager::getList();
//Création du template de la grid
echo '<div class="grid-col-16 gridListe">';

echo '<div class="caseListe titreListe grid-columns-span-16">Liste des Property </div>';
echo '<div class="caseListe grid-columns-span-16">
<div></div>
<div class="caseListe"><a href="index.php?page=FormProperty&mode=Ajouter"><i class="fas fa-plus"></i></a></div>
<div></div>
</div>';

echo '<div class="caseListe labelListe">Title</div>';
echo '<div class="caseListe labelListe">Description</div>';
echo '<div class="caseListe labelListe">Surface</div>';
echo '<div class="caseListe labelListe">Rooms</div>';
echo '<div class="caseListe labelListe">Bedrooms</div>';
echo '<div class="caseListe labelListe">Floor</div>';
echo '<div class="caseListe labelListe">Price</div>';
echo '<div class="caseListe labelListe">Heat</div>';
echo '<div class="caseListe labelListe">City</div>';
echo '<div class="caseListe labelListe">Address</div>';
echo '<div class="caseListe labelListe">Postal_code</div>';
echo '<div class="caseListe labelListe">Sold</div>';
echo '<div class="caseListe labelListe">Created_at</div>';

//Remplissage de div vide pour la structure de la grid
echo '<div class="caseListe"></div>';
echo '<div class="caseListe"></div>';
echo '<div class="caseListe"></div>';

// Affichage des ennregistrements de la base de données
foreach($objets as $unObjet)
{
echo '<div class="caseListe donneeListe">'.$unObjet->getTitle().'</div>';
echo '<div class="caseListe donneeListe">'.$unObjet->getDescription().'</div>';
echo '<div class="caseListe donneeListe">'.$unObjet->getSurface().'</div>';
echo '<div class="caseListe donneeListe">'.$unObjet->getRooms().'</div>';
echo '<div class="caseListe donneeListe">'.$unObjet->getBedrooms().'</div>';
echo '<div class="caseListe donneeListe">'.$unObjet->getFloor().'</div>';
echo '<div class="caseListe donneeListe">'.$unObjet->getPrice().'</div>';
echo '<div class="caseListe donneeListe">'.$unObjet->getHeat().'</div>';
echo '<div class="caseListe donneeListe">'.$unObjet->getCity().'</div>';
echo '<div class="caseListe donneeListe">'.$unObjet->getAddress().'</div>';
echo '<div class="caseListe donneeListe">'.$unObjet->getPostal_code().'</div>';
echo '<div class="caseListe donneeListe">'.$unObjet->getSold().'</div>';
echo '<div class="caseListe donneeListe">'.$unObjet->getCreated_at().'</div>';
echo '<div class="caseListe"> <a href="index.php?page=FormProperty&mode=Afficher&id='.$unObjet->getId().'"><i class="fas fa-file-contract"></i></a></div>';
                                                    
echo '<div class="caseListe"> <a href="index.php?page=FormProperty&mode=Modifier&id='.$unObjet->getId().'"><i class="fas fa-pen"></i></a></div>';
                                                    
echo '<div class="caseListe"> <a href="index.php?page=FormProperty&mode=Supprimer&id='.$unObjet->getId().'"><i class="fas fa-trash-alt"></i></a></div>';
}
//Derniere ligne du tableau (bouton retour)
echo '<div class="caseListe grid-columns-span-16">
	<div></div>
	<a href="index.php?page=Accueil"><button><i class="fas fa-sign-out-alt fa-rotate-180"></i></button></a>
	<div></div>
</div>';

echo'</div>'; //Grid
echo'</div>'; //Div
echo '<div class="flex-0-1"></div>';
echo '</main>';
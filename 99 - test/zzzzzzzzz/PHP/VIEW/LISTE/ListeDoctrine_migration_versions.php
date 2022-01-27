<?php

 echo '<main>';

 echo '<div class="flex-0-1"></div>';

 echo '<div>';
 

$objets = Doctrine_migration_versionsManager::getList();
//Création du template de la grid
echo '<div class="grid-col-5 gridListe">';

echo '<div class="caseListe titreListe grid-columns-span-5">Liste des Doctrine_migration_versions </div>';
echo '<div class="caseListe grid-columns-span-5">
<div></div>
<div class="caseListe"><a href="index.php?page=FormDoctrine_migration_versions&mode=Ajouter"><i class="fas fa-plus"></i></a></div>
<div></div>
</div>';

echo '<div class="caseListe labelListe">Executed_at</div>';
echo '<div class="caseListe labelListe">Execution_time</div>';

//Remplissage de div vide pour la structure de la grid
echo '<div class="caseListe"></div>';
echo '<div class="caseListe"></div>';
echo '<div class="caseListe"></div>';

// Affichage des ennregistrements de la base de données
foreach($objets as $unObjet)
{
echo '<div class="caseListe donneeListe">'.$unObjet->getExecuted_at().'</div>';
echo '<div class="caseListe donneeListe">'.$unObjet->getExecution_time().'</div>';
echo '<div class="caseListe"> <a href="index.php?page=FormDoctrine_migration_versions&mode=Afficher&id='.$unObjet->getVersion().'"><i class="fas fa-file-contract"></i></a></div>';
                                                    
echo '<div class="caseListe"> <a href="index.php?page=FormDoctrine_migration_versions&mode=Modifier&id='.$unObjet->getVersion().'"><i class="fas fa-pen"></i></a></div>';
                                                    
echo '<div class="caseListe"> <a href="index.php?page=FormDoctrine_migration_versions&mode=Supprimer&id='.$unObjet->getVersion().'"><i class="fas fa-trash-alt"></i></a></div>';
}
//Derniere ligne du tableau (bouton retour)
echo '<div class="caseListe grid-columns-span-5">
	<div></div>
	<a href="index.php?page=Accueil"><button><i class="fas fa-sign-out-alt fa-rotate-180"></i></button></a>
	<div></div>
</div>';

echo'</div>'; //Grid
echo'</div>'; //Div
echo '<div class="flex-0-1"></div>';
echo '</main>';
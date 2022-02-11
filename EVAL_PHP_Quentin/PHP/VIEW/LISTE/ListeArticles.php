<?php

 echo '<div><div class="flex-0-1"></div><main>';

//  echo '<div class="flex-0-1"></div>';

//  echo '<div>';
 

$objets = ArticlesManager::getList();
//Création du template de la grid
// echo '<div class="grid-col-8 gridListe">';

// echo '<div class="caseListe titreListe grid-columns-span-8">Liste des Articles </div>';
// echo '<div class="caseListe grid-columns-span-8">
// <div></div>
// <div class="caseListe"><a href="index.php?page=FormArticles&mode=Ajouter"><i class="fas fa-plus"></i></a></div>
// <div></div>
// </div>';

// echo '<div class="caseListe labelListe">LibelleArticle</div>';
// echo '<div class="caseListe labelListe">DescriptionArticle</div>';
// echo '<div class="caseListe labelListe">PrixArticle</div>';
// echo '<div class="caseListe labelListe">Photos</div>';
// echo '<div class="caseListe labelListe">IdTypeArticle</div>';

// //Remplissage de div vide pour la structure de la grid
// echo '<div class="caseListe"></div>';
// echo '<div class="caseListe"></div>';
// echo '<div class="caseListe"></div>';

// // Affichage des ennregistrements de la base de données
// foreach($objets as $unObjet)
// {
// echo '<div class="caseListe donneeListe">'.$unObjet->getLibelleArticle().'</div>';
// echo '<div class="caseListe donneeListe">'.$unObjet->getDescriptionArticle().'</div>';
// echo '<div class="caseListe donneeListe">'.$unObjet->getPrixArticle().'</div>';
// echo '<div class="caseListe donneeListe">'.$unObjet->getPhotos().'</div>';
// echo '<div class="caseListe donneeListe">'.$unObjet->getIdTypeArticle().'</div>';
// echo '<div class="caseListe"> <a href="index.php?page=FormArticles&mode=Afficher&id='.$unObjet->getIdArticle().'"><i class="fas fa-file-contract"></i></a></div>';
                                                    
// echo '<div class="caseListe"> <a href="index.php?page=FormArticles&mode=Modifier&id='.$unObjet->getIdArticle().'"><i class="fas fa-pen"></i></a></div>';
                                                    
// echo '<div class="caseListe"> <a href="index.php?page=FormArticles&mode=Supprimer&id='.$unObjet->getIdArticle().'"><i class="fas fa-trash-alt"></i></a></div>';
// }
// //Derniere ligne du tableau (bouton retour)
// echo '<div class="caseListe grid-columns-span-8">
// 	<div></div>
// 	<a href="index.php?page=Accueil"><button><i class="fas fa-sign-out-alt fa-rotate-180"></i></button></a>
// 	<div></div>
// </div>';

// echo'</div>'; //Grid
// echo'</div>'; //Div
// echo '<div class="flex-0-1"></div>';

$objets = ArticlesManager::getList(['*'],null,"IdTypeArticle ASC");
echo'<div class="titreListe center">Catalogue</div>';
$typeArticles[] = $objets[0]->getTypeArticle()->getLibelleTypeArticle();

for ($i = 1; $i < count($objets); $i++)
{
	$curr = $objets[$i-1];
	if ($objets[$i]->getIdTypeArticle() != $objets[$i-1]->getIdTypeArticle())
	{
		$typeArticles[] = $objets[$i]->getTypeArticle()->getLibelleTypeArticle();
	}
}
$cpt = 0;
foreach($typeArticles as $unType)
{
	
	echo '<div class="blocTypeArticle"><div></div><div class="titreListe">Type : '.$unType.'</div><div></div></div>';
	echo'<div class="ligneArticleListe">';
	while($cpt < count($objets) && $objets[$cpt]->getTypeArticle()->getLibelleTypeArticle() == $unType)
	{
		echo'<div class="colonne center">';
		echo'<div><img src="./IMG/'.$objets[$cpt]->getPhotos().'"></div>';
		echo'<div>
		<div class="colonne">
			<div>'.$objets[$cpt]->getLibelleArticle().'</div>';
		echo'<div>'.$objets[$cpt]->getDescriptionArticle().'</div>
		</div>';
		if ($_SESSION['utilisateur']->getRole() == 1)
		{
			echo'<a href="index.php?page=ActionLignesPaniers&mode=Ajouter&idArticle='.$objets[$cpt]->getIdArticle().'"><i class="fas fa-cart-plus"></i></a>';
		}

		echo'</div>
		</div>';
		$cpt++;
	}
	echo'</div>';
}

echo'<div>
	<div></div>
	<a href="index.php?page=ListeArticles"><button><i class="fas fa-sign-out-alt fa-rotate-180"></i></button></a>
	<div></div>
</div>';

echo '</main><div class="flex-0-1"></div></div>';
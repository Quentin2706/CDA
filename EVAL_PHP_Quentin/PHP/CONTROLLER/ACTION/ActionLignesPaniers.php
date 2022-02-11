<?php
$elm = new LignesPaniers($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$panier = PaniersManager::getList(["*"], ["IdClient" => $_SESSION["utilisateur"]->getIdUtilisateur()],null,null,false,true);
		if (empty($panier))
		{
			global $date;
			$panier = new Paniers(["idPanier" => null, "IdClient" =>  $_SESSION["utilisateur"]->getIdUtilisateur(),"DatePanier" => $date,"Adresselivraison" => "chez moi"]);
			PaniersManager::add($panier);
			$panier = PaniersManager::getList(["*"], ["IdClient" => $_SESSION["utilisateur"]->getIdUtilisateur()]);
		}
		if(empty($_POST) && isset($_GET['idArticle']))
		{
			$elm = LignesPaniersManager::getList(["*"], ["IdPanier" => $panier[count($panier)-1]->getIdPanier(), "Idarticle" => $_GET['idArticle']]);
			if ($elm != null)
			{
				$elm[0]->setQuantite($elm[0]->getQuantite()+1);
				$elm = $elm[0];
				$elm = LignesPaniersManager::update($elm);
			} else {
				$elm = new LignesPaniers(["IdArticle" => $_GET["idArticle"],"IdPanier" => $panier[count($panier)-1]->getIdPanier(), "quantite" => 1]);
				$elm = LignesPaniersManager::add($elm);
			}
		}
		
		break;
	}
	case "Modifier": {
		$elm = LignesPaniersManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = LignesPaniersManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeLignesPaniers");
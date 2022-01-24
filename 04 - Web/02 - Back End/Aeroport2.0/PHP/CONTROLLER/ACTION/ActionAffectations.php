<?php
$elm = new Affectations($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = AffectationsManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = AffectationsManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = AffectationsManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeAffectations");
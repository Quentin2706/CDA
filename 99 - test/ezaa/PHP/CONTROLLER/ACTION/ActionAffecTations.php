<?php
$elm = new AffecTations($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = AffecTationsManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = AffecTationsManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = AffecTationsManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeAffecTations");
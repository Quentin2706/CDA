<?php
$elm = new Avions($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = AvionsManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = AvionsManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = AvionsManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeAvions");
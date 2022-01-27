<?php
$elm = new PiloTes($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = PiloTesManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = PiloTesManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = PiloTesManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListePiloTes");
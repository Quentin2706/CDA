<?php
$elm = new Pilotes($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = PilotesManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = PilotesManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = PilotesManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListePilotes");
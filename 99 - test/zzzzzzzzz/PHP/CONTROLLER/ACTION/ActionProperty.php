<?php
$elm = new Property($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = PropertyManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = PropertyManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = PropertyManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeProperty");
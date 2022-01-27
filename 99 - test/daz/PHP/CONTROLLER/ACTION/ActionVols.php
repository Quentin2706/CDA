<?php
$elm = new Vols($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = VolsManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = VolsManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = VolsManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeVols");
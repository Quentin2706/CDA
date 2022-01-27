<?php
$elm = new UtilisaTeurs($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = UtilisaTeursManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = UtilisaTeursManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = UtilisaTeursManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeUtilisaTeurs");
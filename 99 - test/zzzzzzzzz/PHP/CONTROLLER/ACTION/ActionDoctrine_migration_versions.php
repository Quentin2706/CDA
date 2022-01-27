<?php
$elm = new Doctrine_migration_versions($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = Doctrine_migration_versionsManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = Doctrine_migration_versionsManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = Doctrine_migration_versionsManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeDoctrine_migration_versions");
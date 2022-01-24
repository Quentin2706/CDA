<?php

include "./PHP/CONTROLLER/Outils.php";

spl_autoload_register("ChargerClasse");

Parametres::init();

DbConnect::init();

session_start();

/******Les langues******/
/***On récupère la langue***/
if (isset($_GET['lang']) && TextesManager::checkIfLangExist($_GET['lang'])) {
	 // tester si la langue est gérée
	$_SESSION['lang'] = $_GET['lang'];
}else if (isset($_COOKIE['lang'])) {
	$_SESSION['lang'] = $_COOKIE['lang'];
}else{
	$_SESSION['lang'] = 'FR';
}
//Crée un cookie lang sur la machine de l'utilisateur d'une durée de 10h.
setcookie("lang", $_SESSION['lang'], time()+36000, '/');
/******Fin des langues******/

$routes=[
	"Default"=>["PHP/VIEW/FORM/","FormInscriptionConnexion","Connexion & Inscription",0,false],
	"Accueil"=>["PHP/VIEW/GENERAL/","Accueil","Accueil",0,false],

	"ActionConnexion"=>["PHP/CONTROLLER/ACTION/","ActionConnexion","Action de la connexion",0,false],
	"ActionInscription"=>["PHP/CONTROLLER/ACTION/","ActionInscription","Action de l'inscription",0,false],
	"ActionDeconnexion"=>["PHP/CONTROLLER/ACTION/","ActionDeconnexion","Action de deconnexion",0,false],

	"ListeMailAPI"=>["PHP/MODEL/API/","ListeMailAPI", "ListeMailAPI",0,true],

	"ListeAffectations"=>["PHP/VIEW/LISTE/","ListeAffectations","Liste des Affectations",0,false],
	"FormAffectations"=>["PHP/VIEW/FORM/","FormAffectations","Formulaire Affectations",0,false],
	"ActionAffectations"=>["PHP/CONTROLLER/ACTION/","ActionAffectations","Action Affectations",0,false],

	"ListeAvions"=>["PHP/VIEW/LISTE/","ListeAvions","Liste  des  Avions",0,false],
	"FormAvions"=>["PHP/VIEW/FORM/","FormAvions","Formulaire Avions",0,false],
	"ActionAvions"=>["PHP/CONTROLLER/ACTION/","ActionAvions","Action Avions",0,false],

	"ListePilotes"=>["PHP/VIEW/LISTE/","ListePilotes","Liste  des  Pilotes",0,false],
	"FormPilotes"=>["PHP/VIEW/FORM/","FormPilotes","Formulaire Pilotes",0,false],
	"ActionPilotes"=>["PHP/CONTROLLER/ACTION/","ActionPilotes","Action Pilotes",0,false],

	"ListeUtilisateurs"=>["PHP/VIEW/LISTE/","ListeUtilisateurs","Liste  des  Utilisateurs",0,false],
	"FormUtilisateurs"=>["PHP/VIEW/FORM/","FormUtilisateurs","Formulaire Utilisateurs",0,false],
	"ActionUtilisateurs"=>["PHP/CONTROLLER/ACTION/","ActionUtilisateurs","Action Utilisateurs",0,false],

	"ListeVols"=>["PHP/VIEW/LISTE/","ListeVols","Liste Vols",0,false],
	"FormVols"=>["PHP/VIEW/FORM/","FormVols","Formulaire Vols",0,false],
	"ActionVols"=>["PHP/CONTROLLER/ACTION/","ActionVols","Action Vols",0,false],

];

if(isset($_GET["page"]))
{

	$page=$_GET["page"];

	if(isset($routes[$page]))
	{
		AfficherPage($routes[$page]);
	}
	else
	{
		AfficherPage($routes["Default"]);
	}
}
else
{
	AfficherPage($routes["Default"]);
}
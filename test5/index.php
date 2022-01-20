<?php

include "./PHP/CONTROLLER/Outils.php";

spl_autoload_register("ChargerClasse");

Parametres::init();

DbConnect::init();

session_start();

/******Les langues******/
/***On récupère la langue***/
if (isset($_GET['lang']) && TexteManager::checkIfLangExist($_GET['lang'])) {
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
	"ListeCategories"=>["PHP/VIEW/LISTE/","ListeCategories","Liste Categories",0,false],
	"FormCategories"=>["PHP/VIEW/FORM/","FormCategories","Formulaire Categories",0,false],
	"ActionCategories"=>["PHP/CONTROLLER/ACTION/","ListeCategories","Action Categories",0,false],
	"ListeProduits"=>["PHP/VIEW/LISTE/","ListeProduits","Liste Produits",0,false],
	"FormProduits"=>["PHP/VIEW/FORM/","FormProduits","Formulaire Produits",0,false],
	"ActionProduits"=>["PHP/CONTROLLER/ACTION/","ListeProduits","Action Produits",0,false],
	"ListeTexte"=>["PHP/VIEW/LISTE/","ListeTexte","Liste Texte",0,false],
	"FormTexte"=>["PHP/VIEW/FORM/","FormTexte","Formulaire Texte",0,false],
	"ActionTexte"=>["PHP/CONTROLLER/ACTION/","ListeTexte","Action Texte",0,false],
	"ListeUtilisateurs"=>["PHP/VIEW/LISTE/","ListeUtilisateurs","Liste Utilisateurs",0,false],
	"FormUtilisateurs"=>["PHP/VIEW/FORM/","FormUtilisateurs","Formulaire Utilisateurs",0,false],
	"ActionUtilisateurs"=>["PHP/CONTROLLER/ACTION/","ListeUtilisateurs","Action Utilisateurs",0,false],
	"default"=>["PHP/VIEW/GENERAL/","Accueil","Accueil",0,false],
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
		AfficherPage($routes["default"]);
	}
}
else
{
	AfficherPage($routes["default"]);
}
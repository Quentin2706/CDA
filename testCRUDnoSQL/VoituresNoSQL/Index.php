<?php

require("./Outils.php");

Parametres::init();

DbConnect::init();

session_start();

/******Les langues******/
/***On récupère la langue***/
if (isset($_GET['lang']))
{
	$_SESSION['lang'] = $_GET['lang'];
}

/***On récupère la langue de la session/FR par défaut***/
$lang=isset($_SESSION['lang']) ? $_SESSION['lang'] : 'FR';
/******Fin des langues******/

$routes=[
	"default"=>["PHP/VIEW/","accueil","Accueil"],
	"TestmarquesManager"=>["PHP/MODEL/TESTMANAGER/","TestmarquesManager","Test de marques"],
	"TestmodelesManager"=>["PHP/MODEL/TESTMANAGER/","TestmodelesManager","Test de modeles"],
	"Testmodeles_optionsManager"=>["PHP/MODEL/TESTMANAGER/","Testmodeles_optionsManager","Test de modeles_options"],
	"TestoptionsManager"=>["PHP/MODEL/TESTMANAGER/","TestoptionsManager","Test de options"],
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
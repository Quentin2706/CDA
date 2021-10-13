<?php

//Test Modeles_optionsManager

echo "recherche id = 1" . "<br>";
$obj =Modeles_optionsManager::findById(1);
var_dump($obj);
echo $obj->toString();

echo "ajout de l'objet". "<br>";
$newObj = new Modeles_options(["om_mod_id" => "([value 1])", "om_opt_id" => "([value 2])"]);
var_dump(Modeles_optionsManager::add($newObj));

echo "Liste des objets" . "<br>";
$array = Modeles_optionsManager::getList();
foreach ($array as $unObj)
{
	echo $unObj->toString() . "<br><br>";
}

echo "on met à jour l'id 1" . "<br>";
$obj->setom_mod_id("[(Value)]");
Modeles_optionsManager::update($obj);
$objUpdated = Modeles_optionsManager::findById(1);
echo "Liste des objets" . "<br>";
$array = Modeles_optionsManager::getList();
foreach ($array as $unObj)
{
	echo $unObj->toString() . "<br><br>";
}

echo "on supprime un objet". "<br>";
$obj = Modeles_optionsManager::findById(1);
Modeles_optionsManager::delete($obj);
echo "Liste des objets" . "<br>";
$array = Modeles_optionsManager::getList();
foreach ($array as $unObj)
{
	echo $unObj->toString() . "<br><br>";
}

?>
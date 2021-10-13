<?php

//Test ModelesManager

echo "recherche id = 1" . "<br>";
$obj =ModelesManager::findById(1);
var_dump($obj);
echo $obj->toString();

echo "ajout de l'objet". "<br>";
$newObj = new Modeles(["mod_mar_id" => "([value 1])", "mod_nom" => "([value 2])", "mod_cylindree" => "([value 3])", "mod_prix" => "([value 4])", "mod_date_dispo" => "([value 5])", "mod_date_ajout" => "([value 6])"]);
var_dump(ModelesManager::add($newObj));

echo "Liste des objets" . "<br>";
$array = ModelesManager::getList();
foreach ($array as $unObj)
{
	echo $unObj->toString() . "<br><br>";
}

echo "on met à jour l'id 1" . "<br>";
$obj->setmod_mar_id("[(Value)]");
ModelesManager::update($obj);
$objUpdated = ModelesManager::findById(1);
echo "Liste des objets" . "<br>";
$array = ModelesManager::getList();
foreach ($array as $unObj)
{
	echo $unObj->toString() . "<br><br>";
}

echo "on supprime un objet". "<br>";
$obj = ModelesManager::findById(1);
ModelesManager::delete($obj);
echo "Liste des objets" . "<br>";
$array = ModelesManager::getList();
foreach ($array as $unObj)
{
	echo $unObj->toString() . "<br><br>";
}

?>
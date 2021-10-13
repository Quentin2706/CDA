<?php

//Test MarquesManager

echo "recherche id = 1" . "<br>";
$obj =MarquesManager::findById(1);
var_dump($obj);
echo $obj->toString();

echo "ajout de l'objet". "<br>";
$newObj = new Marques(["mar_nom" => "([value 1])"]);
var_dump(MarquesManager::add($newObj));

echo "Liste des objets" . "<br>";
$array = MarquesManager::getList();
foreach ($array as $unObj)
{
	echo $unObj->toString() . "<br><br>";
}

echo "on met à jour l'id 1" . "<br>";
$obj->setmar_nom("[(Value)]");
MarquesManager::update($obj);
$objUpdated = MarquesManager::findById(1);
echo "Liste des objets" . "<br>";
$array = MarquesManager::getList();
foreach ($array as $unObj)
{
	echo $unObj->toString() . "<br><br>";
}

echo "on supprime un objet". "<br>";
$obj = MarquesManager::findById(1);
MarquesManager::delete($obj);
echo "Liste des objets" . "<br>";
$array = MarquesManager::getList();
foreach ($array as $unObj)
{
	echo $unObj->toString() . "<br><br>";
}

?>
<?php

//Test OptionsManager

echo "recherche id = 1" . "<br>";
$obj =OptionsManager::findById(1);
var_dump($obj);
echo $obj->toString();

echo "ajout de l'objet". "<br>";
$newObj = new Options(["opt_libelle" => "([value 1])", "opt_prix" => "([value 2])"]);
var_dump(OptionsManager::add($newObj));

echo "Liste des objets" . "<br>";
$array = OptionsManager::getList();
foreach ($array as $unObj)
{
	echo $unObj->toString() . "<br><br>";
}

echo "on met à jour l'id 1" . "<br>";
$obj->setopt_libelle("[(Value)]");
OptionsManager::update($obj);
$objUpdated = OptionsManager::findById(1);
echo "Liste des objets" . "<br>";
$array = OptionsManager::getList();
foreach ($array as $unObj)
{
	echo $unObj->toString() . "<br><br>";
}

echo "on supprime un objet". "<br>";
$obj = OptionsManager::findById(1);
OptionsManager::delete($obj);
echo "Liste des objets" . "<br>";
$array = OptionsManager::getList();
foreach ($array as $unObj)
{
	echo $unObj->toString() . "<br><br>";
}

?>
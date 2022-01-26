<?php

$tabFK = [];
$tabFK[] = ["TABLE_NAME" => "affectations", "COLUMNS_NAME" => "idPilote"];
$tabFK[] = ["TABLE_NAME" => "affectations", "COLUMNS_NAME" => "idVol"];
$tabFK[] = ["TABLE_NAME" => "affectations", "COLUMNS_NAME" => "idVdzdzdl"];
$tabFK[] = ["TABLE_NAME" => "affectations", "COLUMNS_NAME" => "idzdaazdadol"];
$tabFK[] = ["TABLE_NAME" => "affectations", "COLUMNS_NAME" => "idVol"];
$tabFK[] = ["TABLE_NAME" => "affectations", "COLUMNS_NAME" => "idVzadol"];
$tabFK[] = ["TABLE_NAME" => "affectations", "COLUMNS_NAME" => "idVoadadazdl"];
$tabFK[] = ["TABLE_NAME" => "affectations", "COLUMNS_NAME" => "idVozadzadl"];
$tabFK[] = ["TABLE_NAME" => "affectations", "COLUMNS_NAME" => "idVol"];
$tabFK[] = ["TABLE_NAME" => "efzfzefzfze", "COLUMNS_NAME" => "idVadazdaol"];
$tabFK[] = ["TABLE_NAME" => "affectations", "COLUMNS_NAME" => "idVazol"];
$tabFK[] = ["TABLE_NAME" => "affectations", "COLUMNS_NAME" => "idVol"];
$tabFK[] = ["TABLE_NAME" => "affectations", "COLUMNS_NAME" => "idVol"];


var_dump(array_column($tabFK, "COLUMNS_NAME"));
var_dump(array_search("zzzz", array_column($tabFK, "COLUMNS_NAME")));
// var_dump($tabFK[]);
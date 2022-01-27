<?php

class AvionsManager 
{

	public static function add(Avions $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Avions $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Avions $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Avions::getAttributes(),"Avions",["IdAvion" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Avions::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Avions",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}
<?php

class PropertyManager 
{

	public static function add(Property $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Property $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Property $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Property::getAttributes(),"Property",["id" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Property::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Property",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}
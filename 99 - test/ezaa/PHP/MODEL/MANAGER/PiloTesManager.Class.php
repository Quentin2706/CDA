<?php

class PiloTesManager 
{

	public static function add(PiloTes $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(PiloTes $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(PiloTes $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(PiloTes::getAttributes(),"PiloTes",["IdPilote" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?PiloTes::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"PiloTes",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}
<?php

class VolsManager 
{

	public static function add(Vols $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Vols $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Vols $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Vols::getAttributes(),"Vols",["IdVol" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Vols::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Vols",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}
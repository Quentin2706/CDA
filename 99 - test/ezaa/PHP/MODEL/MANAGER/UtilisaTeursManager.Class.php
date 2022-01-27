<?php

class UtilisaTeursManager 
{

	public static function add(UtilisaTeurs $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(UtilisaTeurs $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(UtilisaTeurs $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(UtilisaTeurs::getAttributes(),"UtilisaTeurs",["idUtilisateur" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?UtilisaTeurs::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"UtilisaTeurs",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}
<?php

class AffectationsManager 
{

	public static function add(Affectations $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Affectations $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Affectations $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Affectations::getAttributes(),"Affectations",["IdAffectation" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Affectations::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Affectations",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}
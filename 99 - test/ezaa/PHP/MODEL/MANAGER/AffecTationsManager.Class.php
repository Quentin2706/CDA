<?php

class AffecTationsManager 
{

	public static function add(AffecTations $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(AffecTations $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(AffecTations $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(AffecTations::getAttributes(),"AffecTations",["IdAffectation" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?AffecTations::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"AffecTations",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}
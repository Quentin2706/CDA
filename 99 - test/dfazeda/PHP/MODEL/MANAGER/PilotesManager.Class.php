<?php

class PilotesManager 
{

	public static function add(Pilotes $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Pilotes $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Pilotes $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Pilotes::getAttributes(),"Pilotes",["IdPilote" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Pilotes::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Pilotes",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}
<?php

class Doctrine_migration_versionsManager 
{

	public static function add(Doctrine_migration_versions $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Doctrine_migration_versions $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Doctrine_migration_versions $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Doctrine_migration_versions::getAttributes(),"Doctrine_migration_versions",["version" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Doctrine_migration_versions::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Doctrine_migration_versions",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}
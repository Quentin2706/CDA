<?php

class OptionsManager 
{
	public static function add(Options $obj)
	{
 		$db=DbConnect::getDb();
		$q=$db->prepare("INSERT INTO Options (opt_libelle,opt_prix) VALUES (:opt_libelle,:opt_prix)");
		$q->bindValue(":opt_libelle", $obj->getOpt_libelle());
		$q->bindValue(":opt_prix", $obj->getOpt_prix());
		$q->execute();
	}

	public static function update(Options $obj)
	{
 		$db=DbConnect::getDb();
		$q=$db->prepare("UPDATE Options SET opt_id=:opt_id,opt_libelle=:opt_libelle,opt_prix=:opt_prix WHERE opt_id=:opt_id");
		$q->bindValue(":opt_id", $obj->getOpt_id());
		$q->bindValue(":opt_libelle", $obj->getOpt_libelle());
		$q->bindValue(":opt_prix", $obj->getOpt_prix());
		$q->execute();
	}
	public static function delete(Options $obj)
	{
 		$db=DbConnect::getDb();
		$db->exec("DELETE FROM Options WHERE opt_id=" .$obj->getOpt_id());
	}
	public static function findById($id)
	{
 		$db=DbConnect::getDb();
		$id = (int) $id;
		$q=$db->query("SELECT * FROM Options WHERE opt_id =".$id);
		$results = $q->fetch(PDO::FETCH_ASSOC);
		if($results != false)
		{
			return new Options($results);
		}
		else
		{
			return false;
		}
	}
	public static function getList()
	{
 		$db=DbConnect::getDb();
		$liste = [];
		$q = $db->query("SELECT * FROM Options");
		while($donnees = $q->fetch(PDO::FETCH_ASSOC))
		{
			if($donnees != false)
			{
				$liste[] = new Options($donnees);
			}
		}
		return $liste;
	}
}
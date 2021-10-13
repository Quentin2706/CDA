<?php

class Modeles_optionsManager 
{
	public static function add(Modeles_options $obj)
	{
 		$db=DbConnect::getDb();
		$q=$db->prepare("INSERT INTO Modeles_options (om_mod_id,om_opt_id) VALUES (:om_mod_id,:om_opt_id)");
		$q->bindValue(":om_mod_id", $obj->getOm_mod_id());
		$q->bindValue(":om_opt_id", $obj->getOm_opt_id());
		$q->execute();
	}

	public static function update(Modeles_options $obj)
	{
 		$db=DbConnect::getDb();
		$q=$db->prepare("UPDATE Modeles_options SET om_id=:om_id,om_mod_id=:om_mod_id,om_opt_id=:om_opt_id WHERE om_id=:om_id");
		$q->bindValue(":om_id", $obj->getOm_id());
		$q->bindValue(":om_mod_id", $obj->getOm_mod_id());
		$q->bindValue(":om_opt_id", $obj->getOm_opt_id());
		$q->execute();
	}
	public static function delete(Modeles_options $obj)
	{
 		$db=DbConnect::getDb();
		$db->exec("DELETE FROM Modeles_options WHERE om_id=" .$obj->getOm_id());
	}
	public static function findById($id)
	{
 		$db=DbConnect::getDb();
		$id = (int) $id;
		$q=$db->query("SELECT * FROM Modeles_options WHERE om_id =".$id);
		$results = $q->fetch(PDO::FETCH_ASSOC);
		if($results != false)
		{
			return new Modeles_options($results);
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
		$q = $db->query("SELECT * FROM Modeles_options");
		while($donnees = $q->fetch(PDO::FETCH_ASSOC))
		{
			if($donnees != false)
			{
				$liste[] = new Modeles_options($donnees);
			}
		}
		return $liste;
	}
}
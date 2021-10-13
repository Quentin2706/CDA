<?php

class ModelesManager 
{
	public static function add(Modeles $obj)
	{
 		$db=DbConnect::getDb();
		$q=$db->prepare("INSERT INTO Modeles (mod_mar_id,mod_nom,mod_cylindree,mod_prix,mod_date_dispo,mod_date_ajout) VALUES (:mod_mar_id,:mod_nom,:mod_cylindree,:mod_prix,:mod_date_dispo,:mod_date_ajout)");
		$q->bindValue(":mod_mar_id", $obj->getMod_mar_id());
		$q->bindValue(":mod_nom", $obj->getMod_nom());
		$q->bindValue(":mod_cylindree", $obj->getMod_cylindree());
		$q->bindValue(":mod_prix", $obj->getMod_prix());
		$q->bindValue(":mod_date_dispo", $obj->getMod_date_dispo());
		$q->bindValue(":mod_date_ajout", $obj->getMod_date_ajout());
		$q->execute();
	}

	public static function update(Modeles $obj)
	{
 		$db=DbConnect::getDb();
		$q=$db->prepare("UPDATE Modeles SET mod_id=:mod_id,mod_mar_id=:mod_mar_id,mod_nom=:mod_nom,mod_cylindree=:mod_cylindree,mod_prix=:mod_prix,mod_date_dispo=:mod_date_dispo,mod_date_ajout=:mod_date_ajout WHERE mod_id=:mod_id");
		$q->bindValue(":mod_id", $obj->getMod_id());
		$q->bindValue(":mod_mar_id", $obj->getMod_mar_id());
		$q->bindValue(":mod_nom", $obj->getMod_nom());
		$q->bindValue(":mod_cylindree", $obj->getMod_cylindree());
		$q->bindValue(":mod_prix", $obj->getMod_prix());
		$q->bindValue(":mod_date_dispo", $obj->getMod_date_dispo());
		$q->bindValue(":mod_date_ajout", $obj->getMod_date_ajout());
		$q->execute();
	}
	public static function delete(Modeles $obj)
	{
 		$db=DbConnect::getDb();
		$db->exec("DELETE FROM Modeles WHERE mod_id=" .$obj->getMod_id());
	}
	public static function findById($id)
	{
 		$db=DbConnect::getDb();
		$id = (int) $id;
		$q=$db->query("SELECT * FROM Modeles WHERE mod_id =".$id);
		$results = $q->fetch(PDO::FETCH_ASSOC);
		if($results != false)
		{
			return new Modeles($results);
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
		$q = $db->query("SELECT * FROM Modeles");
		while($donnees = $q->fetch(PDO::FETCH_ASSOC))
		{
			if($donnees != false)
			{
				$liste[] = new Modeles($donnees);
			}
		}
		return $liste;
	}
}
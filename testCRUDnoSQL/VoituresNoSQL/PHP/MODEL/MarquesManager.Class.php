<?php

class MarquesManager 
{
	public static function add(Marques $obj)
	{
 		$db=DbConnect::getDb();
		$q=$db->prepare("INSERT INTO Marques (mar_nom) VALUES (:mar_nom)");
		$q->bindValue(":mar_nom", $obj->getMar_nom());
		$q->execute();
	}

	public static function update(Marques $obj)
	{
 		$db=DbConnect::getDb();
		$q=$db->prepare("UPDATE Marques SET mar_id=:mar_id,mar_nom=:mar_nom WHERE mar_id=:mar_id");
		$q->bindValue(":mar_id", $obj->getMar_id());
		$q->bindValue(":mar_nom", $obj->getMar_nom());
		$q->execute();
	}
	public static function delete(Marques $obj)
	{
 		$db=DbConnect::getDb();
		$db->exec("DELETE FROM Marques WHERE mar_id=" .$obj->getMar_id());
	}
	public static function findById($id)
	{
 		$db=DbConnect::getDb();
		$id = (int) $id;
		$q=$db->query("SELECT * FROM Marques WHERE mar_id =".$id);
		$results = $q->fetch(PDO::FETCH_ASSOC);
		if($results != false)
		{
			return new Marques($results);
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
		$q = $db->query("SELECT * FROM Marques");
		while($donnees = $q->fetch(PDO::FETCH_ASSOC))
		{
			if($donnees != false)
			{
				$liste[] = new Marques($donnees);
			}
		}
		return $liste;
	}
}
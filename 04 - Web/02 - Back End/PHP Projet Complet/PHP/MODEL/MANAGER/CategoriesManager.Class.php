<?php


class CategoriesManager 
{
	public static function add(Categories $obj)
	{
		return Services::add($obj);
	}

	public static function update(Categories $obj)
	{
		return Services::update($obj);
	}
	public static function delete(Categories $obj)
	{
		return Services::delete($obj);
	}
	public static function findById($id)
	{
 		$db=DbConnect::getDb();
		$id = (int) $id;
		$q=$db->query("SELECT * FROM Categories WHERE idCategorie =".$id);
		$results = $q->fetch(PDO::FETCH_ASSOC);
		if($results != false)
		{
			return new Categories($results);
		}
		else
		{
			return false;
		}
	}
	public static function getList()
	{
 		//return Services::select();
	}
}
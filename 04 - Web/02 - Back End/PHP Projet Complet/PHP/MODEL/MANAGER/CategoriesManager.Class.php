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
	public static function findById(int $id)
	{
		return Services::select(Categories::getAttributes(),"Categories",false, ["idCategorie" => $id]);
	}
	public static function getList()
	{
 		return Services::select(Categories::getAttributes(),"Categories");
	}
}
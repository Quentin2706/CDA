<?php
class DbConnect{
	private static $db;

	public static function getDb()
	{
		return DbConnect::$db;
	}

	public static function init()
	{
		try {
			self::$db = new Mongo('mongodb://localhost', array(
				'db'       => 'Voitures'
			));
		}
		catch (Exception $e)
		{
			die('Erreur :'. $e->getMessage());
		}
	}
}
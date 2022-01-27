<?php

class Doctrine_migration_versions 
{

	/*****************Attributs***************** */

	private $_version;
	private $_executed_at;
	private $_execution_time;
	private static $_attributes=["version","executed_at","execution_time"];
	/***************** Accesseurs ***************** */


	public function getVersion()
	{
		return $this->_version;
	}

	public function setVersion(string $version)
	{
		$this->_version=$version;
	}

	public function getExecuted_at()
	{
		return is_null($this->_executed_at)?null:$this->_executed_at->format('Y-n-j H:i:s');
	}

	public function setExecuted_at(?string $executed_at)
	{
		$this->_executed_at=is_null($executed_at)?null:DateTime::createFromFormat("Y-n-j H:i:s",$executed_at);
	}

	public function getExecution_time()
	{
		return $this->_execution_time;
	}

	public function setExecution_time(?int $execution_time)
	{
		$this->_execution_time=$execution_time;
	}

	public static function getAttributes()
	{
		return self::$_attributes;
	}

	/*****************Constructeur***************** */

	public function __construct(array $options = [])
	{
 		if (!empty($options)) // empty : renvoi vrai si le tableau est vide
		{
			$this->hydrate($options);
		}
	}
	public function hydrate($data)
	{
 		foreach ($data as $key => $value)
		{
 			$methode = "set".ucfirst($key); //ucfirst met la 1ere lettre en majuscule
			if (is_callable(([$this, $methode]))) // is_callable verifie que la methode existe
			{
				$this->$methode($value===""?null:$value);
			}
		}
	}

	/*****************Autres Méthodes***************** */

	/**
	* Transforme l'objet en chaine de caractères
	*
	* @return String
	*/
	public function toString()
	{
		return "Version : ".$this->getVersion()."Executed_at : ".$this->getExecuted_at()."Execution_time : ".$this->getExecution_time()."\n";
	}
}
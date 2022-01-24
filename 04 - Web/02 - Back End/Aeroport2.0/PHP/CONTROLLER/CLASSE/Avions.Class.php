<?php

class Avions 
{

	/*****************Attributs***************** */

	private $_IdAvion;
	private $_Compagnie;
	private $_Type;
	private static $_attributes=["IdAvion","Compagnie","Type"];
	/***************** Accesseurs ***************** */


	public function getIdAvion()
	{
		return $this->_IdAvion;
	}

	public function setIdAvion(int $IdAvion)
	{
		$this->_IdAvion=$IdAvion;
	}

	public function getCompagnie()
	{
		return $this->_Compagnie;
	}

	public function setCompagnie(?string $Compagnie)
	{
		$this->_Compagnie=$Compagnie;
	}

	public function getType()
	{
		return $this->_Type;
	}

	public function setType(?string $Type)
	{
		$this->_Type=$Type;
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
		return "IdAvion : ".$this->getIdAvion()."Compagnie : ".$this->getCompagnie()."Type : ".$this->getType()."\n";
	}
}
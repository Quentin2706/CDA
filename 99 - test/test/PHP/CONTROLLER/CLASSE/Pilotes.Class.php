<?php

class Pilotes 
{

	/*****************Attributs***************** */

	private $_IdPilote;
	private $_Nom;
	private $_Prenom;
	private static $_attributes=["IdPilote","Nom","Prenom"];
	/***************** Accesseurs ***************** */


	public function getIdPilote()
	{
		return $this->_IdPilote;
	}

	public function setIdPilote(int $IdPilote)
	{
		$this->_IdPilote=$IdPilote;
	}

	public function getNom()
	{
		return $this->_Nom;
	}

	public function setNom(string $Nom)
	{
		$this->_Nom=$Nom;
	}

	public function getPrenom()
	{
		return $this->_Prenom;
	}

	public function setPrenom(string $Prenom)
	{
		$this->_Prenom=$Prenom;
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
		return "IdPilote : ".$this->getIdPilote()."Nom : ".$this->getNom()."Prenom : ".$this->getPrenom()."\n";
	}
}
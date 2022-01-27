<?php

class AffecTations 
{

	/*****************Attributs***************** */

	private $_IdAffectation;
	private $_IdPilote;
	private $_IdVol;
	private $_Pilotes;
	private $_Vols;
	private static $_attributes=["IdAffectation","IdPilote","IdVol"];
	/***************** Accesseurs ***************** */


	public function getIdAffectation()
	{
		return $this->_IdAffectation;
	}

	public function setIdAffectation(int $IdAffectation)
	{
		$this->_IdAffectation=$IdAffectation;

	}

	public function getIdPilote()
	{
		return $this->_IdPilote;
	}

	public function setIdPilote(int $IdPilote)
	{
		$this->_IdPilote=$IdPilote;

		$this->_Pilotes=PiloTesManager::findById($IdPilote);
	}

	public function getIdVol()
	{
		return $this->_IdVol;
	}

	public function setIdVol(int $IdVol)
	{
		$this->_IdVol=$IdVol;

		$this->_Vols=VolsManager::findById($IdVol);
	}


	public function getPilotes()
{
	return $this->_Pilotes;
}

	public function getVols()
{
	return $this->_Vols;
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
		return "IdAffectation : ".$this->getIdAffectation()."IdPilote : ".$this->getIdPilote()."IdVol : ".$this->getIdVol()."\n";
	}
}
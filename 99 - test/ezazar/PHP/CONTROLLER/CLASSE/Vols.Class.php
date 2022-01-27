<?php

class Vols 
{

	/*****************Attributs***************** */

	private $_IdVol;
	private $_DateVol;
	private $_AeroportArrivee;
	private $_DureeVol;
	private $_AeroportDepart;
	private $_IdAvion;
	private $_Avions;
	private static $_attributes=["IdVol","DateVol","AeroportArrivee","DureeVol","AeroportDepart","IdAvion"];
	/***************** Accesseurs ***************** */


	public function getIdVol()
	{
		return $this->_IdVol;
	}

	public function setIdVol(int $IdVol)
	{
		$this->_IdVol=$IdVol;
	}

	public function getDateVol()
	{
		return is_null($this->_DateVol)?null:$this->_DateVol->format('Y-n-j');
	}

	public function setDateVol(string $DateVol)
	{
		$this->_DateVol=DateTime::createFromFormat("Y-n-j",$DateVol);
	}

	public function getAeroportArrivee()
	{
		return $this->_AeroportArrivee;
	}

	public function setAeroportArrivee(?string $AeroportArrivee)
	{
		$this->_AeroportArrivee=$AeroportArrivee;
	}

	public function getDureeVol()
	{
		return $this->_DureeVol;
	}

	public function setDureeVol(?string $DureeVol)
	{
		$this->_DureeVol=$DureeVol;
	}

	public function getAeroportDepart()
	{
		return $this->_AeroportDepart;
	}

	public function setAeroportDepart(?string $AeroportDepart)
	{
		$this->_AeroportDepart=$AeroportDepart;
	}

	public function getIdAvion()
	{
		return $this->_IdAvion;
	}

	public function setIdAvion(int $IdAvion)
	{
		$this->_IdAvion=$IdAvion;
		$this->_Avions=AvionsManager::findById($IdAvion);
	}


	public function getAvions()
{
	return $this->_Avions;
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
		return "IdVol : ".$this->getIdVol()."DateVol : ".$this->getDateVol()."AeroportArrivee : ".$this->getAeroportArrivee()."DureeVol : ".$this->getDureeVol()."AeroportDepart : ".$this->getAeroportDepart()."IdAvion : ".$this->getIdAvion()."\n";
	}
}
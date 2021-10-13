<?php

class Options 
{

	/*****************Attributs***************** */

	private $_opt_id;
	private $_opt_libelle;
	private $_opt_prix;

	/***************** Accesseurs ***************** */


	public function getOpt_id()
	{
		return $this->_opt_id;
	}

	public function setOpt_id($opt_id)
	{
		$this->_opt_id=$opt_id;
	}

	public function getOpt_libelle()
	{
		return $this->_opt_libelle;
	}

	public function setOpt_libelle($opt_libelle)
	{
		$this->_opt_libelle=$opt_libelle;
	}

	public function getOpt_prix()
	{
		return $this->_opt_prix;
	}

	public function setOpt_prix($opt_prix)
	{
		$this->_opt_prix=$opt_prix;
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
				$this->$methode($value);
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
		return "Opt_id : ".$this->getOpt_id()."Opt_libelle : ".$this->getOpt_libelle()."Opt_prix : ".$this->getOpt_prix()."\n";
	}


	
	/* Renvoit Vrai si lobjet en paramètre est égal 
	* à l'objet appelant
	*
	* @param [type] $obj
	* @return bool
	*/
	public function equalsTo($obj)
	{
		return;
	}


	/**
	* Compare l'objet à un autre
	* Renvoi 1 si le 1er est >
	*        0 si ils sont égaux
	*      - 1 si le 1er est <
	*
	* @param [type] $obj1
	* @param [type] $obj2
	* @return Integer
	*/
	public function compareTo($obj)
	{
		return;
	}
}
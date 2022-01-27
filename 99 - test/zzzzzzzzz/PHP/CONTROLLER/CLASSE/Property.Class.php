<?php

class Property 
{

	/*****************Attributs***************** */

	private $_id;
	private $_title;
	private $_description;
	private $_surface;
	private $_rooms;
	private $_bedrooms;
	private $_floor;
	private $_price;
	private $_heat;
	private $_city;
	private $_address;
	private $_postal_code;
	private $_sold;
	private $_created_at;
	private static $_attributes=["id","title","description","surface","rooms","bedrooms","floor","price","heat","city","address","postal_code","sold","created_at"];
	/***************** Accesseurs ***************** */


	public function getId()
	{
		return $this->_id;
	}

	public function setId(int $id)
	{
		$this->_id=$id;
	}

	public function getTitle()
	{
		return $this->_title;
	}

	public function setTitle(string $title)
	{
		$this->_title=$title;
	}

	public function getDescription()
	{
		return $this->_description;
	}

	public function setDescription(?string $description)
	{
		$this->_description=$description;
	}

	public function getSurface()
	{
		return $this->_surface;
	}

	public function setSurface(int $surface)
	{
		$this->_surface=$surface;
	}

	public function getRooms()
	{
		return $this->_rooms;
	}

	public function setRooms(int $rooms)
	{
		$this->_rooms=$rooms;
	}

	public function getBedrooms()
	{
		return $this->_bedrooms;
	}

	public function setBedrooms(int $bedrooms)
	{
		$this->_bedrooms=$bedrooms;
	}

	public function getFloor()
	{
		return $this->_floor;
	}

	public function setFloor(int $floor)
	{
		$this->_floor=$floor;
	}

	public function getPrice()
	{
		return $this->_price;
	}

	public function setPrice(int $price)
	{
		$this->_price=$price;
	}

	public function getHeat()
	{
		return $this->_heat;
	}

	public function setHeat(int $heat)
	{
		$this->_heat=$heat;
	}

	public function getCity()
	{
		return $this->_city;
	}

	public function setCity(string $city)
	{
		$this->_city=$city;
	}

	public function getAddress()
	{
		return $this->_address;
	}

	public function setAddress(string $address)
	{
		$this->_address=$address;
	}

	public function getPostal_code()
	{
		return $this->_postal_code;
	}

	public function setPostal_code(string $postal_code)
	{
		$this->_postal_code=$postal_code;
	}

	public function getSold()
	{
		return $this->_sold;
	}

	public function setSold(int $sold)
	{
		$this->_sold=$sold;
	}

	public function getCreated_at()
	{
		return is_null($this->_created_at)?null:$this->_created_at->format('Y-n-j H:i:s');
	}

	public function setCreated_at(string $created_at)
	{
		$this->_created_at=DateTime::createFromFormat("Y-n-j H:i:s",$created_at);
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
		return "Id : ".$this->getId()."Title : ".$this->getTitle()."Description : ".$this->getDescription()."Surface : ".$this->getSurface()."Rooms : ".$this->getRooms()."Bedrooms : ".$this->getBedrooms()."Floor : ".$this->getFloor()."Price : ".$this->getPrice()."Heat : ".$this->getHeat()."City : ".$this->getCity()."Address : ".$this->getAddress()."Postal_code : ".$this->getPostal_code()."Sold : ".$this->getSold()."Created_at : ".$this->getCreated_at()."\n";
	}
}
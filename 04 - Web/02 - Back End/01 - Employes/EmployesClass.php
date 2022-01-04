<?php


class Employes
{

    private $_nom;
    private $_prenom;
    private $_dateEmb;
    private $_fonction;
    private $_salaire;
    private $_service;
    private $_agence;
    private $_enfants = [];

    /******************Accesseurs********************** */

    
    public function getNom()
    {
        return $this->_nom;
    }

    public function setNom(string $nom)
    {
        $this->_nom = $nom;
    }

    public function getPrenom()
    {
        return $this->_prenom;
    }

    public function setPrenom(string $prenom)
    {
        $this->_prenom = $prenom;
    }

    public function getDateEmb()
    {
        return $this->_dateEmb;
    }

    public function setDateEmb(DateTime $dateEmb)
    {
        $this->_dateEmb = $dateEmb;
    }

    public function getFonction()
    {
        return $this->_fonction;
    }

    public function setFonction(string $fonction)
    {
        $this->_fonction = $fonction;
    }

    public function getSalaire()
    {
        return $this->_salaire;
    }

    public function setSalaire(string $salaire)
    {
        $this->_salaire = $salaire;
    }

    public function getService()
    {
        return $this->_service;
    }

    public function setService(string $service)
    {
        $this->_service = $service;
    }

    public function getAgence()
    {
        return $this->_agence;
    }

    public function setAgence(Agences $agence)
    {
        $this->_agence = $agence;
    }

    public function getEnfants()
    {
        return $this->_enfants;
    }

    public function setEnfants(Array $enfants)
    {
        $this->_enfants = $enfants;
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
        foreach ($data as $key => $value) {
            $methode = "set" . ucfirst($key); //ucfirst met la 1ere lettre en majuscule
            if (is_callable(([$this, $methode]))) // is_callable verifie que la methode existe
            {
                $this->$methode($value);
            }
        }
    }

    /*****************Autres Méthodes***************** */

    public function anciennete()
    {
        $aujd = new DateTime("now");
        $aujd->format("Y-mm-dd");
        return date_diff($this->getDateEmb(),$aujd)->format("%y");
    }

    private function primeSalaireAnnuel()
    {
        return $this->getSalaire()*0.05;
    }

    private function primeAnciennete()
    {
        return ($this->getSalaire()*0.02)*$this->anciennete();
    }

    public function prime()
    {
        return Round($this->primeSalaireAnnuel()+$this->primeAnciennete(),2);
    }


    public static function compareTo($emp1, $emp2)
    {
        if ($emp1->getNom() < $emp2->getNom())
        {
            return -1;
        } else if ($emp1->getNom() > $emp2->getNom()){
            return 1;
        } else {
            if ($emp1->getPrenom() > $emp2->getPrenom())
            {
                return 1;
            } else if ($emp1->getPrenom() < $emp2->getPrenom())   
            {
                return -1;
            }            
        }
        return 0;
    }

    public static function compareToServices($emp1, $emp2)
    {
        if ($emp1->getService() < $emp2->getService())
        {
            return -1;
        } else if ($emp1->getService() > $emp2->getService()){
            return 1;
        } else {
            return self::compareTo($emp1, $emp2);      
        }
        return 0;
    }

    public function chequeVacances()
    {
        if ($this->anciennete() >= 1)
        {
            return true;
        }
        return false;
    }

    public function chequeNoel()
    {
        $tab = ["20" => 0, "30" => 0, "50" => 0];

        foreach($this->getEnfants() as $unEnfant)
        {
            if($unEnfant->chequeNoel() != 0)
                $tab[$unEnfant->chequeNoel()]++;
        }
        return $tab;
    }


}
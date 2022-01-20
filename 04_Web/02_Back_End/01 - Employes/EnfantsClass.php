<?php

class Enfants
{

    private $_prenom;
    private $_ddn;

    /******************Accesseurs************************/
    public function getPrenom()
    {
        return $this->_prenom;
    }

    public function setPrenom(string $prenom)
    {
        $this->_prenom = $prenom;
    }

    public function getDDN()
    {
        return $this->_ddn;
    }

    public function setDDN($ddn)
    {
        $this->_ddn = $ddn;
    }
    /*****************Constructeur********************/

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

    public function Age()
    {
        $aujd = new DateTime("now");
        $aujd->format("Y-mm-dd");
        return date_diff($this->getDDN(), $aujd)->format("%y");
    }

    public function chequeNoel()
    {
        $age = $this->Age();
        switch ($age) {
            case $age <= 10:
                return 20;
                break;
            case $age <= 15:
                return 30;
                break;
            case $age <= 18:
                return 50;
                break;
            default:
                return 0;
                break;
        }
    }
}

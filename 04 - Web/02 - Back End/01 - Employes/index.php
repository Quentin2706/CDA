<?php

require "EmployesClass.php";
require "EnfantsClass.php";
require "AgencesClass.php";

$a[] = new Agences(["nom" => "gryffondor", "adresse" => "11 rue du chateau","codePostal" => "4535", "ville" => "poudlard", "restauration" => true]);
$a[] = new Agences(["nom" => "Poufsouffle", "adresse" => "30 rue des paumés","codePostal" => "4535", "ville" => "le dortoir", "restauration" => false]);

$enf[] = new Enfants(["prenom" => "Jean", "DDN" => new DateTime("2020-06-21")]);
$enf[] = new Enfants(["prenom" => "Jacques", "DDN" => new DateTime("2005-06-21")]);
$enf[] = new Enfants(["prenom" => "Jean", "DDN" => new DateTime("2001-06-21")]);
$enf[] = new Enfants(["prenom" => "Jacques", "DDN" => new DateTime("2007-06-21")]);


$emp[] = new Employes(["nom" => "dupont", "prenom" => "toto", "dateEmb" => new DateTime("2021-06-21"), "fonction" => "secrétaire", "salaire" => 30.30, "Service" => "Administration", "agence" => $a[0], "enfants" => [$enf[0], $enf[1], $enf[2]]]);
$emp[] = new Employes(["nom" => "dupont", "prenom" => "tuto", "dateEmb" => new DateTime("2015-03-12"), "fonction" => "soudeur", "salaire" => 10.30, "Service" => "Artisanat", "agence" => $a[0]]);
$emp[] = new Employes(["nom" => "dupond", "prenom" => "toto", "dateEmb" => new DateTime("2002-01-20"), "fonction" => "jockey", "salaire" => 340.30, "Service" => "Hippique", "agence" => $a[1], "enfants" => [$enf[3]]]);
$emp[] = new Employes(["nom" => "dupont", "prenom" => "toto", "dateEmb" => new DateTime("1999-07-09"), "fonction" => "chercheur", "salaire" => 323.30, "Service" => "Nucléaire", "agence" => $a[1]]);
$emp[] = new Employes(["nom" => "dupont", "prenom" => "toto", "dateEmb" => new DateTime("1970-04-23"), "fonction" => "plombier", "salaire" => 30.60, "Service" => "Plomberie", "agence" => $a[0]]);

/******** Montant des primes de chaques employés ********* */

/*****  Transfert a la banque  ********/
$aujd = new DateTime("now");
$anneCourante = $aujd->format("Y");

if (new DateTime("now") == new DateTime($anneCourante . "-12-31")) {
    echo "<div>Transfert effectué à la banque avec succès.</div><br/>";
    foreach ($emp as $elt) {
        echo "<div>" . $elt->getNom() . " " . $elt->getPrenom() . " montant de la prime : " . $elt->prime() . "</div>";
    }
}
/**************************************/

echo "<div>Il y a ".count($emp)." employés inscrits.</div>";

usort($emp, array("Employes","compareTo"));

foreach ($emp as $elt) {
    echo "<div>" . $elt->getNom() . " " . $elt->getPrenom() . "</div>";
}

usort($emp, array("Employes","compareToServices"));

foreach ($emp as $elt) {
    echo "<div>" . $elt->getNom() . " " . $elt->getPrenom() ." ".$elt->getService(). "</div>";
}

$montant = 0;

foreach ($emp as $elt) {
   $montant += $elt->getSalaire();
}

echo"<div>Montant de la masse salariale totale : ".$montant."</div>";

foreach ($emp as $elt) {
    echo "<div>" . $elt->getNom() . " " . $elt->getPrenom() ." ".$elt->getService()." Mode de restauration : ". $elt->getAgence()->getNom()." ";
    echo $elt->getAgence()->getRestauration() ? "Restaurant disponible" : "tickets restaurants";
    echo "</div>";
    echo"<div>Chèques vacances :";
    echo $elt->chequeVacances() ? " Oui" : " Non";
    echo"</div>";

    $cheques = $elt->chequeNoel();

    if (array_sum($cheques) != 0)
    {
        echo "<div>cheques noel :</div>";

        foreach($cheques as $key => $value)
        {
            if ($value != 0)
                echo "<div>".$value." "."chèque de ".$key." Euros</div>";
        }

    } else {
        echo "<div>cheques noel : Non</div>";
    }


}







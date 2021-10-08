<?php
    $xml = simplexml_load_file("test.xml");
    $json = json_encode($xml);;
    $myArray = json_decode($json,true);

    var_dump ($myArray);

    /*
    MyArray['Table'][i]['Name'] => name = Nom de la table
    MyArray['Table'][i]['Column'] => C'est un Tableau avec des tableaux qui seront les colonnes de la table
    MyArray['Table'][i]['Column'][i]['Name'] => Nom de la colonne
    MyArray['Table'][i]['Column'][i]['Type'] => Type de la colonne
    MyArray ['Table][i]['PK'][0]['Key'] => les clés primaires /!\ si la clé primaire contient une ',' c'est une table associative !
    MyArray ['Table][i]['FK'][i]['Key'] => le nom de la clé étrangère
    MyArray ['Table][i]['FK'][i]['Reference'] => nom de la références (c'est le truc qui a apres references en SQL)
    */
    $SQLFile = fopen($myArray['Name'].'.sql', 'w');

    $SQLSnippet = "DROP DATABASE IF EXISTS ".$myArray['Name'].';'
    ."\nCREATE DATABASE ".$myArray['Name'].';'
    ."\nUSE ".$myArray['Name'].';';

    //var_dump (count($myArray['Table']));
    for ($i=0;$i<count($myArray['Table']);$i++)
    {
        $SQLSnippet .= "\n#========================================\n
        # Table : ".$myArray['Table'][$i]['Name']."
        \n#========================================\n";

        //var_dump($myArray['Table'][$i]['Name']);

        // for ($j=0;$j<count($myArray['Table'][$i]['Column']);$j++)
        // {
        //     // var_dump($myArray['Table'][$i]['Column'][$j]['Name']);
        // }
    }

fputs($SQLFile, $SQLSnippet);
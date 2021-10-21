1.	Afficher les noms de département
SELECT nomdep FROM departement

2.	Afficher les numéros et noms de département
SELECT nodep, nomdep FROM departement

3.	Afficher toutes les propriétés des employés
SELECT * FROM employe

4.	Afficher les fonctions des employés
SELECT fonction FROM employe

5.	Afficher les fonctions des employés sans double
SELECT DISTINCT fonction FROM employe

6.	Afficher les noms des employés avec leur date dembauche, ainsi que la date dembauche augmentée d'une journée
SELECT nomemp, datemb, DATE_FORMAT(datemb+1, "%Y-%m-%d") as "datemb + 1" FROM employe

7.	Afficher les noms des employés suivis d'un espace, suivi de leur fonction
SELECT CONCAT(nomemp, « »,fonction) as "nomep + fonction" FROM employe

1.	Donner la liste des numéros et noms des employés du département 30
SELECT noemp, nomemp FROM employe WHERE nodep = 30

2.	Donner la liste des numéros et noms des ouvriers ainsi que leur numéro de département
SELECT noemp, nomemp, nodep FROM employe WHERE fonction = "ouvrier"

3.	Donner les noms et numéros des départements dont le numéro est supérieur ou égal à 30
SELECT nomemp, nodep FROM employe WHERE nodep >= 30

4.	Donner les noms, salaires et commissions des employés dont la commission excède le salaire
SELECT nomemp, sala, comm FROM employe WHERE comm > sala

5.	Donner les noms et salaires des vendeurs du département 30 dont le salaire est supérieur à 1500 €
SELECT nomemp, sala FROM employe WHERE fonction = "vendeur" AND nodep = 30 AND sala > 1500

6.	Donner la liste des noms, fonctions et salaires des directeurs et des présidents
SELECT nomemp, fonction, sala FROM employe WHERE fonction = "directeur" OR  fonction = "president"

7.	Donner la liste des noms, fonctions et salaires des directeurs et des employés qui ont un salaire > 2500 €
SELECT nomemp, fonction, sala FROM employe WHERE fonction = "directeur" OR sala > 2500

8.	Donner la liste des noms, numéros de département des directeurs et des ouvriers du département 10
SELECT nomemp, nodep FROM employe WHERE (fonction = "directeurs" OR fonction = "ouvrier") AND nodep = 10

9.	Donner la liste des noms, fonctions et numéros de département des employés du département 10 qui ne sont ni ouvrier ni directeur
SELECT nomemp, fonction, nodep FROM employe WHERE nodep = 10 AND fonction NOT IN ("ouvrier","directeur")

10.	Donner la liste des noms, fonctions et numéros de département des directeurs qui ne sont pas directeur dans le département 30
SELECT nomemp, fonction, nodep FROM employe WHERE fonction = "directeur" AND nodep <> 30

11.	Donner la liste des noms, fonctions et salaires des employés qui gagnent entre 1200 € et 1300 €
SELECT nomemp, fonction, sala FROM employe WHERE sala BETWEEN 1200 AND 1300

12.	Donner la liste des noms, numéros de département et fonctions des employés
« ouvrier », « analyste » ou « vendeur »
SELECT nomemp, nodep, fonction FROM employe WHERE fonction IN ("ouvrier", "analyste", "vendeur")

13.	Donner les employés qui ne sont pas "vendeur"
SELECT * FROM employe WHERE fonction <> "vendeur"

14.	Donner la liste des employés dont la première lettre du nom est un "C"
SELECT * FROM employe WHERE nomemp LIKE "C%"

15.	Donner la liste des employés qui n ont pas de commission
SELECT * FROM employe WHERE comm = 0 OR comm = null

16.	Donner la liste des employés qui ont une commission et qui sont dans le département 30 ou 20
SELECT * FROM employe WHERE (comm <> 0 OR comm = null) AND nodep IN (30,20) 


1.	Donner la liste des salaires, fonctions et noms des employés du département 30, selon l ordre croissant des salaires
SELECT sala, fonction, nomemp FROM employe WHERE nodep = 30 ORDER BY sala

2.	Donner la liste des salaires, fonctions et noms des employés du département 30, selon l ordre décroissant des salaires
SELECT sala, fonction, nomemp FROM employe WHERE nodep = 30 ORDER BY sala DESC

3.	Donner la liste des employés triée selon l ordre croissant des fonctions et l ordre décroissant des salaires
SELECT * FROM employe ORDER BY fonction, sala DESC

4.	Donner la liste des commissions, salaires et noms triée selon l ordre croissant des commissions
SELECT comm, sala, nomemp FROM employe ORDER BY comm 


5.	Donner la liste des commissions, salaires et noms triée selon l ordre décroissant des commissions
SELECT comm, sala, nomemp FROM employe ORDER BY comm DESC


1.	Donner la ville dans laquelle travaille Costanza
SELECT ville FROM employe INNER JOIN departement ON employe.nodep = departement.nodep WHERE nomemp = "Costanza"

2.	Donner les noms, fonctions, et noms des départements des employés des départements 30 et 40
SELECT nomemp, fonction, nomdep FROM employe INNER JOIN departement ON employe.nodep = departement.nodep WHERE departement.nodep IN (30,40) 
 

3.	Donner le grade, la fonction, le nom et le salaire de chaque employé
SELECT (SELECT nograde FROM grade WHERE e.sala BETWEEN salmin AND salmax) as nograde, fonction, nom, sala FROM employe as e

4.	Donner la liste des noms et salaires des employés qui gagnent plus que leur responsable
SELECT nomemp, sala FROM employe as t WHERE sala > (SELECT sala FROM employe WHERE noemp = t.noresp)

5.	Donner la liste des noms, salaires, fonctions des employés qui gagnent plus que Perou
SELECT nomemp, sala, fonction FROM employe WHERE sala > (SELECT sala FROM employe WHERE nomemp = "Perou");



1.	Donner les noms, salaires, commissions et revenus des vendeurs
SELECT nomemp, sala, comm, ROUND((sala + comm),2) as revenus FROM employe WHERE fonction = "vendeur";

2.	Donner les noms, salaires et les commissions des employés dont la commission est supérieure à 25% de leur salaire
SELECT nomemp, sala, comm FROM employe WHERE comm => sala*0.25;

3.	Donner la liste des vendeurs dans l ordre décroissant de leur commission divisée par leur salaire
SELECT nomemp, fonction, comm/sala as "pourcentage par rapport au sala" FROM employe WHERE fonction = "vendeur" ORDER BY "pourcentage par rapport au sala"

4.	Donner le revenu annuel de chaque vendeur
SELECT nomemp, ((sala*12)+comm) as "revenu annuel" FROM employe WHERE fonction = "vendeur"

5.	Donner le salaire quotidien des vendeurs
SELECT nomemp, (sala/30) as "salaire quotidien" FROM employe WHERE fonction = "vendeur"

6.	Donner la moyenne des salaires des ouvriers
SELECT ROUND(AVG(sala),2) FROm employe WHERE fonction = "ouvrier";

7.	Donner le total des salaires et des commissions des vendeurs
SELECT SUM(sala) as "salaires totaux", SUM(comm) as "commissions totales" FROM employe WHERE fonction = "vendeur"

8.	Donner le revenu annuel moyen de tous les vendeurs
SELECT AVG((sala*12)+comm) as "revenu annuel" FROM employe WHERE fonction = "vendeur" 

9.	Donner le plus haut salaire, le plus bas et l écart entre les deux
SELECT MIN(sala) as minsala, MAX(sala) as maxsala, MAX(sala)-MIN(sala) as diffsala FROM employe 

10.	Donner le nombre d employés du département 30
SELECT COUNT(*) as nbinnodep30 FROM employe WHERE nodep = 30


1.	Donner la moyenne des salaires pour chaque département
SELECT AVG(sala) as moysala, nodep FROM employe GROUP BY nodep

2.	Donner pour chaque département, le salaire annuel moyen des employés qui ne sont ni directeur ni président
SELECT AVG(sala*12) as moysala, nodep FROM employe WHERE fonction NOT IN ("directeur", "president") GROUP BY nodep

3.	Donner pour chaque fonction de chaque département le nombre d employés et le salaire annuel moyen
SELECT count(*), AVG(sala*12) as moysala, nodep, fonction FROM employe GROUP BY nodep,fonction 

4.	Donner la liste des salaires annuels moyens pour les fonctions comportant plus de deux employés
SELECT AVG(sala*12) as moysala, fonction FROM employe GROUP BY fonction HAVING count(*) > 2

5.	Donner la liste des départements avec au moins deux ouvriers
SELECT departement.nodep, nomdep FROM employe INNER JOIN departement ON employe.nodep = departement.nodep GROUP BY nodep HAVING count(noemp) >= 2 AND fonction = "ouvrier"  

6.	Donner les salaires moyens des présidents, directeurs et responsables
SELECT AVG(sala) as moysala, fonction FROM employe WHERE fonction IN ("president", "responsable", "directeur") GROUP BY fonction 



1.	Donner les noms et fonctions des employés qui gagnent plus que "Bibaut";
SELECT nomemp, fonction FROm employe WHERE sala > (SELECT sala FROm employe WHERE nomemp = "Bibaut");

2.	Donner les fonctions dont la moyenne des salaires est supérieure à la moyenne SALAIRES des "vendeurs";

SELECT e.fonction, AVG(e.sala) FROM employe as e GROUP BY fonction HAVING AVG(e.sala) > (SELECT AVG(sala) FROM employe WHERE fonction = "vendeur") 

3.	Donner les noms des départements des employés qui gagnent plus de 2 700 € ;
SELECT employe.nodep, nomdep FROM employe INNER JOIN departement ON employe.nodep = departement.nodep GROUP BY nodep HAVING MAX(sala) > 2700

4.	Déterminer le salarié le plus ancien
SELECT * FROM employe WHERE datemb = (SELECT MIN(datemb) FROM employe)

5.	Déterminer le dernier salarié embauché
SELECT * FROM employe WHERE datemb = (SELECT MAX(datemb) FROM employe)

6.	Afficher la liste des employés responsables dautres employés.
SELECT * FROM employe WHERE noemp IN (SELECT DISTINCT noresp FROM employe)

7.	Donner les employés qui ont occupé les fonctions de vendeur et de directeur
SELECT * FROM employe WHERE noemp IN (SELECT DISTINCT noemp FROM histofonction WHERE fonction IN ("vendeur", "directeur"))

8.	Donner les noms des employés (avec leur numéro de département et leur salaire) qui gagnent plus que la moyenne des employés de leur département
SELECT nomemp, nodep, sala FROM employe as e WHERE sala > (SELECT AVG(sala) FROM employe WHERE e.nodep = nodep)

DELIMITER $$
CREATE PROCEDURE C cado 20 pour tout le monde()
BEGIN 
UPDATE avoir_note SET note=20;
END$$
DELIMITER ;

CREATE VIEW EtudiantsNoteEpreuves AS
SELECT
    e.idEtudiant,
    e.nomEtudiant,
    e.prenomEtudiant,
    e.adresseEtudiant,
    e.villeEtudiant,
    e.codePostalEtudiant,
    e.telephoneEtudiant,
    e.dateEntreeEtudiant,
    e.anneeEtudiant,
    e.remarqueEtudiant,
    e.sexeEtudiant,
    e.dateNaissanceEtudiant,
    a.idAvoirNote,
    a.note,
    ep.idEpreuve,
    ep.libelleEpreuve,
    ep.idEnseignantEpreuve,
    ep.idMatiereEpreuve,
    ep.dateEpreuve,
    ep.CoefficientEpreuve,
    ep.anneeEpreuve
FROM
    etudiants as e
    INNER JOIN avoir_note as a ON e.idEtudiant = a.idEtudiant
    INNER JOIN epreuves as ep ON a.idEpreuve = ep.idEpreuve

CREATE VIEW yatoula AS
SELECT
    e.idEtudiant,
    e.nomEtudiant,
    e.prenomEtudiant,
    e.adresseEtudiant,
    e.villeEtudiant,
    e.codePostalEtudiant,
    e.telephoneEtudiant,
    e.dateEntreeEtudiant,
    e.anneeEtudiant,
    e.remarqueEtudiant,
    e.sexeEtudiant,
    e.dateNaissanceEtudiant,
    a.idAvoirNote,
    a.note,
    ep.idEpreuve,
    ep.libelleEpreuve,
    ep.idEnseignantEpreuve,
    ep.idMatiereEpreuve,
    ep.dateEpreuve,
    ep.CoefficientEpreuve,
    ep.anneeEpreuve,
    ens.nomEnseignant,
    ens.prenomEnseignant,
    ens.fonctionEnseignant,
    ens.adresseEnseignant,
    ens.villeEnseignant,
    ens.codePostalEnseignant,
    ens.telephoneEnseignant,
    ens.dateNaissanceEnseignant,
    ens.dateEmbaucheEnseignant,
    mat.nomMatiere,
    mat.idModule,
    mat.coefficientMatiere,
    modu.nomModule,
    modu.coefficientModule,
    fc.idFaireCours,
    fc.annee

FROM
    etudiants as e
    INNER JOIN avoir_note as a ON e.idEtudiant = a.idEtudiant
    INNER JOIN epreuves as ep ON a.idEpreuve = ep.idEpreuve
    INNER JOIN enseignants as ens ON ep.idEnseignantEpreuve = ens.idEnseignant
    INNER JOIN matieres as mat ON ep.idMatiereEpreuve = mat.idMatiere
    INNER JOIN modules as modu ON mat.idModule = modu.idModule
    INNER JOIN faire_cours as fc ON mat.idMatiere = fc.idMatiere
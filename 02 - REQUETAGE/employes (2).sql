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

6.	Afficher les noms des employés avec leur date d'embauche, ainsi que la date d'embauche augmentée d'une journée
SELECT nomemp, datemb, datemb+1 FROM employe

7.	Afficher les noms des employés suivis d'un espace, suivi de leur fonction
SELECT CONCAT(nomemp, « »,fonction) FROM employe

1.	Donner la liste des numéros et noms des employés du département 30
SELECT noemp, nomemp FROM employe WHERE nodep = 30

2.	Donner la liste des numéros et noms des ouvriers ainsi que leur numéro de département
SELECT noemp, nomemp, nodep FROM employe WHERE fonction = "ouvrier"

3.	Donner les noms et numéros des départements dont le numéro est supérieur ou égal à 30
SELECT nomemp, nodep FROM employe WHERE nodep >= 30

4.	Donner les noms, salaires et commissions des employés dont la commission excède le salaire
SELECT nomemp, sala, comm FROM employe WHERE comm > salaire

5.	Donner les noms et salaires des vendeurs du département 30 dont le salaire est supérieur à 1500 €
SELECT nomemp, sala FROM employe WHERE fonction = "vendeur" AND nodep = 30 AND sala > 1500

6.	Donner la liste des noms, fonctions et salaires des directeurs et des présidents
SELECT nomemp, fonction, sala FROM employe WHERE fonction = "directeur" AND  fonction = "presidents"

7.	Donner la liste des noms, fonctions et salaires des directeurs et des employés qui ont un salaire > 2500 €
SELECT nomemp, fonction, sala FROM employe WHERE fonction = "directeur" OR sala > 2500

8.	Donner la liste des noms, numéros de département des directeurs et des ouvriers du département 10
SELECT nomemp, nodep FROM employe WHERE fonction = "directeurs" AND fonction = "directeurs" AND nodep = 10

9.	Donner la liste des noms, fonctions et numéros de département des employés du département 10 qui ne sont ni ouvrier ni directeur
SELECT nomemp, fonction, nodep FROM employe WHERE nodep = 10 AND fonction IS NOT "ouvrier" OR "directeur"

10.	Donner la liste des noms, fonctions et numéros de département des directeurs qui ne sont pas directeur dans le département 30
SELECT nomemp, fonction, nodep FROM employe WHERE fonction = "directeur" AND IS NOT nodep = 30

11.	Donner la liste des noms, fonctions et salaires des employés qui gagnent entre 1200 € et 1300 €
SELECT nomemp, fonction, sala FROM employe WHERE sala BETWEEN 1200 AND 1300

12.	Donner la liste des noms, numéros de département et fonctions des employés
« ouvrier », « analyste » ou « vendeur »
SELECT nomemp, nodep, fonction FROM employe WHERE fonction IN ("ouvrier", "analyste", "vendeur")

13.	Donner les employés qui ne sont pas "vendeur"
SELECT * FROM employe WHERE fonction IS NOT "vendeur"

14.	Donner la liste des employés dont la première lettre du nom est un "C"
SELECT * FROM employe WHERE nomemp LIKE "C%"

15.	Donner la liste des employés qui n ont pas de commission
SELECT * FROM employe WHERE comm = ""

16.	Donner la liste des employés qui ont une commission et qui sont dans le département 30 ou 20
SELECT * FROM employe WHERE comm <> "" AND nodep IN (30,20) 



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
SELECT ville FROM employe INNER JOIN departement employe.nodep = departement.nodep WHERE nomemp = "Costanza"

2.	Donner les noms, fonctions, et noms des départements des employés des départements 30 et 40
SELECT nomemp, fonction, nomdep FROM employe INNER JOIN departement employe.nodep = departement.nodep WHERE departement.nodep IN (30,40) 
 
-- A REVOIR
3.	Donner le grade, la fonction, le nom et le salaire de chaque employé
SELECT grade, fonction, nom, sala FROM employe INNER JOIN grade ON employe.nograde = grade.nograde

4.	Donner la liste des noms et salaires des employés qui gagnent plus que leur responsable
SELECT nomemp, sala FROM employe 

5.	Donner la liste des noms, salaires, fonctions des employés qui gagnent plus que Perou

E.	Requêtes avec fonctions et expressions numériques

1.	Donner les noms, salaires, commissions et revenus des vendeurs
2.	Donner les noms, salaires et les commissions des employés dont la commission est supérieure à 25% de leur salaire
3.	Donner la liste des vendeurs dans l'ordre décroissant de leur commission divisée par leur salaire
4.	Donner le revenu annuel de chaque vendeur
5.	Donner le salaire quotidien des vendeurs
6.	Donner la moyenne des salaires des ouvriers
7.	Donner le total des salaires et des commissions des vendeurs
8.	Donner le revenu annuel moyen de tous les vendeurs
9.	Donner le plus haut salaire, le plus bas et l'écart entre les deux
10.	Donner le nombre d'employés du département 30


F.	Requêtes avec clause « group by »

1.	Donner la moyenne des salaires pour chaque département
2.	Donner pour chaque département, le salaire annuel moyen des employés qui ne sont ni directeur ni président
3.	Donner pour chaque fonction de chaque département le nombre d'employés et le salaire annuel moyen
4.	Donner la liste des salaires annuels moyens pour les fonctions comportant plus de deux employés
5.	Donner la liste des départements avec au moins deux ouvriers
6.	Donner les salaires moyens des présidents, directeurs et responsables


G.	Requêtes imbriquées

1.	Donner les noms et fonctions des employés qui gagnent plus que "Bibaut";
2.	Donner les fonctions dont la moyenne des salaires est supérieure à la moyenne des "vendeurs";
3.	Donner les noms des départements des employés qui gagnent plus de 2 700 € ;
4.	Déterminer le salarié le plus ancien
5.	Déterminer le dernier salarié embauché
6.	Afficher la liste des employés responsables d'autres employés.
7.	Donner les employés qui ont occupé les fonctions de vendeur et de directeur
8.	Donner les noms des employés (avec leur numéro de département et leur salaire) qui gagnent plus que la moyenne des employés de leur département

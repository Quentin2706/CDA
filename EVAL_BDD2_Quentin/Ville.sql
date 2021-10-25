1.	Obtenir la liste des villes qui ont un nom d''au moins 40 lettres
SELECT * FROM villes_france WHERE LENGTH(ville_nom) >= 40

2. Obtenir la liste des départements d’outre-mer, c’est-à-dire ceux dont le numéro de département commence par “97”
SELECT * FROM departements WHERE departement_code LIKE "97%"

3.	Obtenir la liste des départements des Hauts-de-France trier par ordre alphabétique des noms de département (sans jointure)
SELECT * FROM departements WHERE departement_regionId = (SELECT region_id FROM regions WHERE region_nom = "Hauts-de-France") ORDER BY departement_nom

4.	Obtenir le nom de toutes les villes, ainsi que le nom du département associé. Les plus peuplées en 2012 apparaitront en premier
SELECT ville_nom, departement_nom FROM villes_france INNER JOIN departements ON villes_france.ville_departement = departements.departement_id GROUP BY departement_nom ORDER BY ville_population_2012 DESC

5.	Obtenir la liste du nom de chaque département, associé à son code et du nombre de commune au sein de ces départements, en triant afin d’obtenir en priorité les départements qui possèdent le plus de communes
SELECT  departement_code,departement_nom, COUNT(ville_commune) as 'nb de communes' FROM villes_france INNER JOIN departements ON villes_france.ville_departement = departements.departement_id GROUP BY departement_code ORDER BY COUNT(ville_commune) DESC

6.	Obtenir la liste des départements, classés en fonction de leur superficie (plus grand en premier)
SELECT  departement_code,departement_nom, ROUND(SUM(ville_surface),2) as 'superficie' FROM villes_france INNER JOIN departements ON villes_france.ville_departement = departements.departement_id GROUP BY departement_code ORDER BY SUM(ville_surface) DESC

7.	Compter le nombre de villes dont le nom commence par “Saint”
SELECT COUNT(*) as 'nb de ville commencant par "Saint"' FROM villes_france WHERE ville_nom LIKE "Saint%"
-- SELECT Count(*) as 'nb de ville commencant par "Saint"' FROM (SELECT ville_id FROM villes_france as v WHERE ville_nom LIKE "Saint%") as nb

8.	Obtenir la liste des villes qui ont un nom existants plusieurs fois, et trier afin d’obtenir en premier celles dont le nom est le plus souvent utilisé par plusieurs communes
SELECT ville_id, ville_nom FROM villes_france GROUP BY ville_nom HAVING COUNT(*) > 1

9.  Obtenir en une seule requête SQL la liste des villes dont la superficie est supérieure à la superficie moyenne
SELECT *, SUM(ville_surface) as 'superficie de la ville' FROM villes_france WHERE ville_surface > (SELECT AVG(ville_surface) as "superficie moyenne" FROM villes_france) GROUP BY ville_nom

10.	Obtenir la liste des départements qui possèdent plus de 1.5 millions d’habitants en 2012
SELECT departement_id, departement_nom, SUM(ville_population_2012) FROM villes_france INNER JOIN departements ON villes_france.ville_departement = departements.departement_id GROUP BY departement_nom HAVING SUM(ville_population_2012) > 1500000

11.	Remplacez les tirets par un espace vide, pour toutes les villes commençant par “SAINT-” (dans la colonne qui contient les noms en majuscule)
SELECT ville_nom, REPLACE(ville_nom,"-"," ") as "ville_nom sans tirets" FROM villes_france WHERE ville_nom LIKE "SAINT-%"

12.	Supplémentaire. Obtenir la liste des 50 villes ayant la plus faible superficie
SELECT ville_nom, ROUND(SUM(ville_surface),2) as "ville_surface" FROM villes_france GROUP BY ville_nom ORDER BY SUM(ville_surface) LIMIT 50

13.	Ajouter une colonne region_nbDepartement dans la table regions (mettre le code dans le script de réponse)
ALTER TABLE regions ADD region_nbDepartement INT

14.	Ecrire une procédure stockée (nommée MajRegion), qui vient mettre à jour cette colonne
-- je suis pas loin d'avoir trouvé
DELIMITER $$
CREATE PROCEDURE MajRegion()
BEGIN
DECLARE @minimum int;
DECLARE @maximum int;
DECLARE @X int;
SELECT @minimum=min(region_id), @maximum=max(region_id) FROM regions;

SET @X=@minimum ;
WHILE (@x <= @maximum)
SELECT @nbDept=COUNT(*) FROM departements INNER JOIN regions ON departements.departement_regionId = regions.region_id WHERE region_id=@X;
UPDATE regions SET region_nbDepartement=@nbDept WHERE region_id=@X;
END WHILE,
END$$
DELIMITER ;

15.	Créer une vue qui regroupe les 3 tables

CREATE VIEW 'regions_depts_villes' AS 
SELECT 
    r.region_id,
    r.region_nom,
    r.region_nbDepartement,
    d.departement_id,
    d.departement_code,
    d.departement_nom,
    d.departement_nom_uppercase,
    d.departement_slug,
    d.departement_nom_soundex,
    v.ville_id,
    v.ville_departement,
    v.ville_slug,
    v.ville_nom,
    v.ville_nom_simple,
    v.ville_nom_reel,
    v.ville_nom_soundex,
    v.ville_nom_metaphone,
    v.ville_code_postal,
    v.ville_commune,
    v.ville_code_commune,
    v.ville_arrondissement,
    v.ville_canton,
    v.ville_amdi,
    v.ville_population_2010,
    v.ville_population_1999,
    v.ville_population_2012,
    v.ville_densite_2010,
    v.ville_surface,
    v.ville_longitude_deg,
    v.ville_latitude_deg,
    v.ville_longitude_grd,
    v.ville_latitude_grd,
    v.ville_longitude_dms,
    v.ville_latitude_dms,
    v.ville_zmin,
    v.ville_zmax
FROM table

INNER JOIN table ON cle=cle

WHERE condition

GROUP BY colonne

HAVING condition

ORDER BY colonne ;

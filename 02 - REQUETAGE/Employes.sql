-- 1. Afficher toutes les informations concernant les employés.
SELECT * FROM `employe`

-- 2. Afficher toutes les informations concernant les dept.
SELECT * FROM `dept`

-- 3. Afficher le nom, la date d'embauche, le numéro du supérieur, le numéro de département et le salaire de tous les employés. 
SELECT nom, dateemb, nosup, salaire FROM `employe`

-- 4. Afficher le titre de tous les employés
SELECT titre FROM `employe`

-- 5. Afficher les différentes valeurs des titres des employés.
SELECT DISTINCT(titre) FROM `employe`

--6. Afficher le nom, le numéro d'employé et le numéro du département des employés dont le titre est « Secrétaire ».
SELECT nom, noemp, nodep FROM `employe` WHERE titre = "Secrétaire"

-- 7.  Afficher le nom et le numéro de département dont le numéro de département est supérieur à 40.
SELECT nom, nodept FROM dept WHERE nodept > 40

-- 8. Afficher le nom et le prénom des employés dont le nom est alphabétiquement antérieur au prénom.
SELECT nom, prenom FROM `employe` WHERE nom < prenom

-- 9. Afficher le nom, le salaire et le numéro du département des employés dont le titre est « Représentant », le numéro de département est 35 et le salaire est supérieur à 20000.
SELECT nom, salaire,nodep FROM `employe` WHERE titre = "Représentant" AND nodep  = 35 AND salaire > 20000

-- 10.Afficher le nom, le titre et le salaire des employés dont le titre est « Représentant » ou dont le titre est « Président ».
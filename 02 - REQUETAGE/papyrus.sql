-- 1. Quelles sont les commandes du fournisseur 09120 ?
SELECT numcom FROM entcom INNER JOIN fournis ON entcom.numfou = fournis.numfou WHERE fournis.numfou = 09120;

-- 2. Afficher le code des fournisseurs pour lesquels des commandes ont été passées.
SELECT entcom.numfou FROM entcom

-- 3. Afficher le nombre de commandes fournisseurs passées, et le nombre de fournisseur concernés.
SELECT count(*) as "nombre de commandes passées", count(DISTINCT(fournis.numfou)) as "nombre de fournisseurs concernés" FROM entcom 

-- 4. Editer les produits ayant un stock inférieur ou égal au stock d'alerte et dont la quantité annuelle est inférieur est inférieure à 1000(informations à fournir : n° produit, libellé produit, stock, stock actuel d'alerte, quantité annuelle)
SELECT * FROM produit WHERE stkphy <= stkale AND qteann < 1000 

-- 5. Quels sont les fournisseurs situés dans les départements 75 78 92 77 ? L’affichage (département, nom fournisseur) sera effectué par département décroissant, puis par ordre alphabétique
SELECT posfou, nomfou FROM fournis WHERE LEFT(posfou,2) in (75,78,92,77) 

-- 6. Quelles sont les commandes passées au mois de mars et avril ?
SELECT numfou FROM entcom WHERE MONTH(datcom,6,2) in (3,4)

-- 7. Quelles sont les commandes du jour qui ont des observations particulières ?(Affichage numéro de commande, date de commande)
SELECT numcom, DATE(datcom) as date FROM entcom WHERE obscom <> "" AND DATE(NOW()) = DATE(datcom);

-- 8. Lister le total de chaque commande par total décroissant (Affichage numéro de commande et total)
SELECT numcom, SUM(qtecde*priuni) as 'prix total' FROM ligcom GROUP BY numcom ORDER BY DESC;

-- 9. Lister les commandes dont le total est supérieur à 10 000€ ; on exclura dans le calcul du total les articles commandés en quantité supérieure ou égale à 1000.(Affichage numéro de commande et total)
SELECT numcom, SUM(qtecde*priuni) as 'prix total' FROM ligcom WHERE qtecde < 1000 GROUP BY numcom  HAVING SUM(qtecde*priuni) > 10000;

-- 10.Lister les commandes par nom fournisseur (Afficher le nom du fournisseur, le numéro de commande et la date)
SELECT nomfou, numcom, datcom FROM entcom INNER JOIN fournis ON entcom.numfou = fournis.numfou  

-- 11.Sortir les produits des commandes ayant le mot "urgent" en observation?(Afficher le numéro de commande, le nom du fournisseur, le libellé du produit et le sous total = quantité commandée * Prix unitaire) 
SELECT entcom.numcom, entcom.numfou, produit.libart, qtecde*priuni as total FROM entcom INNER JOIN ligcom ON entcom.numcom = ligcom.numcom INNER JOIN produit ON ligcom.codart = produit.codart WHERE obscom LIKE '%urgent%'

-- 12.Coder de 2 manières différentes la requête suivante :Lister le nom des fournisseurs susceptibles de livrer au moins un article
SELECT fournis.numfou FROM fournis INNER JOIN vente ON fournis.numfou = vente.numfou INNER JOIN produit ON vente.codart = produit.codart WHERE stkphy > 0 GROUP BY fournis.numfou

SELECT numfou FROM (SELECT fournis.numfou, stkphy as stock FROM fournis INNER JOIN vente ON fournis.numfou = vente.numfou INNER JOIN produit ON vente.codart = produit.codart) as e WHERE stock > 0 GROUP BY numfou


-- 13.Coder de 2 manières différentes la requête suivante Lister les commandes (Numéro et date) dont le fournisseur est celui de la commande 70210 :
SELECT nomfou, numcom, datcom FROM entcom INNER JOIN fournis ON entcom.numfou = fournis.numfou WHERE nomfou = (SELECT nomfou FROM entcom INNER JOIN fournis ON entcom.numfou = fournis.numfou WHERE numcom = '70210');

-- 14.Dans les articles susceptibles d’être vendus, lister les articles moins chers (basés sur Prix1) que le moins cher des rubans (article dont le premier caractère commence par R). On affichera le libellé de l’article et prix1
SELECT libart, prix1 FROM vente INNER JOIN produit ON vente.codart = produit.codart WHERE prix1 <  (SELECT MIN(prix1) FROM produit INNER JOIN vente ON produit.codart = vente.codart WHERE produit.codart LIKE 'R%' )

-- 15.Editer la liste des fournisseurs susceptibles de livrer les produits dont le stock est inférieur ou égal à 150 % du stock d'alerte. La liste est triée par produit puis fournisseur

SELECT libart, nomfou FROM fournis INNER JOIN vente ON fournis.numfou = vente.numfou INNER JOIN produit ON vente.codart = produit.codart WHERE stkphy <= stkale*1.5 GROUP BY fournis.numfou ORDER BY produit.codart, fournis.numfou


-- 16.Éditer la liste des fournisseurs susceptibles de livrer les produit dont le stock est inférieur ou égal à 150 % du stock d'alerte et un délai de livraison d'au plus 30 jours. La liste est triée par fournisseur puis produit
SELECT libart, nomfou FROM fournis INNER JOIN vente ON fournis.numfou = vente.numfou INNER JOIN produit ON vente.codart = produit.codart WHERE stkphy <= stkale*1.5 AND delliv <= 30 GROUP BY fournis.numfou ORDER BY produit.codart, fournis.numfou


-- 17.Avec le même type de sélection que ci-dessus, sortir un total des stocks par fournisseur trié par total décroissant

SELECT libart, nomfou, SUM(stkphy) as total FROM fournis INNER JOIN vente ON fournis.numfou = vente.numfou INNER JOIN produit ON vente.codart = produit.codart WHERE stkphy <= stkale*1.5 AND delliv <= 30 GROUP BY fournis.numfou ORDER BY produit.codart, fournis.numfou


-- 18.En fin d'année, sortir la liste des produits dont la quantité réellement commandée dépasse 90% de la quantité annuelle prévue.
SELECT codart FROM ligcom INNER JOIN produit ON ligcom.codart = produit.codart WHERE qtecde*90/100 > qteann


-- 19.Calculer le chiffre d'affaire par fournisseur pour l'année 93 sachant que les prix indiqués sont hors taxes et que le taux de TVA est 20%.
SELECT entcom.numcom, ROUND(SUM(qtecde*priuni)*1.2,2) as 'prix total' FROM ligcom INNER JOIN entcom ON ligcom.numcom = entcom.numcom WHERE YEAR(datcom) = 1993 GROUP BY numfou ; 

-- /*
-- 20.Existe-t-il des lignes de commande non cohérentes avec les produits vendus par 
-- les fournisseurs. ?
-- */


1. Application dune augmentation de tarif de 4% pour le prix 1, 2% pour le prix2 pour le fournisseur 9180

UPDATE vente SET prix1= prix1*1.04 , prix2= prix1*1.02 WHERE numfou = 9180

2. Dans la table vente, mettre à jour le prix2 des articles dont le prix2 est null, en affectant a valeur de prix.
UPDATE vente SET prix2= prix1 WHERE prix2 = 0 

3. Mettre à jour le champ obscom en positionnant ***** pour toutes les commandes dont le fournisseur a un indice de satisfaction <5
UPDATE entcom INNER JOIN fournis ON entcom.numfou = fournis.numfou SET  obscom = '*****'  WHERE satisf < 5
UPDATE entcom SET  obscom = '*****'  WHERE numfou in (SELECT numfou FROM fournis WHERE satisf < 5 )


4. Suppression du produit I110
DELETE FROM produit WHERE codart = 'I110';

5. Suppression des entête de commande qui n'ont aucune ligne
DELETE FROM entcom WHERE numcom not in (SELECT DISTINCT numcom FROM ligcom);


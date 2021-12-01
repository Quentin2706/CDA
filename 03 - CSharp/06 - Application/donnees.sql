INSERT INTO `typesproduits`(`IdTypeProduit`, `LibelleTypeProduit`) VALUES (null,"Alimentaire");
INSERT INTO `typesproduits`(`IdTypeProduit`, `LibelleTypeProduit`) VALUES (null,"non Alimentaire");
INSERT INTO `typesproduits`(`IdTypeProduit`, `LibelleTypeProduit`) VALUES (null,"Hygiène");

INSERT INTO `categories`(`IdCategorie`, `LibelleCategorie`, `IdTypeProduit`) VALUES (null,"bébé",3);
INSERT INTO `categories`(`IdCategorie`, `LibelleCategorie`, `IdTypeProduit`) VALUES (null,"détergents",3);
INSERT INTO `categories`(`IdCategorie`, `LibelleCategorie`, `IdTypeProduit`) VALUES (null,"Jouet",2);
INSERT INTO `categories`(`IdCategorie`, `LibelleCategorie`, `IdTypeProduit`) VALUES (null,"Conserve",1);
INSERT INTO `categories`(`IdCategorie`, `LibelleCategorie`, `IdTypeProduit`) VALUES (null,"surgelés",1);
INSERT INTO `categories`(`IdCategorie`, `LibelleCategorie`, `IdTypeProduit`) VALUES (null,"non perissable",1);

INSERT INTO `articles`(`IdArticle`, `LibelleArticle`, `QuantiteStockee`, `IdCategorie`) VALUES (null,"Pates",30,6);
INSERT INTO `articles`(`IdArticle`, `LibelleArticle`, `QuantiteStockee`, `IdCategorie`) VALUES (null,"Jeu enfant +2 ans",5,3);
INSERT INTO `articles`(`IdArticle`, `LibelleArticle`, `QuantiteStockee`, `IdCategorie`) VALUES (null,"Cassoulet",46,4);
INSERT INTO `articles`(`IdArticle`, `LibelleArticle`, `QuantiteStockee`, `IdCategorie`) VALUES (null,"Antibact'",94,2);
INSERT INTO `articles`(`IdArticle`, `LibelleArticle`, `QuantiteStockee`, `IdCategorie`) VALUES (null,"Frites surgelées",24,5);
INSERT INTO `articles`(`IdArticle`, `LibelleArticle`, `QuantiteStockee`, `IdCategorie`) VALUES (null,"Mustela",64,1);


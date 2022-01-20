<body class="colonne">
    <header>
        <div class="mini"><img src="./IMG/logo.png" class="" alt="logo"></div>
        <div class="titre center"><h1><?php echo $titre; ?></h1></div>
        <div class="colonne mini">
            <?php

            if (isset($_SESSION['utilisateur'])) {
                echo '<div class="center">'. texte('Bonjour') ." ". $_SESSION['utilisateur']->getNom() . '</div>';
                echo '<div><a href="index.php?page=actionDeconnexion" class="center">'. texte("Deconnection") .'</a></div>';
            } else {
                echo '<a href="index.php?page=connection" class="center">'. texte("Connexion") .'</a>';
            }
            ?>

        </div>
    </header>
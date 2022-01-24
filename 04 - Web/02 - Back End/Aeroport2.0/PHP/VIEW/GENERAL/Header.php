<body class="colonne">
    <header>
        <div><img src="./IMG/logo.png" alt="image de marque"></div>
        <div class="titre center"><h1><?php echo $titre; ?></h1></div>
        <div class="colonne">
            <?php
            
            if (isset($_SESSION['utilisateur'])) {
                echo '<div class="center ">'. texte('Bonjour') ." ". $_SESSION['utilisateur']->getNom() . '</div>';
                echo '<div><a href="index.php?page=ActionDeconnexion" class="center" id="btn-connect-header"><button type="button" >'. texte("Deconnexion") .'</button></a></div>';
            } else {
                echo '<a href="index.php?page=Default" class="center">'. texte("Connexion") .'</a>';
            }
            ?>
        </div>
    </header>
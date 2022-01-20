<?php
echo '<main>';
echo '<div class="flex-0-1"></div>';
echo '<div>';
echo '<div class="GridForm">';

echo '<form action="index.php?page=utilisateursAction&mode="'.$_GET['mode'].'" methode="post"/>';

echo '<div class="caseForm titreGridForm">Formulaire utilisateurs</div>';
echo '<div class="caseForm">idUtilisateur</div>';
echo '<div class="caseForm"><input type="text" name="idUtilisateur"></div>';
echo '<div class="caseForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm"><i class="fas fa-check-circle"></i></div>';

echo '<div class="caseForm">nom</div>';
echo '<div class="caseForm"><input type="text" name="nom"></div>';
echo '<div class="caseForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm"><i class="fas fa-check-circle"></i></div>';

echo '<div class="caseForm">prenom</div>';
echo '<div class="caseForm"><input type="text" name="prenom"></div>';
echo '<div class="caseForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm"><i class="fas fa-check-circle"></i></div>';

echo '<div class="caseForm">motDePasse</div>';
echo '<div class="caseForm"><input type="text" name="motDePasse"></div>';
echo '<div class="caseForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm"><i class="fas fa-check-circle"></i></div>';

echo '<div class="caseForm">adresseMail</div>';
echo '<div class="caseForm"><input type="text" name="adresseMail"></div>';
echo '<div class="caseForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm"><i class="fas fa-check-circle"></i></div>';

echo '<div class="caseForm">role</div>';
echo '<div class="caseForm"><input type="text" name="role"></div>';
echo '<div class="caseForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm"><i class="fas fa-check-circle"></i></div>';

echo '<div class="caseForm">pseudo</div>';
echo '<div class="caseForm"><input type="text" name="pseudo"></div>';
echo '<div class="caseForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm"><i class="fas fa-check-circle"></i></div>';

echo '<div class="caseForm titreGridForm"> 
	<div></div>
	<a href="index.php?page=ListeUtilisateurs"><i class="fas fa-sign-out-alt fa-rotate-180"></i></a>
	<div class="flex-0-1"></div>
	<button type="submit"><i class="fas fa-paper-plane"></i></button>
	<div></div>
	</div>';

echo'</form>';

echo '</div>';
echo '</div>';
echo '<div class="flex-0-1"></div>';
echo '</main>';
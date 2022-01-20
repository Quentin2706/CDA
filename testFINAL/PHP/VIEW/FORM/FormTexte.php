<?php
echo '<main>';
echo '<div class="flex-0-1"></div>';
echo '<div>';
echo '<div class="GridForm">';

echo '<form action="index.php?page=texteAction&mode="'.$_GET['mode'].'" methode="post"/>';

echo '<div class="caseForm titreGridForm">Formulaire texte</div>';
echo '<div class="caseForm">idTexte</div>';
echo '<div class="caseForm"><input type="text" name="idTexte"></div>';
echo '<div class="caseForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm"><i class="fas fa-check-circle"></i></div>';

echo '<div class="caseForm">codeTexte</div>';
echo '<div class="caseForm"><input type="text" name="codeTexte"></div>';
echo '<div class="caseForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm"><i class="fas fa-check-circle"></i></div>';

echo '<div class="caseForm">fr</div>';
echo '<div class="caseForm"><input type="text" name="fr"></div>';
echo '<div class="caseForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm"><i class="fas fa-check-circle"></i></div>';

echo '<div class="caseForm">en</div>';
echo '<div class="caseForm"><input type="text" name="en"></div>';
echo '<div class="caseForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm"><i class="fas fa-check-circle"></i></div>';

echo '<div class="caseForm titreGridForm"> 
	<div></div>
	<a href="index.php?page=ListeTexte"><i class="fas fa-sign-out-alt fa-rotate-180"></i></a>
	<div class="flex-0-1"></div>
	<button type="submit"><i class="fas fa-paper-plane"></i></button>
	<div></div>
	</div>';

echo'</form>';

echo '</div>';
echo '</div>';
echo '<div class="flex-0-1"></div>';
echo '</main>';
<?php
echo '<main class="center">';

echo '<form class="GridForm" action="index.php?page=ActionTexte&mode='.$_GET['mode'].'" method="post"/>';

echo '<div class="caseForm gridForm-col-span">Formulaire Texte</div>';
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

echo '<div class="caseForm gridForm-col-span"> 
	<div></div>
	<a href="index.php?page=ListeTexte"><button type="button"><i class="fas fa-sign-out-alt fa-rotate-180"></i></button></a>
	<div class="flex-0-1"></div>
	<button type="submit"><i class="fas fa-paper-plane"></i></button>
	<div></div>
	</div>';

echo'</form>';

echo '</main>';
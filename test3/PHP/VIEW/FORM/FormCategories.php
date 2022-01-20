<?php
echo '<main class="center">';

echo '<form class="GridForm" action="index.php?page=ActionCategories&mode='.$_GET['mode'].'" method="post"/>';

echo '<div class="caseForm gridForm-col-span">Formulaire Categories</div>';
echo '<div class="caseForm">idCategorie</div>';
echo '<div class="caseForm"><input type="text" name="idCategorie"></div>';
echo '<div class="caseForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm"><i class="fas fa-check-circle"></i></div>';

echo '<div class="caseForm">LibelleCategorie</div>';
echo '<div class="caseForm"><input type="text" name="LibelleCategorie"></div>';
echo '<div class="caseForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm"><i class="fas fa-check-circle"></i></div>';

echo '<div class="caseForm gridForm-col-span"> 
	<div></div>
	<a href="index.php?page=ListeCategories"><button type="button"><i class="fas fa-sign-out-alt fa-rotate-180"></i></button></a>
	<div class="flex-0-1"></div>
	<button type="submit"><i class="fas fa-paper-plane"></i></button>
	<div></div>
	</div>';

echo'</form>';

echo '</main>';
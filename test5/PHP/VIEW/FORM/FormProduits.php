<?php
echo '<main class="center">';

echo '<form class="GridForm" action="index.php?page=ActionProduits&mode='.$_GET['mode'].'" method="post"/>';

echo '<div class="caseForm gridForm-col-span">Formulaire Produits</div>';
echo '<div class="caseForm">idProduit</div>';
echo '<div class="caseForm"><input type="text" name="idProduit"></div>';
echo '<div class="caseForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm"><i class="fas fa-check-circle"></i></div>';

echo '<div class="caseForm">libelleProduit</div>';
echo '<div class="caseForm"><input type="text" name="libelleProduit"></div>';
echo '<div class="caseForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm"><i class="fas fa-check-circle"></i></div>';

echo '<div class="caseForm">prix</div>';
echo '<div class="caseForm"><input type="text" name="prix"></div>';
echo '<div class="caseForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm"><i class="fas fa-check-circle"></i></div>';

echo '<div class="caseForm">dateDePeremption</div>';
echo '<div class="caseForm"><input type="text" name="dateDePeremption"></div>';
echo '<div class="caseForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm"><i class="fas fa-check-circle"></i></div>';

echo '<div class="caseForm">idCategorie</div>';
echo '<div class="caseForm"><input type="text" name="idCategorie"></div>';
echo '<div class="caseForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm"><i class="fas fa-check-circle"></i></div>';

echo '<div class="caseForm gridForm-col-span"> 
	<div></div>
	<a href="index.php?page=ListeProduits"><button type="button"><i class="fas fa-sign-out-alt fa-rotate-180"></i></button></a>
	<div class="flex-0-1"></div>
	<button type="submit"><i class="fas fa-paper-plane"></i></button>
	<div></div>
	</div>';

echo'</form>';

echo '</main>';
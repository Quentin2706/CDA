<?php
echo '<main>';
echo '<div class="flex-0-1"></div>';
echo '<div>';
echo '<div class="GridForm">';

echo '<form action="index.php?page=produitsAction&mode="'.$_GET['mode'].'" methode="post"/>';

echo '<div class="caseForm titreGridForm">Formulaire produits</div>';
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

echo '<div class="caseForm titreGridForm"> 
	<div></div>
	<a href="index.php?page=ListeProduits"><i class="fas fa-sign-out-alt fa-rotate-180"></i></a>
	<div class="flex-0-1"></div>
	<button type="submit"><i class="fas fa-paper-plane"></i></button>
	<div></div>
	</div>';

echo'</form>';

echo '</div>';
echo '</div>';
echo '<div class="flex-0-1"></div>';
echo '</main>';
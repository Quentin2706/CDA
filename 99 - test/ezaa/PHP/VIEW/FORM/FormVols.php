<?php
global $regex;
$mode = $_GET['mode'];
$disabled = " ";
switch ($mode) {
	case "Afficher":
	case "Supprimer":
		$disabled = " disabled ";
		break;
}

if (isset($_GET['id'])) {
	$elm = VolsManager::findById($_GET['id']);
} else {
	$elm = new Vols();
}
echo '<main class="center">';

echo '<form class="GridForm" action="index.php?page=ActionVols&mode='.$_GET['mode'].'" method="post"/>';

echo '<div class="caseForm titreForm col-span-form">Formulaire Vols</div>';
	echo '<div class="noDisplay"><input type="hidden" value="'.$elm->getIdVol().'" name=IdVol></div>';
echo '<label for=DateVol class="caseForm labelForm">'.texte("DateVol").'</label>';
echo '<div class="caseForm donneeForm"><input type="text" '.$disabled .'value="'.$elm->getDateVol().'" name=DateVol pattern="'.$regex["*"].'"></div>';
echo '<div class="caseForm infoForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm checkForm"><i class="fas fa-check-circle"></i></div>';

echo '<label for=AeroportArrivee class="caseForm labelForm">'.texte("AeroportArrivee").'</label>';
echo '<div class="caseForm donneeForm"><input type="text" '.$disabled .'value="'.$elm->getAeroportArrivee().'" name=AeroportArrivee pattern="'.$regex["*"].'"></div>';
echo '<div class="caseForm infoForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm checkForm"><i class="fas fa-check-circle"></i></div>';

echo '<label for=DureeVol class="caseForm labelForm">'.texte("DureeVol").'</label>';
echo '<div class="caseForm donneeForm"><input type="text" '.$disabled .'value="'.$elm->getDureeVol().'" name=DureeVol pattern="'.$regex["*"].'"></div>';
echo '<div class="caseForm infoForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm checkForm"><i class="fas fa-check-circle"></i></div>';

echo '<label for=AeroportDepart class="caseForm labelForm">'.texte("AeroportDepart").'</label>';
echo '<div class="caseForm donneeForm"><input type="text" '.$disabled .'value="'.$elm->getAeroportDepart().'" name=AeroportDepart pattern="'.$regex["*"].'"></div>';
echo '<div class="caseForm infoForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm checkForm"><i class="fas fa-check-circle"></i></div>';

echo '<label for=IdAvion class="caseForm labelForm">'.texte("IdAvion").'</label>';
echo '<div class="caseForm donneeForm"><input type="text" '.$disabled .'value="'.$elm->getIdAvion().'" name=IdAvion pattern="'.$regex["*"].'"></div>';
echo '<div class="caseForm infoForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm checkForm"><i class="fas fa-check-circle"></i></div>';

echo '<div class="caseForm col-span-form">
	<div></div>
	<div><a href="index.php?page=ListeVols"><button type="button"><i class="fas fa-sign-out-alt fa-rotate-180"></i></button></a></div>
	<div class="flex-0-1"></div>';
	echo ($mode == "Afficher") ? "" : " <div><button type=\"submit\"><i class=\"fas fa-paper-plane\"></i></button></div>";
	echo'<div></div>
	</div>';

echo'</form>';

echo '</main>';
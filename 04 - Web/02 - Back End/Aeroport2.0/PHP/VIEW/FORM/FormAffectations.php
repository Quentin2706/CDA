<?php
global $regex;
$mode = $_GET['mode'];
$disabled = " ";
switch ($mode) {
	case "Afficher":
	case "Supprimer":
		$disabled = " disabled";
		break;
}

if (isset($_GET['id'])) {
	$elm = AffectationsManager::findById($_GET['id']);
} else {
	$elm = new Affectations();
}
echo '<main class="center">';

echo '<form class="GridForm" action="index.php?page=ActionAffectations&mode='.$_GET['mode'].'" method="post"/>';

echo '<div class="caseForm col-span-form">Formulaire Affectations</div>';
if ($mode != "Ajouter") {
	echo '<div class="noDisplay"><input type="hidden" value="'.$elm->getIdAffectation().'" name=IdAffectation></div>';
};
echo '<div class="caseForm">IdPilote</div>';
echo '<div class="caseForm">';
// <input type="text" '.$disabled;
// echo ($mode == "Ajouter") ? "" : " value=".$elm->getIdPilote(); echo ' name=IdPilote pattern="'.$regex["*"].'">
echo creerSelect($elm->getIdPilote(),"Pilotes",["nom","prenom"],"",null,"nom, prenom",false);
echo'</div>';
echo '<div class="caseForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm"><i class="fas fa-check-circle"></i></div>';

echo '<div class="caseForm">IdVol</div>';
// echo '<div class="caseForm"><input type="text" '.$disabled;
// echo ($mode == "Ajouter") ? "" : " value=".$elm->getIdVol(); echo ' name=IdVol pattern="'.$regex["*"].'"></div>';
echo creerSelect($elm->getIdVol(),"Vols",["AeroportDepart","AeroportArrivée"],"",null,"",false);
echo '<div class="caseForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm"><i class="fas fa-check-circle"></i></div>';

echo '<div class="caseForm col-span-form">
	<div></div>
	<div><a href="index.php?page=ListeAffectations"><button type="button"><i class="fas fa-sign-out-alt fa-rotate-180"></i></button></a></div>
	<div class="flex-0-1"></div>';
	echo ($mode == "Afficher") ? "" : " <div><button type=\"submit\"><i class=\"fas fa-paper-plane\"></i></button></div>";
	echo'<div></div>
	</div>';

echo'</form>';

echo '</main>';
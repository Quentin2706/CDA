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
	$elm = Doctrine_migration_versionsManager::findById($_GET['id']);
} else {
	$elm = new Doctrine_migration_versions();
}
echo '<main class="center">';

echo '<form class="GridForm" action="index.php?page=ActionDoctrine_migration_versions&mode='.$_GET['mode'].'" method="post"/>';

echo '<div class="caseForm titreForm col-span-form">Formulaire Doctrine_migration_versions</div>';
	echo '<div class="noDisplay"><input type="hidden" value="'.$elm->getVersion().'" name=Version></div>';
echo '<label for=Executed_at class="caseForm labelForm">'.texte("Executed_at").'</label>';
echo '<div class="caseForm donneeForm"><input type="text" '.$disabled .'value="'.$elm->getExecuted_at().'" name=Executed_at pattern="'.$regex["*"].'"></div>';
echo '<div class="caseForm infoForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm checkForm"><i class="fas fa-check-circle"></i></div>';

echo '<label for=Execution_time class="caseForm labelForm">'.texte("Execution_time").'</label>';
echo '<div class="caseForm donneeForm"><input type="text" '.$disabled .'value="'.$elm->getExecution_time().'" name=Execution_time pattern="'.$regex["*"].'"></div>';
echo '<div class="caseForm infoForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm checkForm"><i class="fas fa-check-circle"></i></div>';

echo '<div class="caseForm col-span-form">
	<div></div>
	<div><a href="index.php?page=ListeDoctrine_migration_versions"><button type="button"><i class="fas fa-sign-out-alt fa-rotate-180"></i></button></a></div>
	<div class="flex-0-1"></div>';
	echo ($mode == "Afficher") ? "" : " <div><button type=\"submit\"><i class=\"fas fa-paper-plane\"></i></button></div>";
	echo'<div></div>
	</div>';

echo'</form>';

echo '</main>';
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
	$elm = PropertyManager::findById($_GET['id']);
} else {
	$elm = new Property();
}
echo '<main class="center">';

echo '<form class="GridForm" action="index.php?page=ActionProperty&mode='.$_GET['mode'].'" method="post"/>';

echo '<div class="caseForm titreForm col-span-form">Formulaire Property</div>';
	echo '<div class="noDisplay"><input type="hidden" value="'.$elm->getId().'" name=Id></div>';
echo '<label for=Title class="caseForm labelForm">'.texte("Title").'</label>';
echo '<div class="caseForm donneeForm"><input type="text" '.$disabled .'value="'.$elm->getTitle().'" name=Title pattern="'.$regex["*"].'"></div>';
echo '<div class="caseForm infoForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm checkForm"><i class="fas fa-check-circle"></i></div>';

echo '<label for=Description class="caseForm labelForm">'.texte("Description").'</label>';
echo '<div class="caseForm donneeForm"><input type="text" '.$disabled .'value="'.$elm->getDescription().'" name=Description pattern="'.$regex["*"].'"></div>';
echo '<div class="caseForm infoForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm checkForm"><i class="fas fa-check-circle"></i></div>';

echo '<label for=Surface class="caseForm labelForm">'.texte("Surface").'</label>';
echo '<div class="caseForm donneeForm"><input type="text" '.$disabled .'value="'.$elm->getSurface().'" name=Surface pattern="'.$regex["*"].'"></div>';
echo '<div class="caseForm infoForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm checkForm"><i class="fas fa-check-circle"></i></div>';

echo '<label for=Rooms class="caseForm labelForm">'.texte("Rooms").'</label>';
echo '<div class="caseForm donneeForm"><input type="text" '.$disabled .'value="'.$elm->getRooms().'" name=Rooms pattern="'.$regex["*"].'"></div>';
echo '<div class="caseForm infoForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm checkForm"><i class="fas fa-check-circle"></i></div>';

echo '<label for=Bedrooms class="caseForm labelForm">'.texte("Bedrooms").'</label>';
echo '<div class="caseForm donneeForm"><input type="text" '.$disabled .'value="'.$elm->getBedrooms().'" name=Bedrooms pattern="'.$regex["*"].'"></div>';
echo '<div class="caseForm infoForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm checkForm"><i class="fas fa-check-circle"></i></div>';

echo '<label for=Floor class="caseForm labelForm">'.texte("Floor").'</label>';
echo '<div class="caseForm donneeForm"><input type="text" '.$disabled .'value="'.$elm->getFloor().'" name=Floor pattern="'.$regex["*"].'"></div>';
echo '<div class="caseForm infoForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm checkForm"><i class="fas fa-check-circle"></i></div>';

echo '<label for=Price class="caseForm labelForm">'.texte("Price").'</label>';
echo '<div class="caseForm donneeForm"><input type="text" '.$disabled .'value="'.$elm->getPrice().'" name=Price pattern="'.$regex["*"].'"></div>';
echo '<div class="caseForm infoForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm checkForm"><i class="fas fa-check-circle"></i></div>';

echo '<label for=Heat class="caseForm labelForm">'.texte("Heat").'</label>';
echo '<div class="caseForm donneeForm"><input type="text" '.$disabled .'value="'.$elm->getHeat().'" name=Heat pattern="'.$regex["*"].'"></div>';
echo '<div class="caseForm infoForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm checkForm"><i class="fas fa-check-circle"></i></div>';

echo '<label for=City class="caseForm labelForm">'.texte("City").'</label>';
echo '<div class="caseForm donneeForm"><input type="text" '.$disabled .'value="'.$elm->getCity().'" name=City pattern="'.$regex["*"].'"></div>';
echo '<div class="caseForm infoForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm checkForm"><i class="fas fa-check-circle"></i></div>';

echo '<label for=Address class="caseForm labelForm">'.texte("Address").'</label>';
echo '<div class="caseForm donneeForm"><input type="text" '.$disabled .'value="'.$elm->getAddress().'" name=Address pattern="'.$regex["*"].'"></div>';
echo '<div class="caseForm infoForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm checkForm"><i class="fas fa-check-circle"></i></div>';

echo '<label for=Postal_code class="caseForm labelForm">'.texte("Postal_code").'</label>';
echo '<div class="caseForm donneeForm"><input type="text" '.$disabled .'value="'.$elm->getPostal_code().'" name=Postal_code pattern="'.$regex["*"].'"></div>';
echo '<div class="caseForm infoForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm checkForm"><i class="fas fa-check-circle"></i></div>';

echo '<label for=Sold class="caseForm labelForm">'.texte("Sold").'</label>';
echo '<div class="caseForm donneeForm"><input type="text" '.$disabled .'value="'.$elm->getSold().'" name=Sold pattern="'.$regex["*"].'"></div>';
echo '<div class="caseForm infoForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm checkForm"><i class="fas fa-check-circle"></i></div>';

echo '<label for=Created_at class="caseForm labelForm">'.texte("Created_at").'</label>';
echo '<div class="caseForm donneeForm"><input type="text" '.$disabled .'value="'.$elm->getCreated_at().'" name=Created_at pattern="'.$regex["*"].'"></div>';
echo '<div class="caseForm infoForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm checkForm"><i class="fas fa-check-circle"></i></div>';

echo '<div class="caseForm col-span-form">
	<div></div>
	<div><a href="index.php?page=ListeProperty"><button type="button"><i class="fas fa-sign-out-alt fa-rotate-180"></i></button></a></div>
	<div class="flex-0-1"></div>';
	echo ($mode == "Afficher") ? "" : " <div><button type=\"submit\"><i class=\"fas fa-paper-plane\"></i></button></div>";
	echo'<div></div>
	</div>';

echo'</form>';

echo '</main>';
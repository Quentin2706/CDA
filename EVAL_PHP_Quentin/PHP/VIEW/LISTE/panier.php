<?php 

echo '<div><div class="flex-0-1"></div><main>';

if($_SESSION["utilisateur"]->getRole() == 1)
{
    PaniersManager::getList(["*"],["idCLient" => $_SESSION['Utilisateur']->getId, "DatePanier" => $aujd]);



} else if($_SESSION["utilisateur"]->getRole() == 2) {

}

echo '</main><div class="flex-0-1"></div></div>';
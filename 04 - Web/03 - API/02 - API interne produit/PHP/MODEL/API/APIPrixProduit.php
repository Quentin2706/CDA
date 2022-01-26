<?php
if (isset($_POST["prix"]))
{
    echo json_encode(ProduitsManager::getList(["*"],["Prix" => $_POST["prix"]],null,null,true,false));
} else if (isset($_POST["categ"])){
    
}

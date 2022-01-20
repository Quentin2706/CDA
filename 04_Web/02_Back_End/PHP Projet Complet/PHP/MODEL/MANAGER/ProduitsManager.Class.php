<?php
class ProduitsManager
{
    public static function add(Produits $obj)
    {
        Services::add($obj);
    }

    public static function update(Produits $obj)
    {
        Services::update($obj);
    }

    public static function delete(Produits $obj)
    {
        Services::delete($obj);
    }

    public static function findById($id)
    {
        return Services::select(Produits::getAttributes(),"Produits",false, ["IdProduit" => $id]);
    }

    public static function getList()
    {   
        return Services::select(Produits::getAttributes(),"Produits");
    }

    public static function getListByCategorie($idCategorie)
    {
        return Services::select(Produits::getAttributes(),"Produits",false, ["IdCategorie" => $idCategorie]);
        
    }
}

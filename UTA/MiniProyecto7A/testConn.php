<?php
    include ("conexion.php");

    echo "archivo para probar una conexion";

    $oconn = new Conexion ("localhost", "root","","bdtoolsteacher");

    $conn= $oconn -> regresaConexion();
    
    if($conn!=null)
    {
     echo"conexión exitosa";   
    }
    else
    {
        echo("error");
    }
    
?>
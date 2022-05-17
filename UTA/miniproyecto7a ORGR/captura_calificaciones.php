<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <form action="caprura_calificaciones.php">
        Dame número de equipo = <input type="text" id="nequipo" name="nequipo">
        <br>
        <input type="submit" value ="enviar">
        <?php
            include ("alumno_controlador");
            $nequipo = $_GET['nequipo'];
            if (isset($nequipo))
            {
                $oalctrl= new Alumno_ctrl;
                echo $oalctrl->regresar_equipo($nequipo);
            }
        
        ?>
       
    </form>
    
</body>
</html>
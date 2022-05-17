<?php
    include ("conexion.php");
    include ("alumno_modelo.php");



    class Alumno_ctrl
    {
        function regresar_equipo($numequipo)
        {
            $oconn = new Conexion("localhost","root","","bdtoolsteacher");

            $conn = $oconn ->regresaConexion();

            if($conn->connect_error)
            {
                die("Falló la conexión!!".$conn->connect_error);

            }

            $csql = "SELECT idAlumno, matricula, apellido1, apellido2, fk_idequipo FROM alumno WHERE fk_idequipo =".$numequipo;

            $result = $conn->query($csql);

            if ($result-> num_row > 0) 
            { 
                while($row = $result->fetch_assoc())
                {
                    $regreso = $regreso + $row['matricula']." ".$row['nombres']." <BR>".;

                }

            }
                return $regreso;
        } 

    }

?>
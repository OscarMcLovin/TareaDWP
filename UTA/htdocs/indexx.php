<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Calculadora</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"></script>
</head>
<body>
    <div class="container mt-3">
        <h2>Example about software architecture</h2>
        <p>Select the example to show:</p>
        <ul class="nav nav-pills">
            <li class="nav-item">
                <a class="nav-link active" href>Calculadora</a>
            </li>
        </ul>
        <table>
            <tbody>
                <tr>
                    <td>
                        <form action="calculadora.php">
                            <div class="md-3 mt-3">
                                <label for="op1" class="form-label">Valor 1:</label>
                                <input type="number" class="form-control" id="op1" placeholder="Ingresar Valor 1" name="op1">
                            </div>
                            <div class="md-3 mt-3">
                                <label for="op2" class="form-label">Valor 2:</label>
                                <input type="number" class="form-control" id="op2" placeholder="Ingresar Valor 2" name="op1">
                            </div>
                            <div class="md-3 mt-3">
                                <label for="operacion" class="form-label">Seleccionar operacion:</label>
                                <select class="form-select" aria-label="Select operation" name="operacion" id="operacion">
                                <option selected value="1">Suma (+)</option>
                                <option value="2">Resta (-)</option>
                                <option value="3">Division (/)</option>
                                <option value="4">Multiplicacion (*)</option>
                                <option value="5">Raiz Cuadrada</option>
                                </select>
                            </div>
                            <div class="md-3 mt-3">
                                <label for="resultado" class="form-laber">Resultado</label>
                                <input type="number" class="form-control text-white bg-dark"
                                id="result" placeholder="Resultado" name="Resultado" value>
                            </div>
                            <button type="submit" class="btn btn-primary">Submit</button>
                        </form>
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
    <style>
       .footer,.generic-footer{margin-bottom:98px}@media (min-width:374px)
       {.footer,.generic-footer{margin-bottom:78px}}@media (min-width:546px)
       {.footer,.generic-footer{margin-bottom:56px}}@media (min-width:1055px)
       {.footer,.generic-footer{margin-bottom:0}
    }.disclaimer{position:fixed;z-index:9999999;bottom:0;right:0;border-top:2px solid #ff5c62;text-align:center;font-size:14px;font-weight:400;background-color:#fff;padding:5px 10px 5px 10px}.disclaimer a:hover{text-decoration:underline}@media (min-width:1052px){.disclaimer{text-align:right;border-left:2px solid red;border-top-left-radius:10px}}@media (min-width:1920px){.disclaimer{width:60%}}
    </style>
</body>
</html>

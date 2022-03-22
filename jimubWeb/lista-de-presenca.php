<?php require_once 'conexao.php'; ?>
<!DOCTYPE html>
<html>

<head>
    <meta charset='utf-8'>
    <meta http-equiv='X-UA-Compatible' content='IE=edge'>
    <title>Registro</title>
    <meta name='viewport' content='width=device-width, initial-scale=1'>
    <link rel='stylesheet' type='text/css' media='screen' href='css/bootstrap.min.css'>
  
    <link rel='stylesheet' type='text/css' media='screen' href='css/font-awesome.min.css'>
    <link rel='stylesheet' type='text/css' media='screen' href='css/meu_estilo.css'>

    <style>
        .bd-placeholder-img {
            font-size: 1.125rem;
            text-anchor: middle;
            -webkit-user-select: none;
            -moz-user-select: none;
            user-select: none;
        }
        
        @media (min-width: 768px) {
            .bd-placeholder-img-lg {
                font-size: 3.5rem;
            }
        }
    </style>
</head>

<body>
    <nav class="navbar navbar-expand-lg navbar-light menu-jimub bg-warning">
        <div class="container-fluid">
            <strong><a class="navbar-brand" href="#">JIMUB</a></strong>
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarCollapse" aria-controls="navbarCollapse" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarCollapse">
                <ul class="navbar-nav me-auto mb-2 mb-md-0">
                    <li class="nav-item nav-item-jimub">
                        <a class="nav-link active" aria-current="page" href="#">Home</a>
                    </li>
                    <li class="nav-item nav-item-jimub">
                        <a class="nav-link" href="#">Alterar seus dados</a>
                    </li>
                </ul>
                <form class="d-flex form-login" name="login-jimub">
                    <input type="text" name="username" class="form-control me-2 form-login-dashboard" id="inputUsername" placeholder="Username" required/>
                    <input type="password" name="senha" class="form-control me-2 form-login-dashboard" id="inputSenha" placeholder="Senha" required/>
                    <button class="btn btn-dark btn-dark-entrar" type="submit">Entrar</button>
                </form>
            </div>
        </div>
    </nav>
    <br>
    <main class="container">
        <div class="row">
            <div class="col-md-4 panel panel-default panel-profile m-b-0 my-panel">
                <div class="panel-heading"></div>
                <div class="panel-body text-center">
                    <img class="panel-profile-img my-profile-img" src="img/IMG-20211002-WA0012-1.jpg" style="width:30%">
                    <strong> <h5 class="panel-title">Eduardo Kiassucumuca</h5></strong>
                    <p class="m-b">O engenheiro formado no isptec.</p>
                    <a href="sair.php" style="color:#ffc425; border:1px solid #ffc425; margin-bottom: 10px;" class="btn btn">Sair</a>
                </div>
            </div>
            <div class="col-md-8">
                <div class="alert alert-warning" role="alert">
                    <h4 class="alert-heading">Bem-Vindo | Lista de presença </h4>
                </div>
        
                <div class="lista-presenca-jimub" id="lista_presenca">
                    <div class="table-responsive">
                        <table class="table table-responsive table-striped table-bordered table-presenca">
                            <thead>
                                <tr class="bg-light">
                                    
                                    <th scope="col" width="5%">#ID</th>
                                    <th scope="col" width="40%">Nome Completo</th>
                                    <th scope="col" width="3%">Presença</th>
                                    
                                </tr>
                            </thead>
                            <tbody>
                                <?php 
                                    $limite = 8;
                                    $qtd_membros = "select count('id') from tb_membros";
                                    $result_membro = mysqli_query($conexao, $qtd_membros);
                                    $total_rows = mysqli_fetch_array($result_membro)[0];
                                    $total_pages = ceil($total_rows / $limite);
                                    
                                    $pg=(isset($_GET['pg'])) ? (int)$_GET['pg'] :1;
                                    $estart =($pg-1) * $limite;
                                     $sql_membro=mysqli_query($conexao,"select * from tb_membros ORDER by nome asc LIMIT $estart, $limite");
                                         while($linha=mysqli_fetch_array($sql_membro)):
                                ?>
                                <tr>
                                    <td><?php echo $linha['id_membro'];?></td>
                                    <td><?php echo $linha['nome'];?></td>
                                    <th scope="row"><input class="form-check-input" type="checkbox"></th>
                                    <?php endwhile;?>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                    <nav style="text-align:left;" aria-label="Page navigation">
				        <ul style="" class="pagination">

			        <?php
			  
                        if($total_pages >= 1 or $pg <= $total_pages){
                            
                            for($i=1; $i<=$total_pages; $i++){
                        
					  ?>
					 
					<li>			    
					  <a href="?pg=<?php echo $i;?>" id="pag" style="color:#ffc425;background-color:white;border:1px solid #eceeef;" ><?php echo $i;?></a>
				    <?php
			            }
			        }
			        ?>
			 
			        <li>
					 </li>
					  </ul>
					</nav>
                </div>
            </div>
        </div>
        <div class="modal fade" id="myModalInfo">
            <div class="modal-dialog alert-warning">
                <div class="modal-content">

                    <!-- Modal Header -->
                    <div class="modal-header">
                        <h3 class="modal-title">Sucesso!</h3>
                    </div>

                    <!-- Modal body -->
                    <div class="modal-body">
                        Os dados foram guardados com sucesso!
                    </div>

                    <!-- Modal footer -->
                    <div class="modal-footer">
                        <button type="button" class="btn btn-warning btn-ok" data-bs-dismiss="modal">OK</a>
                    </div>
                </div>
            </div>
        </div>
    </main>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/bootstrap.bundle.min.js"></script>
    <script src="js/jquery-3.6.0.min.js"></script>
    <script src="js/main.js"></script>
</body>

</html>
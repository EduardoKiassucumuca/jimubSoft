<?php
	$servidor = "localhost";
	$user = "root";
	$pass = '';
	$bd = 'jimub';

	$conexao = mysqli_connect($servidor,$user,$pass,$bd);

	if (!$conexao) {
		
		echo "Erro ao criar a conexão com o banco de dados! contacte um técnico";
	}
?>
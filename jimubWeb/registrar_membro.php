<?php
    require_once 'conexao.php';

    //registrando a morada do membro
    $last_id_morada = 0;
    $bairro = $_POST['meu_bairro'];
    $rua = $_POST['minha_rua'];
    $descricao = $_POST['minha_descricao'];

    echo $bairro;

    $sql_morada = "Insert into tb_morada(bairro,rua,descricao_casa)Values('$bairro','$rua','$descricao')";
    $result_morada = mysqli_query($conexao, $sql_morada);
    $last_id_morada = mysqli_insert_id($conexao);

    //registrando os dados dos pais do membro
    $nome_pai = $_POST['meu_pai'];
    $nome_mae = $_POST['minha_mae'];
    $last_id_filiacao = 0;

    $sql_filiacao = "Insert into tb_filiacao(pai,mae)Values('$pai','$mae')";
    $result_filiacao = mysqli_query($conexao, $sql_filiacao);
    $last_id_filiacao = mysqli_insert_id($conexao);

    //registrando o cargo
    $cargo = $_POST['meu_cargo'];
    $last_id_cargo = 0;
    $sql_cargo = "Insert into tb_cargo(cargo)Values('$cargo')";
    $result_cargo = mysqli_query($conexao,$sql_cargo);
    $last_id_cargo = mysqli_insert_id($conexao);

    //registrando o cargo
    $comissao = $_POST['minha_comissao'];
    $last_id_comissao = 0;
    $sql_comissao = "Insert into tb_comissao(comissao)Values('$comissao')";
    $result_comissao = mysqli_query($conexao, $sql_comissao);
    $last_id_comissao = mysqli_insert_id($conexao);

    //Registrando o membro
    $last_id_membro = 0;
    $nome = $_POST['meu_nome'];
    $telefone_principal = $_POST['meu_telefone1'];
    $telefone_secundario = $_POST['meu_telefone2'];
    $genero = $_POST['meu_genero'];
    $data_nascimento = $_POST['minha_dataNascimento'];
    $year_nascimento = intval(substr($data_nascimento, 0,4));
    $year_now = intval(date("Y"));
    $idade = $year_now - $year_nascimento;
    $facebook = $_POST['meu_facebook'];
    $nivel_escolar = $_POST['meu_nivelEscolar'];
    $area_formacao = $_POST['minha_areaFormacao'];
    $profissao = $_POST['minha_profissao'];
    $escola = $_POST['minha_escola'];
    $ramo_ocupacional = $_POST['meu_ramoOcupacional'];
    $estado_civil = $_POST['meu_estadoCivil'];
    $cat_membro = $_POST['minha_catMembro'];
    $grupo = $_POST['meu_grupo'];
    $classe = $_POST['minha_classe'];
    $data_ingresso = $_POST['minha_dataIngresso'];
    $como_entrou_na_organizacao = $_POST['minha_entrada_naOrganizacao'];
    $frequencia = $_POST['minha_frequencia'];
    $motivo = $_POST['meu_motivo'];
    $igreja_anterior = $_POST['minha_igrejaAnterior'];
    $minha_funcaoAExercer = $_POST['funcao_a_exercer'];
    $achas_organizacao = $_POST['oq_achas_organizacao'];
    $estado = "Vivo";
    $status = 1;
    $sql_membro = "Insert into tb_membros(nome,alcunha,telefone1,telefone2,idade,sexo,id_morada,estado_civil,id_filiacao,facebook,areaFormacao,nivelEscolar,escola,ramo,profissao,id_cargo,id_comissao,grupo,data_nascimento,cat_membro,classe,data_emissao,como_ingressou,presenca,motivo,igreja_Anterior,funcaoA_Exercer,descricao_Organizacao,estado,status)Values('$nome','$alcunha','$telefone_principal','$telefone_secundario','$idade','$genero','$last_id_morada','$estado_civil','$last_id_filiacao','$facebook','$area_formacao','$nivel_escolar','$escola','$ramo_ocupacional','$profissao','$last_id_cargo','$last_id_comissao','$grupo','$data_nascimento','$cat_membro','$classe','$data_ingresso','$como_entrou_na_organizacao','$frequencia','$motivo','$igreja_anterior','$minha_funcaoAExercer','$achas_organizacao','$estado','$status')";
    $result_membro = mysqli_query($conexao, $sql_membro);
    $last_id_membro = mysqli_insert_id($conexao);
   





?>
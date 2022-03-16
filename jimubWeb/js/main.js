$(document).ready(function() {
    $("#myModalInfo").hide();
    $("#dados_eclesiasticos").hide();
    var count = 1;
    $(".form-control-jimub").each(function() {
        var current = $(this);
        var paragrafo_validacao = document.createElement("p");
        var text = document.createTextNode("Nova Paragrafo");
        var novo_paragrafo = paragrafo_validacao.appendChild(text);
        var current_input_id = current.attr('id');
        var id_text_validacao = "text_valida_" + count;
        $(paragrafo_validacao).addClass("text_validacao");
        $(paragrafo_validacao).attr('id', id_text_validacao);
        current.after(paragrafo_validacao);
        $(paragrafo_validacao).css("color", "red");
        $(paragrafo_validacao).hide();
        count += 1
    });
    $(".btn-avancar").click(function() {
        var nome = $("#inputNome").val();
        var bairro = $("#inputBairro").val();
        var rua = $("#inputRua").val();
        var descricao = $("#inputDescricao").val();
        var telefone_principal = $("#inputTelefonePrincipal").val();
        var telefone_secundario = $("#inputTelefoneSecundário").val();
        var genero = $("#inputGenero option:selected").val();
        var data_nascimento = $("#inputDate_nascimento").val();
        var facebook = $("#inputFacebook").val();
        var nivel_escolar = $("#inputNivel_escolar option:selected").val();
        var area_formacao = $("#inputAreaFormacao").val();
        var profissao = $("#inputProfissao").val();
        var escola = $("#inputEscola").val();
        var ramo_ocupacional = $("#inputRamo_ocupacional option:selected").val();
        var estado_civil = $("#inputEstado_civil option:selected").val();
        var nome_pai = $("#inputPai").val();
        var nome_mae = $("#inputMae").val();

        /*if (nome == "" && bairro == "" && rua == "" && descricao == "" && telefone_principal == "" && telefone_secundario == "" && genero == "Genero" && data_nascimento == "" && facebook == "" && nivel_escolar == "Nível Escolar" && area_formacao == "" && profissao == "" && escola == "" && ramo_ocupacional == "Ramo Ocupacional" && estado_civil == "Estado Civíl" && nome_mae == "" && nome_pai == "") {
            $(".text_validacao").text("Campo Obrigatório");
            $(".text_validacao").show();
        } else if (nome == "") {
            $("#text_valida_1").text("Preencha o nome completo");
            $("#text_valida_1").show();
        } else if (bairro == "") {
            $("#text_valida_2").text("Preencha o bairro");
            $("#text_valida_2").show();
        } else if (rua == "") {
            $("#text_valida_3").text("Preencha a rua");
            $("#text_valida_3").show();
        } else if (descricao == "") {
            $("#text_valida_4").text("Preencha a descricao da casa");
            $("#text_valida_4").show();
        } else if (telefone_principal == "") {
            $("#text_valida_5").text("Preencha o telefone principal");
            $("#text_valida_5").show();
        } else if (telefone_secundario == "") {
            $("#text_valida_6").text("Preencha o telefone secundario");
            $("#text_valida_6").show();
        } else if (genero == "") {
            $("#text_valida_7").text("Seleciona o genero");
            $("#text_valida_7").show();
        } else if (data_nascimento == "") {
            $("#text_valida_8").text("Preencha a data de nascimento");
            $("#text_valida_8").show();
        } else if (facebook == "") {
            $("#text_valida_9").text("Preencha o facebook");
            $("#text_valida_9").show();
        } else if (nivel_escolar == "Nivel Escolar") {
            $("#text_valida_10").text("Preencha o nível escolar");
            $("#text_valida_10").show();
        } else if (area_formacao == "") {
            $("#text_valida_11").text("Preencha a area de formação");
            $("#text_valida_11").show();
        } else if (profissao == "") {
            $("#text_valida_12").text("Preencha a profissao");
            $("#text_valida_12").show();
        } else if (escola == "") {
            $("#text_valida_13").text("Preencha a escola");
            $("#text_valida_13").show();
        } else if (ramo_ocupacional == "Ramo Ocupacional") {
            $("#text_valida_14").text("Preencha o ramo ocupacional");
            $("#text_valida_14").show();
        } else if (estado_civil == "Estado Civíl") {
            $("#text_valida_15").text("Preencha o estado civíl");
            $("#text_valida_15").show();
        } else if (nome_pai == "") {
            $("#text_valida_17").text("Preencha o nome do pai");
            $("#text_valida_17").show();
        } else if (nome_mae == "") {
            $("#text_valida_18").text("Preencha o nome da mãe");
            $("#text_valida_18").show();
        } else {*/
        $("#dados_pessoais").hide(1000);
        $("#dados_eclesiasticos").show(2000);

    });
    $(".btn-voltar").click(function() {
        $("#dados_eclesiasticos").hide(1000);
        $("#dados_pessoais").show(2000);
    });

    $(".btn-guardar").click(function() {

        // obtendo os dados pessoais do membro
        var nome = $("#inputNome").val();
        var bairro = $("#inputBairro").val();
        var rua = $("#inputRua").val();
        var descricao = $("#inputDescricao").val();
        var telefone_principal = $("#inputTelefonePrincipal").val();
        var telefone_secundario = $("#inputTelefoneSecundário").val();
        var genero = $("#inputGenero option:selected").val();
        var data_nascimento = $("#inputDate_nascimento").val();
        var facebook = $("#inputFacebook").val();
        var nivel_escolar = $("#inputNivel_escolar option:selected").val();
        var area_formacao = $("#inputAreaFormacao").val();
        var profissao = $("#inputProfissao").val();
        var escola = $("#inputEscola").val();
        var ramo_ocupacional = $("#inputRamo_ocupacional option:selected").val();
        var estado_civil = $("#inputEstado_civil option:selected").val();
        var nome_pai = $("#inputPai").val();
        var nome_mae = $("#inputMae").val();

        //obtendo os dados eclesiasticos do membro
        var cat_membro = $("#inputCategoria_membro option:selected").text().trim();
        var grupo = $("#inputGrupo option:selected").val();
        var classe = $("#inputClasse option:selected").text().trim();
        var comissao = $("#inputComissao option:selected").text().trim();
        var data_ingresso = $("#inputdate_ingresso").val();
        var cargo = $("#inputCargo option:selected").text().trim();
        var como_entrou_na_organizacao = $("#inputorganizacao option:selected").text().trim();
        var frequencia_membro = $("#inputfrequencia option:selected").text().trim();
        var motivo_ausencia = $("#inputMotivo option:selected").text().trim();
        var igreja_anterior = $("#inputIgreja_Anterior").val();
        var funcao_a_exercer = $("#inputExercer_funcao").val();
        var achas_organizacao = $("#inputAchas_organizacao").val();

        //enviando requesição ajax
        var request = $.ajax({
            method: 'POST',
            dataType: 'text',
            url: 'registrar_membro.php',
            data: {
                meu_nome: nome,
                meu_bairro: bairro,
                minha_rua: rua,
                minha_descricao: descricao,
                meu_telefone1: telefone_principal,
                meu_telefone2: telefone_secundario,
                meu_genero: genero,
                minha_dataNascimento: data_nascimento,
                meu_facebook: facebook,
                meu_nivelEscolar: nivel_escolar,
                minha_areaFormacao: area_formacao,
                minha_profissao: profissao,
                minha_escola: escola,
                meu_ramoOcupacional: ramo_ocupacional,
                meu_estadoCivil: estado_civil,
                meu_pai: nome_pai,
                minha_mae: nome_mae,
                minha_catMembro: cat_membro,
                meu_grupo: grupo,
                minha_classe: classe,
                minha_comissao: comissao,
                minha_dataIngresso: data_ingresso,
                meu_cargo: cargo,
                minha_entrada_naOrganizacao: como_entrou_na_organizacao,
                minha_frequencia: frequencia_membro,
                meu_motivo: motivo_ausencia,
                minha_igrejaAnterior: igreja_anterior,
                minha_funcaoAExercer: funcao_a_exercer,
                oq_achas_organizacao: achas_organizacao
            },
            success: function(resposta) {
                $("#myModalInfo").show();
            },
            error: function(request, error) {
                console.log("error")
            }

        });
        $(".btn-ok").click(function() {
            setInterval(function() {
                window.location.href = "http://localhost:888/jimubSoft/jimubWeb/dashboard.html";
            }, 1000);

        });



    });

});
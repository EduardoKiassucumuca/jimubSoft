$(document).ready(function() {
    $("#myModalInfo").hide();
    $("#dados_eclesiasticos").hide();
    $(".btn-avancar").click(function() {
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
                window.location.href = "http://localhost:888/jimub/dashboard.html";
            }, 1000);

        });



    });

});
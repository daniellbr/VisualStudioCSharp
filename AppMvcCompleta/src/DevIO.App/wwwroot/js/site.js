﻿function AjaxModal() {
    $(document).ready(function () {
        $(function () {
            $.ajaxSetup({ cache: false });

            $("a[data-modal]").on("click",
                function (e) {
                    $('#myModalContent').load(this.href,
                        function () {
                            $('#myModal').modal({
                                keyborard: true
                            },
                                'show');
                            bindForm(this);
                        });
                    return false;
                });
        });


        function bindForm(dialog) {
            $('form', dialog).submit(function () {
                $.ajax({
                    url: this.action,
                    type: this.method,
                    data: $(this).serialize(),
                    success: function (result) {
                        if (result.success) {                            
                            $('#myModal').modal('hide');
                            $('#EnderecoTarget').load(result.url); //Carrega o resultado HTML para a div
                        } else {
                            $('#myModalContent').html(result);
                            bindForm(dialog);
                        }
                    }
                });
                return false;
            });
        }
    });
}

function BuscaCep() {
    $(document).ready(function () {

        function limpa_formulario_cep() {
            //Limpa valores do formulario de cep.
            $("#Endereco_Logradouro").val("");
            $("#Endereco_Bairro").val("");
            $("#Endereco_Cidade").val("");
            $("#Endereco_Estado").val("");
        }

        //Quando o campo cep perde o foco.
        $("#Endereco_Cep").blur(function () {

            //Nova variavel "cep" somente com digitos
            var cep = $(this).val().replace(/\D/g, '');

            //Verifica se campo cep possui valor informado
            if (cep != "") {

                //Expressao regular regex para validar o cep
                var validacep = /^[0-9]{8}$/;

                //Valida o formato do cep
                if (validacep.test(cep)) {
                    $("#Endereco_Logradouro").val("...");
                    $("#Endereco_Bairro").val("...");
                    $("#Endereco_Cidade").val("...");
                    $("#Endereco_Estado").val("...");

                    //Consulta o webservice viacep.com.br
                    $.getJSON("https://viacep.com.br/ws/" + cep + "/json/?callback=?",
                        function (dados) {

                            if (!("erro" in dados)) {
                                //Atualiza os campos com os valores da consulta
                                $("#Endereco_Logradouro").val(dados.logradouro);
                                $("#Endereco_Bairro").val(dados.bairro);
                                $("#Endereco_Cidade").val(dados.localidade);
                                $("#Endereco_Estado").val(dados.uf);
                            } else {
                                //Cep pesquisado não foi encontrado
                                limpa_formulario_cep();
                                alert("CEP não encontrado.");
                            }
                        })
                } else {
                    //cep invalido
                    limpa_formulario_cep();
                    alert("Formato do CEP inválido.");
                }
            } else {
                //cep sem valor, limpa formulário
                limpa_formulario_cep();
            }
        });
    });
};
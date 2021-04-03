using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using static DevIO.Business.Models.Validations.Documentos.ValidacaoDocumento;

namespace DevIO.Business.Models.Validations
{
    class FornecedorValidation : AbstractValidator<Fornecedor>
    {
        public FornecedorValidation()
        {
            RuleFor(fornec => fornec.Nome)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 1000)
                .WithMessage("O campo  {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            When(fornec => fornec.TipoFornecedor == TipoFornecedor.PessoaFisica, () => 
            {
                RuleFor(fornec => fornec.Documento.Length).Equal(CpfValidacao.TamanhoCpf)
                    .WithMessage("O campo Documento precisa ter {ComparisonValue} caracteres e foi fornecido {PropertyValue}.");
                RuleFor(fornec => CpfValidacao.Validar(fornec.Documento)).Equal(true)
                    .WithMessage("O documento fornecido é invalido");
            });
            When(fornec => fornec.TipoFornecedor == TipoFornecedor.PessoaJuridica, () => 
            {
                RuleFor(fornec => fornec.Documento.Length).Equal(CnpjValidacao.TamanhoCnpj)
                .WithMessage("O campo Documento precisa ter {ComparisonValue} caracteres e foi fornecido {PropertyValue}.");
                RuleFor(fornec => CnpjValidacao.Validar(fornec.Documento)).Equal(true)
                    .WithMessage("O documento fornecido é invalido");
            });
        }
    }
}

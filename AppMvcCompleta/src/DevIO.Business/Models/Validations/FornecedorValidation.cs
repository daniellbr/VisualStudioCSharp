using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using static DevIO.Business.Models.Validations.Documentos.ValidacaoDocumento;

namespace DevIO.Business.Models.Validations
{
    class EnderecoValidation : AbstractValidator<Endereco>
    {
        public EnderecoValidation()
        {
            RuleFor(ender => ender.Logradouro)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 200)
                .WithMessage("O campo  {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(ender => ender.Bairro)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 100)
                .WithMessage("O campo  {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(ender => ender.Cep)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(8)
                .WithMessage("O campo  {PropertyName} precisa ter {MinLength} caracteres");

            RuleFor(ender => ender.Cidade)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 100)
                .WithMessage("O campo  {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(ender => ender.Estado)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 50)
                .WithMessage("O campo  {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(ender => ender.Numero)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 50)
                .WithMessage("O campo  {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");
        }
    }
}

using DevIO.Business.Interfaces;
using DevIO.Business.Models;
using DevIO.Business.Notifications;
using FluentValidation;
using FluentValidation.Results;

namespace DevIO.Business.Services
{
    public abstract class BaseService
    {
        private readonly INotificador _notificador;

        public BaseService(INotificador notificador)
        {
            _notificador = notificador;
        }

        protected void Notificar(ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors)
            {
                Notificar(error.ErrorMessage);
            } 
        }
        protected void Notificar(string mensagem)
        {
            _notificador.Handle(new Notificacao(mensagem));
        }

        //Metodo generico que pode receber qualquer entidade para validação
        protected bool ExecutarValidacao<TV, TE>(TV tpGenValidacao, TE tpGenEntidade) where TV : AbstractValidator<TE> where TE : Entity
        {
            var validator = tpGenValidacao.Validate(tpGenEntidade);

            if (validator.IsValid) return true;

            Notificar(validator);

            return false;
        }
    }
}

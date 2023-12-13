using SpaUserControl.Common.Ressources;
using SpaUserControl.Common.Validation;
using System.Globalization;

namespace SpaUserControl.Domain.Models
{
    public class User
    {
        #region Ctor
        public User(string name, string email)
        {
            this.Id = new Guid();
            this.Name = name;
            this.Email = email;                         
        }
        #endregion

        #region Prop
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Passord { get; private set; }
        #endregion

        #region Metodos
        public void SetPassword(string password, string confirmPassoword)
        {
            AssertionConcern.AssertArgumentNotNull(password, Errors.SenhaNaoNula);
            AssertionConcern.AssertArgumentNotNull(confirmPassoword, Errors.ConfirmacaoNaoNula);
            AssertionConcern.AssertArgumentNotEmpty(password, Errors.ConfirmacaoNaoVazia);
            AssertionConcern.AssertArgumentLength(password, 6, 20, Errors.TamanhoMinMax);
            AssertionConcern.AssertArgumentNotEmpty(confirmPassoword, Errors.ConfirmacaoNaoVazia);
            AssertionConcern.AssertArgumentEquals(password, confirmPassoword,Errors.SenhasNaoCoincidem);

            this.Passord = PasswordAssertionConcern.Encrypt(password);
        }

        public string ResetPassword()
        {
            string password = Guid.NewGuid().ToString().Substring(0, 8);
            this.Passord = PasswordAssertionConcern.Encrypt(password);

            return password;
        }

        public void ChangeName(string name)
        {
            this.Name = name;
        }

        public void Validate()
        {
            AssertionConcern.AssertArgumentLength(this.Name,3,120,Errors.NomeInvalido);
            EmailAssertionConcern.AssertIsValid(this.Email);
            PasswordAssertionConcern.AssertIsValid(this.Passord);
        }
        #endregion

    }
}

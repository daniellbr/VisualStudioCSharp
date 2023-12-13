namespace SpaUserControl.Common.Validation
{
    public class PasswordAssertionConcern
    {
        public static void AssertIsValid(string password)
        {
            AssertionConcern.AssertArgumentNotNull(password, "Senha não pode ser nula ou vazia");
        }

        public static string Encrypt(string password)
        {
            //var guid = Guid.NewGuid();
            //password += "|" + guid;
            password += "|2d331cca - f6c0 - 40c0 - bb43 - 6e32989c2881";
            System.Security.Cryptography.MD5 mD5 = System.Security.Cryptography.MD5.Create();
            byte[] data = mD5.ComputeHash(System.Text.Encoding.Default.GetBytes(password));
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i = 0; i < data.Length; i++)
                sb.Append(data[i].ToString("x2"));
            return sb.ToString();
        }
    }
}

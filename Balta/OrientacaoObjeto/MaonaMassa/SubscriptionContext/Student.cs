namespace MaoNaMassa.Subscription
{
    public class Student
    {
        public Student(string name, string email, User user)
        {
            Name = name;
            Email = email;
            User = user;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public User User { get; set; }
    }
}
namespace YanStore.Domain.Application.Commands
{
    public class RegisterUserCommand
    {
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public RegisterUserCommand(string fullName, string username, string email, string password, string confirmpass)
        {
            this.FullName = fullName;
            this.UserName = username;
            this.Email = email;
            this.Password = password;
            this.ConfirmPassword = confirmpass;
        }
    }
}

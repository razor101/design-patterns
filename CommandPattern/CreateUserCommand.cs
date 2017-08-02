using System;

namespace design_patterns.CommandPattern
{
    public class CreateUserCommand : ICommandWithResults<string>
    {
        private readonly string userName;
        private readonly string email;
        private readonly string password;

        public CreateUserCommand(string userName, string email, string password)
        {
            this.password = password;
            this.email = email;
            this.userName = userName;
        }

        public string Execute()
        {
            return this.userName;
        }
    }
}
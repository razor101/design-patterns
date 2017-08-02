using System;

namespace design_patterns.CommandPattern
{
    public class CreateUserCommand : ICommandWithResults<Guid>
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

        public Guid Execute()
        {
            return Guid.NewGuid();
        }
    }
}
using System;

namespace design_patterns.CommandPattern
{
    public class LookupUserCommand : ICommandWithResults<string>
    {
        private readonly string email;
        public LookupUserCommand(string email)
        {
            this.email = email;
        }

        public string Execute()
        {
            return "John Doe";
        }
    }
}
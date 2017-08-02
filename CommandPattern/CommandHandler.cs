using System;

namespace design_patterns.CommandPattern
{
    public class CommandHandler : ICommandHandler
    {
        public void Execute(ICommand command)
        {
            command.Execute();
        }

        public TResult ExecuteWithResults<TResult>(ICommandWithResults<TResult> command)
        {
            return command.Execute();
        }
    }
}
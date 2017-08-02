using System;

namespace design_patterns.CommandPattern
{
    public class CommandHandler : ICommandHandler
    {
        public void Execute<TCommand>(TCommand command)
            where TCommand : ICommand
        {
            command.Execute();
        }

        public TCommandResults ExecuteWithResults<TCommand, TCommandResults>(TCommand command)
            where TCommand : ICommandWithResults<TCommandResults>
        {
            return command.Execute();
        }
    }
}
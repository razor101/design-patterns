namespace design_patterns.CommandPattern
{
    public interface ICommandHandler
    {
         void Execute<TCommand>(TCommand command)
            where TCommand : ICommand;

         TCommandResults ExecuteWithResults<TCommand, TCommandResults>(TCommand command)
            where TCommand : ICommandWithResults<TCommandResults>;
    }
}
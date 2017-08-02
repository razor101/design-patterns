namespace design_patterns.CommandPattern
{
    public interface ICommandHandler
    {
         void Execute(ICommand command);

         TResult ExecuteWithResults<TResult>(ICommandWithResults<TResult> command);
    }
}
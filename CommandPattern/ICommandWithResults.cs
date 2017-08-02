namespace design_patterns.CommandPattern
{
    public interface ICommandWithResults<TResults>
    {
         TResults Execute();
    }
}
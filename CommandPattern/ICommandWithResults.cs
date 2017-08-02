namespace design_patterns.CommandPattern
{
    public interface ICommandWithResults<T>
    {
         T Execute();
    }
}
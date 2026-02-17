namespace Akeldov.Collections.Queries
{
    public interface IFunc<TFrom, TTo>
    {
        TTo Invoke(TFrom value);
    }
}

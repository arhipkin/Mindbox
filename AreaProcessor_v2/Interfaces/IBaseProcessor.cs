namespace AreaProcessor_v2.Interfaces
{
    public interface IBaseProcessor<TResult>
    {
        TResult Process(params double[] data);
    }
}

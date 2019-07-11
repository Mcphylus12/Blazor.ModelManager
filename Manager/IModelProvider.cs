namespace Manager
{
    public interface IModelProvider
    {
        IModelHandle<T> RequestHandle<T>()
            where T : class;
    }
}

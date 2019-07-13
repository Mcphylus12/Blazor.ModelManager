namespace Manager
{
    public interface IModelStoreCollection
    {
        IModelStore GetStore<T>();
    }
}
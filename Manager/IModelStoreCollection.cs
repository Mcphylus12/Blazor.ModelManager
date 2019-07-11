namespace Manager
{
    internal interface IModelStoreCollection
    {
        IModelStore GetStore<T>();
    }
}
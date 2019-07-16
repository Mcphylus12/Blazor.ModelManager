namespace Manager
{
    public interface IModelStoreRegister
    {
        void RegisterStoreOverride<TModel>(IModelStore store);
    }
}

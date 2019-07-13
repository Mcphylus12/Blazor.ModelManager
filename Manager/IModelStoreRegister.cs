namespace Manager
{
    public interface IModelStoreRegister
    {
        void RegisterStoreOverride<TModel, TStore>()
            where TStore : IModelStore;
    }
}

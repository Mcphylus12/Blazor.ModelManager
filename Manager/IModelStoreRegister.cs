namespace Manager
{
    public interface IModelStoreRegister
    {
        void RegisterStoreOverride<TModel, TModelStore>()
            where TModelStore : class, IModelStore;
    }
}

namespace Manager
{
    public interface IModelManagerConfiguration
    {
        void RegisterManagers(IModelManagerRegister register);
        void RegisterStoreOverrides(IModelStoreRegister storeRegister);
    }
}

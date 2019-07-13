namespace Manager
{
    public interface IModelRequestManagerStore
    {
        IModelRequestManager GetManager<T>();

        void RegisterModelManager<ModelType>(IModelRequestManager manager);
    }
}
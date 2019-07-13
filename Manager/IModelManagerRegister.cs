namespace Manager
{
    public interface IModelManagerRegister
    {
        void RegisterModelManager<TModel, TModelManager>()
            where TModelManager : IModelRequestManager;
    }
}

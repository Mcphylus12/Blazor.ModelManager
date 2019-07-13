using ModelManager.Managers;

namespace Manager
{
    public interface IModelManagerRegister
    {
        void RegisterModelManager<TModel, TModelManager>()
            where TModelManager : ModelRequestManager;
    }
}

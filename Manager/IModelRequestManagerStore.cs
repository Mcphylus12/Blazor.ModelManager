namespace Manager
{
    public interface IModelRequestManagerStore
    {
        IModelRequestManager GetManager<T>();
    }
}
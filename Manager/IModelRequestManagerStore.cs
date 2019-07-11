namespace Manager
{
    internal interface IModelRequestManagerStore
    {
        IModelRequestManager GetManager<T>();
    }
}
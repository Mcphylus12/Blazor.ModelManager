namespace Manager
{
    public interface IModelStorer
    {
        void StoreModel<T>(string key, T model);
    }
}
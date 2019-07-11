namespace Manager
{
    internal interface IModelRequestManager
    {
        void AddInterest(string key);

        void RemoveInterest(string key);
    }
}
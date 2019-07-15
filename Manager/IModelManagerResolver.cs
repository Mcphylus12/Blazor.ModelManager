using System;

namespace Manager
{
    public interface IModelManagerResolver
    {
        IModelRequestManager GetManager(Type managerType);
    }
}
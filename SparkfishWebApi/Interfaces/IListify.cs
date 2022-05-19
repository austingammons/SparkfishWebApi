using System.Collections.Generic;

namespace SparkfishWebApi.Interfaces
{
    public interface IListify<T>
    {
        T IndexOfRange(IEnumerable<T> sequence, int index);
    }
}

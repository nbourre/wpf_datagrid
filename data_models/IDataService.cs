using System;
using System.Collections.Generic;
using System.Text;

namespace data_models
{
    interface IDataService<T>
    {
        IEnumerable<T> GetAll();
        void Add(T record);
    }
}

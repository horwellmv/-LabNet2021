using System.Collections.Generic;

namespace Lab.Net.Practica.Logic
{
    interface IMetodosLogic<T> 
    {
        List<T> GetAll();
        void add(T newAdd);
        void update(T toUpdate);
    }
}

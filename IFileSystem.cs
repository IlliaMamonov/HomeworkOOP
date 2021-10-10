using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    interface IFileSystem<T> 
    {
        public T Open();
        public void Delete();
    }
}

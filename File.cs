using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class File : FileSystemObject
    {
        private object _content;
        public object Content { get => _content; set => _content = value; }
        
        public override void Delete()
        {
            Console.WriteLine("file " + this.Name + " located at " + this.Path + " deleted!");
        }

        public override FileSystemObject Open()
        {
            return this;
        }
    }
}

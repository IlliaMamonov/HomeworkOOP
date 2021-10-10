using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Shortcut : FileSystemObject
    {
        private File _content;
        public File Content { get => _content; set => _content = value; }
        public override void Delete()
        {
            Console.WriteLine("Short cut has been deleted");
        }

        public override FileSystemObject Open()
        {
            return _content.Open();
        }
    }
}

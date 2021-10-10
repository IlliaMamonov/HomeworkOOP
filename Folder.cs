using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Folder : FileSystemObject
    {

        private List<FileSystemObject> _content = new List<FileSystemObject>();
        public List<FileSystemObject> Content { get => _content; set => _content = value; }

        public void AddObject(FileSystemObject ob)
        {
            _content.Add(ob);
        }

        public override void Rename(string name)
        {
            foreach (var element in _content)
            {
                element.Path = "new path, a folder was renamed";
            }
        }
        public override void MoveTo(string path)
        {
            foreach (var element in _content)
            {
                element.Path = "new path, a folder was moved";
            }
            Console.WriteLine("Hello World!");
        }

        public override void Delete()
        {
            throw new NotImplementedException();
        }

        public override FileSystemObject Open()
        {
            return this;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    abstract class FileSystemObject : IFileSystem<FileSystemObject>
    {

        private string _path;
        private string _name;
        public string Path { get => _path; set => _path = value; }
        public string Name { get => _name; set => _name = value; }
        public abstract void Delete();
        public abstract FileSystemObject Open();

        public virtual void Rename(string name)
        {
            if (Name is not null)
            {
                this.Name = name;
            }
        }

        public virtual void MoveTo(string path)
        {
            Console.WriteLine("Moved to " + path);
        }

    }
}

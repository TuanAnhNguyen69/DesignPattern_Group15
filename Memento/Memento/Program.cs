using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Program
    {
        class Storage // Memento
        {
            public Storage(String content)
            {
                this.content = content;
            }

            public String content { get; set; }
        }

        class Editor //Originator
        {
            public String content { get; set; }

            public void Type(String content)
            {
                this.content = content;
            }

            public void UnDo(Storage storage)
            {
                this.content = storage.content;
            }

            public Storage Save()
            {
                return new Storage(content);
            }
        }



        static void Main(string[] args)
        {
            Editor editor = new Editor();
            Storage storage = new Storage("");

            editor.Type("Abcd");
            Console.WriteLine(editor.content);
            storage = editor.Save();
            Console.WriteLine("Saved");

            editor.Type("ababababa");
            Console.WriteLine(editor.content);
            editor.UnDo(storage);
            Console.WriteLine("UnDo");

            Console.WriteLine(editor.content);
            Console.ReadLine();
        }
    }
}

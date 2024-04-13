using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAuthors
{
    internal class Author
    {
        private List<string> names = new List<string>();
        
        private string filename = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/Authors.txt";

        public List<string> Names
  {
            get
            {
                return names;
            }
            set
            {
                names = value;
            }
        }

        public string Filename
        {
            get
            {
                return filename;
            }
        }   
        
        public Author()
        {
            Names = ReadFromFile();
        }

        private List<string> ReadFromFile()
        {
            if (!File.Exists(Filename))
            {
                File.Create(Filename).Close();
            }
            return File.ReadAllLines(Filename).ToList();
        }

        public void WriteToFile()
        {
            File.WriteAllLines(Filename, Names);
        }

    }
}

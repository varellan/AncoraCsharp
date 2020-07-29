using System;
using System.IO;
using System.Text;

namespace Lab9_4
{
    class Header
    {
        public const string open = "<h1>";
        public const string close = "<h2>";

        public string CreateHeader(string text)
        {
            string header = String.Concat(open, text, close, "\n");
            return header;
        }
    }

    class UnorderedList
    {
        public const string open = "<h1>";
        public const string close = "<h2>";

        public string CreateListItem(string text)
        {
            string open = "<li>\n";
            string close = "</li>\n";

            string listItem = String.Concat(open, text, close, "\n");
            return listItem;
        }

        public StringBuilder CreateList(string[] listItems)
        {

            StringBuilder sb = new StringBuilder();
            sb.Append(open);
            foreach (string item in listItems)
            {
                sb.Append(item);
            }
            sb.Append(close);

            return sb;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            string filename = "D://Users//sdoff//source//repos//9_4//somefilename.html";

            Header header = new Header();
            UnorderedList list = new UnorderedList();
            StringBuilder sb = new StringBuilder();

            Console.WriteLine("Enter text for HTML header.");
            string headerElement = header.CreateHeader(Console.ReadLine());
            string[] listItems = new string[3];

            for (int i = 0; i < listItems.Length; i++)
            {

                Console.WriteLine("Add another item to the list.");
                listItems[i] = list.CreateListItem(Console.ReadLine());
            }

            StringBuilder listElement = list.CreateList(listItems);
            sb.Append(headerElement);
            sb.Append(listElement.ToString());

            File.AppendAllText(filename, sb.ToString());
        }
    }
}
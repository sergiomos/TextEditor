using System;
using System.IO;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar novo arquivo");
            Console.WriteLine("0 - Sair");

            short option = short.Parse(Console.ReadLine());

            Console.Write(option);

            switch(option) {
                case 0: System.Environment.Exit(0); break;
                case 1: OpenFile(); break;
                case 2: CreateNewFile(); break;
                default: Menu(); break;
            }
        }

        static void OpenFile() {}

        static void CreateNewFile() 
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
            Console.WriteLine("------------------------");

            string text = "";

            do {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while(Console.ReadKey().Key != ConsoleKey.Escape);

            Console.Write(text);
        }
   
        static void SaveFile(string text) 
        {
            Console.Clear();
            Console.WriteLine("Qual caminho para salvar o arquivo?");

            string path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }


        }
    }
}

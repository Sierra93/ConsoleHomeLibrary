using System;

namespace ConsoleHomeLibrary {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Выберите пункт меню:\n" +
                "1 - Добавление книги в коллекцию\n" +
                "2 - Просмотр списка коллекции");
            int inputParam = Convert.ToInt32(Console.ReadLine());
            switch (inputParam) {
                case 1:
                    // Добавление книги в коллекцию
                    Book.AddBook();
                    break;
                case 2:
                    // Просмотр списка коллекции
                    Book.InfoList();
                    break;
            }
            Console.ReadKey();
        }
    }
}

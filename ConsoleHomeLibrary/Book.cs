using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;
using System.IO;

namespace ConsoleHomeLibrary {
    // Класс, который представляет книгу
    public class Book {
        public int ID { get; set; }     // ID книги
        public string bookName { get; set; }    // Название книги
        public int bookYear { get; set; }   // Год издания
        public Book(int id, string name, int year) {
            ID = id;
            bookName = name;
            bookYear = year;
        }
        // Просматриваем список
        public static void InfoList() {
            // Инициализируем объект значениями
            Book philosophy = new Book(
                1,
                "Философия",
                1964);
            Console.WriteLine();

            Book liter = new Book(
                2,
                "Литература",
                1976);
            Console.WriteLine();

            // up cast приводим объекты класса Book к общему, для того чтобы работать как с единым целым
            List<object> books = new List<object> {
                philosophy,
                liter
            };
            // Выводим список книг
            Console.WriteLine();
            // Записываем в перечислитель элементы из общего списка, чтобы работать с ним через LINQ
            IEnumerable listBooks = (from b in books select b);
            foreach (Book book in listBooks) {
                Console.WriteLine(book.bookName);
                Console.WriteLine(book.bookYear);
                Console.WriteLine();
            }
            // Записываем коллекцию в файл и читаем из нее  
            string readPath = @"C:\FFiles\library.txt";
            //string writePath = @"C:\FFiles\library.txt";
            string text = "";
            try {
                using (StreamReader sr = new StreamReader(readPath, Encoding.Default)) {
                    text = sr.ReadToEnd();
                    Console.WriteLine("Данные из файла\n" + text);
                }
                //using (StreamWriter sw = new StreamWriter(writePath, false, Encoding.Default)) {
                //    sw.WriteLine(text);
                //    sw.WriteLine(bookNewName);
                //    sw.WriteLine(bookNewYear);
                //}

                //using (StreamWriter sw = new StreamWriter(writePath, true, Encoding.Default)) {
                //    IEnumerable listBooksNew = (from b in books select b);
                //    foreach (Book book in listBooksNew) {
                //        Console.WriteLine(book.bookName);
                //        Console.WriteLine(book.bookYear);
                //        Console.WriteLine();
                //    }
                //}
            }
            catch {
                Console.WriteLine("Неверный формат файла");
                //throw new Exception("Неверный формат файла");
            }
        }
        // Добавляем книгу
        public static void AddBook() {
            Console.WriteLine("Введите название новой книги: ");
            // Вводим название книги
            string bookNewName = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Введите год издания новой книги: ");
            // Вводим год издания книги
            var bookNewYear = Convert.ToInt32(Console.ReadLine());
            // Инициализируем объект значениями
            Book philosophy = new Book(
                1,
                "Философия",
                1964);
            Console.WriteLine();

            Book liter = new Book(
                2,
                "Литература",
                1976);
            Console.WriteLine();

            // up cast приводим объекты класса Book к общему, для того чтобы работать как с единым целым
            List<object> books = new List<object> {
                philosophy,
                liter
            };
            // Выводим список книг
            // Записываем в перечислитель элементы из общего списка, чтобы работать с ним через LINQ
            IEnumerable listBooks = (from b in books select b);
            foreach (Book book in listBooks) {
                Console.WriteLine(book.bookName);
                Console.WriteLine(book.bookYear);
                Console.WriteLine();
            }
            //foreach (Book elem in books) {

            //}
            //IEnumerable listItems = (from b in books.ToList() select b);
            //foreach (Book book in listItems) {
            //    books.Add(bookNewName);
            //    books.Add(philosophy);
            //    Console.WriteLine(book.bookName);
            //    Console.WriteLine(book.bookYear);
            //    Console.WriteLine();
            //}
            Console.WriteLine();

            // Записываем коллекцию в файл и читаем из нее  
            string readPath = @"C:\FFiles\library.txt";
            string writePath = @"C:\FFiles\library.txt";
            string text = "";
            try {
                using (StreamReader sr = new StreamReader(readPath, Encoding.Default)) {
                    text = sr.ReadToEnd();
                    Console.WriteLine("Данные из файла\n" + text);
                }
                using (StreamWriter sw = new StreamWriter(writePath, false, Encoding.Default)) {
                    sw.WriteLine(text);
                    sw.WriteLine(bookNewName);
                    sw.WriteLine(bookNewYear);
                }

                using (StreamWriter sw = new StreamWriter(writePath, true, Encoding.Default)) {
                    IEnumerable listBooksNew = (from b in books select b);
                    foreach (Book book in listBooksNew) {
                        Console.WriteLine(book.bookName);
                        Console.WriteLine(book.bookYear);
                        Console.WriteLine();
                    }
                }
            }
            catch {
                Console.WriteLine("Неверный формат файла");
                //throw new Exception("Неверный формат файла");
            }
        }
    }
}

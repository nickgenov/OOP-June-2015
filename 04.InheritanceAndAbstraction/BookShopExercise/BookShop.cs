using System;

namespace BookShopExercise
{
    class BookShop
    {
        static void Main()
        {
            Book book = new Book("Pod Igoto", "Ivan Vazov", 15.90M);
            Console.WriteLine(book);

            GoldenEditionBook goldenBook = new GoldenEditionBook("Tutun", "Dimitar Dimov", 22.90M);
            Console.WriteLine(goldenBook);
        }
    }
}
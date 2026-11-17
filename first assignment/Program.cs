namespace first_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 1st Question 

            object historicalBook = new Book("2nd world war", 445);
            Console.WriteLine(historicalBook);

            #endregion

            #region 2nd Question

            string res1 = historicalBook.ToString();
            bool res2 = historicalBook.Equals(historicalBook);
            int res3 = historicalBook.GetHashCode();
            object res4 = historicalBook.GetType();

            #endregion

            #region 3rd Question

            //int pages = "464";
            //compile_time error, it has to be:
            int pages = 464;

            #endregion

            #region 4th Question 
            try
            {
                int x = 10;
                int y = 0;
                int division = x / y;
            }
            catch { Console.WriteLine("Cannot divide by zero"); }
            finally { Console.WriteLine("Done"); }

            #endregion

            #region 5th Question 

            int Pages = 400;
            double result = Pages;

            #endregion

            #region 6th Question 

            double price = 49.99;
            int priceConverted = (int)price;

            #endregion

            #region 7th Question 

            string pagesText = "464";
            int result2 = Convert.ToInt32(pagesText);

            #endregion

            #region 8th Question 

            string yearText = "2023";
            int result3 = int.Parse(yearText);
            string badText = "abc";
            bool result4 = int.TryParse(badText, out int ress);
            if (!result4)
            Console.WriteLine("Invalid number");

            #endregion

            #region 9th Question 

            int PageS = 464;
            string result5 = PageS.ToString();
            Console.WriteLine(result5.GetType());

            #endregion

            #region 10th Question 

            int copies = 100;
            object r = copies;
            int t = (int)r;
            Console.WriteLine($"boxing {r} , unboxing {t}");
            #endregion

            #region 11th Question 

            int? year = null;
            Console.WriteLine(year.HasValue);

            year = 2023;
            Console.WriteLine(year);

            #endregion

            #region 12th Question 

            string? reviewer = null;
            if (year.HasValue)
                Console.WriteLine(reviewer);

            #endregion

            #region 13th Question 

            Book? book = null;
            book?.title = Console.ReadLine();
            Console.WriteLine(book?.title);

            #endregion

            #region 14th Question 

            Console.WriteLine(book?.title ?? "Untitled");
            book?.title ??= "Untitled";

            #endregion

            #region 15th Question 

            string? name = "Ahmed";

            string confirmedName = name!;

            Console.WriteLine(confirmedName);

            #endregion
        }
    }
}

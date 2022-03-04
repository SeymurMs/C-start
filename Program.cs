using System;

   namespace P203
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic month = "december";

            #region if else
            if (month == "december" || month == "march" || month == "may" || month == "july" || month == "august")
            {
                Console.WriteLine("31 days");
            } else if (month == "january" || month == "april" || month == "june" || month == "september" || month == "november" || month == "october")
            {
                Console.WriteLine("30 days");
            } else if (month == "february")
            {
                Console.WriteLine("29 gundur");
            }
            else
            {
                Console.WriteLine("wrong input");
            }
            #endregion 



            #region Switch case
            //switch (month)
            // {
            //     case "january":
            //         Console.WriteLine("31gundur");
            //         break;
            //     case "february":
            //         Console.WriteLine("29gundur");
            //         break;
            //     case "december":
            //         Console.WriteLine("31gundur");
            //         break;
            //     case "march":
            //         Console.WriteLine("31gundur");
            //         break;
            //     case "april":
            //         Console.WriteLine("30gundur");
            //         break;
            //     case "may":
            //         Console.WriteLine("31gundur");
            //         break;
            //     case "june":
            //         Console.WriteLine("30 gundur");
            //         break;
            //     case "july":
            //         Console.WriteLine("31gundur");
            //         break;
            //     case "august":
            //         Console.WriteLine("31gundur");
            //         break;
            //     case "september":
            //         Console.WriteLine("30gundur");
            //         break;
            //     case "november":
            //         Console.WriteLine("30gundur");
            //         break;
            //     case "october":
            //         Console.WriteLine("31gundur");
            //         break;

            // }
            #endregion





        }
    }
}

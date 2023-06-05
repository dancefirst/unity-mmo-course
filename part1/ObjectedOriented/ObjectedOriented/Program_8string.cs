using System;

namespace ObjectedOriented
{
    // 문자열 !!

    class Program
    {
        static void Main(string[] args)
        {
            string name = "Harry Porter";

            // 1. 찾기
            bool found = name.Contains("Harry");
            int indexOfP = name.IndexOf("P");

            // 2. 변형하기
            name = name + " Junior";

            string lowerCaseName = name.ToLower();
            string upperCaseName = name.ToUpper();
            string newName = name.Replace("r", "l");

            // 3. 분할하기
            string[] names = name.Split(new char[] { ' ' });
            Console.WriteLine(names);

            string nameSubstring = name.Substring(5);
            Console.WriteLine(nameSubstring);

        }
    }
}

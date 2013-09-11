using System;

namespace Files
{
	class MainClass
	{
		static void Read() {

			for (int i=0; i<lines.Length; i++) {
				Console.WriteLine (lines [i]);
			}

		}

		static void Write() {
			string tekst = "Lang\n kedelig\n tekst!";
			//string path = @"/Users/ptx/Desktop/test.txt";

			string path = @"C:\Users\brugernavn\Desktop\test.txt";
			// ^- Husk at ændre brugernavn!

			System.IO.File.WriteAllText (path, tekst);


		}

		public static void Main (string[] args)
		{

			Write ();
			Read ();

			
			Console.ReadKey();
		}
	}
}

using System;

namespace Files
{
	class MainClass
	{
		static void Read(string path) {
			
			string[] lines = System.IO.File.ReadAllLines (path);

			for (int i=0; i<lines.Length; i++) {
				Console.WriteLine (lines [i]);
			}

		}

	

		static void Write(string path) {
			string tekst = "Lang\n kedelig\n tekst!";
			//string path = @"/Users/ptx/Desktop/test.txt";

			

			System.IO.File.WriteAllText (path, tekst);


		}

		public static void Main (string[] args)
		{



			string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

			Console.WriteLine ("Dit skrivebord ligger på: " + desktop);

			string p = System.IO.Path.Combine (desktop, "test.txt");

			Console.WriteLine ("Fuld sti til fil: " + p);


			Write (p);
			Read (p);

			
			Console.ReadKey();
		}
	}
}

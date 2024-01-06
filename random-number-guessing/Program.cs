namespace random_number_guessing
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Tahmin Oyunu";
			int puan = 50;
			while (true) // Oyun Döngüsü
			{
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("\t\t\t --Yeni Oyun--");
				int can = 3;
				Random a = new Random();
				int number = a.Next(0, 6);
				while (true) // Yanlış cevap döngüsü
				{
					Console.Write("Sayıyı tahmin edin: ");
					Console.ForegroundColor = ConsoleColor.Blue;
					Console.WriteLine($"\t\t\t\t Puan: {puan} \t Kalan hak: {can}");
					Console.ForegroundColor = ConsoleColor.White;
					int tahmin = Convert.ToInt32(Console.ReadLine());
					if (puan <= 0)
					{
						Console.Clear();
						puan = 50;
                        Console.WriteLine("Oyun bitti! Tekrar deneyin.");
                        break;
					}
					if (tahmin == number) // Doğru cevap şartı
					{
						puan = puan + 10;
						Console.Clear();
						Console.ForegroundColor = ConsoleColor.Green;
						Console.WriteLine("Doğru!");
						Console.ForegroundColor = ConsoleColor.White;
						break;
					}
					else // Yanlış cevap şartı
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("Yanlış!");
						puan = puan - 5;
						can--;
						if (can == 0) // Oyun kaybetme durum şartı
						{
							Console.Clear();
							Console.WriteLine("Hakkınız tükendi! Kaybettiniz.");
							break;
						}
						Console.ForegroundColor = ConsoleColor.White;
					}
				}
			}
		}
	}
}
namespace random_number_guessing
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Tahmin Oyunu";
			int puan = 0, can = 0, aralik = 0; // Dsğişken hatası almamak için boş atama yapılması
			Console.WriteLine("Zorluk seviyesi seçin (1 - 2 - 3)");
			byte level = Convert.ToByte(Console.ReadLine()); // Kullanıcıdan zorluk seviyesi alma
			if (level == 1) // Zorluk seviyesi atama
			{
				can = 5;
				puan = 100;
				aralik = 10;
			}
			else if (level == 2)
			{
				can = 5;
				puan = 75;
				aralik = 10;
			}
			else if (level == 3)
			{
				can = 3;
				puan = 50;
				aralik = 20;
			}
			while (true) // Ana Oyun Döngüsü
			{
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine($"\t\tZorluk: {level}\t --Yeni Oyun--");
				int can_1 = can , puan_1 = puan; // Her yeni oyunda can ve puan yenilenmesi yapılması
				Random a = new Random();
				int number = a.Next(0, aralik);
				while (true) // Yanlış cevap döngüsü
				{
					Console.Write("Sayıyı tahmin edin: ");
					Console.ForegroundColor = ConsoleColor.Blue;
					Console.WriteLine($"\t\t\t\t Puan: {puan_1} \t Kalan hak: {can_1}");
					Console.ForegroundColor = ConsoleColor.White;
					int tahmin = Convert.ToInt32(Console.ReadLine());
					if (puan_1 <= 0) // Puan sıfırlanınca oyunu tekrar başlatma
					{
						Console.Clear();
						puan_1 = puan;
                        Console.WriteLine("Oyun bitti! Tekrar deneyin.");
                        break;
					}
					if (tahmin == number) // Doğru cevap şartı
					{
						puan_1 = puan_1 + 10;
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
						puan_1 = puan_1 - 5;
						can_1--;
						if (can_1 == 0) // Can sıfırlanınca oyunu tekrar başlatma
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
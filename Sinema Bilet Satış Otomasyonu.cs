Class Program
{
	static void Main(string[] args)
	{
	double bilet_satis_fiyati=0, indirim_tutari=0, odenecek_tutar=0;
	char secim1, secim2;

	Console.Write("Bilet Satış Fiyatı:");
	bilet_satis_fiyati=Convert.ToDouble(Console.ReadLine());
	Console.WriteLine("1-Normal Bilet \n 2-İndirimli Bilet");
	Console.Write("Seçiminiz: (1,2):");
	secim1=Convert.ToDouble(Console.ReadLine());
	
	if(secim1=='1')
	{
	indirim_tutari=0;
	odenecek_tutar = bilet_satis_fiyati;
	Console.Write("Bilet Satış Fiyatı{0} İndirim Oranı=0 İndirim Tutarı=0 Bilet Türü=Normal Ödenecek Tutar{1}",bilet_satis_fiyati,odenecek_tutar);
	}
	else if(secim=='2')
	{
	Console.WriteLine("1-Öğrenci 2-Gazi 3-Öğretmen 4-Polis");
	Console.Write("Seçiminiz 1/2/3/4");
	seçim2=Convert.ToChar(Console.ReadLine());
	
	switch(secim2)
	{
		case '1';
		indirim tutari=bilet_satis_fiyati * 0,5;
		odenecek_tutar=bilet_satis_fiyati - indirim_tutari;
		Console.Write("Bilet Satış Fiyatı{0} İndirim Oranı=%50 İndirim Tutarı={1} Bilet Türü=Öğrenci Ödenecek Tutar{2}",bilet_satis_fiyati,indirim_tutari,odenecek_tutar);
		break;

		case '2';
		indirim tutari=bilet_satis_fiyati * 0,4;
		odenecek_tutar=bilet_satis_fiyati - indirim_tutari;
		Console.Write("Bilet Satış Fiyatı{0} İndirim Oranı=%40 İndirim Tutarı={1} Bilet Türü=Gazi Ödenecek Tutar{2}",bilet_satis_fiyati,indirim_tutari,odenecek_tutar);
		break;

		case '3';
		indirim tutari=bilet_satis_fiyati * 0,3;
		odenecek_tutar=bilet_satis_fiyati - indirim_tutari;
		Console.Write("Bilet Satış Fiyatı{0} İndirim Oranı=%30 İndirim Tutarı={1} Bilet Türü=Öğretmen Ödenecek Tutar{2}",bilet_satis_fiyati,indirim_tutari,odenecek_tutar);
		break;

		case '4';
		indirim tutari=bilet_satis_fiyati * 0,2;
		odenecek_tutar=bilet_satis_fiyati - indirim_tutari;
		Console.Write("Bilet Satış Fiyatı{0} İndirim Oranı=%20 İndirim Tutarı={1} Bilet Türü=Polis Ödenecek Tutar{2}",bilet_satis_fiyati,indirim_tutari,odenecek_tutar);
		break;

		default:
		Console.Write("Hatalı Menü Seçimi!");
		break;
	}
	}
	else
	{
	Console.Write("Hatalı Menü Seçimi!");
	}

        Console.ReadKey();
	}
}

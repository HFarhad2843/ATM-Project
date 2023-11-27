

int balans = 1500;

Console.WriteLine("Kapital banka xosh geldiniz");
Console.WriteLine("Muvafiq seciminizi edin");


Console.WriteLine("1- Balansi ekranda goster");
Console.WriteLine("2- Naglashdirma");
Console.WriteLine("3-Balansi artir");
Console.WriteLine("4-Cixish");

string secim = Console.ReadLine();

switch (secim)
{
    case "1":
        Console.WriteLine("balansiniz:" + balans);
        break;


    case "2":
        Console.WriteLine("Nagdlashdiracaginiz meblegi gosterir");
        int cekilecek_mebleg = Convert.ToInt32(Console.ReadLine());

        if (cekilecek_mebleg > balans)
        {
            Console.WriteLine("Balansinizda yeteri qeder vesait yoxdur");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Balansinizda qalan mebleg:" + (balans - cekilecek_mebleg));
        }
        break;

    case "3":
        Console.WriteLine("Artiracaginiz meblegi daxil edin");
        int artirilacaq_mebleg = (int)Convert.ToUInt32(Console.ReadLine());

        Console.WriteLine("Girdiyiniz mebleg: " + (balans + artirilacaq_mebleg));
        break;

    case "4":
        Console.WriteLine("Cixish Gununuz ugurlu olsun");
        break;

    default:
        Console.WriteLine("Xahish edirik duzgun secim edin");
        break;
}

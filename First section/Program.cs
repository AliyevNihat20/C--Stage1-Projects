// Greeting Program -1

//Console.WriteLine("Hello, World!");

//Console.WriteLine("What is your name?");
//string name = Console.ReadLine();
//Console.WriteLine("Hello, " + name);











//Simple Calculator-2

//Console.WriteLine("1-ci ədədi daxil edin:");
//int eded1 = int.Parse(Console.ReadLine());

//Console.WriteLine("Əməliyyatı daxil edin (+, -, *, /):");
//string emeliyyat = Console.ReadLine();

//Console.WriteLine("2-ci ədədi daxil edin:");
//int eded2 = int.Parse(Console.ReadLine());

//if (emeliyyat == "+")
//{
//    Console.WriteLine("Nəticə: " + (eded1 + eded2));
//}
//else if (emeliyyat == "-")
//{
//    Console.WriteLine("Nəticə: " + (eded1 - eded2));
//}
//else if (emeliyyat == "*")
//{
//    Console.WriteLine("Nəticə: " + (eded1 * eded2));
//}
//else if (emeliyyat == "/")
//{
//    Console.WriteLine("Nəticə: " + (eded1 / eded2));
//}
//else
//{
//    Console.WriteLine("Yanlış əməliyyat!");
//}











//BMI Calculator-3

//Console.WriteLine("Çəkinizi daxil edin:");
//double ceki = double.Parse(Console.ReadLine());
//Console.WriteLine("Boyunuzu daxil edin:");
//double boy = double.Parse(Console.ReadLine());
//double bmi = ceki / (boy * boy);
//Console.WriteLine("BMI: " + bmi);












//Number Guessing Game-4

//Random random = new Random();
//int gizliEded = random.Next(1, 101);
//Console.WriteLine("Ədəd təxmin et:");
//int texmin = 0;

//while (texmin != gizliEded)
//{

//    texmin = int.Parse(Console.ReadLine());

//    if (texmin == gizliEded)
//    {
//        Console.WriteLine("Təbriklər! Düzgün təxmin etdiniz.");
//    }
//    else if (texmin < gizliEded)
//    {
//        Console.WriteLine("Daha böyük bir ədəd təxmin edin.");
//    }
//    else
//    {
//        Console.WriteLine("Daha kiçik bir ədəd təxmin edin.");
//    }
//}







//Multiplication Table-5

//Console.WriteLine("Ədəd daxil edin:");
//int eded = int.Parse(Console.ReadLine());
//for(int i = 1; i <= 10; i++)
//{
//    Console.WriteLine(eded + " x " + i + " = " + (eded * i));
//}





//PIN Code Login System-6

//Console.WriteLine("karti daxil edin:");
//Thread.Sleep(500);

//Console.WriteLine("bir nece saniye gozleyin...");
//Thread.Sleep(3000);
//Console.WriteLine("4 reqemli kodu daxil edin:");
//Thread.Sleep(1000);
//Console.WriteLine("4 rəqəmli kodu daxil edin:");
//int kod = int.Parse(Console.ReadLine());

//int haqq = 3;

//if(kod == 1234)
//{
//    Console.WriteLine("Daxil oldunuz!");
//}
//else
//{
//    while (haqq > 0)
//    {
//        haqq--;
//        Console.WriteLine("Yanlış kod! Qalan cəhd sayı: " + haqq);
//        if (haqq == 0)
//        {
//            Console.WriteLine("Hesabınız bloklandı!");
//            break;
//        }
//        Console.WriteLine("4 rəqəmli kodu daxil edin:");
//        kod = int.Parse(Console.ReadLine());
//        if (kod == 1234)
//        {
//            Console.WriteLine("Daxil oldunuz!");
//            break;
//        }
//    }
//}


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

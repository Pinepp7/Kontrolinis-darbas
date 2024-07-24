
//Uzduotis 1.



//namespace Classes.Models
//{
//    public class Automobilis
//    {

//        public string Marke;
//        public int metai; 


//        public Automobilis(string Marke, int matai)
//        {


//            this.Marke = Marke;
//            metai = matai;
//        }

//    }
//    class Program
//    {

//        static void Main(string[] args)
//        {



//            Automobilis manoAutomobilis = new Automobilis( "Golf 4", 1998);

//            Console.WriteLine("Automobilio marke: " + manoAutomobilis.Marke);
//            Console.WriteLine("Automobilio metai: " + manoAutomobilis.metai);



//        }

//    }

//}


//Uzduotis 2

//using System;

//namespace ManoPrograma
//{
//    public class PagrindineKlase
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Iveskite amziu");
//            int amzius = int.Parse(Console.ReadLine());
//            string atakymas = Patikrinimas (amzius);
//            Console.WriteLine(atakymas);


//        }

//        public static int Patikrinimas(int amzius)
//        {

//            if (amzius > 18 && amzius < 75)
//            {


//                Console.WriteLine("Pilnamietis");

//            }

//            if (amzius > 75)
//            {
//                Console.WriteLine("Jus esate Senjoras");

//            }




//        }





//    }
//} 



//Uzduotis 2 II vairantas


//Console.WriteLine("Iveskite amziu");
//int amzius = int.Parse(Console.ReadLine());

//if (amzius > 18) && (amzius < 75);
//Console.WriteLine("Esi Pilnametis");

//if (amzius > 75) ;
//Console.WriteLine("Esi Senjoras"); NOPE




//Uzduotis 3 Nice (maybe)



//using System;

//namespace ManoPrograma
//{
//    public class PagrindineKlase
//    {
//        public static void Main(string[] args)
//        {
//            for (int i = 1; i < 11; i++)
//            {

//                Console.WriteLine(i);
//            }


//        }
//    }
//}


//Uzduotis 4 variantas I



//using System;

//namespace ManoPrograma
//{
//    public class PagrindineKlase
//    {
//        public static void Main(string[] args)
//        {

//            int number = 1;


//            while (number < 6)
//            {

//                Console.WriteLine(number);
//                number++;

//            }

//        }



//    }
//}



//Uzduotis 4 variantas II


//using System;

//namespace ManoPrograma
//{
//    public class PagrindineKlase
//    {
//        public static void Main(string[] args)
//        {
//            int skaicius = 1;
//            int suma = 0;

//            while (skaicius < 5)
//            {

//                suma += skaicius;
//                skaicius++;

//            }
//            Console.WriteLine("Skaiciai nuo 1 iki 5 suma yra " + suma);

//        }
//    }
//}


//Uzduotis 5


//namespace Classes.Models
//{
//    public class Studentas
//    {

//        public string Vardas { get; set; }
//        public int Pazymis { get; set; }

//        public Studentas()
//        {

//        }
//        public Studentas(string vardas, int pazymys)
//        {

//            Vardas = vardas;
//            Pazymis = pazymys;

//        }

//        public bool ArIslaike()
//        {

//            return Pazymis >= 5;

//        }

//        class program
//        {
//            static void Main(string[] args)
//            {
//                Studentas studentas = new Studentas("IGARR", 7);

//                if (studentas.ArIslaike())
//                {
//                    Console.WriteLine($"{studentas.Vardas} islaike egzamina.");

//                }

//                else
//                {

//                    Console.WriteLine($"{studentas.Vardas} neislaike egzamino.");
//                }



//            }






//        }

//    }

//}



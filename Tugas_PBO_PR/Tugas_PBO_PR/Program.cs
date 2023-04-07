using System;


// superclass Processor
public class Processor
    {
        public virtual string  Merk { get; set; }
        public virtual string Tipe { get; set; }

    }

//subclass dari Proscessor
    class Intel : Processor 
    {
        public Intel()
        {
            base.Merk = "intel";
        }
    }
//subclass dari Proscessor
    public class AMD : Processor
    {
        public override string Merk { get; set; }

        public AMD(string Merk)
        {
            base.Merk = "AMD";
        }
    }
//superclass Laptop
    public class Laptop
    {
    //Atribut dari class Laptop
        public string Merk { get; set; }
        public string Tipe { get; set; }
        public string Vga { get; set; }
        public string Processor { get; set; }
    // Method LaptopDinyalakan 
        public void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop  {Merk} {Tipe} menyala");
        }
    // Method LaptopDimatikan 
        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop {Merk} {Tipe} mati");
        }

    }
//class Acer Subclass dari laptop
    class Acer : Laptop
    {
        public new string Tipe { get; set; }
        public Acer()
        {
            base.Merk = "Acer";
        }
    }
//class Swift Subclass dari Acer
    class Swift : Acer
    {
        public Swift()
        {
            base.Tipe = "Swift";
        }
    }
//class Predator subclass Acer 
    class Predator : Acer
    {
        public Predator()
        {
            base.Tipe = "Predator";
        }

        public void BermainGame()
        {
        Console.WriteLine($"Laptop {Merk} {Tipe} sedang memainkan game");
        }
    }
//subclaas ASUS dari superclass Laptop
    class ASUS : Laptop
    {
        public new string Tipe { get; set; }
        public ASUS()
        {
            base.Merk = "ASUS";
        }
    }
//subclass ROG dari superclass ASUS
    class ROG : ASUS
    {
        public ROG()
        {
            Tipe = "ROG";
        }
    }
//subclass ROG dari superclass ASUS
    
    class Vivobook : ASUS
    {
            public Vivobook()
        {
            base.Tipe = "Vivobook";
        }
        //method Ngoding
        public void Ngoding()
        {
             Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
        }
    }
//subclass Lenovo dari superclass Laptop
    class Lenovo : Laptop
    {
        public new string Tipe {get; set; }
        public Lenovo()
        {
            base.Merk = "Lenovo";
        }
    }
//subclass Ideapad dari superclass Lenovo
    class Ideapad : Lenovo
    {
       public Ideapad()
       {
        base.Tipe = "Ideapad";
       }
    }
//subclass Legion dari superclass Lenovo
    class Legion : Lenovo
    {
        public Legion()
        {
            base.Tipe = "Legion";
        }
    }
    // Namespace Tipe_VGA
    namespace Tipe_VGA
    {
    //superclass VGA
        class VGA
        {
        //atribut pada class VGA
            public string Merk { get; set; }
        }
    //subclass Nvidia dari superclass VGA
        class Nvidia : VGA
        {
            public Nvidia()
            {
                base.Merk = "Nvidia";
            }
        }
    //subclass AMD dari superclass VGA
        class AMD : VGA
        {
            public AMD()
            {
                base.Merk = "AMD";
            }
        }   
    }

//Class main 
    class program
    {
        static void Main(string[] args)
        {
        //membuat objek laptop1 yang bertipe data Laptop dan memberi nilai pada atribut
        Laptop Laptop1 = new Laptop();
        Laptop1.Merk = "Vivobook";
        Laptop1.Tipe = "Core i5";
        Laptop1.Vga = "Nvidia";
        Laptop1.LaptopDimatikan();
        Laptop1.LaptopDinyalakan();
        Console.WriteLine("Laptop 1:");
        Console.WriteLine("Merk: " + Laptop1.Merk);
        Console.WriteLine("VGA: " + Laptop1.Vga);
        Console.WriteLine("Tipe: " + Laptop1.Tipe);

        //membuat objek laptop2 yang bertipe data Laptop dan memberi nilai pada atribut
        Laptop Laptop2 = new Laptop();
        Laptop2.Merk = "Ideapad";
        Laptop2.Tipe = "Presor Ryzen";
        Laptop2.Vga = "AMD";
        Laptop2.LaptopDimatikan();
        Laptop2.LaptopDinyalakan();

        //membuat objek predator yang bertipe data Predator dan memberi nilai atribut
        Predator predator = new Predator();
        predator.Vga = "AMD";
        predator.Tipe = "Processor core i7";
        predator.BermainGame();

        //membuat objek acer yang bertipe data acer dan memberi nilai atribut
        Acer acer = new Acer();
        acer.Vga = "AMD";
        acer.Tipe = "Processor core i7";
        }
}
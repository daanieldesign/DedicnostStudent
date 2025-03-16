internal class Program
{
    private static void Main(string[] args)
    {
        Student1AI student1 = new Student1AI("Karel", "Dvořák");
        student1.VypisInfo();
        student1.PasovaniPrvaku();

        Student2AI student2 = new Student2AI("Eva", "Novotná");
        student2.VypisInfo();
        student2.Praxe();

        Student3AI student3 = new Student3AI("David", "Svoboda");
        student3.VypisInfo();
        student3.Praxe();

        Student4AI student4 = new Student4AI("Petr", "Novák", new DateTime(2025, 3, 14));
        student4.VypisInfo();
        student4.PripravaNaMaturitu();

        Absolvent absolvent = new Absolvent("Jan", "Hanzelka", true);
        absolvent.VypisInfo();
    }
    class Student
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string Rozvrh { get; set; }

        public Student(string jmeno, string prijmeni, string rozvrh)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Rozvrh = rozvrh;
        }

        public virtual void VypisInfo() //virtual u VypisInfo() znamená, že metoda může být přepsána (override) v potomcích.
        {
            Console.WriteLine($"Student: {Jmeno} {Prijmeni}, Rozvrh: {Rozvrh}");
            Console.ReadKey();
        }
    }

    class Student1AI : Student
    {
        public bool Promenne { get; set; } = true;
        public bool Vetveni { get; set; } = true;
        public bool Cykly { get; set; } = true;

        public Student1AI(string jmeno, string prijmeni) : base(jmeno, prijmeni, "Proměnné, Větvení, Cykly") { }

        public override void VypisInfo() //Přepisuje (override) VypisInfo(), aby vypisovala i tyto předměty.
        {
            base.VypisInfo();
            Console.WriteLine($"Rozvrh: Proměnné - {Promenne}, Větvení - {Vetveni}, Cykly - {Cykly}");
            Console.ReadKey();
        }

        public void PasovaniPrvaku()
        {
            Console.WriteLine($"{Jmeno} {Prijmeni} byl pasován na prváka.\n");
            Console.ReadKey();
        }
    }

    class Student2AI : Student
    {
        public bool Pole { get; set; } = true;
        public bool Metody { get; set; } = true;
        public bool TeoretickaInformatika { get; set; } = true;

        public Student2AI(string jmeno, string prijmeni) : base(jmeno, prijmeni, "Pole, Metody, Teoretická informatika") { }

        public override void VypisInfo()
        {
            base.VypisInfo();
            Console.WriteLine($"Rozvrh: Pole - {Pole}, Metody - {Metody}, Teoretická informatika - {TeoretickaInformatika}");
            Console.ReadKey();
        }

        public void Praxe()
        {
            Console.WriteLine($"{Jmeno} {Prijmeni} vykonává praxi.\n");
            Console.ReadKey();
        }
    }

    class Student3AI : Student
    {
        public bool GUI { get; set; } = true;
        public bool OOP { get; set; } = true;
        public bool MVC { get; set; } = true;

        public Student3AI(string jmeno, string prijmeni) : base(jmeno, prijmeni, "GUI, OOP, MVC") { }

        public override void VypisInfo()
        {
            base.VypisInfo();
            Console.WriteLine($"Rozvrh: GUI - {GUI}, OOP - {OOP}, MVC - {MVC}");
            Console.ReadKey();
        }

        public void Praxe()
        {
            Console.WriteLine($"{Jmeno} {Prijmeni} vykonává praxi.\n");
            Console.ReadKey();
        }
    }

    class Student4AI : Student
    {
        public DateTime DatumMaturitniZkousky { get; set; }

        public Student4AI(string jmeno, string prijmeni, DateTime datumMaturitniZkousky)
            : base(jmeno, prijmeni, "Příprava na maturitu")
        {
            DatumMaturitniZkousky = datumMaturitniZkousky;
        }

        public override void VypisInfo()
        {
            base.VypisInfo();
            Console.WriteLine($"Datum maturitní zkoušky: {DatumMaturitniZkousky.ToShortDateString()}");
            Console.ReadKey();
        }

        public void PripravaNaMaturitu()
        {
            Console.WriteLine($"{Jmeno} {Prijmeni} se připravuje na maturitu, která bude {DatumMaturitniZkousky.ToShortDateString()}.\n");
            Console.ReadKey();
        }
    }

    class Absolvent : Student
    {
        public bool UspesnostZkousky { get; set; }

        public Absolvent(string jmeno, string prijmeni, bool uspesnostZkousky)
            : base(jmeno, prijmeni, "Bývalý student")
        {
            UspesnostZkousky = uspesnostZkousky;
        }

        public override void VypisInfo()
        {
            base.VypisInfo();
            Console.WriteLine($"Úspěšnost zkoušky: {(UspesnostZkousky ? "Úspěšně složena" : "Neuspěl")}\n");
            Console.ReadKey();
        }
    }
}
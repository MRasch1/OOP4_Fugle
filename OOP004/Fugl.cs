namespace OOP004Fugle
{
    internal class Fugl
    {
        public string[] farver = { "Blå", "Brun", "Grøn", "Gul", "Rød" };
        private string? name;
        public bool? trueorfalse;
        public Fugl()
        {
            List<string> Farve = new List<string>(farver);
        }

        public string? Name 
        {
            get { return name; } 
            set
            { 
                if (value == "")
                {
                    Console.WriteLine("Prøv igen..");
                    name = null;
                }
                else name = value; 
            } 
        }
        public bool? PlanteæderEllerEj
        {
            get { return trueorfalse; }
            set
            {
                if (value == false)
                {
                    Console.Write("Det er ikke en planteæder...");
                    trueorfalse = value;
                }
                else Console.Write("Det er en planteæder."); trueorfalse = value; 
            }
        }

        public int Vingefang { get; set; }

        public int Vægt { get; set; }

        public string Næb { get; set; }
    }
}

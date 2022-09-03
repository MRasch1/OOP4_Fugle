using OOP004Fugle;

namespace OOP004
{
    internal class StartUp
    {
        public StartUp()
        {
            Fugl fugl = new Fugl();
            Rovfugl rovfugl = new Rovfugl();
            Planteæder planteæder = new Planteæder();

            GetName(fugl);
            GetName(rovfugl);
            Console.WriteLine($"Din fugl er {fugl.farver[0]}, den vejer {fugl.Vægt = 2500}gram og den hedder: {fugl.Name}.");
            GetResultPlanteæder(fugl);
            Console.WriteLine($"Rovfuglen er {rovfugl.farver[1]}, den vejer {rovfugl.Vægt = 4500}gram og den hedder: {rovfugl.Name}.");
            
        }

        private void GetName(Fugl fugl)
        {
            do
            {
                Console.Write("Indtast navn på fugl: ");
                fugl.Name = Console.ReadLine();
            } while (fugl.Name == null);
        }

        private void GetResultPlanteæder(Fugl fugl)
        {

        }
    }
}

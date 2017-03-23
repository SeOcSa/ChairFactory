using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace project_PASSC_chair_factory
{
    class Program
    {
        private const int NumberOfChairs = 4;
        static void Main(string[] args)
        {
            List<Worker> workers = new List<Worker>();
            List<Chair> chairs = new List<Chair>(new Chair[] {
                new ChairTypeA(),new ChairTypeB(), new ChairTypeD(), new ChairTypeC()});
            SeatWorker C = new SeatWorker("Gigi", 10);
            FeetWorker F = new FeetWorker("Dragos", 20);
            StabilizerBarWorker S = new StabilizerBarWorker("Vasile", 30);
            BackRestWorker B = new BackRestWorker("Petru", 30);
            PackageChairWorker P = new PackageChairWorker("Geo", 10);

            workers.Add(C);
            workers.Add(F);
            workers.Add(S);
            workers.Add(B);
            workers.Add(P);

            Factory factory = new PipesAndFilters_Factory(workers);
            //testPipesAndFilterFactory((PipesAndFilters_Factory)factory);
            factory = new BlackBoard_Factory(chairs, workers);
            //testBlackBoardFactory(factory);

            factory = new BusEventFactory(chairs, workers);
            ((BusEventFactory)factory).buildChair(null);
        }
        static private void testPipesAndFilterFactory(PipesAndFilters_Factory pipeAndFilterFac)
        {
            for (int i = 1; i <= NumberOfChairs; i++)
            {
                Console.WriteLine("----Start building chair number " + i + "----");
                ChairTypeA chair = new ChairTypeA();
                pipeAndFilterFac.buildChair(chair);
                if (chair.package)
                {
                    Console.WriteLine("----Done building chair number " + i + "----\n");
                }
                else
                    Console.WriteLine("----Building chair number " + i + " failed----\n");
            }
        }

        static private void testBlackBoardFactory(Factory factory)
        {
            ((BlackBoard_Factory)factory).buildChair(null);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_m_still_here
{
  class Building
    {
        public int Floors;
        public int Area;
        public int Occupants;

        public Building(int f, int a, int o)
        {
            Floors = f;
            Area = a;
            Occupants = o;
        }

        public int AreaPerPerson()
        {
            return Area / Occupants;
        }

        public int MaxOccupant(int minArea)
        {
            return Area / minArea;
        }

    }

    public class BuildingDemo
    {

       public static void My_future()
        {
            Building house = new Building(2, 2500, 4);
            Building office = new Building(3, 4200, 25);
            //int areaPP;


            Console.WriteLine("Максимальное количество человек в доме, \n" +
                                " если на каждого должно приходиться " +
                                300 + " кв. футов: " +
                                house.MaxOccupant(300)); 
            
            
            Console.WriteLine("Максимальное количество человек в учреждении, \n" +
                                " если на каждого должно приходиться " +
                                300 + " кв. футов: " +
                                office.MaxOccupant(300));

            /*areaPP = house.AreaPerPerson();

            Console.WriteLine("Дом имеет:\n" +
                                house.Floors + " этажа\n" +
                                house.Occupants + " жильца\n" +
                                house.Area +
                                " кв. футов общей площади, из них " + areaPP + " приходится на одного человека");

            Console.WriteLine();

            areaPP = office.AreaPerPerson();

            Console.WriteLine("\n\nУчреждение имеет:\n" +
                                office.Floors + " этажа\n" +
                                office.Occupants + " работников\n" +
                                office.Area +
                                " кв. футов общей площади, из них " + areaPP + " приходится на одного человека");*/


        }

    }
}

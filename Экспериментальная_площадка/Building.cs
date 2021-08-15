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

        public int AreaPerPerson()
        {
            return Area / Occupants;
        }
    }

    public class BuildingDemo
    {

       public static void My_future()
        {
            Building house = new Building();
            Building office = new Building();
            int areaPP;


            house.Occupants = 4;
            house.Area = 2500;
            house.Floors = 2;


            office.Occupants = 25;
            office.Area = 4200;
            office.Floors = 3;

            areaPP = house.AreaPerPerson();

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
                                " кв. футов общей площади, из них " + areaPP + " приходится на одного человека");


        }

    }
}

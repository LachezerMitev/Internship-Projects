using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.Vehicle
{
    class VehicleStorage
    {
        public static List<Data.Entity.Vehicle> VehicleList = new List<Data.Entity.Vehicle>();
        public static Dictionary<long, Data.Entity.Vehicle> VehicleDictionary = new Dictionary<long, Data.Entity.Vehicle>();

        static VehicleStorage()
        {
            Data.Entity.Vehicle Vehicle1 = new Data.Entity.Vehicle
            {

            };

            Data.Entity.Vehicle Vehicle2 = new Data.Entity.Vehicle
            {

            };

            Data.Entity.Vehicle Vehicle3 = new Data.Entity.Vehicle
            {

            };
            Data.Entity.Vehicle Vehicle4 = new Data.Entity.Vehicle
            {

            };
            Data.Entity.Vehicle Vehicle5 = new Data.Entity.Vehicle
            {

            };
            Data.Entity.Vehicle Vehicle6 = new Data.Entity.Vehicle
            {

            };
            Data.Entity.Vehicle Vehicle7 = new Data.Entity.Vehicle
            {

            };
            Data.Entity.Vehicle Vehicle8 = new Data.Entity.Vehicle
            {

            };
            Data.Entity.Vehicle Vehicle9 = new Data.Entity.Vehicle
            {

            };
            Data.Entity.Vehicle Vehicle10 = new Data.Entity.Vehicle
            {

            };

            VehicleList.Add(Vehicle1);
            VehicleList.Add(Vehicle2);
            VehicleList.Add(Vehicle3);
            VehicleList.Add(Vehicle4);
            VehicleList.Add(Vehicle5);
            VehicleList.Add(Vehicle6);
            VehicleList.Add(Vehicle7);
            VehicleList.Add(Vehicle8);
            VehicleList.Add(Vehicle9);
            VehicleList.Add(Vehicle10);

            VehicleDictionary.Add(Vehicle1.Id, Vehicle1);
            VehicleDictionary.Add(Vehicle2.Id, Vehicle2);
            VehicleDictionary.Add(Vehicle3.Id, Vehicle3);
            VehicleDictionary.Add(Vehicle4.Id, Vehicle4);
            VehicleDictionary.Add(Vehicle5.Id, Vehicle5);
            VehicleDictionary.Add(Vehicle6.Id, Vehicle6);
            VehicleDictionary.Add(Vehicle7.Id, Vehicle7);
            VehicleDictionary.Add(Vehicle8.Id, Vehicle8);
            VehicleDictionary.Add(Vehicle9.Id, Vehicle9);
            VehicleDictionary.Add(Vehicle10.Id, Vehicle10);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.VehicleStatus
{
    class VehicleStatusStorage
    {
        public static List<Data.Entity.VehicleStatus> VehicleStatusList = new List<Data.Entity.VehicleStatus>();
        public static Dictionary<long, Data.Entity.VehicleStatus> VehicleStatusDictionary = new Dictionary<long, Data.Entity.VehicleStatus>();

        static VehicleStatusStorage()
        {
            Data.Entity.VehicleStatus VehicleStatus1 = new Data.Entity.VehicleStatus
            {

            };

            Data.Entity.VehicleStatus VehicleStatus2 = new Data.Entity.VehicleStatus
            {

            };

            Data.Entity.VehicleStatus VehicleStatus3 = new Data.Entity.VehicleStatus
            {

            };
            Data.Entity.VehicleStatus VehicleStatus4 = new Data.Entity.VehicleStatus
            {

            };
            Data.Entity.VehicleStatus VehicleStatus5 = new Data.Entity.VehicleStatus
            {

            };
            Data.Entity.VehicleStatus VehicleStatus6 = new Data.Entity.VehicleStatus
            {

            };
            Data.Entity.VehicleStatus VehicleStatus7 = new Data.Entity.VehicleStatus
            {

            };
            Data.Entity.VehicleStatus VehicleStatus8 = new Data.Entity.VehicleStatus
            {

            };
            Data.Entity.VehicleStatus VehicleStatus9 = new Data.Entity.VehicleStatus
            {

            };
            Data.Entity.VehicleStatus VehicleStatus10 = new Data.Entity.VehicleStatus
            {

            };

            VehicleStatusList.Add(VehicleStatus1);
            VehicleStatusList.Add(VehicleStatus2);
            VehicleStatusList.Add(VehicleStatus3);
            VehicleStatusList.Add(VehicleStatus4);
            VehicleStatusList.Add(VehicleStatus5);
            VehicleStatusList.Add(VehicleStatus6);
            VehicleStatusList.Add(VehicleStatus7);
            VehicleStatusList.Add(VehicleStatus8);
            VehicleStatusList.Add(VehicleStatus9);
            VehicleStatusList.Add(VehicleStatus10);

            VehicleStatusDictionary.Add(VehicleStatus1.Id, VehicleStatus1);
            VehicleStatusDictionary.Add(VehicleStatus2.Id, VehicleStatus2);
            VehicleStatusDictionary.Add(VehicleStatus3.Id, VehicleStatus3);
            VehicleStatusDictionary.Add(VehicleStatus4.Id, VehicleStatus4);
            VehicleStatusDictionary.Add(VehicleStatus5.Id, VehicleStatus5);
            VehicleStatusDictionary.Add(VehicleStatus6.Id, VehicleStatus6);
            VehicleStatusDictionary.Add(VehicleStatus7.Id, VehicleStatus7);
            VehicleStatusDictionary.Add(VehicleStatus8.Id, VehicleStatus8);
            VehicleStatusDictionary.Add(VehicleStatus9.Id, VehicleStatus9);
            VehicleStatusDictionary.Add(VehicleStatus10.Id, VehicleStatus10);

        }
    }
}

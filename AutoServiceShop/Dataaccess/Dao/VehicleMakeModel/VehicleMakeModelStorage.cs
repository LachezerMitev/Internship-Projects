using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.VehicleMakeModel
{
    class VehicleMakeModelStorage
    {
        public static List<Data.Entity.VehicleMakeModel> VehicleMakeModelList = new List<Data.Entity.VehicleMakeModel>();
        public static Dictionary<long, Data.Entity.VehicleMakeModel> VehicleMakeModelDictionary = new Dictionary<long, Data.Entity.VehicleMakeModel>();

        static VehicleMakeModelStorage()
        {
            Data.Entity.VehicleMakeModel VehicleMakeModel1 = new Data.Entity.VehicleMakeModel
            {

            };

            Data.Entity.VehicleMakeModel VehicleMakeModel2 = new Data.Entity.VehicleMakeModel
            {

            };

            Data.Entity.VehicleMakeModel VehicleMakeModel3 = new Data.Entity.VehicleMakeModel
            {

            };
            Data.Entity.VehicleMakeModel VehicleMakeModel4 = new Data.Entity.VehicleMakeModel
            {

            };
            Data.Entity.VehicleMakeModel VehicleMakeModel5 = new Data.Entity.VehicleMakeModel
            {

            };
            Data.Entity.VehicleMakeModel VehicleMakeModel6 = new Data.Entity.VehicleMakeModel
            {

            };
            Data.Entity.VehicleMakeModel VehicleMakeModel7 = new Data.Entity.VehicleMakeModel
            {

            };
            Data.Entity.VehicleMakeModel VehicleMakeModel8 = new Data.Entity.VehicleMakeModel
            {

            };
            Data.Entity.VehicleMakeModel VehicleMakeModel9 = new Data.Entity.VehicleMakeModel
            {

            };
            Data.Entity.VehicleMakeModel VehicleMakeModel10 = new Data.Entity.VehicleMakeModel
            {

            };

            VehicleMakeModelList.Add(VehicleMakeModel1);
            VehicleMakeModelList.Add(VehicleMakeModel2);
            VehicleMakeModelList.Add(VehicleMakeModel3);
            VehicleMakeModelList.Add(VehicleMakeModel4);
            VehicleMakeModelList.Add(VehicleMakeModel5);
            VehicleMakeModelList.Add(VehicleMakeModel6);
            VehicleMakeModelList.Add(VehicleMakeModel7);
            VehicleMakeModelList.Add(VehicleMakeModel8);
            VehicleMakeModelList.Add(VehicleMakeModel9);
            VehicleMakeModelList.Add(VehicleMakeModel10);

            VehicleMakeModelDictionary.Add(VehicleMakeModel1.Id, VehicleMakeModel1);
            VehicleMakeModelDictionary.Add(VehicleMakeModel2.Id, VehicleMakeModel2);
            VehicleMakeModelDictionary.Add(VehicleMakeModel3.Id, VehicleMakeModel3);
            VehicleMakeModelDictionary.Add(VehicleMakeModel4.Id, VehicleMakeModel4);
            VehicleMakeModelDictionary.Add(VehicleMakeModel5.Id, VehicleMakeModel5);
            VehicleMakeModelDictionary.Add(VehicleMakeModel6.Id, VehicleMakeModel6);
            VehicleMakeModelDictionary.Add(VehicleMakeModel7.Id, VehicleMakeModel7);
            VehicleMakeModelDictionary.Add(VehicleMakeModel8.Id, VehicleMakeModel8);
            VehicleMakeModelDictionary.Add(VehicleMakeModel9.Id, VehicleMakeModel9);
            VehicleMakeModelDictionary.Add(VehicleMakeModel10.Id, VehicleMakeModel10);

        }
    }
}

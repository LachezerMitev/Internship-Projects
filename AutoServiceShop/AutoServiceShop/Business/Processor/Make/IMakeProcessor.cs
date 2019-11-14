using AutoServiceShop.Business.Processor.Converter.Make;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Make
{
    interface IMakeProcessor
    {
        MakeResult Create(MakeParam param);
        List<MakeResult> Create(List<MakeParam> param);

        void Update(long id, MakeParam param);
        void Update(List<MakeParam> param);

        void Delete(long id);
        void Delete(List<long> idList);

        MakeResult Find(long id);
        List<MakeResult> Find();
    }
}

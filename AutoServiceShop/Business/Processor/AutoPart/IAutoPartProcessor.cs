using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Business.Processor.Converter.AutoPart;

namespace AutoServiceShop.Business.Processor.AutoPart
{
    interface IAutoPartProcessor
    {
        AutoPartResult Create(AutoPartParam param);
        List<AutoPartResult> Create(List<AutoPartParam> param);

        void Update(long id, AutoPartParam param);
        void Update(List<AutoPartParam> param);

        void Delete(long id);
        void Delete(List<long> idList);

        AutoPartResult Find(long id);
        List<AutoPartResult> Find();
    }
}

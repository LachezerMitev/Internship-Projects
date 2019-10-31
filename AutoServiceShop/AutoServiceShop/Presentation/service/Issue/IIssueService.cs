using AutoServiceShop.Data.Common;
using AutoServiceShop.Business.Processor.Converter.Issue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AutoServiceShop.Presentation.service.Issue
{
    interface IIssueService
    {
        ApiResponse FindByPK(long id);
        ApiResponse ListAll();

        ApiResponse Create(IssueParam param);
        ApiResponse Create(List<IssueParam> param);

        ApiResponse Update(long id, IssueParam param);
        ApiResponse Update(List<IssueParam> param);

        ApiResponse DeleteById(long id);
        ApiResponse Delete(List<long> idList);

        void ValidateParameters(IssueParam param);
        void ValidateParameters(List<IssueParam> param);
    }
}

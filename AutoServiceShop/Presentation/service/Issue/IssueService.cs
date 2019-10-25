using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Issue;
using AutoServiceShop.Business.Processor.Issue;
using AutoServiceShop.Data.Common;

namespace AutoServiceShop.Presentation.service.Issue
{
    class IssueService : IIssueService
    {
        IIssueProcessor IssueProcessor = new IssueProcessor();
        public ApiResponse Response = new ApiResponse();

        public ApiResponse Create(IssueParam param)
        {
            IssueProcessor = new IssueProcessor();
            Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(IssueProcessor.Create(param));
                Response.result = true;

                return Response;
            }

            catch
            {
                Response.text = "Something went wrong :(";
                Response.result = false;

                return Response;
            }
        }

        public ApiResponse Create(List<IssueParam> param)
        {
            IssueProcessor = new IssueProcessor();
            Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(IssueProcessor.Create(param));
                Response.result = true;

                return Response;
            }
            catch
            {
                Response.text = "Something went wrong :(";
                Response.result = false;

                return Response;
            }
        }

        public ApiResponse Delete(List<long> idList)
        {
            IssueProcessor = new IssueProcessor();
            Response = new ApiResponse();

            try
            {
                IssueProcessor.Delete(idList);
                Response.text = "Entity was successfully removed from the system.";
                Response.result = true;

                return Response;
            }
            catch
            {
                Response.text = "Unfortunately something went wrong. Try again later. :)";
                Response.result = false;

                return Response;
            }
        }

        public ApiResponse DeleteById(long id)
        {
            IssueProcessor = new IssueProcessor();
            Response = new ApiResponse();

            try
            {
                IssueProcessor.Delete(id);
                Response.text = "Entity was successfully removed from the system.";
                Response.result = true;

                return Response;
            }
            catch
            {
                Response.text = "Unfortunately something went wrong :(";
                Response.result = false;

                return Response;
            }
        }

        public ApiResponse FindByPK(long id)
        {
            IssueProcessor = new IssueProcessor();
            Response = new ApiResponse();

            try
            {
                IssueProcessor.Find(id);
                Response.text = "Account with this PK has been found" + Environment.NewLine + JsonConverter.JsonConverter.ObjToJson(IssueProcessor.Find(id));
                Response.result = true;

                return Response;
            }
            catch
            {
                Response.text = "An account with this id does not exist";
                Response.result = false;

                return Response;
            }
        }

        public ApiResponse ListAll()
        {
            IssueProcessor = new IssueProcessor();
            Response = new ApiResponse();

            try
            {
                IssueProcessor.Find();
                Response.text = JsonConverter.JsonConverter.ObjToJson(IssueProcessor.Find());
                Response.result = true;

                return Response;
            }
            catch
            {
                Response.text = "Unfortunately something went wrong :(";
                Response.result = false;

                return Response;
            }
        }

        public ApiResponse Update(long id, IssueParam param)
        {
            IssueProcessor = new IssueProcessor();
            Response = new ApiResponse();

            try
            {
                IssueProcessor.Update(id, param);
                Response.text = "Entity was successfully updated";
                Response.result = true;

                return Response;
            }
            catch
            {
                Response.text = "Unfortunately something went wrong :(";
                Response.result = false;

                return Response;
            }
        }

        public ApiResponse Update(List<IssueParam> param)
        {
            IssueProcessor = new IssueProcessor();
            Response = new ApiResponse();

            try
            {
                IssueProcessor.Update(param);

                Response.text = "Entities were successfully updated.";
                Response.result = true;

                return Response;
            }
            catch
            {
                Response.text = "Unfortunately something went wrong :(";
                Response.result = false;

                return Response;
            }
        }

        public void ValidateParameters(IssueParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<IssueParam> param)
        {
            throw new NotImplementedException();
        }
    }
}

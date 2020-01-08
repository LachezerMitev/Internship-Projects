using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Common;
using AutoServiceShop.Business.Processor.Converter;
using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Data.Common;
using AutoServiceShop.Dataaccess.Dao.Common;

namespace AutoServiceShop.Presentation.service.Common
{
    public abstract class BaseService<TProcessor, TParamConverter, TResultConverter, TParam, TResult, TDao, TId, TEntity> 
        : IBaseService<TProcessor, TParamConverter, TResultConverter, TParam, TResult, TDao, TId, TEntity>

        where TProcessor : IBaseProcessor<TParamConverter, TResultConverter, TParam, TResult, TDao, TId, TEntity>
        where TParamConverter : IBaseParamConverter<TParam, TEntity>
        where TDao : IBaseDao<TEntity, TId>
        where TResultConverter : IBaseResultConverter<TEntity, TResult>
        where TEntity : class
        where TParam : BaseParam<TId>
    {
<<<<<<< Updated upstream:AutoServiceShop/AutoServiceShop/Presentation/service/CustomerStatus/CustomerStatusService.cs
        ICustomerStatusProcessor CustomerStatusProcessor = new CustomerStatusProcessor();
        public ApiResponse Response = new ApiResponse();
=======
        private TProcessor _processor;

        public TProcessor Processor
        {
            set => _processor = value;
            get
            {
                if (_processor == null)
                {
                    throw new Exception("No instance of an object");
                }
                else
                {
                    return _processor;
                }
            }
        }
>>>>>>> Stashed changes:AutoServiceShop/AutoServiceShop/Presentation/service/Common/BaseService.cs

        public ApiResponse Create(TParam param)
        {
<<<<<<< Updated upstream:AutoServiceShop/AutoServiceShop/Presentation/service/CustomerStatus/CustomerStatusService.cs
            CustomerStatusProcessor = new CustomerStatusProcessor();
            Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(CustomerStatusProcessor.Create(param));
=======
            ApiResponse Response = new ApiResponse();
            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(_processor.Create(param));

>>>>>>> Stashed changes:AutoServiceShop/AutoServiceShop/Presentation/service/Common/BaseService.cs
                Response.result = true;

                return Response;
            }

            catch (Exception e)
            {
                Response.text = "Something went wrong :( " + e;
                Response.result = false;

                return Response;
            }
        }

        public ApiResponse Create(List<TParam> param)
        {
            CustomerStatusProcessor = new CustomerStatusProcessor();
            Response = new ApiResponse();

            try
            {
<<<<<<< Updated upstream:AutoServiceShop/AutoServiceShop/Presentation/service/CustomerStatus/CustomerStatusService.cs
                Response.text = JsonConverter.JsonConverter.ObjToJson(CustomerStatusProcessor.Create(param));
=======
                Response.text = JsonConverter.JsonConverter.ObjToJson(_processor.Create(param));
>>>>>>> Stashed changes:AutoServiceShop/AutoServiceShop/Presentation/service/Common/BaseService.cs
                Response.result = true;

                return Response;
            }
            catch (Exception e)
            {
                Response.text = "Something went wrong :( " + e;
                Response.result = false;

                return Response;
            }
        }

        public ApiResponse Delete(List<TId> idList)
        {
            CustomerStatusProcessor = new CustomerStatusProcessor();
            Response = new ApiResponse();

            try
            {
<<<<<<< Updated upstream:AutoServiceShop/AutoServiceShop/Presentation/service/CustomerStatus/CustomerStatusService.cs
                CustomerStatusProcessor.Delete(idList);
=======
                _processor.Delete(idList);
>>>>>>> Stashed changes:AutoServiceShop/AutoServiceShop/Presentation/service/Common/BaseService.cs
                Response.text = "Entity was successfully removed from the system.";
                Response.result = true;

                return Response;
            }
            catch (Exception e)
            {
                Response.text = "Unfortunately something went wrong. Try again later. :)" + e;
                Response.result = false;

                return Response;
            }
        }

        public ApiResponse DeleteById(TId id)
        {
            CustomerStatusProcessor = new CustomerStatusProcessor();
            Response = new ApiResponse();

            try
            {
<<<<<<< Updated upstream:AutoServiceShop/AutoServiceShop/Presentation/service/CustomerStatus/CustomerStatusService.cs
                CustomerStatusProcessor.Delete(id);
=======
                _processor.Delete(id);
>>>>>>> Stashed changes:AutoServiceShop/AutoServiceShop/Presentation/service/Common/BaseService.cs
                Response.text = "Entity was successfully removed from the system.";
                Response.result = true;

                return Response;
            }
            catch (Exception e)
            {
                Response.text = "Unfortunately something went wrong :(" + e;
                Response.result = false;

                return Response;
            }
        }

        public ApiResponse FindByField(string field, string value)
        {
            CustomerStatusProcessor = new CustomerStatusProcessor();
            Response = new ApiResponse();

            try
            {
<<<<<<< Updated upstream:AutoServiceShop/AutoServiceShop/Presentation/service/CustomerStatus/CustomerStatusService.cs
                CustomerStatusProcessor.Find(id);
                Response.text = "Account with this PK has been found" + Environment.NewLine + JsonConverter.JsonConverter.ObjToJson(CustomerStatusProcessor.Find(id));
=======
                _processor.Find(field, value);
                Response.text = JsonConverter.JsonConverter.ObjToJson(_processor.Find(field, value));
>>>>>>> Stashed changes:AutoServiceShop/AutoServiceShop/Presentation/service/Common/BaseService.cs
                Response.result = true;

                return Response;
            }
            catch (Exception e)
            {
                Response.text = "An account with this field or value doesn't exist" + e;
                Response.result = false;

                return Response;
            }
        }

        public ApiResponse FindByPK(TId id)
        {
            ApiResponse Response = new ApiResponse();

            try
            {
                _processor.Find(id);
                Response.text = "Account with this PK has been found" + Environment.NewLine + JsonConverter.JsonConverter.ObjToJson(_processor.Find(id));
                Response.result = true;

                return Response;
            }
            catch (Exception e)
            {
                Response.text = "An account with this id does not exist" + e;
                Response.result = false;

                return Response;
            }
        }

        public ApiResponse ListAll()
        {
            CustomerStatusProcessor = new CustomerStatusProcessor();
            Response = new ApiResponse();

            try
            {
<<<<<<< Updated upstream:AutoServiceShop/AutoServiceShop/Presentation/service/CustomerStatus/CustomerStatusService.cs
                CustomerStatusProcessor.Find();
                Response.text = JsonConverter.JsonConverter.ObjToJson(CustomerStatusProcessor.Find());
=======
                _processor.Find();
                Response.text = JsonConverter.JsonConverter.ObjToJson(_processor.Find());
>>>>>>> Stashed changes:AutoServiceShop/AutoServiceShop/Presentation/service/Common/BaseService.cs
                Response.result = true;

                return Response;
            }
            catch (Exception e)
            {
                Response.text = "Unfortunately something went wrong :(" + e;
                Response.result = false;

                return Response;
            }
        }

        public ApiResponse Update(TId id, TParam param)
        {
            CustomerStatusProcessor = new CustomerStatusProcessor();
            Response = new ApiResponse();

            try
            {
<<<<<<< Updated upstream:AutoServiceShop/AutoServiceShop/Presentation/service/CustomerStatus/CustomerStatusService.cs
                CustomerStatusProcessor.Update(id, param);
=======
                _processor.Update(id, param);
>>>>>>> Stashed changes:AutoServiceShop/AutoServiceShop/Presentation/service/Common/BaseService.cs
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

        public ApiResponse Update(List<TParam> param)
        {
            CustomerStatusProcessor = new CustomerStatusProcessor();
            Response = new ApiResponse();

            try
            {
<<<<<<< Updated upstream:AutoServiceShop/AutoServiceShop/Presentation/service/CustomerStatus/CustomerStatusService.cs
                CustomerStatusProcessor.Update(param);
=======
                _processor.Update(param);
>>>>>>> Stashed changes:AutoServiceShop/AutoServiceShop/Presentation/service/Common/BaseService.cs

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

        public void ValidateParameters(TParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<TParam> param)
        {
            throw new NotImplementedException();
        }
    }
}

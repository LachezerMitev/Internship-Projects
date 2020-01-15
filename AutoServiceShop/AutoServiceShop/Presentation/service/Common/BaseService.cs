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

        public ApiResponse Create(TParam param)
        {
            ApiResponse Response = new ApiResponse();
            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(_processor.Create(param));

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
            ApiResponse Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(_processor.Create(param));
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
            ApiResponse Response = new ApiResponse();

            try
            {
                _processor.Delete(idList);
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
            ApiResponse Response = new ApiResponse();

            try
            {
                _processor.Delete(id);
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
            ApiResponse Response = new ApiResponse();

            try
            {
                _processor.Find(field, value);
                Response.text = JsonConverter.JsonConverter.ObjToJson(_processor.Find(field, value));
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
            ApiResponse Response = new ApiResponse();

            try
            {
                _processor.Find();
                Response.text = JsonConverter.JsonConverter.ObjToJson(_processor.Find());
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
            ApiResponse Response = new ApiResponse();

            try
            {
                _processor.Update(id, param);
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
            ApiResponse Response = new ApiResponse();

            try
            {
                _processor.Update(param);

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
    }
}

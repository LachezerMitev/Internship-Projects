using AutoServiceShop.AuthorizationAttributes;
using AutoServiceShop.Business.Processor.Common;
using AutoServiceShop.Business.Processor.Converter;
using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Dataaccess.Dao.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Controllers.CommonController
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class BaseController<TProcessor, TParamConverter, TResultConverter, TParam, TResult, TDao, TId, TEntity>
        : ControllerBase, IBaseController<TProcessor, TParamConverter, TResultConverter, TParam, TResult, TDao, TId, TEntity>

        where TProcessor : IBaseProcessor<TParamConverter, TResultConverter, TParam, TResult, TDao, TId, TEntity>
        where TParamConverter : IBaseParamConverter<TParam, TEntity>
        where TDao : IBaseDao<TEntity, TId>
        where TResultConverter : IBaseResultConverter<TEntity, TResult>
        where TEntity : class
        where TParam : BaseParam<TId>

    {
        private readonly TProcessor _processor;

        public BaseController(TProcessor processor)
        {
            _processor = processor;
        }

        /// <summary>
        /// Creates an entity.
        /// </summary>
        /// <param name="param"></param>   
        /// <response code="200">Item created</response>
        /// <response code="400">Item has missing/invalid values</response>
        /// <response code="500">Oops! Can't create your Item right now</response>
        [AuthorizationCreate]
        [HttpPost("Create/{param}")]
        public IActionResult Create(TParam param)
        {
            try
            {
                return Ok(_processor.Create(param));
            }
            catch
            {

                return BadRequest();
            }
        }

        /// <summary>
        /// Creates a list of entities.
        /// </summary>
        /// <param name="param"></param>   
        /// <response code="200">Items created</response>
        /// <response code="400">Items have missing/invalid values</response>
        /// <response code="500">Oops! Can't create your Items right now</response>
        [AuthorizationCreateWithList]
        [HttpPost("CreateWithList/{param}")]
        public IActionResult CreateWithList(List<TParam> param)
        {
            try
            {
                return Ok(_processor.Create(param));
            }
            catch
            {

                return BadRequest();
            }
        }

        /// <summary>
        /// Deletes a list of entity by their ID.
        /// </summary>
        /// <param name="idList"></param>
        /// <response code="200">Items deleted</response>
        /// <response code="400">Items have missing/invalid values</response>
        /// <response code="500">Oops! Can't delete your Items right now</response>
        [AuthorizationDelete]
        [HttpDelete("Delete/{idList}")]
        public IActionResult Delete(List<TId> idList)
        {
            try
            {
                _processor.Delete(idList);
                return Ok("Entity was successfully removed from the system.");
            }
            catch
            {

                return BadRequest();
            }
        }

        /// <summary>
        /// Deletes an entity by its Id.
        /// </summary>
        /// <param name="id"></param>
        /// <response code="200">Item deleted</response>
        /// <response code="400">Item has missing/invalid values</response>
        /// <response code="500">Oops! Can't delete your Item right now</response>
        
        [HttpDelete("DeleteById/{id}")]
        [AuthorizationDeleteById]
        public IActionResult DeleteById(TId id)
        {
            try
            {
                _processor.Delete(id);
                return Ok("Entity was successfully removed from the system.");
            }
            catch
            {

                return BadRequest();
            }
        }

        /// <summary>
        /// Finds entities with a specific value in a field.
        /// </summary>
        /// <param name="field"></param> 
        /// <param name="value"></param> 
        /// <response code="200">Item found</response>
        /// <response code="400">Item has missing/invalid values</response>
        /// <response code="500">Oops! Can't find your Item right now</response>
        [AuthorizationFindByField]
        [HttpGet("FindByField/{field}/{value}")]
        public IActionResult FindByField(string field, string value)
        {
            try
            {
                return Ok(_processor.Find(field, value));
            }
            catch(Exception e)
            {

                return BadRequest(e);
            }
        }

        /// <summary>
        /// Finds an entity by its Id.
        /// </summary>
        /// <param name="id"></param>
        /// <response code="200">Item found</response>
        /// <response code="400">Item has missing/invalid values</response>
        /// <response code="500">Oops! Can't find your Item right now</response>
        [AuthorizationFindByPK]
        [HttpGet("FindByPK/{id}")]
        public IActionResult FindByPK(TId id)
        {
            try
            {
                return Ok(_processor.Find(id));
            }
            catch
            {

                return BadRequest();
            }
        }

        /// <summary>
        /// Returns All Entities.
        /// </summary>
        /// <response code="200">Items listed</response>
        /// <response code="400">Item has missing/invalid values</response>
        /// <response code="500">Oops! Can't list your Items right now</response>
        [AuthorizationListAll]
        [HttpGet("ListAll")]
        public IActionResult ListAll()
        {
            try
            {
                return Ok(_processor.Find());
            }
            catch
            {

                return BadRequest();
            }
        }

        /// <summary>
        /// Updates an entity by its Id.
        /// </summary>
        /// <param name="id"></param> 
        /// <param name="param"></param> 
        /// <response code="200">Item updated</response>
        /// <response code="400">Item has missing/invalid values</response>
        /// <response code="500">Oops! Can't update your Item right now</response>
        [AuthorizationUpdate]
        [HttpPut("Update/{id}/{param}")]
        public IActionResult Update(TId id, TParam param)
        {
            try
            {
                _processor.Update(id, param);
                return Ok("Entity was successfully updated");
            }
            catch
            {

                return BadRequest();
            }
        }

        /// <summary>
        /// Updates a list of entities.
        /// </summary>
        /// <param name="param"></param>
        /// <response code="200">Items updated</response>
        /// <response code="400">Items have missing/invalid values</response>
        /// <response code="500">Oops! Can't update your Items right now</response>
        [AuthorizationUpdateByList]
        [HttpPut("UpdateByList/{param}")]
        public IActionResult UpdateByList(List<TParam> param)
        {
            try
            {
                _processor.Update(param);
                return Ok("Entity was successfully updated");
            }
            catch
            {

                return BadRequest();
            }
        }
    }
}

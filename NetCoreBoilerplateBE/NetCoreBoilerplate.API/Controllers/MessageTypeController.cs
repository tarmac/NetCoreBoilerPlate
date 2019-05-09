using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreBoilerplate.Contracts;
using NetCoreBoilerplate.Entities.Models;

namespace NetCoreBoilerplate.API.Controllers
{
    [Route("api/messagetype")]
    [ApiController]
    public class MessageTypeController : ControllerBase
    {
        private IRepositoryWrapper _repository;
        private ILoggerManager _logger;

        public MessageTypeController(IRepositoryWrapper repository, ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetAllMessageTypes()
        {
            try
            {
                var messageTypes = _repository.MessageType.GetAllMessageTypes();

                return Ok(messageTypes);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetAllMessageTypes action: {ex.Message}");
                return StatusCode(500, "Internal sever error");
            }
        }

        [HttpGet ("{id}", Name = "MessageTypeById")]
        public IActionResult GetMessageTypeById(long id)
        {
            try
            {
                var messageType = _repository.MessageType.GetMessageTypeById(id);

                if (messageType == null)
                {
                    _logger.LogError($"Owner with id: {id}, hasn't been found in db.");
                    return NotFound();
                }
                
                return Ok(messageType);

            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetMessageTypeById action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPost]
        public IActionResult CreateMessageType([FromBody]MessageType messageType)
        {
            if (messageType == null)
                return BadRequest("MessageType object is null");

            if (!ModelState.IsValid)
                return BadRequest("Invalid model object");

            _repository.MessageType.Create(messageType);

            return CreatedAtRoute("MessageTypeById", new { id = messageType.Id }, messageType);
        }
    }
}
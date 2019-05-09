using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreBoilerplate.Contracts;
using NetCoreBoilerPlate.Repo.Definition;

namespace NetCoreBoilerplate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private IRepositoryWrapper _repoWrapper;

        public MessageController(IRepositoryWrapper repoWrapper)
        {
            _repoWrapper = repoWrapper;
        }

        /// <summary>
        /// The get messages controller
        /// </summary>
        /// <remarks>
        /// A remakr placeholder, extra info
        /// </remarks>
        /// <returns>returns the messages</returns>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var messageTypes = _repoWrapper.MessageType.FindAll();
          // _repoWrapper
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// The get message controller
        /// </summary>
        /// <remarks>
        /// A remakr placeholder, extra info
        /// </remarks>
        /// <param name="id">the id of message</param>
        /// <returns>it returns the message</returns>
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// The Post message Controller
        /// </summary>
        /// <remarks>
        /// A remakr placeholder, extra info
        /// </remarks>
        /// <param name="value"></param>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        /// <summary>
        /// The Put message controller
        /// </summary>
        /// <remarks>
        /// A remakr placeholder, extra info
        /// </remarks>
        /// <param name="id">the id</param>
        /// <param name="value">the body value</param>
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        /// <summary>
        /// The Delete message controller
        /// </summary>
        /// <remarks>
        /// A remakr placeholder, extra info
        /// </remarks>
        /// <param name="id">the id</param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

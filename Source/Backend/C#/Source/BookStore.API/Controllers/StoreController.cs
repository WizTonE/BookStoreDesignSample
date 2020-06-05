using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        #region Properties
        protected IStore Store { get; set; }
        protected IStoreStorage StoreStorage { get; set; }
        #endregion

        public StoreController(IStoreStorage storeStorage)
        {
            StoreStorage = storeStorage;
            Store = storeStorage.GetStore(StoreStorage.)
        }
        // POST: api/Store
        [HttpPost]
        public void Post([FromBody] string value)
        {
            
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

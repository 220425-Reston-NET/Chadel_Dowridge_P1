using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using StoreBL;
using StoreModel;

namespace SneakerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SneakerController : ControllerBase
    {
         //=================Dependency Injection=============
        private IStoreBL _storeBL;

        public SneakerController(IStoreBL storeBL)
        {
            _storeBL = storeBL;
            
        }

        //=================================================
         //Data annotation to indicate what type of HTTP verb it is
        //This is an action of a controller
        //It needs what HTTP verb it is associated with
        //================================================

        //===================Get All Sneakers==================
        [HttpGet("GetAllSneakers")]
        public IActionResult GetAllSneakers()
        {
            try
            {
                List<Sneaker> listOfCurrentSneakers = _storeBL.GetAllSneakers();
    
                //Followed by "Ok()" it determines what http status code to give
                return Ok(listOfCurrentSneakers);
            }
            catch (SqlException)
            {
                return NotFound("No Sneaker Exist");
            }
        }
        [HttpPost("AddSneaker")]
        public IActionResult AddSneaker([FromBody] Sneaker p_sneaker)
        {
            try
            {
                _storeBL.AddSneaker(p_sneaker);

                return Created("A Sneaker was created!", p_sneaker);
            }
            catch (SqlException)
            {
                return Conflict();
            }
        }

        [HttpGet("SearchSneakerByName")]
        public IActionResult SearchSneaker([FromQuery] string sneakerName)
        {
            try
            {
                return Ok(_storeBL.SearchSneakerByName(sneakerName));
            }
            catch (SqlException)
            {
                return Conflict();
            }
        }
    }
}


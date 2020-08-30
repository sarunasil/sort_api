using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sort_api.Models;
using sort_api.Services;

namespace sort_api.Controllers{

    [Route("api/sort")]
    [ApiController]
    public class SortFileController : ControllerBase{
        //The controller responsible for taking in
        //array input and returning sorted result

        private readonly ISortingService _sorter = new QuickSortingService();

        //GET /api/sort
        [HttpGet(Name="GetSortedFile")]
        public ActionResult<string> GetSortedFile(){


            return Ok("GetSortFile");
        }

        //POST api/sort
        [HttpPut]
        public IActionResult SortFile(NumArrayData numArrayData){

            var result =_sorter.Sort(numArrayData);
            if (result){
                return CreatedAtRoute(nameof(GetSortedFile), numArrayData );
            }
            else{
                return StatusCode(500, "Could not sort.");
            }

        }

    }
}
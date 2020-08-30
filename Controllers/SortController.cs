using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sort_api.Models;
using sort_api.Repository;
using sort_api.Services;

namespace sort_api.Controllers{

    [Route("api/sort")]
    [ApiController]
    public class SortFileController : ControllerBase{
        //The controller responsible for taking in
        //array input and returning sorted result

        private readonly ISortingService _sorter;

        public SortFileController(ISortingService sorter){
            _sorter = sorter;
        }

        //GET /api/sort
        [HttpGet(Name="GetSortedFile")]
        public ActionResult<string> GetSortedFile(){

            var sorted = _sorter.GetSorted();
            if (sorted == null){
                return StatusCode(500, "Could not get sorted.");
            }
            return Ok(sorted);
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
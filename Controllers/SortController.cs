using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using sort_api.Models;

namespace sort_api.Controllers{

    [Route("api/sort")]
    [ApiController]
    public class SortFileController : ControllerBase{

        //GET /api/sort
        [HttpGet]
        public ActionResult<string> GetSortedFile(){


            return Ok("GetSortFile");
        }

        //POST api/sort
        [HttpPost]
        public ActionResult<string> SortFile(List<int> numArrayData){


            numArrayData.Sort();

            return Ok("SortFile Post - " + string.Join(",", numArrayData) );
        }

    }
}
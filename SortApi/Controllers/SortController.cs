using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SortApi.DTOs;
using SortApi.Models;
using SortApi.Repository;
using SortApi.Services;

namespace SortApi.Controllers{

    [Route("api/sort")]
    [ApiController]
    public class SortFileController : ControllerBase{
        //The controller responsible for taking in
        //array input and returning sorted result

        private readonly ISortingService _sorter;
        private readonly IMapper _mapper;

        public SortFileController(ISortingService sorter, IMapper mapper){
            _sorter = sorter;
            _mapper = mapper;
        }

        //GET /api/sort
        [HttpGet(Name="GetSortedFile")]
        public IActionResult GetSortedFile(){

            NumArrayData sorted = _sorter.GetSorted();
            if (sorted == null){
                return StatusCode(500, "Could not get sorted.");
            }

            NumArrayDataRW numArrayDataR = _mapper.Map<NumArrayData, NumArrayDataRW>(sorted);
            return Ok(numArrayDataR);
        }

        //PUT(POST) api/sort
        [HttpPut]
        public IActionResult SortFile(NumArrayDataRW numArrayDataW){
            NumArrayData numArrayData = _mapper.Map<NumArrayDataRW, NumArrayData>(numArrayDataW);

            var result =_sorter.Sort(numArrayData);
            if (result){

                var numArrayDataR = _mapper.Map<NumArrayData, NumArrayDataRW>(numArrayData);
                return Created(nameof(GetSortedFile), numArrayDataR);
            }
            else{
                return StatusCode(500, "Could not sort.");
            }

        }

    }
}
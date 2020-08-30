
using AutoMapper;
using SortApi.DTOs;
using SortApi.Models;

namespace SortApi.Profiles{
    public class SorterProfile : Profile{

        public SorterProfile(){
            //Internal -> external (for reading)
            CreateMap<NumArrayData, NumArrayDataRW>();

            //External -> internal (for creating)
            CreateMap<NumArrayDataRW, NumArrayData>();
        }
    }
}
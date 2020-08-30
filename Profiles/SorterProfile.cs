
using AutoMapper;
using sort_api.DTOs;
using sort_api.Models;

namespace sort_api.Profiles{
    public class SorterProfile : Profile{

        public SorterProfile(){
            //Internal -> external (for reading)
            CreateMap<NumArrayData, NumArrayDataRW>();

            //External -> internal (for creating)
            CreateMap<NumArrayDataRW, NumArrayData>();
        }
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using SortApi.Models;

namespace SortApi.Services
{
    public interface ISortingService
    {
        //Interface for data processing layer
        //which is just sorting in this case

        NumArrayData GetSorted();
        bool Sort(NumArrayData numArrayData);
    }
}

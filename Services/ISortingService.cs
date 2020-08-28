using System.Collections.Generic;
using System.Threading.Tasks;
using sort_api.Models;

namespace sort_api.Services
{
    public interface ISortingService
    {
        NumArrayData GetSorted();
        bool Sort(NumArrayData numArrayData);
    }
}

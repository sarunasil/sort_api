
using SortApi.Models;

namespace SortApi.Repository{
    public interface IArrayDataRepo{
        //Interface for storing NumArrayData
        //read/write

        NumArrayData GetSorted();
        bool SaveSorted(NumArrayData numArrayData);
    }
}
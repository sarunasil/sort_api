
using sort_api.Models;

namespace sort_api.Repository{
    public interface IArrayDataRepo{
        //Interface for storing NumArrayData
        //read/write

        NumArrayData GetSorted();
        bool SaveSorted(NumArrayData numArrayData);
    }
}
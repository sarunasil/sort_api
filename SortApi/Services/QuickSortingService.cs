
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using SortApi.Models;
using SortApi.Repository;

namespace SortApi.Services{
    public class QuickSortingService : ISortingService{

        //Implementation of a sorter that uses
        //QuickSort

        private readonly IArrayDataRepo _fileRepo;

        public QuickSortingService(IArrayDataRepo repo){
            _fileRepo = repo;
        }

        public NumArrayData GetSorted()
        {
            try{
                return _fileRepo.GetSorted();
            }
            catch{
                return null;
            }
        }

        public bool Sort(NumArrayData numArrayData){

            try{
                // Could be just:
                // numArrayData.Array.Sort();
                QuickSort(numArrayData.Array, 0, numArrayData.Array.Count-1);

                var res = _fileRepo.SaveSorted(numArrayData);

                if (!res){
                    throw new System.Exception("Could not save to file");
                }
                return true;
            }
            catch{
                return false;
            }
        }

        private static void QuickSort(List<int> arr, int low, int high){
            if (low < high){
                int pi = Partition(arr, low, high);

                QuickSort(arr, low, pi-1);
                QuickSort(arr, pi+1, high);
            }
        }

        private static int Partition(List<int> arr, int low, int high){
            int pivot = arr[high];

            int i = low - 1;
            for (int j = low; j < high; j++){
                if (arr[j] < pivot){
                    i++;
                    // swap arr[i] and arr[j]
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            int temp1 = arr[i+1];
            arr[i+1] = arr[high];
            arr[high] = temp1;

            return i+1;
        }

    }
}
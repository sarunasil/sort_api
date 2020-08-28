
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sort_api.Models;

namespace sort_api.Services{
    public class SortingService : ISortingService{
        //Implementation of a sorter that uses
        //QuickSort

        public NumArrayData GetSorted()
        {
            throw new System.NotImplementedException();
        }

        public bool Sort(NumArrayData numArrayData){

            try{
                // Could be just:
                // numArrayData.Array.Sort();
                Quick_Sort(numArrayData.Array, 0, numArrayData.Array.Count-1);

                return true;
            }
            catch{
                return false;
            }
        }


        private static void Quick_Sort(List<int> arr, int left, int right){
            if (left < right){
                int marker = Partition(arr, left, right);

                if (marker > 1) {
                    Quick_Sort(arr, left, marker - 1);
                }
                if (marker + 1 < right) {
                    Quick_Sort(arr, marker + 1, right);
                }
            }
        }

        private static int Partition(List<int> arr, int left, int right){
            int marker = arr[left];
            while (true){

                while (arr[left] < marker){
                    left++;
                }

                while (arr[right] > marker){
                    right--;
                }

                if (left < right){
                    if (arr[left] == arr[right]){
                        return right;
                    }

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;

                }
                else {
                    return right;
                }
            }
        }
    }
}
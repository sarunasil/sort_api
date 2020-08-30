
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace sort_api.Models{
    public class NumArrayData{
        //Overcomplicated data class to store
        //the array that's to be sorted

        private const int MAX_SIZE = 256;
        [Required]
        [MaxLength(MAX_SIZE)]
        public List<int> Array { get; set; } = new List<int>{1,2,3};

    }

}
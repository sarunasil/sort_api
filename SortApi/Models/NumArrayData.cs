
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SortApi.Models{
    public class NumArrayData {
        //Overcomplicated data class to store
        //the array that's to be sorted

        [Required]
        public List<int> Array { get; set; }

    }

}
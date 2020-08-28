
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace sort_api.Models{
    public class NumArrayData{

        private const int MAX_SIZE = 256;
        [Required]
        [MaxLength(MAX_SIZE)]
        public List<int> Array { get; set; } = new List<int>{1,2,3};


    }

}
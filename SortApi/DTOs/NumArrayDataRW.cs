
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SortApi.DTOs{
    public class NumArrayDataRW {
        //Overcomplicated Data Type Object to
        //Read / Write NumArrayData objects
        //could justify overcomplicating things more
        //be creating 2 separate DTOs for R and W


        //It's actually not needed in this case as it's just transperrant
        //but just to show that I know what it is
        [Required]
        public List<int> Array { get; set; }

    }

}
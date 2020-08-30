
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SortApi.DTOs{
    public class NumArrayDataRW : IValidatableObject {
        //Overcomplicated Data Type Object to
        //Read / Write NumArrayData objects
        //could justify overcomplicating things more
        //be creating 2 separate DTOs for R and W


        //It's actually not needed in this case as it's just transperrant
        //but just to show that I know what it is

        const int MIN_LIMIT = 1;
        const int MAX_LIMIT = 10;

        [Required]
        public List<int> Array { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            foreach (int el in Array){
                if (!(MIN_LIMIT <= el && el <= MAX_LIMIT)){
                    yield return new ValidationResult($"All entered numbers must be between {MIN_LIMIT} and {MAX_LIMIT}(incl).");
                }
            }
        }

    }

}
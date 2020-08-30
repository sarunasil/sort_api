
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace sort_api.Models{
    public class NumArrayData : IValidatableObject{
        //Overcomplicated data class to store
        //the array that's to be sorted

        const int MIN_LIMIT = 1;
        const int MAX_LIMIT = 10;

        [Required]
        public List<int> Array { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            foreach (int el in Array){
                if (!(MIN_LIMIT < el && el <= MAX_LIMIT)){
                    yield return new ValidationResult($"All entered numbers must be between {MIN_LIMIT} and {MAX_LIMIT}(incl).");
                }
            }
        }
    }

}
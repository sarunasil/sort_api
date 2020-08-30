
using System.Collections.Generic;
using SortApi.Models;
using SortApi.Repository;
using SortApi.Services;
using Xunit;

namespace sort_api.Tests{
    public class SortingServiceTest{

        // Tests for sorting
        // Only includes tests for

        //Separate tests for Repository and Controller(end-points)
        //could have been designed but it's such a simple app
        //I couldn't justify the trouble
        //Obv, in a more realistic app, it wouldn't have been left in such a way
        private readonly IArrayDataRepo _repo;
        private readonly ISortingService _sorter;

        public SortingServiceTest(){
            _repo = new NumArrayDataFileRepo();
            _sorter = new QuickSortingService(_repo);
        }

        [Theory]
        [ClassData(typeof(NumArrayDataTestStub))]
        public void SortTest(NumArrayData numArrayData, IEnumerable<int> expected){

            _sorter.Sort(numArrayData);

            Assert.Equal(numArrayData.Array, expected);
        }

        [Theory]
        [ClassData(typeof(NumArrayDataTestStub))]
        public void GetTest(NumArrayData numArrayData, IEnumerable<int> expected){
            //It's kinda hacky to test it this way put I'm just concerned
            //that the saved file stays the same
            //and, of course, could have de-coupled from the SortTest stub object
            //but it doesn't make any difference
            _sorter.Sort(numArrayData);

            NumArrayData res = _sorter.GetSorted();

            Assert.Equal(res.Array, expected);
        }
    }
}

using System;
using System.IO;
using System.Text.Json;
using SortApi.Models;

namespace SortApi.Repository{
    public class NumArrayDataFileRepo : IArrayDataRepo
    {
        //Implementation of a class that saves
        //ArrayData (NumArrayData) to a file

        const string SAVE_FILE = "./save_file.json";
        public NumArrayData GetSorted()
        {
            try{
                string jsonString = File.ReadAllText(SAVE_FILE);

                NumArrayData numArrayData = JsonSerializer.Deserialize<NumArrayData>(jsonString);

                return numArrayData;
            }
            catch{
                throw new Exception("Could read the saved file.");
            }
        }

        public bool SaveSorted(NumArrayData numArrayData)
        {

            try{
                string jsonString = JsonSerializer.Serialize(numArrayData);

                File.WriteAllText(SAVE_FILE, jsonString);
                return true;
            }
            catch{
                return false;
            }

        }
    }
}
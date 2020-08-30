
using System;
using System.IO;
using System.Text.Json;
using sort_api.Models;

namespace sort_api.Repository{
    public class NumArrayDataFileRepo : IArrayDataRepo
    {
        //Implementation of a class that saves
        //ArrayData (NumArrayData) to a file

        const string SAVE_FILE = "./save_file.json";
        public NumArrayData GetSorted()
        {
            throw new System.NotImplementedException();
        }

        public bool SaveSorted(NumArrayData numArrayData)
        {

            try{
                string jsonString = JsonSerializer.Serialize(numArrayData);

                Console.Write(jsonString);

                File.WriteAllText(SAVE_FILE, jsonString);
                return true;
            }
            catch{
                return false;
            }

        }
    }
}
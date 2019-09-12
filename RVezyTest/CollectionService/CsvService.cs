using CsvHelper;
using RVezyTest.Interfaces;
using RVezyTest.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RVezyTest.CollectionService
{
    public class CsvService : ICsvService
    {
        const string fileName = "\\seattle\\listings.csv";
        public IEnumerable<Listing> GetValues()
        {
            var filePath = Environment.CurrentDirectory + fileName;
            var contents = File.ReadAllText(filePath).Split('\n');

            TextReader reader = new StreamReader(filePath);
            var csvReader = new CsvReader(reader);
            var records = csvReader.GetRecords<Listing>();

            return records;
        }


        // ran out of time to figure out how to parse this
        public IEnumerable<Listing> GetValuesByPropertyType(string property_type)
        {
            var filePath = Environment.CurrentDirectory + fileName;
            var contents = File.ReadAllText(filePath).Split('\n');

            var reader = new CsvReader(File.OpenText(filePath));
            reader.Read();
            reader.ReadHeader();
            string[] headerRow = reader.Context.HeaderRecord;
            while (reader.Read())
            {
          
                string value = reader.GetField<string>(property_type);

            }

            return reader.GetRecords<Listing>();
        }
    }
}

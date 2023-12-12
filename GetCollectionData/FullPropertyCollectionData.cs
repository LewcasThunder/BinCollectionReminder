using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using GetCollectionData.Models;

namespace GetCollectionData
{
    public class FullPropertyCollectionData
    {
        public readonly IEnumerable<AddressModel> AddressList = LoadCsv<AddressModel>("https://opendata.leeds.gov.uk/downloads/bins/dm_premises.csv");
        public readonly IEnumerable<CollectionDataModel> CollectionData = LoadCsv<CollectionDataModel>("https://opendata.leeds.gov.uk/downloads/bins/dm_jobs.csv");

        private static IEnumerable<T> LoadCsv<T>(string url)
        {
            var getCsvResponse = new HttpClient().GetStringAsync(url).Result;

            using var csv = new CsvReader(new CsvParser(new StringReader(getCsvResponse), new CsvConfiguration(CultureInfo.InvariantCulture) { HasHeaderRecord = false }));
            return csv.GetRecords<T>().ToArray();
        }
    }
}

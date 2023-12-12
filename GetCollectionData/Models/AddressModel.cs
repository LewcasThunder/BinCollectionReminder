using CsvHelper.Configuration.Attributes;

namespace GetCollectionData.Models
{
    public class AddressModel
    {
        [Index(0)]
        public readonly int PropertyId;
        [Index(1)]
        public readonly string? AddressLine1;
        [Index(2)]
        public readonly string? AddressLine2;
        [Index(3)]
        public readonly string? AddressLine3;
        [Index(4)] 
        public readonly string? AddressLine4;
        [Index(5)]
        public readonly string? AddressLine5;
        [Index(6)]
        public readonly string Postcode;


        public AddressModel(int propertyId, string? addressLine1, string? addressLine2, string? addressLine3, string? addressLine4, string? addressLine5, string postcode)
        {
            PropertyId = propertyId;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            AddressLine3 = addressLine3;
            AddressLine4 = addressLine4;
            AddressLine5 = addressLine5;
            Postcode = postcode;
        }
    }
}

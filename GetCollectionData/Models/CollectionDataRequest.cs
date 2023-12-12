namespace GetCollectionData.Models
{
    public class CollectionDataRequest
    {
        public CollectionDataRequest(string postcode)
        {
            Postcode = postcode;
        }

        public string Postcode { get; }
    }
}

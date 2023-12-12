namespace GetCollectionData.Models
{
    public class CollectionDataModel
    {
        internal readonly int PropertyId;
        internal readonly string BinType;
        internal readonly string CollectionDate;

        public CollectionDataModel(int propertyId, string binType, string collectionDate)
        {
            PropertyId = propertyId;
            BinType = binType;
            CollectionDate = collectionDate;
        }
    }
}

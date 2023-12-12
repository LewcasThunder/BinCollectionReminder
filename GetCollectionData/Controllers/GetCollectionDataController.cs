using GetCollectionData.Models;
using Microsoft.AspNetCore.Mvc;

namespace GetCollectionData.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GetCollectionDataController : ControllerBase
    {
        private readonly FullPropertyCollectionData _collectionData;

        public GetCollectionDataController(FullPropertyCollectionData collectionData)
        {
            _collectionData = collectionData;
        }

        [HttpGet]
        [Route("{postcode}")]
        public IEnumerable<CollectionDataResponse> Post(string postcode)
        {
            var reducedInputPostcode = postcode.Replace(" ", string.Empty).ToUpper();
            var propertyId = _collectionData.AddressList.First(address =>
                address.Postcode.Replace(" ", string.Empty).ToUpper() == reducedInputPostcode).PropertyId;

            return _collectionData.CollectionData
                .Where(collectionData => collectionData.PropertyId == propertyId)
                .Select(collectionData => new CollectionDataResponse
                {
                    CollectionDate = DateTime.Parse(collectionData.CollectionDate), 
                    BinType = collectionData.BinType
                });
        }
    }
}

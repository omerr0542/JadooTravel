using AutoMapper;
using JadooTravel.Dtos.DestinationDtos;
using JadooTravel.Entites;
using JadooTravel.Settings;
using MongoDB.Driver;

namespace JadooTravel.Services.DestinationServices
{
    public class DestinationService : IDestinationService
    {

        private readonly IMongoCollection<Destination> _destinationCollection;
        private readonly IMapper _mapper;

        public DestinationService(IMapper mapper, IDatabaseSettings databaseSettings)
        {
            var client = new MongoClient(databaseSettings.CollectionString);
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            _destinationCollection = database.GetCollection<Destination>(databaseSettings.DestinationCollectionName);

            _mapper = mapper;
        }

        public async Task CreateDestinationAsync(CreateDestinationDto createDestinationDto)
        {
            var values = _mapper.Map<Destination>(createDestinationDto); // Dto'dan Entity'e dönüşüm
            await _destinationCollection.InsertOneAsync(values); // Veritabanına ekleme işlemi
        }

        public async Task DeleteDestinationAsync(string id)
        {
            await _destinationCollection.DeleteOneAsync(x => x.DestinationId == id);
        }

        public async Task<List<ResultDestinationDto>> GetAllDestinationAsync()
        {
            var values = await _destinationCollection.Find(x => true).ToListAsync(); // Tüm belgeleri getirir
            return _mapper.Map<List<ResultDestinationDto>>(values); // Entity listesini Dto listesine dönüştürür
        }

        public async Task<GetDestinationByIdDto> GetDestinationByIdAsync(string id)
        {
            var value =  await _destinationCollection.Find(x => x.DestinationId == id).FirstOrDefaultAsync(); // Belirli bir belgeyi getirir
            return _mapper.Map<GetDestinationByIdDto>(value); // Entity'yi Dto'ya dönüştürür
        }

        public async Task UpdateDestinationAsync(UpdateDestinationDto updateDestinationDto)
        {
            var value = _mapper.Map<Destination>(updateDestinationDto); // Dto'dan Entity'e dönüşüm
            await _destinationCollection.FindOneAndReplaceAsync(x => x.DestinationId == updateDestinationDto.DestinationId, value); // Belgeyi günceller
        }
    }
}

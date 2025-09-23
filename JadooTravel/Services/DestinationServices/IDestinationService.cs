﻿using JadooTravel.Dtos.DestinationDtos;

namespace JadooTravel.Services.DestinationServices
{
    public interface IDestinationService
    {
        Task<List<ResultDestinationDto>> GetAllDestinationAsync();
        Task CreateDestinationAsync(CreateDestinationDto createDestinationDto);
        Task UpdateDestinationAsync(UpdateDestinationDto updateDestinationDto);
        Task DeleteDestinationAsync(string id);
        Task<GetDestinationByIdDto> GetDestinationByIdAsync(string id);
    }
}

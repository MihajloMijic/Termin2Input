using Code9.Domain.Commands;
using Code9.Domain.Interfaces;
using Code9.Domain.Models;
using MediatR;

namespace Code9.Domain.Handlers
{
    public class AddCinemaHandler : IRequestHandler<AddCinemaCommand, Cinema>
    {
        private readonly ICinemaRepository _cinemaRepository;

        public AddCinemaHandler(ICinemaRepository cinemaRepository)
        {
            _cinemaRepository = cinemaRepository;
        }

        public async Task<Cinema> Handle(AddCinemaCommand request, CancellationToken cancellationToken)
        {
            var cinema = new Cinema
            {
                Name = request.Name,
                City = request.City,
                Street = request.Street,
                NumberOfAuditoriums = request.NumberOfAuditoriums
            };

            return await _cinemaRepository.AddCinema(cinema);
        }
    }
}

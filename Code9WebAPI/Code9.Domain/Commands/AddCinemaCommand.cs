using Code9.Domain.Models;
using MediatR;

namespace Code9.Domain.Commands
{
    public record AddCinemaCommand : IRequest<Cinema>
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int NumberOfAuditoriums { get; set; }
    }
}

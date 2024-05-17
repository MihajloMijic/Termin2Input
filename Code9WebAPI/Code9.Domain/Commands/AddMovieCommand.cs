using Code9.Domain.Models;
using MediatR;

namespace Code9.Domain.Commands
{
    public class AddMovieCommand : IRequest<Movie>
    {
    }
}

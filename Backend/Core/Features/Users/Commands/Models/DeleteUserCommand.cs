using Core.Bases;
using MediatR;

namespace Core.Features.Users.Commands.Models;

public class DeleteUserCommand : IRequest<Response<string>>
{
    public int Id { get; set; }
    public DeleteUserCommand(int id)
    {
        Id = id;
    }
}

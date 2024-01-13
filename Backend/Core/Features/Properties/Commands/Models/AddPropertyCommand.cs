using Core.Bases;
using MediatR;

namespace Core.Features.Properties.Commands.Models;

public class AddPropertyCommand : IRequest<Response<string>>
{
    public string NameAr { get; set; }
    public string NameEn { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public int BrokerId { get; set; }
}

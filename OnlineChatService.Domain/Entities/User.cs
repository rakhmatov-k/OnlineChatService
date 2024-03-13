using OnlineChatService.Domain.Commons;

namespace OnlineChatService.Domain.Entities;

public class User : Auditable
{
    public string UserName {  get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
}


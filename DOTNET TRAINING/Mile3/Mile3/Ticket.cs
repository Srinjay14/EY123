using System;
using System.Collections.Generic;

namespace Mile3;

public partial class Ticket
{
    public int TicketId { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string Status { get; set; } = null!;

    public int UserId { get; set; }

    public virtual User1 User { get; set; } = null!;
}

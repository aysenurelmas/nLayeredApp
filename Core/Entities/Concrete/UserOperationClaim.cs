﻿using Entities.Concrete;

namespace Core.Entities.Concrete;

public class UserOperationClaim : Entity<Guid>
{
    public Guid UserId { get; set; }
    public Guid OperationClaimId { get; set; }

   // public virtual User User { get; set; }
    public virtual OperationClaim OperationClaim { get; set; }
    public virtual User User { get; set; }
}

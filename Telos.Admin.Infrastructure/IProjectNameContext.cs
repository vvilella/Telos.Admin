using System;

namespace  Telos.Admin.Infrastructure
{
    public interface IDatabaseControlContext
    {
        int SaveChanges();
    }
}

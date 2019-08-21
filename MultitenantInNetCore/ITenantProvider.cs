using System;

namespace MultitenantInNetCore
{
    public interface ITenantProvider
    {
        Guid GetTenantId();
    }
}
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultitenantInNetCore
{
    public class DatabaseTenantProvider : ITenantProvider
    {
        private Guid _tenantId;

        public DatabaseTenantProvider(TenantsDbContext context, IHttpContextAccessor accessor)
        {
            var host = accessor.HttpContext.Request.Host.Value;
            _tenantId = context.Tenants.First(t => t.HostName == host).Id;
        }

        public Guid GetTenantId()
        {
            return _tenantId;
        }
    }
}

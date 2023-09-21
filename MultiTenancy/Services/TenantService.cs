namespace MultiTenancy.Services
{
    public class TenantService : ITenantService
    {
        private HttpContext? _httpContext;
        private Tenant? _currentTenant;
        public TenantService(IHttpContextAccessor contextAccessor)
        {
            _httpContext = contextAccessor.HttpContext;
            if(_httpContext is not null)
            {
                if(_httpContext.Request.Headers.TryGetValue("tenant", out var tenantId))
                {

                }
            }
        }
        public string? GetConnectionSting()
        {
            throw new NotImplementedException();
        }

        public Tenant? GetCurrentTenant()
        {
            return _currentTenant;
        }

        public string? GetDatabaseProvider()
        {
            throw new NotImplementedException();
        }
    }
}

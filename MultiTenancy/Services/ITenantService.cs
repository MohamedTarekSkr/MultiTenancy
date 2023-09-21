namespace MultiTenancy.Services
{
    public interface ITenantService
    {
        string? GetDatabaseProvider();
        string? GetConnectionSting();
        Tenant? GetCurrentTenant();
    }
}

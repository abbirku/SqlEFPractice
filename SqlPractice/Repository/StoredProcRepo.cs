using Microsoft.EntityFrameworkCore;
using SqlPractice.Core.PROC_Models;

namespace SqlPractice.Repository
{
    public class StoredProcRepo
    {
        private readonly EFCoreContext _context;

        public StoredProcRepo(EFCoreContext context)
        {
            _context = context;
        }

        public async Task<List<VehiclePR>> GetVehiclePrRecords(string query, int pageNumber, int pageSize)
        {
            var command = "";
            if (!string.IsNullOrEmpty(query) && query.Equals("null"))
                command = $"EXEC PROC_ADMIN_CreateVehiclePR @SearchKeyword = {query}, @PageNumber = {pageNumber}, @PageSize = {pageSize};";
            else
                command = $"EXEC PROC_ADMIN_CreateVehiclePR @SearchKeyword = '{query}', @PageNumber = {pageNumber}, @PageSize = {pageSize};";

            var prRes = await _context.PROC_VehiclePR_Model
                .FromSqlRaw(command)
                .ToListAsync();

            return prRes;
        }
    }
}

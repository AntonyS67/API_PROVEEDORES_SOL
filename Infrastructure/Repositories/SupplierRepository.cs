using Application.Repositories;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly AppDBContext context;

        public SupplierRepository(AppDBContext context)
        {
            this.context = context;
        }

        public async Task<string> CreateSupplier(Supplier request)
        {
            await context.Suppliers.AddAsync(request);
            await context.SaveChangesAsync();
            return "Supplier Created";
        }

        public async Task<bool> DeleteSupplier(int id)
        {
            Supplier supplier = await this.GetSupplier(id);
            if (supplier == null)
            {
                return false;
            }

            context.Suppliers.Remove(supplier);
            await context.SaveChangesAsync();
            return true;
        }

        public async Task<Supplier> GetSupplier(int id)
        {
            Supplier? supplier = await context.Suppliers.FindAsync(id);
            return supplier;

        }

        public async Task<List<Supplier>> ListSuppliers()
        {
            List<Supplier> suppliers = new List<Supplier>();

            suppliers = await context.Suppliers.ToListAsync();

            return suppliers;
        }

        public async Task<string> UpdateSupplier(Supplier request)
        {
            Supplier supplier = await this.GetSupplier(request.Id);

            if (supplier == null)
            {
                return "Supplier not exist";
            }

            supplier.NIT = request.NIT;
            supplier.Razon_Social = request.Razon_Social;
            supplier.Address = request.Address;
            supplier.City = request.City;
            supplier.Region = request.Region;
            supplier.Email = request.Email;
            supplier.Contact_Name = request.Contact_Name;
            supplier.Contact_Email = request.Contact_Email;
            await context.SaveChangesAsync();

            return "Supplier Updated";
        }
    }
}

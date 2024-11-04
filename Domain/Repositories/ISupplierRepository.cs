namespace Application.Repositories
{
    public interface ISupplierRepository
    {
        public Task<List<Supplier>> ListSuppliers();

        public Task<Supplier> GetSupplier(int id);

        public Task<string> CreateSupplier(Supplier request);
        public Task<string> UpdateSupplier(Supplier request);
        public Task<bool> DeleteSupplier(int id);
    }
}

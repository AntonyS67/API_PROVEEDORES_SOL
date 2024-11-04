namespace Application.UseCases
{
    public interface ISupplierUseCase
    {
        public Task<List<Supplier>> ListSuppliers();

        public Task<Supplier> GetSupplier(int id);

        public Task<string> CreateSupplier(Supplier request);
        public Task<string> UpdateSupplier(Supplier request);
        public Task<bool> DeleteSupplier(int id);
    }
}

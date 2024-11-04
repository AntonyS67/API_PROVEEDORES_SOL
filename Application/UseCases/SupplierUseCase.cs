using Application.Repositories;

namespace Application.UseCases
{
    public class SupplierUseCase : ISupplierUseCase
    {
        public readonly ISupplierRepository supplierRepository;

        public SupplierUseCase(ISupplierRepository supplierRepository)
        {
            this.supplierRepository = supplierRepository;
        }

        public async Task<string> CreateSupplier(Supplier request)
        {
            return await this.supplierRepository.CreateSupplier(request);
        }

        public async Task<bool> DeleteSupplier(int id)
        {
            return await this.supplierRepository.DeleteSupplier(id);
        }

        public async Task<Supplier> GetSupplier(int id)
        {
            return await this.supplierRepository.GetSupplier(id);
        }

        public async Task<List<Supplier>> ListSuppliers()
        {
            return await this.supplierRepository.ListSuppliers();
        }

        public async Task<string> UpdateSupplier(Supplier request)
        {
            return await this.supplierRepository.UpdateSupplier(request);
        }
    }
}

using BootcampAPIProje.Commands.KitapDelete;
using BootcampAPIProje.Commands.KitapInsert;
using BootcampAPIProje.Commands.KitapUpdate;
using BootcampAPIProje.Models;

namespace BootcampAPIProje.Repositories
{
    public interface IKitapRepository
    {
        Task<List<Kitap>> GetAll();

        Task<List<Kitap>> GetAllWithPage(int page, int pageSize);

        Task<List<Kitap>> GetAllWithPageParameters(int page, int pageSize);

        Task<int> Save(KitapInsertCommand kitapInsertCommand);

        Task<bool> Update(KitapUpdateCommand updateCommand);

        Task<bool> Delete(KitapDeleteCommand kitapDeleteCommand);
    }
}
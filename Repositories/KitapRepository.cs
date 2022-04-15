using BootcampAPIProje.Commands.KitapDelete;
using BootcampAPIProje.Commands.KitapInsert;
using BootcampAPIProje.Commands.KitapUpdate;
using BootcampAPIProje.Models;
using Dapper;
using System.Data;

namespace BootcampAPIProje.Repositories
{
    public class KitapRepository : IKitapRepository
    {
        private readonly IDbConnection _connection;

        public KitapRepository(IDbConnection connection)
        {
            _connection = connection;
        }


        public async Task<List<Kitap>> GetAll()
        {
            var query = "select * from kitaplar";

            var kitaplar = await _connection.QueryAsync<Kitap>(query);

            return kitaplar.ToList();
        }

        public async Task<List<Kitap>> GetAllWithPage(int page, int pageSize)
        {
            int offset = (page - 1) * pageSize;
            var query = "select * from kitaplar order by id desc limit @pagesize offset @offset";

            var kitaplar = await _connection.QueryAsync<Kitap>(query, new { pagesize = pageSize, offset = offset });

            return kitaplar.ToList();
        }

        public async Task<List<Kitap>> GetAllWithPageParameters(int page, int pageSize)
        {

            int offset = (page - 1) * pageSize;
            var query = "select * from kitaplar order by id desc limit @pagesize offset @offset";

            var parameters = new DynamicParameters();
            parameters.Add("pagesize", pageSize, DbType.Int32);
            parameters.Add("offset", offset, DbType.Int32);
            var kitaplar = await _connection.QueryAsync<Kitap>(query, parameters);

            return kitaplar.ToList();
        }

        public async Task<int> Save(KitapInsertCommand kitapInsertCommand)
        {
            var command = "insert into kitaplar(Isbn, KitapAdi, YazarAdi, Fiyat) values(@isbn,@kitapadi,@yazaradi,@fiyat) returning isbn";

            var isbn = await _connection.ExecuteScalarAsync<int>(command, kitapInsertCommand.newKitap);

            return isbn;
        }

        public async Task<bool> Update(KitapUpdateCommand updateCommmand)
        {
            var command = "update kitaplar set isbn=@isbn, kitapadi=@kitapadi, yazaradi=@yazaradi, fiyat=@fiyat where isbn=@isbn";

            return await _connection.ExecuteAsync(command, updateCommmand) > 0;
        }



        public async Task<bool> Delete(KitapDeleteCommand kitapDeleteCommand)
        {
            var command = "delete from kitaplar where isbn=@isbn";

            return await _connection.ExecuteAsync(command, kitapDeleteCommand) > 0;
        }




        public async Task<bool> TransferByStoreProcedure(AccountTransferCommand accountTransferCommand)
        {
            var sp = $"call sp_transfer({accountTransferCommand.Sender},{accountTransferCommand.Receiver},{accountTransferCommand.Amount})";

            var p = new DynamicParameters();

            return await _connection.ExecuteAsync(sp, accountTransferCommand) > 0;
        }
    }
}

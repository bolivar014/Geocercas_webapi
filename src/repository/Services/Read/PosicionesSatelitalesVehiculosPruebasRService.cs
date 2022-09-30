using ApplicationDbContextRSQLSERVER;
using DTOS.Read;
using Interfaces.Read;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Services.Read
{
    public class PosicionesSatelitalesVehiculosPruebasRService : PosicionesSatelitalesVehiculosPruebasRInterface
    {
        private readonly ApplicationDbContextRSQLSERVER _applicationDbContextRSQLSERVER;

        public PosicionesSatelitalesVehiculosPruebasRService(
            ApplicationDbContextRSQLSERVER applicationDbContextRSQLSERVER)
        {
            _applicationDbContextRSQLSERVER = applicationDbContextRSQLSERVER;
        }

        public async Task<PosicionesSatelitalesVehiculosPruebasRDTO> Get(Guid id)
        {
            return null;
        }

        public async Task<List<PosicionesSatelitalesVehiculosPruebasRDTO>> GetList()
        {
            try
            {
                // var List<P>
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.ToString());
            }
            return null;
        }
    }
}

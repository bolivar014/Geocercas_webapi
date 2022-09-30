using DTOS.Read;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Read
{
    public class PosicionesSatelitalesVehiculosPruebasRInterface
    {
        Task<List<PosicionesSatelitalesVehiculosPruebasRDTO>> GetList();

        Task<PosicionesSatelitalesVehiculosPruebasRDTO> Get(Guid id);
    }
}

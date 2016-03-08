using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel.GenericRepository;
using BusinessEntities;
namespace BusinessServices.BaoCaoCongNo
{
    interface IBaoCaoCongNoService
    {
        bool Create(BaoCaoCongNoEntity _BaoCaoCongNo);
        bool Delete(BaoCaoCongNoEntity _BaoCaoCongNo);
        bool Update(BaoCaoCongNoEntity _BaoCaoCongNo);
        List<BaoCaoCongNoEntity> GetAll();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel.UnitOfWork;
using DataModel;
using BusinessEntities;

namespace BusinessServices.BaoCaoCongNo
{
    public class BaoCaoCongNoService : IBaoCaoCongNoService
    {
        private readonly UnitOfWork m_UnitOfWork;
        
        public BaoCaoCongNoService()
        {
            m_UnitOfWork = new UnitOfWork();
        }

        public bool Create(BaoCaoCongNoEntity _BaoCaoCongNo)
        {
            try
            {
                var BaoCaoCongNo = new BAOCAOCONGNO
                {
                    NgayBaoCao = _BaoCaoCongNo.NgayBaoCao,
                    MaBaoCaoCongNo = _BaoCaoCongNo.MaBaoCaoCongNo
                };
                if(BaoCaoCongNo.NgayBaoCao == DateTime.MinValue)
                {
                    BaoCaoCongNo.NgayBaoCao = null;
                }
                m_UnitOfWork.BaoCaoCongNoRepository.Insert(BaoCaoCongNo);
                return true;
            }catch(Exception e)
            {
                System.Console.WriteLine(e.ToString());
                return false;
            }
        }

        public bool Delete(BaoCaoCongNoEntity _BaoCaoCongNo)
        {
            try
            {
                m_UnitOfWork.BaoCaoCongNoRepository.Delete(_BaoCaoCongNo);
                return true;
            }catch(Exception e)
            {
                System.Console.WriteLine(e.ToString());
                return false;
            }
        }

        public List<BaoCaoCongNoEntity> GetAll()
        {
            IEnumerable<BAOCAOCONGNO> model = m_UnitOfWork.BaoCaoCongNoRepository.GetAll();
            List<BaoCaoCongNoEntity> result = new List<BaoCaoCongNoEntity>();

            foreach(var item in model)
            {
                BaoCaoCongNoEntity BaoCaoCongNo = new BaoCaoCongNoEntity();
                BaoCaoCongNo.MaBaoCaoCongNo = item.MaBaoCaoCongNo;
                BaoCaoCongNo.NgayBaoCao = item.NgayBaoCao;
                result.Add(BaoCaoCongNo);
            }
            return result;
        }

        public bool Update(BaoCaoCongNoEntity _BaoCaoCongNo)
        {
            var BaoCaoCongNo = m_UnitOfWork.BaoCaoCongNoRepository.GetByID(_BaoCaoCongNo.MaBaoCaoCongNo);
            if (BaoCaoCongNo == null) return false;

            BaoCaoCongNo.MaBaoCaoCongNo = _BaoCaoCongNo.MaBaoCaoCongNo;
            BaoCaoCongNo.NgayBaoCao = _BaoCaoCongNo.NgayBaoCao;

            m_UnitOfWork.BaoCaoCongNoRepository.Update(BaoCaoCongNo);
            m_UnitOfWork.Save();
            return true;
        }
    }
}

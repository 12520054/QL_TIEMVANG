using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel.GenericRepository;

namespace DataModel.UnitOfWork
{
    public class UnitOfWork : IDisposable
    {
        QUANLYTIEMVANGEntities _context = null;

        private GenericRepository<BAOCAOCONGNO> m_BaoCaoCongNoRepository;


        public GenericRepository<BAOCAOCONGNO> BaoCaoCongNoRepository
        {
            get
            {
                if(this.m_BaoCaoCongNoRepository == null)
                {
                    m_BaoCaoCongNoRepository = new GenericRepository<BAOCAOCONGNO>(_context);
                }
                return m_BaoCaoCongNoRepository;
            }
        }

        public UnitOfWork()
        {
            _context = new QUANLYTIEMVANGEntities();
        }
        public void Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {

                var outputLines = new List<string>();
                foreach (var eve in e.EntityValidationErrors)
                {
                    outputLines.Add(string.Format("{0}: Entity of type \"{1}\" in state \"{2}\" has the following validation errors:", DateTime.Now, eve.Entry.Entity.GetType().Name, eve.Entry.State));
                    foreach (var ve in eve.ValidationErrors)
                    {
                        outputLines.Add(string.Format("- Property: \"{0}\", Error: \"{1}\"", ve.PropertyName, ve.ErrorMessage));
                    }
                }
                System.IO.File.AppendAllLines(@"C:\errors.txt", outputLines);

                throw e;
            }

        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    Debug.WriteLine("UnitOfWork is being disposed");
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

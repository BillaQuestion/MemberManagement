using Dayi.Data.Domain.Seedwork.Specification;
using MM.Business.Exceptions;
using MM.Model;
using MM.Model.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM.Business
{
    public class MediumMgr : IMediumMgr
    {
        IMediumRepository _mediumRepository;
        public MediumMgr(IMediumRepository mediumRepository)
        {
            _mediumRepository = mediumRepository;
        }

        public void AddMedium(Medium medium)
        {
            ISpecification<Medium> spec = new DirectSpecification<Medium>(m => m.Name == medium.Name);
            var result = _mediumRepository.FindBySpecification(spec).FirstOrDefault();
            if (result != null) throw new MediumExistException();

            _mediumRepository.Add(medium);
            _mediumRepository.UnitOfWork.Commit();
        }

        public void RemoveMedium(Guid mediumId)
        {
            var medium = _mediumRepository.GetByKey(mediumId);
            _mediumRepository.Remove(medium);

            _mediumRepository.UnitOfWork.Commit();
        }
    }
}

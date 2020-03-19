using System.Threading.Tasks;
using Arenal.Dms.Core.Models;
using Arenal.Dms.Domain.Entities;
using Arenal.Dms.Domain.Repository;

namespace Arenal.Dms.Core.Services
{
    public class DocumentTypeService : IDocumentTypeService
    {
        private readonly IRepository<DocumentType> _documentTypeRepository;

        public DocumentTypeService(IRepository<DocumentType> documentTypeRepository)
        {
            _documentTypeRepository = documentTypeRepository;
        }

        public async Task<DocumentTypeModel> Init(DocumentTypeModel model)
        {
            var xx = await _documentTypeRepository
                .GetWhere(x => x.DocumentTypeId == model.Id);

            return new DocumentTypeModel();
        }

        public async Task Create(DocumentTypeModel model)
        {
            throw new System.NotImplementedException();
        }

        public async Task Update(DocumentTypeModel model)
        {
            throw new System.NotImplementedException();
        }

        public async Task Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
using FluentValidation;

namespace ConsultorioIFSP.Domain.Base
{
    public interface IBaseService<TEntity> where TEntity : IBaseEntity
    {
        public void AttachObject(object obj);
        TOutputModel Add<TInputModel, TOutputModel, TValidator> (TInputModel inputModel)
            where TValidator : AbstractValidator<TEntity>
            where TInputModel : class
            where TOutputModel : class;
        /*public void IBaseService(IBaseService<TEntity> _baseRepository, IMapper _mapper)
        {
            _baseRepository = _baseRepository;
            _mapper = _mapper;
        }*/
        void Delete (int id);
        IEnumerable<TOutputModel> Get<TOutputModel> (IList<string>? includes = null) 
            where TOutputModel : class;
        TOutputModel GetById<TOutputModel>(int id, IList<string>? includes = null) 
            where TOutputModel : class;
        TOutputModel Update<TInputModel, TOutputModel, TValidator>
            (TInputModel inputModel) 
            where TValidator : AbstractValidator<TEntity>
            where TInputModel : class
            where TOutputModel : class;
        //object Get<T>(bool v);
    }
}

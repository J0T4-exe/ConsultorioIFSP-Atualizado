
namespace ConsultorioIFSP.Domain.Base
{
    public abstract class BaseEntity<TId> : IBaseEntity
    {
        protected BaseEntity()
        {
            
        }
        protected BaseEntity(TId id) 
        {
            Id = id;
        }
        public TId? Id { get; set; }

    }
}

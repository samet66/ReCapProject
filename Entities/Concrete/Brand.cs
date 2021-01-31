using Entities.Abstract;

namespace Entities.Concrete
{
    public class Brand : IEntity
    {
        public int BrandID { get; set; }
        public string BrandName { get; set; }
    }
}

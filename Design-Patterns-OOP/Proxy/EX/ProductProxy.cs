namespace Design_Patterns_OOP.Proxy.EX
{
    public class ProductProxy : Product
    {
        private readonly DbContext _context;

        public ProductProxy(int id, DbContext context) : base(id) => _context = context;


        public override void setName(string name)
        {
            base.setName(name);
            _context.markAsChanged(this);
        }
    }
}
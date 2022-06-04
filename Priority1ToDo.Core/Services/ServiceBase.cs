using Priority1ToDo.Core.Data;

namespace Priority1ToDo.Core.Services;

public abstract class ServiceBase
{

    protected Priority1DbContext _context;
    public ServiceBase(Priority1DbContext context)
    {
        _context = context;
    }
}

using System.Data;

namespace Robo.Domain.Interfaces
{
    public interface ILogger
    {
        void LogMsg(DataTable dt);
    }
}

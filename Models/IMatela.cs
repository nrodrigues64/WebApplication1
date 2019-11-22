using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public interface IMatela : IDisposable
    {
        void CreateMatela(DateTime da, int du);
        List<Matela> SelectAllMatelas();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectDesignPattern.Models
{
    public interface IInvoice
    {
        public void GenerateInvoice();
        public void SendInvoice();
    }
}

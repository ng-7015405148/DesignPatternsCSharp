using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectDesignPattern.Models
{
    public sealed class NullInvoice : IInvoice
    {
        private NullInvoice()
        {
        }
        public void GenerateInvoice()
        {
        }
        public void SendInvoice()
        {
        }
        public static NullInvoice Instance { get { return Nested.instance; } }
        class Nested
        {
            static Nested()
            {
            }
            internal static readonly NullInvoice instance = new NullInvoice();

        }

    }
}

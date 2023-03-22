using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp
{
    internal class CommissionEmployee : Employee
    {
        public float CommissionPercentaje { get; set; }
        public decimal Sales { get; set; }
        public override decimal GetValueToPay()
        {
            return Sales * (decimal)CommissionPercentaje;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                $"\n\tCommission percentaje: {$"{CommissionPercentaje:P2}", 18}"+
                $"\n\tSales................: {$"{Sales:C3}", 18}"+
                $"\n\tValue to pay.........:{$"{GetValueToPay():C2}",18}";
        }
    }
}

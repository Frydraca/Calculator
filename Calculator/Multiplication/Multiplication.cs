using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication
{
    [Export(typeof(Calculator.IOperation))]
    [ExportMetadata("Symbol", '*')]
    public class Multiplication : Calculator.IOperation
    {
        public double Operate(double left, double right)
        {
            return left * right;
        }
    }
}

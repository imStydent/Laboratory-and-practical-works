using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class OperationIntegerDivide : IStrategy
    {
        public int DoOperation(int variable1, int variable2) => variable1 / variable2;
    }
}

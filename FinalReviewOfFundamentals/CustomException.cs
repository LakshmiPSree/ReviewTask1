using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalReviewOfFundamentals
{
    internal class CustomException: Exception
    {
        public CustomException(string message) : base(message)
        {
        }
        public override string ToString()
        {
            return $"Custom Exception:{Message}";
        }
    }
}

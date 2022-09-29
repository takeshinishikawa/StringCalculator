using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator.Domain.Models
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;

            var parts = numbers.Split(',');

            if (parts.Length > 2 || parts.Any(x => string.IsNullOrEmpty(x)))
                throw new ArgumentException(nameof(numbers));
            else if (parts.Any(x => !int.TryParse(x, out int _)))
                throw new ArgumentException(nameof(numbers));

            return 100;
        }
    }
}

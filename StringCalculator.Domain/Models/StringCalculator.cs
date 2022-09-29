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
            var exceedsCount = parts.Length > 2;
            var consecutiveCommas = parts.Any(x => string.IsNullOrEmpty(x));
            var nonNumbers = parts.Any(x => !int.TryParse(x, out int _));

            if (exceedsCount || consecutiveCommas || nonNumbers)
                throw new ArgumentException(nameof(numbers));

            var sum = parts.Sum(x => Convert.ToInt32(x));

            return sum;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    /// <summary>
    /// Triangle definition
    /// </summary>
    public static class Triangle
    {
        /// <summary>
        /// Determines whether the specified a is triangle.
        /// </summary>
        /// <param name="a">Side a</param>
        /// <param name="b">Side b</param>
        /// <param name="c">Side c</param>
        /// <returns>
        ///   <c>true</c> if the specified a is triangle; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="ArgumentException">Fill sides more than 0</exception>
        public static bool IsTriangle(double a, double b, double c)
        {
            if (a > 0 && b > 0 && c > 0)
            {
                 return Helper(a, b, c) && Helper(a, c, b) && Helper(b, c, a) ?
                    true : false;
            }

            throw new ArgumentException("Fill value of sides more than 0");
        }
        private static bool Helper(double a, double b, double c)
            => (a + b > c) ? true : false;
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentoringD1D2.Module2.Task3.Helpers
{
    /// <summary>
    /// The class that provides additional functionality to work with array of strings.
    /// </summary>
    public static class StringArrayExtension
    {
        /// <summary>
        /// Returns the string that consists of every second element in array.
        /// </summary>
        /// <param name="array">The array of strings.</param>
        /// <returns>The string that consists of every second element in array.</returns>
        public static string CustomStringConcatenate(this string[] array)
        {
            if(array == null)
                throw new ArgumentNullException(nameof(array));

            if (array.Length == 0)
                return String.Empty;

            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < array.Length; i++)
            {
                if ((i+1)%2 == 0)
                {
                    stringBuilder.Append(array[i] ?? String.Empty);
                }
            }
            return stringBuilder.ToString();
        }
    }
}

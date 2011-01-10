using System.Text;
using System;

namespace Capitalise
{
    public static class ExtensionMethods
    {
        public static string Capitalize(this string value)
        {
            // <pex>
            if (value == (string)null)
                throw new ArgumentNullException("value");
            // </pex>
            var sb = new StringBuilder();
            var writingWord = false;

            foreach (var c in value)
            {
                if (char.IsLetter(c) || c == '_')
                {
                    if (!writingWord)
                    {
                        sb.Append(char.ToUpper(c));
                        writingWord = true;
                    }
                    else
                    {
                        sb.Append(c);
                    }
                }
                else
                {
                    if (c == '.')
                    {
                        sb.Append('_');
                    }
                    writingWord = false;
                }
            }
            return sb.ToString();
        }
    }
}

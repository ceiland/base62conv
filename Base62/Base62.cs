using System;

namespace BaseConverter
{
    public class Base62
    {
        // A public accessor
        public static string Convert(long input)
        {
            //return Base62Iterative(input);
            //return Base62Recursive(input);
            return Base62Condensed(input);
        }

        // An iterative version
        private static string Base62Iterative(long input)
        {
            // Arrange in/out: 
            // in: quotient, base, remainder
            // out: output
            long q = input;
            int b = 62;
            long r = 0;
            string output = string.Empty;

            // Loop until quotient > 62
            while (q >= b)
            {
                // Get a remainder and iterate the quotient
                r = q % b;
                q = q / b;

                // Push the base62 value on top of the string
                output = output.Insert(0, Base62Str((int)r));
            }

            // Push the base62 value of the last quotient
            output = output.Insert(0, Base62Str((int)q));

            return output;
        }
        
        // A recursive version
        private static string Base62Recursive(long input)
        {
            // Break out if the input is a single Base62 "digit"
            if (input < 62)
                return Base62Str((int)input);

            // Set up the working parts
            long q = input;
            int b = 62;
            long r = 0;
            string output = "";

            // Get the remainder and new quotient
            r = q % b;
            q = q / b;

            // Drill down if the next quotient is greater than the base
            // Else append the Base62 digit
            if (q >= b)
            {
                output += Base62Recursive(q);
            }
            else
            {
                output += Base62Str((int)q);
            }

            // Append the last remainder and finish
            output += Base62Str((int)r);
            return output;
        }

        // A condensed recursive version
        private static string Base62Condensed(long input)
        {
            if (input < 62)
                return Base62Str((int)input);

            string output = string.Empty;

            output += (input / 62 >= 62) ? Base62Condensed(input / 62) : Base62Str((int)(input / 62));

            return output += Base62Str((int)(input % 62));
        }

        // Returns the converted string value
        private static string Base62Str(int i)
        {
            return "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"[i].ToString();
        }
    }
}

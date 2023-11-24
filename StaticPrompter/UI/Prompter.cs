using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticPrompter.UI
{   
    /// <summary>
    /// Containes Methods For Prompting Users.
    /// </summary>
    public static class Prompter
    {
        /// <summary>
        /// Prompts The User For A Non-zero Length String.
        /// </summary>
        /// <param name="prompt"> The Text You Want To Display To The User As A Prompt.</param>
        /// <returns>A Non-Zero Length String</returns>
        public static string GetRequiredString (string prompt)
        {
            string input;

            do
            {
                Console.Write(prompt);
                input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input))
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("You Must Enter At Least One Character!");
                }
            } while (true);
        }

    }
}

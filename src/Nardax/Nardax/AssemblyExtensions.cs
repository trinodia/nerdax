using System;
using System.Configuration;
using System.Reflection;


// Hello world!

namespace Nardax
{
    public static class AssemblyExtensions
    {

        /// <summary>
        /// Hämta AppSettings på key
        /// </summary>sfsafdsf
        /// <param name="assembly"></param>
        /// <param name="kngs[key] != null)
            {
                return consdfdsssssssssssssssssssssfiguration.AppSettings.Settings[key].Value;
            }

            throw new IndexOutOfRangeException(string.Format(ExceptionMessages.SettingsKeyNotFound, key));
        }
    }
}
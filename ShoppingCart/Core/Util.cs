using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCodeSystems.ShoppingCart
{
    internal static class Util
    {
        #region Configuration functions
        /// <summary>
        /// Reads the configuration file appSettings section and returns the result as a string
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        public static string ReadConfiguration(string key)
        {
            return ReadConfiguration(null, key);
        }

        /// <summary>
        /// Reads the configuration file specified section and returns the result as a string
        /// </summary>
        /// <param name="section">the name/value pair configuration section to read the key from</param>
        /// <param name="key">The key to read from</param>
        /// <returns></returns>
        public static string ReadConfiguration(string section, string key)
        {
            return ReadConfiguration<string>(section, key);
        }


        /// <summary>
        /// Reads the configuration file appSettings section and casts the return value as T
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        public static T ReadConfiguration<T>(string key)
        {
            return ReadConfiguration<T>(null, key);
        }

        /// <summary>
        /// Reads the configuration file
        /// </summary>
        /// <param name="section">the name/value pair configuration section to read the key from</param>
        /// <param name="key">the configuration key to read</param>
        /// <returns></returns>
        public static T ReadConfiguration<T>(string section, string key)
        {
            string value;
            NameValueCollection sectionData;

            if (section == null)
                section = "appSettings";

            try
            {
                sectionData = (NameValueCollection)ConfigurationManager.GetSection(section);
            }
            catch (InvalidCastException)
            {
                throw new Exception("The configuration file section '" + section + "' is not a name-value pair section (<add key=\"...\" value=\"...\">)");
            }

            if (sectionData == null)
                throw new Exception("The configuration file does not contain a section called '" + sectionData + "'");

            value = sectionData[key];

            if (value == null)
                throw new Exception("The configuration file does not contain an entry for key '" + key + "'");

            T result = default(T);

            try
            {
                result = (T)Convert.ChangeType(value, typeof(T));
            }
            catch (FormatException)
            {
                throw new Exception(String.Format("The value '{0}' read from the configuration file under '{1}' could not be converted to type {2}",
                                    value, key, typeof(T).Name));
            }
            catch
            {
                throw;
            }

            return result;
        }
        #endregion
    }
}

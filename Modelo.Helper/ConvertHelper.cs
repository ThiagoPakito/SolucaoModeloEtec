using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Helper
{
   public class ConvertHelper
    {
        public string ConvertToString(object valor)
        {
            try
            {
                return Convert.ToString(valor);
            }
            catch
            {
                return "";
            }
        }

        public Int16 ConvertToInt16(object valor)
        {
            try
            {
                return Convert.ToInt16(valor);
            }
            catch 
            {
                return 0;
            }
        }

        public Int32 ConvertToInt32(object valor)
        {
            try
            {
                return Convert.ToInt32(valor);
            }
            catch 
            {

                return 0;
            }
        }

        public Int64 ConvertToInt64(object valor)
        {
            try
            {
                return Convert.ToInt64(valor);
            }
            catch
            {

                return 0;
            }
        }

        public decimal ConvertToDecimal(object valor)
        {
            try
            {
                return Convert.ToDecimal(valor);
            }
            catch
            {

                return 0;
            }
        }

        public bool ConvertToBool(object valor)
        {
            try
            {
                return Convert.ToBoolean(valor);
            }
            catch 
            {
                return false;
            }
        }
        
        public DateTime ConvertoToDataTime(object valor)
        {
            try
            {
                return Convert.ToDateTime(valor);
            }
            catch
            {

                return DateTime.MinValue;
            }
        }

        public DateTime? ConvertoToDataTimeNull(object valor)
        {
            try
            {
                return Convert.ToDateTime(valor);
            }
            catch
            {

                return null;
            }
        }
    }
}

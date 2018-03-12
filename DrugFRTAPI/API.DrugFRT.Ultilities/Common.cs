using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using API.DrugFRT.Configuration;
using API.DrugFRT.Model.ResponseModels;

namespace API.DrugFRT.Ultilities
{
    public static class Common
    {
        public static DataTable ToDataTable<T>(this IList<T> data, string columName)
        {

            DataTable table = new DataTable();
            table.Columns.Add(columName, typeof(T));
            if (data != null)
            {
                foreach (T item in data)
                {
                    DataRow row = table.NewRow();
                    row[columName] = item;
                    table.Rows.Add(row);
                }
            }
            return table;
        }

        public static DataTable ToDataTable<T>(this IList<T> data)
        {

            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }

        public static BaseResponseModel GetMessageError(SystemSetting.StatusCode statusCode)
        {
            var reponseBase = new ErrorReponseModel()
            {
                Data = new List<int>() { }
            };
            reponseBase.SetStatusCodeAndMessage(statusCode);
            return reponseBase;
        }

        public static int ToInt(this string str)
        {
            int result = 0;
            if (!string.IsNullOrWhiteSpace(str))
            {
                if (int.TryParse(str, out result))
                    return result;
            }
            return result;
        }

        public static int? ToIntNullable(this string str)
        {
            try
            {
                int output;
                if (int.TryParse(str, out output)) return output;

                return null;
            }
            catch (System.Exception)
            {
                return null;
            }
        }

        public static long ToLong(this string str)
        {
            long result = 0;
            if (!string.IsNullOrWhiteSpace(str))
            {
                if (long.TryParse(str, out result))
                    return result;
            }
            return result;
        }

        public static long? ToLongNullable(this string str)
        {
            try
            {
                long output;
                if (long.TryParse(str, out output)) return output;

                return null;
            }
            catch (System.Exception)
            {
                return null;
            }
        }

        public static readonly string[] DateTimeFormatStringList =
        {
            "dd/MM/yyyy HH:mm:ss",
            "dd/MM/yyyy HH:mm",
            "dd/MM/yyyy",
            "ddd MMM dd yyyy HH:mm:ss 'GMT'K",
            "ddd MMM dd yyyy HH:mm:ss 'GMT'K '(GMT Standard Time)"
        };

        public static DateTime ToDateTime(this string strDate)
        {
            DateTime value = new DateTime();
            foreach (string item in DateTimeFormatStringList)
            {
                if (DateTime.TryParseExact(strDate, item, CultureInfo.InvariantCulture, DateTimeStyles.None, out value))
                {
                    break;
                }
            }
            return value;
        }
    }
}

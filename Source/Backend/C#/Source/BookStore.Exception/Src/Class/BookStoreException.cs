using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using EnumsNET;

namespace BookStore.Exception.Src
{
    public class BookStoreException : ApplicationException
    {
        public StatusCode StatusCode { private set; get; }
        public BookStoreException(StatusCode statusCode, string message, System.Exception exception) : base(message, exception)
        {
            StatusCode = statusCode;
        }
        public BookStoreException(string statusCode, string message, System.Exception e)
           : this(StatusErrorCode(statusCode), message, e)
        {
        }
        private static StatusCode StatusErrorCode(string statusCode)
        {
            return (StatusCode)Enum.Parse(typeof(StatusCode), statusCode);
        }
        public BookStoreException(StatusCode statusCode, System.Exception e)
           : this(statusCode, statusCode.AsString(EnumFormat.Description), e)
        {
        }

        public static void TryThrow(Action action)
        {
            TryThrow(delegate
            {
                action();
                return true;
            });
        }

        public static T TryThrow<T>(Func<T> func)
        {
            try
            {
                return func();
            }
            catch (DbException ex)
            {
                string message = ex.Message;
                Match match = Regex.Match(message, "20000:\\s*(.+)");
                throw new BookStoreException(match.Success ? match.Groups[1].Value : Enum.GetName(typeof(StatusCode), StatusCode.SQDB9999), message, ex);
            }
            catch (WebException e)
            {
                throw new BookStoreException(StatusCode.COMM0201, e);
            }
            catch (System.Exception ex2)
            {
                if (ex2 is BookStoreException)
                {
                    throw;
                }
                throw new BookStoreException(StatusCode.EORR9999, ex2);
            }
        }
    }
}

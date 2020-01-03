using System;
using System.Text;


namespace DesignPatterns.Utils
{
    public class Log
    {
        private StringBuilder buffer = null;


        public Log()
        {
            buffer = new StringBuilder();
        }


        public void AppendLine(int identationLevel, string msg)
        { 
            string   identation      = new String(' ', identationLevel);
            DateTime currentDateTime = DateTime.UtcNow;
            string   ipAddress       = Network.GetIPAddress();
            string result = $"{identation}{currentDateTime} (UTC)\t{ipAddress}\t{msg}";

            buffer.AppendLine(result);
        }

        public void AppendLine(string msg)
        {
            AppendLine(0, msg);
        }


        public void AppendLine()
        {
            buffer.AppendLine(String.Empty);
        }


        public string Flush()
        {
            string result = buffer.ToString();

            buffer.Clear();

            return result;
        }
    }
}

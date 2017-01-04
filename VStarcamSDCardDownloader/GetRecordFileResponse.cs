using System;
using System.Collections.Generic;

namespace VStarcamSDCardDownloader
{
    public class GetRecordFileResponse
    {
        public Record[] Records { get; set; }

        public GetRecordFileResponse(string response)
        {
            Record newRecord = new Record();

            //parse the response into lines
            string[] lines = response.Split(new string[] { "\r\n" }, StringSplitOptions.None);

            //now extract the info from the lines into records
            List<Record> records = new List<Record>();
            foreach (string line in lines)
            {
                if (line.StartsWith("record_name0"))
                {
                    newRecord = new Record();
                    newRecord.Name = this.ExtractName(line);
                }
                else if (line.StartsWith("record_size0"))
                {
                    newRecord.Size = this.ExtractSize(line);
                    records.Add(newRecord);
                }
            }
            this.Records = records.ToArray();
        }

        //eg. record_name0[664]="20161231214522_010.h264";
        protected string ExtractName(string line)
        {
            string name;
            int start = line.IndexOf("]=\"");
            name = line.Substring(start + 3);
            name = name.Substring(0, name.Length - 2);
            return name;
        }

        //eg. record_size0[675]=10638980;        protected long ExtractSize(string line)
        {
            string size;
            int start = line.IndexOf("]=");
            size = line.Substring(start + 2);
            size = size.Substring(0, size.Length - 1);
            return Convert.ToInt64(size);
        }
    }
}

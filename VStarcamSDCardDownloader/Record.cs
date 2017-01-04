namespace VStarcamSDCardDownloader
{
    public class Record
    {
        public string Name { get; set; }

        public long Size { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1}", this.Name, this.Size.ToPrettySize(2));
        }
    }
}
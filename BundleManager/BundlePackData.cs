namespace BundleManager
{
    public class BundlePackData
    {
        public BundlePackData(BinaryReader reader)
        {
            Read(reader);
        }

        public string Name
        {
            get
            {
                return m_name;
            }
        }

        public long OriginSize
        {
            get
            {
                return m_originSize;
            }
        }

        public long Size
        {
            get
            {
                return m_size;
            }
        }

        public List<string> IncludeBundles
        {
            get
            {
                return m_arrayIncludeBundles;
            }
        }

        private void Read(BinaryReader reader)
        {
            m_name = reader.ReadString();
            m_originSize = reader.ReadInt64();
            m_size = reader.ReadInt64();
            int num = reader.ReadInt32();
            for (int i = 0; i < num; i++)
            {
                m_arrayIncludeBundles.Add(reader.ReadString());
            }
        }

        private string m_name = string.Empty;

        private long m_originSize;

        private long m_size;

        private List<string> m_arrayIncludeBundles = new List<string>();
    }
}

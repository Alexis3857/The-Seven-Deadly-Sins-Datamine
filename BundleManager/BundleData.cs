namespace _7dsgcDatamine
{
    public class BundleData
    {
        public BundleData(BinaryReader reader)
        {
            Read(reader);
        }

        public bool Compressed
        {
            get
            {
                return m_compressed;
            }
        }

        public bool Encrypt
        {
            get
            {
                return m_encrypt;
            }
        }

        public bool UseStreamingLoad
        {
            get
            {
                return m_useStreamingLoad;
            }
        }

        public byte Type  // 0 = Scene bundle, 1 = Asset bundle
        {
            get
            {
                return m_type;
            }
        }

        public int Priority
        {
            get
            {
                return m_priority;
            }
        }

        public int Version
        {
            get
            {
                return m_version;
            }
        }

        public uint CRC
        {
            get
            {
                return m_crc;
            }
        }

        public ushort CRC16
        {
            get
            {
                return m_crc16;
            }
        }

        public long Size
        {
            get
            {
                return m_size;
            }
        }

        public string Name
        {
            get
            {
                return m_name;
            }
        }

        public string Variant
        {
            get
            {
                return m_variant;
            }
        }

        public string Checksum
        {
            get
            {
                return m_checksum;
            }
        }

        public List<string> Assets
        {
            get
            {
                return m_arrayAssets;
            }
        }

        public List<string> Dependencies
        {
            get
            {
                return m_arrayDependencies;
            }
        }

        public List<string> AutoDependencies
        {
            get
            {
                return m_arrayAutoDependencies;
            }
        }

        public List<string> NewAssetsList
        {
            get
            {
                return m_newAssetsList;
            }
        }

        private void Read(BinaryReader reader)
        {
            m_compressed = reader.ReadBoolean();
            m_encrypt = reader.ReadBoolean();
            m_useStreamingLoad = reader.ReadBoolean();
            m_type = reader.ReadByte();
            m_crc = reader.ReadUInt32();
            m_crc16 = reader.ReadUInt16();
            m_priority = reader.ReadInt32();
            m_version = reader.ReadInt32();
            m_size = reader.ReadInt64();
            m_name = reader.ReadString();
            m_variant = reader.ReadString();
            m_checksum = reader.ReadString();
            int num = reader.ReadInt32();
            for (int i = 0; i < num; i++)
            {
                m_arrayAssets.Add(reader.ReadString().ToLower());
            }
            num = reader.ReadInt32();
            for (int j = 0; j < num; j++)
            {
                m_arrayDependencies.Add(reader.ReadString());
            }
            num = reader.ReadInt32();
            for (int k = 0; k < num; k++)
            {
                m_arrayAutoDependencies.Add(reader.ReadString());
            }
        }

        private bool m_compressed;

        private bool m_encrypt;

        private bool m_useStreamingLoad;

        private byte m_type;

        private uint m_crc;

        private ushort m_crc16;

        private int m_priority;

        private int m_version;

        private long m_size;

        private string m_name = string.Empty;

        private string m_variant = string.Empty;

        private string m_checksum = string.Empty;

        private List<string> m_arrayAssets = new List<string>();

        private List<string> m_arrayDependencies = new List<string>();

        private List<string> m_arrayAutoDependencies = new List<string>();

        private List<string> m_newAssetsList = new List<string>();
    }
}

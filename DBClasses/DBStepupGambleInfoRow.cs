public class DBStepupGambleInfoRow : ITableRowIndexer
{
    public int GroupId
    {
        get
        {
            return group_id;
        }
    }

    public int GambleLabel
    {
        get
        {
            return gamble_label;
        }
    }

    public List<int> ListArrayStepupSkinId
    {
        get
        {
            return list_array_stepup_skin_id;
        }
    }

    public int StepupBackground
    {
        get
        {
            return stepup_background;
        }
    }

    public string StepupBGName
    {
        get
        {
            return stepup_BG_name;
        }
    }

    public string StepupMBannerName
    {
        get
        {
            return stepup_m_banner_name;
        }
    }

    public int StepupReset
    {
        get
        {
            return stepup_reset;
        }
    }

    public int MileageGroup
    {
        get
        {
            return mileage_group;
        }
    }

    public int MileageReset
    {
        get
        {
            return mileage_reset;
        }
    }

    public string StepupGambleInformationDetail
    {
        get
        {
            return stepup_gamble_information_detail.Localize();
        }
    }

    public byte StepupGambleInformationDetailOnOff
    {
        get
        {
            return stepup_gamble_information_detail_on_off;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        group_id = reader.ReadInt32();
        gamble_label = reader.ReadInt32();
        int num = reader.ReadInt32();
        list_array_stepup_skin_id = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_stepup_skin_id.Add(reader.ReadInt32());
        }
        stepup_background = reader.ReadInt32();
        stepup_BG_name = reader.ReadString();
        stepup_m_banner_name = reader.ReadString();
        stepup_reset = reader.ReadInt32();
        mileage_group = reader.ReadInt32();
        mileage_reset = reader.ReadInt32();
        stepup_gamble_information_detail = reader.ReadInt32();
        stepup_gamble_information_detail_on_off = reader.ReadByte();
        return true;
    }

    public int GetRowIndex()
    {
        return GroupId;
    }

    private int group_id;

    private int gamble_label;

    private List<int> list_array_stepup_skin_id;

    private int stepup_background;

    private string stepup_BG_name;

    private string stepup_m_banner_name;

    private int stepup_reset;

    private int mileage_group;

    private int mileage_reset;

    private int stepup_gamble_information_detail;

    private byte stepup_gamble_information_detail_on_off;
}

public class DBGuildDonationRow : ITableRowIndexer
{
    public int Index
    {
        get
        {
            return index;
        }
    }

    public string Tab
    {
        get
        {
            return tab;
        }
    }

    public List<int> ListArrayItemId
    {
        get
        {
            return list_array_item_id;
        }
    }

    public int DonationOnceCount
    {
        get
        {
            return donation_once_count;
        }
    }

    public int DonationOnceGuildExp
    {
        get
        {
            return donation_once_guild_exp;
        }
    }

    public int DonationOnceGuildGold
    {
        get
        {
            return donation_once_guild_gold;
        }
    }

    public int DonationOnceContribution
    {
        get
        {
            return donation_once_contribution;
        }
    }

    public int DonationOnceGuildSkillPoint
    {
        get
        {
            return donation_once_guild_skill_point;
        }
    }

    public int DonationCountDailyLimit
    {
        get
        {
            return donation_count_daily_limit;
        }
    }

    public int DonationCountResetDia
    {
        get
        {
            return donation_count_reset_dia;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        index = reader.ReadInt32();
        tab = reader.ReadString();
        int num = reader.ReadInt32();
        list_array_item_id = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_item_id.Add(reader.ReadInt32());
        }
        donation_once_count = reader.ReadInt32();
        donation_once_guild_exp = reader.ReadInt32();
        donation_once_guild_gold = reader.ReadInt32();
        donation_once_contribution = reader.ReadInt32();
        donation_once_guild_skill_point = reader.ReadInt32();
        donation_count_daily_limit = reader.ReadInt32();
        donation_count_reset_dia = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Index;
    }

    private int index;

    private string tab;

    private List<int> list_array_item_id;

    private int donation_once_count;

    private int donation_once_guild_exp;

    private int donation_once_guild_gold;

    private int donation_once_contribution;

    private int donation_once_guild_skill_point;

    private int donation_count_daily_limit;

    private int donation_count_reset_dia;
}

public class DBGuildExpBoostRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string GuildExpBoostType
    {
        get
        {
            return guild_exp_boost_type;
        }
    }

    public int GuildBoostStackCount1
    {
        get
        {
            return guild_boost_stack_count_1;
        }
    }

    public int GuildBoostStackCount2
    {
        get
        {
            return guild_boost_stack_count_2;
        }
    }

    public int GuildBoostStackCount3
    {
        get
        {
            return guild_boost_stack_count_3;
        }
    }

    public List<int> ListGuildBoostStackCount
    {
        get
        {
            if (list_guild_boost_stack_count == null)
            {
                list_guild_boost_stack_count = new List<int>
                {
                    GuildBoostStackCount1,
                    GuildBoostStackCount2,
                    GuildBoostStackCount3
                };
            }
            return list_guild_boost_stack_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        guild_exp_boost_type = reader.ReadString();
        guild_boost_stack_count_1 = reader.ReadInt32();
        guild_boost_stack_count_2 = reader.ReadInt32();
        guild_boost_stack_count_3 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string guild_exp_boost_type;

    private int guild_boost_stack_count_1;

    private int guild_boost_stack_count_2;

    private int guild_boost_stack_count_3;

    private List<int> list_guild_boost_stack_count;
}

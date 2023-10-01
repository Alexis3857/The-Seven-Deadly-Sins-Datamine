public class DBMercenaryNpcSettingRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int RegionCheck
    {
        get
        {
            return region_check;
        }
    }

    public int MercenaryNpcSlot1
    {
        get
        {
            return mercenary_npc_slot_1;
        }
    }

    public int MercenaryNpcSlot2
    {
        get
        {
            return mercenary_npc_slot_2;
        }
    }

    public int MercenaryNpcSlot3
    {
        get
        {
            return mercenary_npc_slot_3;
        }
    }

    public int MercenaryNpcSlot4
    {
        get
        {
            return mercenary_npc_slot_4;
        }
    }

    public int MercenaryNpcSlot5
    {
        get
        {
            return mercenary_npc_slot_5;
        }
    }

    public int MercenaryNpcSlot6
    {
        get
        {
            return mercenary_npc_slot_6;
        }
    }

    public int MercenaryNpcSlot7
    {
        get
        {
            return mercenary_npc_slot_7;
        }
    }

    public int MercenaryNpcSlot8
    {
        get
        {
            return mercenary_npc_slot_8;
        }
    }

    public List<int> ListMercenaryNpcSlot
    {
        get
        {
            if (list_mercenary_npc_slot == null)
            {
                list_mercenary_npc_slot = new List<int>
                {
                    MercenaryNpcSlot1,
                    MercenaryNpcSlot2,
                    MercenaryNpcSlot3,
                    MercenaryNpcSlot4,
                    MercenaryNpcSlot5,
                    MercenaryNpcSlot6,
                    MercenaryNpcSlot7,
                    MercenaryNpcSlot8
                };
            }
            return list_mercenary_npc_slot;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        region_check = reader.ReadInt32();
        mercenary_npc_slot_1 = reader.ReadInt32();
        mercenary_npc_slot_2 = reader.ReadInt32();
        mercenary_npc_slot_3 = reader.ReadInt32();
        mercenary_npc_slot_4 = reader.ReadInt32();
        mercenary_npc_slot_5 = reader.ReadInt32();
        mercenary_npc_slot_6 = reader.ReadInt32();
        mercenary_npc_slot_7 = reader.ReadInt32();
        mercenary_npc_slot_8 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int region_check;

    private int mercenary_npc_slot_1;

    private int mercenary_npc_slot_2;

    private int mercenary_npc_slot_3;

    private int mercenary_npc_slot_4;

    private int mercenary_npc_slot_5;

    private int mercenary_npc_slot_6;

    private int mercenary_npc_slot_7;

    private int mercenary_npc_slot_8;

    private List<int> list_mercenary_npc_slot;
}

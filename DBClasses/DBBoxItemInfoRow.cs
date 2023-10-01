public class DBBoxItemInfoRow : ITableRowIndexer
{
    public int ItemId
    {
        get
        {
            return item_id;
        }
    }

    public byte BoxType
    {
        get
        {
            return box_type;
        }
    }

    public string BoxRenderType
    {
        get
        {
            return box_render_type;
        }
    }

    public string BoxRenderOpenAniType
    {
        get
        {
            return box_render_open_ani_type;
        }
    }

    public string BoxRenderFailAniType
    {
        get
        {
            return box_render_fail_ani_type;
        }
    }

    public byte BoxCodeType
    {
        get
        {
            return box_code_type;
        }
    }

    public string BoxCodeAnswer
    {
        get
        {
            return box_code_answer;
        }
    }

    public List<int> ListArrayWeaponSetId
    {
        get
        {
            return list_array_weapon_set_id;
        }
    }

    public List<int> ListArrayWeaponRating
    {
        get
        {
            return list_array_weapon_rating;
        }
    }

    public List<int> ListArrayWeaponPart
    {
        get
        {
            return list_array_weapon_part;
        }
    }

    public byte BoxInventoryPopup
    {
        get
        {
            return box_inventory_popup;
        }
    }

    public int ItemId1
    {
        get
        {
            return item_id_1;
        }
    }

    public int ItemCount1
    {
        get
        {
            return item_count_1;
        }
    }

    public int ItemRate1
    {
        get
        {
            return item_rate_1;
        }
    }

    public int ItemId2
    {
        get
        {
            return item_id_2;
        }
    }

    public int ItemCount2
    {
        get
        {
            return item_count_2;
        }
    }

    public int ItemRate2
    {
        get
        {
            return item_rate_2;
        }
    }

    public int ItemId3
    {
        get
        {
            return item_id_3;
        }
    }

    public int ItemCount3
    {
        get
        {
            return item_count_3;
        }
    }

    public int ItemRate3
    {
        get
        {
            return item_rate_3;
        }
    }

    public int ItemId4
    {
        get
        {
            return item_id_4;
        }
    }

    public int ItemCount4
    {
        get
        {
            return item_count_4;
        }
    }

    public int ItemRate4
    {
        get
        {
            return item_rate_4;
        }
    }

    public int ItemId5
    {
        get
        {
            return item_id_5;
        }
    }

    public int ItemCount5
    {
        get
        {
            return item_count_5;
        }
    }

    public int ItemRate5
    {
        get
        {
            return item_rate_5;
        }
    }

    public int ItemId6
    {
        get
        {
            return item_id_6;
        }
    }

    public int ItemCount6
    {
        get
        {
            return item_count_6;
        }
    }

    public int ItemRate6
    {
        get
        {
            return item_rate_6;
        }
    }

    public int ItemId7
    {
        get
        {
            return item_id_7;
        }
    }

    public int ItemCount7
    {
        get
        {
            return item_count_7;
        }
    }

    public int ItemRate7
    {
        get
        {
            return item_rate_7;
        }
    }

    public int ItemId8
    {
        get
        {
            return item_id_8;
        }
    }

    public int ItemCount8
    {
        get
        {
            return item_count_8;
        }
    }

    public int ItemRate8
    {
        get
        {
            return item_rate_8;
        }
    }

    public int ItemId9
    {
        get
        {
            return item_id_9;
        }
    }

    public int ItemCount9
    {
        get
        {
            return item_count_9;
        }
    }

    public int ItemRate9
    {
        get
        {
            return item_rate_9;
        }
    }

    public int ItemId10
    {
        get
        {
            return item_id_10;
        }
    }

    public int ItemCount10
    {
        get
        {
            return item_count_10;
        }
    }

    public int ItemRate10
    {
        get
        {
            return item_rate_10;
        }
    }

    public int ItemId11
    {
        get
        {
            return item_id_11;
        }
    }

    public int ItemCount11
    {
        get
        {
            return item_count_11;
        }
    }

    public int ItemRate11
    {
        get
        {
            return item_rate_11;
        }
    }

    public int ItemId12
    {
        get
        {
            return item_id_12;
        }
    }

    public int ItemCount12
    {
        get
        {
            return item_count_12;
        }
    }

    public int ItemRate12
    {
        get
        {
            return item_rate_12;
        }
    }

    public int ItemId13
    {
        get
        {
            return item_id_13;
        }
    }

    public int ItemCount13
    {
        get
        {
            return item_count_13;
        }
    }

    public int ItemRate13
    {
        get
        {
            return item_rate_13;
        }
    }

    public List<int> ListItemId
    {
        get
        {
            if (list_item_id == null)
            {
                list_item_id = new List<int>
                {
                    ItemId1,
                    ItemId2,
                    ItemId3,
                    ItemId4,
                    ItemId5,
                    ItemId6,
                    ItemId7,
                    ItemId8,
                    ItemId9,
                    ItemId10,
                    ItemId11,
                    ItemId12,
                    ItemId13
                };
            }
            return list_item_id;
        }
    }

    public List<int> ListItemCount
    {
        get
        {
            if (list_item_count == null)
            {
                list_item_count = new List<int>
                {
                    ItemCount1,
                    ItemCount2,
                    ItemCount3,
                    ItemCount4,
                    ItemCount5,
                    ItemCount6,
                    ItemCount7,
                    ItemCount8,
                    ItemCount9,
                    ItemCount10,
                    ItemCount11,
                    ItemCount12,
                    ItemCount13
                };
            }
            return list_item_count;
        }
    }

    public List<int> ListItemRate
    {
        get
        {
            if (list_item_rate == null)
            {
                list_item_rate = new List<int>
                {
                    ItemRate1,
                    ItemRate2,
                    ItemRate3,
                    ItemRate4,
                    ItemRate5,
                    ItemRate6,
                    ItemRate7,
                    ItemRate8,
                    ItemRate9,
                    ItemRate10,
                    ItemRate11,
                    ItemRate12,
                    ItemRate13
                };
            }
            return list_item_rate;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        item_id = reader.ReadInt32();
        box_type = reader.ReadByte();
        box_render_type = reader.ReadString();
        box_render_open_ani_type = reader.ReadString();
        box_render_fail_ani_type = reader.ReadString();
        box_code_type = reader.ReadByte();
        box_code_answer = reader.ReadString();
        int num = reader.ReadInt32();
        list_array_weapon_set_id = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_weapon_set_id.Add(reader.ReadInt32());
        }
        int num2 = reader.ReadInt32();
        list_array_weapon_rating = new List<int>();
        for (int j = 0; j < num2; j++)
        {
            list_array_weapon_rating.Add(reader.ReadInt32());
        }
        int num3 = reader.ReadInt32();
        list_array_weapon_part = new List<int>();
        for (int k = 0; k < num3; k++)
        {
            list_array_weapon_part.Add(reader.ReadInt32());
        }
        box_inventory_popup = reader.ReadByte();
        item_id_1 = reader.ReadInt32();
        item_count_1 = reader.ReadInt32();
        item_rate_1 = reader.ReadInt32();
        item_id_2 = reader.ReadInt32();
        item_count_2 = reader.ReadInt32();
        item_rate_2 = reader.ReadInt32();
        item_id_3 = reader.ReadInt32();
        item_count_3 = reader.ReadInt32();
        item_rate_3 = reader.ReadInt32();
        item_id_4 = reader.ReadInt32();
        item_count_4 = reader.ReadInt32();
        item_rate_4 = reader.ReadInt32();
        item_id_5 = reader.ReadInt32();
        item_count_5 = reader.ReadInt32();
        item_rate_5 = reader.ReadInt32();
        item_id_6 = reader.ReadInt32();
        item_count_6 = reader.ReadInt32();
        item_rate_6 = reader.ReadInt32();
        item_id_7 = reader.ReadInt32();
        item_count_7 = reader.ReadInt32();
        item_rate_7 = reader.ReadInt32();
        item_id_8 = reader.ReadInt32();
        item_count_8 = reader.ReadInt32();
        item_rate_8 = reader.ReadInt32();
        item_id_9 = reader.ReadInt32();
        item_count_9 = reader.ReadInt32();
        item_rate_9 = reader.ReadInt32();
        item_id_10 = reader.ReadInt32();
        item_count_10 = reader.ReadInt32();
        item_rate_10 = reader.ReadInt32();
        item_id_11 = reader.ReadInt32();
        item_count_11 = reader.ReadInt32();
        item_rate_11 = reader.ReadInt32();
        item_id_12 = reader.ReadInt32();
        item_count_12 = reader.ReadInt32();
        item_rate_12 = reader.ReadInt32();
        item_id_13 = reader.ReadInt32();
        item_count_13 = reader.ReadInt32();
        item_rate_13 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return ItemId;
    }

    private int item_id;

    private byte box_type;

    private string box_render_type;

    private string box_render_open_ani_type;

    private string box_render_fail_ani_type;

    private byte box_code_type;

    private string box_code_answer;

    private List<int> list_array_weapon_set_id;

    private List<int> list_array_weapon_rating;

    private List<int> list_array_weapon_part;

    private byte box_inventory_popup;

    private int item_id_1;

    private int item_count_1;

    private int item_rate_1;

    private int item_id_2;

    private int item_count_2;

    private int item_rate_2;

    private int item_id_3;

    private int item_count_3;

    private int item_rate_3;

    private int item_id_4;

    private int item_count_4;

    private int item_rate_4;

    private int item_id_5;

    private int item_count_5;

    private int item_rate_5;

    private int item_id_6;

    private int item_count_6;

    private int item_rate_6;

    private int item_id_7;

    private int item_count_7;

    private int item_rate_7;

    private int item_id_8;

    private int item_count_8;

    private int item_rate_8;

    private int item_id_9;

    private int item_count_9;

    private int item_rate_9;

    private int item_id_10;

    private int item_count_10;

    private int item_rate_10;

    private int item_id_11;

    private int item_count_11;

    private int item_rate_11;

    private int item_id_12;

    private int item_count_12;

    private int item_rate_12;

    private int item_id_13;

    private int item_count_13;

    private int item_rate_13;

    private List<int> list_item_id;

    private List<int> list_item_count;

    private List<int> list_item_rate;
}

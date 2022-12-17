public class DBArtifactCardUnionRow
{
    public int UnionId
    {
        get
        {
            return union_id;
        }
    }

    public int CollectibleUnionId
    {
        get
        {
            return collectible_union_id;
        }
    }

    public int ArtifactCategoryId
    {
        get
        {
            return artifact_category_id;
        }
    }

    public int UnionCard1
    {
        get
        {
            return union_card_1;
        }
    }

    public int UnionCard2
    {
        get
        {
            return union_card_2;
        }
    }

    public int UnionCard3
    {
        get
        {
            return union_card_3;
        }
    }

    public int UnionCard4
    {
        get
        {
            return union_card_4;
        }
    }

    public int UnionCard5
    {
        get
        {
            return union_card_5;
        }
    }

    public string UnionName
    {
        get
        {
            return union_name.Localize();
        }
    }

    public int UnionPassive1
    {
        get
        {
            return union_passive_1;
        }
    }

    public int UnionPassive2
    {
        get
        {
            return union_passive_2;
        }
    }

    public int UnionPassive3
    {
        get
        {
            return union_passive_3;
        }
    }

    public int UnionPassive4
    {
        get
        {
            return union_passive_4;
        }
    }

    public int UnionPassive5
    {
        get
        {
            return union_passive_5;
        }
    }

    public int ReinforceMaxLevel
    {
        get
        {
            return reinforce_max_level;
        }
    }

    public byte ReinforceClass
    {
        get
        {
            return reinforce_class;
        }
    }

    public List<int> ListUnionCard
    {
        get
        {
            if (list_union_card == null)
            {
                list_union_card = new List<int>
                {
                    UnionCard1,
                    UnionCard2,
                    UnionCard3,
                    UnionCard4,
                    UnionCard5
                };
            }
            return list_union_card;
        }
    }

    public List<int> ListUnionPassive
    {
        get
        {
            if (list_union_passive == null)
            {
                list_union_passive = new List<int>
                {
                    UnionPassive1,
                    UnionPassive2,
                    UnionPassive3,
                    UnionPassive4,
                    UnionPassive5
                };
            }
            return list_union_passive;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        union_id = reader.ReadInt32();
        collectible_union_id = reader.ReadInt32();
        artifact_category_id = reader.ReadInt32();
        union_card_1 = reader.ReadInt32();
        union_card_2 = reader.ReadInt32();
        union_card_3 = reader.ReadInt32();
        union_card_4 = reader.ReadInt32();
        union_card_5 = reader.ReadInt32();
        union_name = reader.ReadInt32();
        union_passive_1 = reader.ReadInt32();
        union_passive_2 = reader.ReadInt32();
        union_passive_3 = reader.ReadInt32();
        union_passive_4 = reader.ReadInt32();
        union_passive_5 = reader.ReadInt32();
        reinforce_max_level = reader.ReadInt32();
        reinforce_class = reader.ReadByte();
        return true;
    }

    private int union_id;

    private int collectible_union_id;

    private int artifact_category_id;

    private int union_card_1;

    private int union_card_2;

    private int union_card_3;

    private int union_card_4;

    private int union_card_5;

    private int union_name;

    private int union_passive_1;

    private int union_passive_2;

    private int union_passive_3;

    private int union_passive_4;

    private int union_passive_5;

    private int reinforce_max_level;

    private byte reinforce_class;

    private List<int> list_union_card;

    private List<int> list_union_passive;
}

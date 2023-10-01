public class DBExpRow : DataTableCryptographer, ITableRowIndexer
{
    protected override uint XOROperand
    {
        get
        {
            return 564U;
        }
    }

    public int Level
    {
        get
        {
            return base.DecryptInt32(level);
        }
    }

    public int UserExp
    {
        get
        {
            return base.DecryptInt32(user_exp);
        }
    }

    public int GuildExp
    {
        get
        {
            return base.DecryptInt32(guild_exp);
        }
    }

    public int MaxStamina
    {
        get
        {
            return base.DecryptInt32(max_stamina);
        }
    }

    public int MaxFriend
    {
        get
        {
            return base.DecryptInt32(max_friend);
        }
    }

    public string OpenContent
    {
        get
        {
            return open_content;
        }
    }

    public int HeroExp
    {
        get
        {
            return base.DecryptInt32(hero_exp);
        }
    }

    public int RankExp1
    {
        get
        {
            return base.DecryptInt32(rank_exp_1);
        }
    }

    public int RankExp2
    {
        get
        {
            return base.DecryptInt32(rank_exp_2);
        }
    }

    public int RankExp3
    {
        get
        {
            return base.DecryptInt32(rank_exp_3);
        }
    }

    public int RankExp4
    {
        get
        {
            return base.DecryptInt32(rank_exp_4);
        }
    }

    public int GuestHeroRatingExp1
    {
        get
        {
            return base.DecryptInt32(guest_hero_rating_exp_1);
        }
    }

    public int GuestHeroRatingExp2
    {
        get
        {
            return base.DecryptInt32(guest_hero_rating_exp_2);
        }
    }

    public int GuestHeroRatingExp3
    {
        get
        {
            return base.DecryptInt32(guest_hero_rating_exp_3);
        }
    }

    public int GuestHeroRatingExp4
    {
        get
        {
            return base.DecryptInt32(guest_hero_rating_exp_4);
        }
    }

    public int RecipeExp
    {
        get
        {
            return base.DecryptInt32(recipe_exp);
        }
    }

    public int UnionClass1
    {
        get
        {
            return base.DecryptInt32(union_class_1);
        }
    }

    public int UnionClass2
    {
        get
        {
            return base.DecryptInt32(union_class_2);
        }
    }

    public int UnionClass3
    {
        get
        {
            return base.DecryptInt32(union_class_3);
        }
    }

    public int UnionClass4
    {
        get
        {
            return base.DecryptInt32(union_class_4);
        }
    }

    public int UnionClass5
    {
        get
        {
            return base.DecryptInt32(union_class_5);
        }
    }

    public int UnionClass6
    {
        get
        {
            return base.DecryptInt32(union_class_6);
        }
    }

    public List<int> ListRankExp
    {
        get
        {
            if (list_rank_exp == null)
            {
                list_rank_exp = new List<int>
                {
                    RankExp1,
                    RankExp2,
                    RankExp3,
                    RankExp4
                };
            }
            return list_rank_exp;
        }
    }

    public List<int> ListGuestHeroRatingExp
    {
        get
        {
            if (list_guest_hero_rating_exp == null)
            {
                list_guest_hero_rating_exp = new List<int>
                {
                    GuestHeroRatingExp1,
                    GuestHeroRatingExp2,
                    GuestHeroRatingExp3,
                    GuestHeroRatingExp4
                };
            }
            return list_guest_hero_rating_exp;
        }
    }

    public List<int> ListUnionClass
    {
        get
        {
            if (list_union_class == null)
            {
                list_union_class = new List<int>
                {
                    UnionClass1,
                    UnionClass2,
                    UnionClass3,
                    UnionClass4,
                    UnionClass5,
                    UnionClass6
                };
            }
            return list_union_class;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        level = reader.ReadBytes(4);
        user_exp = reader.ReadBytes(4);
        guild_exp = reader.ReadBytes(4);
        max_stamina = reader.ReadBytes(4);
        max_friend = reader.ReadBytes(4);
        open_content = reader.ReadString();
        hero_exp = reader.ReadBytes(4);
        rank_exp_1 = reader.ReadBytes(4);
        rank_exp_2 = reader.ReadBytes(4);
        rank_exp_3 = reader.ReadBytes(4);
        rank_exp_4 = reader.ReadBytes(4);
        guest_hero_rating_exp_1 = reader.ReadBytes(4);
        guest_hero_rating_exp_2 = reader.ReadBytes(4);
        guest_hero_rating_exp_3 = reader.ReadBytes(4);
        guest_hero_rating_exp_4 = reader.ReadBytes(4);
        recipe_exp = reader.ReadBytes(4);
        union_class_1 = reader.ReadBytes(4);
        union_class_2 = reader.ReadBytes(4);
        union_class_3 = reader.ReadBytes(4);
        union_class_4 = reader.ReadBytes(4);
        union_class_5 = reader.ReadBytes(4);
        union_class_6 = reader.ReadBytes(4);
        return true;
    }

    public int GetRowIndex()
    {
        return Level;
    }

    private byte[] level;

    private byte[] user_exp;

    private byte[] guild_exp;

    private byte[] max_stamina;

    private byte[] max_friend;

    private string open_content;

    private byte[] hero_exp;

    private byte[] rank_exp_1;

    private byte[] rank_exp_2;

    private byte[] rank_exp_3;

    private byte[] rank_exp_4;

    private byte[] guest_hero_rating_exp_1;

    private byte[] guest_hero_rating_exp_2;

    private byte[] guest_hero_rating_exp_3;

    private byte[] guest_hero_rating_exp_4;

    private byte[] recipe_exp;

    private byte[] union_class_1;

    private byte[] union_class_2;

    private byte[] union_class_3;

    private byte[] union_class_4;

    private byte[] union_class_5;

    private byte[] union_class_6;

    private List<int> list_rank_exp;

    private List<int> list_guest_hero_rating_exp;

    private List<int> list_union_class;
}

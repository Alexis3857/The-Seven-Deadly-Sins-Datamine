public class DBHeroGroupNameRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string CategoryName
    {
        get
        {
            return category_name.Localize();
        }
    }

    public string WeaponCarveHeroPortraitFolder
    {
        get
        {
            return weapon_carve_hero_portrait_folder;
        }
    }

    public string WeaponCarveHeroPortrait
    {
        get
        {
            return weapon_carve_hero_portrait;
        }
    }

    public string WeaponCarveHeroIconFolder
    {
        get
        {
            return weapon_carve_hero_icon_folder;
        }
    }

    public string WeaponCarveHeroIcon
    {
        get
        {
            return weapon_carve_hero_icon;
        }
    }

    public int WeaponCarveHeroOpen
    {
        get
        {
            return weapon_carve_hero_open;
        }
    }

    public List<int> ListArrayFellowshipFoodItem
    {
        get
        {
            return list_array_fellowship_food_item;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        category_name = reader.ReadInt32();
        weapon_carve_hero_portrait_folder = reader.ReadString();
        weapon_carve_hero_portrait = reader.ReadString();
        weapon_carve_hero_icon_folder = reader.ReadString();
        weapon_carve_hero_icon = reader.ReadString();
        weapon_carve_hero_open = reader.ReadInt32();
        int num = reader.ReadInt32();
        list_array_fellowship_food_item = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_fellowship_food_item.Add(reader.ReadInt32());
        }
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int category_name;

    private string weapon_carve_hero_portrait_folder;

    private string weapon_carve_hero_portrait;

    private string weapon_carve_hero_icon_folder;

    private string weapon_carve_hero_icon;

    private int weapon_carve_hero_open;

    private List<int> list_array_fellowship_food_item;
}

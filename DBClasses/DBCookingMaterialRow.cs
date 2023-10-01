public class DBCookingMaterialRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string Category
    {
        get
        {
            return category;
        }
    }

    public string CategoryString
    {
        get
        {
            return category_string.Localize();
        }
    }

    public int SubCategory
    {
        get
        {
            return sub_category;
        }
    }

    public int SubCategoryType
    {
        get
        {
            return sub_category_type;
        }
    }

    public int Type
    {
        get
        {
            return type;
        }
    }

    public int QuestType
    {
        get
        {
            return quest_type;
        }
    }

    public List<int> ListArrayQuestIndex
    {
        get
        {
            return list_array_quest_index;
        }
    }

    public int MaterialId
    {
        get
        {
            return material_id;
        }
    }

    public string RendererIcon
    {
        get
        {
            return renderer_icon;
        }
    }

    public int ObjectType
    {
        get
        {
            return object_type;
        }
    }

    public int RecipeLink
    {
        get
        {
            return recipe_link;
        }
    }

    public int RecipeExp
    {
        get
        {
            return recipe_exp;
        }
    }

    public int EventSubIndex
    {
        get
        {
            return event_sub_index;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        category = reader.ReadString();
        category_string = reader.ReadInt32();
        sub_category = reader.ReadInt32();
        sub_category_type = reader.ReadInt32();
        type = reader.ReadInt32();
        quest_type = reader.ReadInt32();
        int num = reader.ReadInt32();
        list_array_quest_index = new List<int>();
        for (int i = 0; i < num; i++)
        {
            list_array_quest_index.Add(reader.ReadInt32());
        }
        material_id = reader.ReadInt32();
        renderer_icon = reader.ReadString();
        object_type = reader.ReadInt32();
        recipe_link = reader.ReadInt32();
        recipe_exp = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string category;

    private int category_string;

    private int sub_category;

    private int sub_category_type;

    private int type;

    private int quest_type;

    private List<int> list_array_quest_index;

    private int material_id;

    private string renderer_icon;

    private int object_type;

    private int recipe_link;

    private int recipe_exp;

    private int event_sub_index;
}

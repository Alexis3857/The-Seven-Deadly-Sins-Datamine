public class DBFoodHeroEatCategoryInfoRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string FoodBuffType
    {
        get
        {
            return food_buff_type.Localize();
        }
    }

    public int FoodBuffTypePriority
    {
        get
        {
            return food_buff_type_priority;
        }
    }

    public int Food1
    {
        get
        {
            return food_1;
        }
    }

    public int Food2
    {
        get
        {
            return food_2;
        }
    }

    public int Food3
    {
        get
        {
            return food_3;
        }
    }

    public List<int> ListFood
    {
        get
        {
            if (list_food == null)
            {
                list_food = new List<int>
                {
                    Food1,
                    Food2,
                    Food3
                };
            }
            return list_food;
        }
    }


    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        food_buff_type = reader.ReadInt32();
        food_buff_type_priority = reader.ReadInt32();
        food_1 = reader.ReadInt32();
        food_2 = reader.ReadInt32();
        food_3 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int food_buff_type;

    private int food_buff_type_priority;

    private int food_1;

    private int food_2;

    private int food_3;

    private List<int> list_food;
}

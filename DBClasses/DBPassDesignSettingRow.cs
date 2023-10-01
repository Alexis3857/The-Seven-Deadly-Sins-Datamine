public class DBPassDesignSettingRow : ITableRowIndexer
{
    public int SettingId
    {
        get
        {
            return setting_id;
        }
    }

    public string BgDesign
    {
        get
        {
            return bg_design;
        }
    }

    public string ShopBtnDesign
    {
        get
        {
            return shop_btn_design;
        }
    }

    public string FoodDesign
    {
        get
        {
            return food_design;
        }
    }

    public string FoodEmptyDesign
    {
        get
        {
            return food_empty_design;
        }
    }

    public string FoodSpecialDesign
    {
        get
        {
            return food_special_design;
        }
    }

    public string FoodSpecialEmptyDesign
    {
        get
        {
            return food_special_empty_design;
        }
    }

    public string GroundDesign
    {
        get
        {
            return ground_design;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        setting_id = reader.ReadInt32();
        bg_design = reader.ReadString();
        shop_btn_design = reader.ReadString();
        food_design = reader.ReadString();
        food_empty_design = reader.ReadString();
        food_special_design = reader.ReadString();
        food_special_empty_design = reader.ReadString();
        ground_design = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return SettingId;
    }

    private int setting_id;

    private string bg_design;

    private string shop_btn_design;

    private string food_design;

    private string food_empty_design;

    private string food_special_design;

    private string food_special_empty_design;

    private string ground_design;
}

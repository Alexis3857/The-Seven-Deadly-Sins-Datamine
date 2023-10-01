public class DBStoryreviewAreaRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int TargetType
    {
        get
        {
            return target_type;
        }
    }

    public int TargetRegion
    {
        get
        {
            return target_region;
        }
    }

    public int TargetRegionEp
    {
        get
        {
            return target_region_ep;
        }
    }

    public int TargetAreaId
    {
        get
        {
            return target_area_id;
        }
    }

    public string TargetAreaIcon
    {
        get
        {
            return target_area_icon;
        }
    }

    public string TargetAreaName
    {
        get
        {
            return target_area_name.Localize();
        }
    }

    public string TargetRegionEpName
    {
        get
        {
            return target_region_ep_name.Localize();
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        target_type = reader.ReadInt32();
        target_region = reader.ReadInt32();
        target_region_ep = reader.ReadInt32();
        target_area_id = reader.ReadInt32();
        target_area_icon = reader.ReadString();
        target_area_name = reader.ReadInt32();
        target_region_ep_name = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int target_type;

    private int target_region;

    private int target_region_ep;

    private int target_area_id;

    private string target_area_icon;

    private int target_area_name;

    private int target_region_ep_name;
}

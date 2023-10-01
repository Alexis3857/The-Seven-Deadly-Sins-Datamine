public class DBEventMonthlyStoryRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string BannerImage
    {
        get
        {
            return banner_image;
        }
    }

    public string BannerTitleText
    {
        get
        {
            return banner_title_text.Localize();
        }
    }

    public string BannerTitleTextColor
    {
        get
        {
            return banner_title_text_color;
        }
    }

    public string BannerStoryText
    {
        get
        {
            return banner_story_text.Localize();
        }
    }

    public string BannerStoryColor
    {
        get
        {
            return banner_story_color;
        }
    }

    public string BannerDimmedColor
    {
        get
        {
            return banner_dimmed_color;
        }
    }

    public int StageSet
    {
        get
        {
            return stage_set;
        }
    }

    public int StageId1
    {
        get
        {
            return stage_id_1;
        }
    }

    public int StageId2
    {
        get
        {
            return stage_id_2;
        }
    }

    public int StageId3
    {
        get
        {
            return stage_id_3;
        }
    }

    public int StageId4
    {
        get
        {
            return stage_id_4;
        }
    }

    public int StageId5
    {
        get
        {
            return stage_id_5;
        }
    }

    public List<int> ListStageId
    {
        get
        {
            if (list_stage_id == null)
            {
                list_stage_id = new List<int>
                {
                    StageId1,
                    StageId2,
                    StageId3,
                    StageId4,
                    StageId5
                };
            }
            return list_stage_id;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        banner_image = reader.ReadString();
        banner_title_text = reader.ReadInt32();
        banner_title_text_color = reader.ReadString();
        banner_story_text = reader.ReadInt32();
        banner_story_color = reader.ReadString();
        banner_dimmed_color = reader.ReadString();
        stage_set = reader.ReadInt32();
        stage_id_1 = reader.ReadInt32();
        stage_id_2 = reader.ReadInt32();
        stage_id_3 = reader.ReadInt32();
        stage_id_4 = reader.ReadInt32();
        stage_id_5 = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string banner_image;

    private int banner_title_text;

    private string banner_title_text_color;

    private int banner_story_text;

    private string banner_story_color;

    private string banner_dimmed_color;

    private int stage_set;

    private int stage_id_1;

    private int stage_id_2;

    private int stage_id_3;

    private int stage_id_4;

    private int stage_id_5;

    private List<int> list_stage_id;
}

public class DBEventConquestTileRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int EventSubIndex
    {
        get
        {
            return event_sub_index;
        }
    }

    public int TilePositionIndex
    {
        get
        {
            return tile_position_index;
        }
    }

    public string TileSurfaceResource
    {
        get
        {
            return tile_surface_resource;
        }
    }

    public string TileCutSurfaceSubResource1
    {
        get
        {
            return tile_cut_surface_sub_resource_1;

        }
    }

    public string TileCutSurfaceSubResource2
    {
        get
        {
            return tile_cut_surface_sub_resource_2;

        }
    }

    public string TileCutSurfaceSubResource3
    {
        get
        {
            return tile_cut_surface_sub_resource_3;

        }
    }

    public string TileCutSurfaceSubResource4
    {
        get
        {
            return tile_cut_surface_sub_resource_4;

        }
    }

    public string TileCutSurfaceSubResource5
    {
        get
        {
            return tile_cut_surface_sub_resource_5;

        }
    }

    public string TileCutSurfaceSubResource6
    {
        get
        {
            return tile_cut_surface_sub_resource_6;

        }
    }

    public string TileCutSurfaceSubResource7
    {
        get
        {
            return tile_cut_surface_sub_resource_7;

        }
    }

    public string TileCutSurfaceSubResource8
    {
        get
        {
            return tile_cut_surface_sub_resource_8;

        }
    }

    public string TileCutSurfaceSubResource9
    {
        get
        {
            return tile_cut_surface_sub_resource_9;

        }
    }

    public string TileCutSurfaceSubResource10
    {
        get
        {
            return tile_cut_surface_sub_resource_10;

        }
    }

    public string TileCutSurfaceSubResource11
    {
        get
        {
            return tile_cut_surface_sub_resource_11;

        }
    }

    public string TileCutSurfaceSubResource12
    {
        get
        {
            return tile_cut_surface_sub_resource_12;

        }
    }

    public string TileCutSurfaceSubResource13
    {
        get
        {
            return tile_cut_surface_sub_resource_13;

        }
    }

    public string TileCutSurfaceSubResource14
    {
        get
        {
            return tile_cut_surface_sub_resource_14;

        }
    }

    public string TileCutSurfaceSubResource15
    {
        get
        {
            return tile_cut_surface_sub_resource_15;

        }
    }

    public string TileCutSurfaceSubResource16
    {
        get
        {
            return tile_cut_surface_sub_resource_16;

        }
    }

    public string TileCutSurfaceSubResource17
    {
        get
        {
            return tile_cut_surface_sub_resource_17;

        }
    }

    public string TileCutSurfaceSubResource18
    {
        get
        {
            return tile_cut_surface_sub_resource_18;

        }
    }

    public List<string> ListTileCutSurfaceSubResource
    {
        get
        {
            if (list_tile_cut_surface_sub_resource == null)
            {
                list_tile_cut_surface_sub_resource = new List<string>
                {
                    TileCutSurfaceSubResource1,
                    TileCutSurfaceSubResource2,
                    TileCutSurfaceSubResource3,
                    TileCutSurfaceSubResource4,
                    TileCutSurfaceSubResource5,
                    TileCutSurfaceSubResource6,
                    TileCutSurfaceSubResource7,
                    TileCutSurfaceSubResource8,
                    TileCutSurfaceSubResource9,
                    TileCutSurfaceSubResource10,
                    TileCutSurfaceSubResource11,
                    TileCutSurfaceSubResource12,
                    TileCutSurfaceSubResource13,
                    TileCutSurfaceSubResource14,
                    TileCutSurfaceSubResource15,
                    TileCutSurfaceSubResource16,
                    TileCutSurfaceSubResource17,
                    TileCutSurfaceSubResource18
                };
            }
            return list_tile_cut_surface_sub_resource;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        tile_position_index = reader.ReadInt32();
        tile_surface_resource = reader.ReadString();
        tile_cut_surface_sub_resource_1 = reader.ReadString();
        tile_cut_surface_sub_resource_2 = reader.ReadString();
        tile_cut_surface_sub_resource_3 = reader.ReadString();
        tile_cut_surface_sub_resource_4 = reader.ReadString();
        tile_cut_surface_sub_resource_5 = reader.ReadString();
        tile_cut_surface_sub_resource_6 = reader.ReadString();
        tile_cut_surface_sub_resource_7 = reader.ReadString();
        tile_cut_surface_sub_resource_8 = reader.ReadString();
        tile_cut_surface_sub_resource_9 = reader.ReadString();
        tile_cut_surface_sub_resource_10 = reader.ReadString();
        tile_cut_surface_sub_resource_11 = reader.ReadString();
        tile_cut_surface_sub_resource_12 = reader.ReadString();
        tile_cut_surface_sub_resource_13 = reader.ReadString();
        tile_cut_surface_sub_resource_14 = reader.ReadString();
        tile_cut_surface_sub_resource_15 = reader.ReadString();
        tile_cut_surface_sub_resource_16 = reader.ReadString();
        tile_cut_surface_sub_resource_17 = reader.ReadString();
        tile_cut_surface_sub_resource_18 = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return id;
    }

    private int id;

    private int event_sub_index;

    private int tile_position_index;

    private string tile_surface_resource;

    private string tile_cut_surface_sub_resource_1;

    private string tile_cut_surface_sub_resource_2;

    private string tile_cut_surface_sub_resource_3;

    private string tile_cut_surface_sub_resource_4;

    private string tile_cut_surface_sub_resource_5;

    private string tile_cut_surface_sub_resource_6;

    private string tile_cut_surface_sub_resource_7;

    private string tile_cut_surface_sub_resource_8;

    private string tile_cut_surface_sub_resource_9;

    private string tile_cut_surface_sub_resource_10;

    private string tile_cut_surface_sub_resource_11;

    private string tile_cut_surface_sub_resource_12;

    private string tile_cut_surface_sub_resource_13;

    private string tile_cut_surface_sub_resource_14;

    private string tile_cut_surface_sub_resource_15;

    private string tile_cut_surface_sub_resource_16;

    private string tile_cut_surface_sub_resource_17;

    private string tile_cut_surface_sub_resource_18;

    private List<string> list_tile_cut_surface_sub_resource;
}

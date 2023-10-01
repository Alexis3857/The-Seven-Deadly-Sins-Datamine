public class DBSkillCardBulletRow : DataTableCryptographer, ITableRowIndexer
{
    protected override uint XOROperand
    {
        get
        {
            return 726U;
        }
    }

    public int Id
    {
        get
        {
            return base.DecryptInt32(id);
        }
    }

    public float BulletSpeed
    {
        get
        {
            return base.DecryptFloat(bullet_speed);
        }
    }

    public string BulletTargetSocket
    {
        get
        {
            return bullet_target_socket;
        }
    }

    public int FireSfxId
    {
        get
        {
            return base.DecryptInt32(fire_sfx_id);
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadBytes(4);
        bullet_speed = reader.ReadBytes(4);
        bullet_target_socket = reader.ReadString();
        fire_sfx_id = reader.ReadBytes(4);
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private byte[] id;

    private byte[] bullet_speed;

    private string bullet_target_socket;

    private byte[] fire_sfx_id;
}

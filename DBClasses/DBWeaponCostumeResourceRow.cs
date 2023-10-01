public class DBWeaponCostumeResourceRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public string CharacterBase
    {
        get
        {
            return character_base;
        }
    }

    public string ResourceWeapon
    {
        get
        {
            return resource_weapon;
        }
    }

    public int WeaponModelType
    {
        get
        {
            return weapon_model_type;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        character_base = reader.ReadString();
        resource_weapon = reader.ReadString();
        weapon_model_type = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string character_base;

    private string resource_weapon;

    private int weapon_model_type;
}

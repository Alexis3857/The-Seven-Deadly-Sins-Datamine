public class DBDemonlordRuleRow : ITableRowIndexer
{
    public int Id => id;

    public int RuleStageId => rule_stage_id;

    public int RulePhase => rule_phase;

    public string RuleType => rule_type;

    public List<int> ListArrayRuleValueFirst => list_array_rule_value_first;

    public List<int> ListArrayRuleValueSecond => list_array_rule_value_second;

    public List<int> ListArrayRuleValueThird => list_array_rule_value_third;

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        rule_stage_id = reader.ReadInt32();
        rule_phase = reader.ReadInt32();
        rule_type = reader.ReadString();
        list_array_rule_value_first = new List<int>();
        int count = reader.ReadInt32();
        for (int i = 0; i < count; i++)
        {
            list_array_rule_value_first.Add(reader.ReadInt32());
        }
        list_array_rule_value_second = new List<int>();
        count = reader.ReadInt32();
        for (int i = 0; i < count; i++)
        {
            list_array_rule_value_second.Add(reader.ReadInt32());
        }
        list_array_rule_value_third = new List<int>();
        count = reader.ReadInt32();
        for (int i = 0; i < count; i++)
        {
            list_array_rule_value_third.Add(reader.ReadInt32());
        }
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int rule_stage_id;

    private int rule_phase;

    private string rule_type;

    private List<int> list_array_rule_value_first;

    private List<int> list_array_rule_value_second;

    private List<int> list_array_rule_value_third;
}
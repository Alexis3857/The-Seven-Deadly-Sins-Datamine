public class DBStepupSetRow : ITableRowIndexer
{
    public int Id
    {
        get
        {
            return id;
        }
    }

    public int GroupId
    {
        get
        {
            return group_id;
        }
    }

    public int Step
    {
        get
        {
            return step;
        }
    }

    public int StepGambleGroup
    {
        get
        {
            return step_gamble_group;
        }
    }

    public int StepLimitCount
    {
        get
        {
            return step_limit_count;
        }
    }

    public int StepGambleCount
    {
        get
        {
            return step_gamble_count;
        }
    }

    public int StepGambleTicketId
    {
        get
        {
            return step_gamble_ticket_id;
        }
    }

    public int StepGambleTicketCountDisplay
    {
        get
        {
            return step_gamble_ticket_count_display;
        }
    }

    public int StepGambleTicketCountReal
    {
        get
        {
            return step_gamble_ticket_count_real;
        }
    }

    public int StepGambleTicketRewardId
    {
        get
        {
            return step_gamble_ticket_reward_id;

        }
    }

    public int StepGambleTicketRewardIdCount
    {
        get
        {
            return step_gamble_ticket_reward_id_count;

        }
    }

    public int StepGambleMoneyId
    {
        get
        {
            return step_gamble_money_id;
        }
    }

    public int StepGambleMoneyCountDisplay
    {
        get
        {
            return step_gamble_money_count_display;
        }
    }

    public int StepGambleMoneyCountReal
    {
        get
        {
            return step_gamble_money_count_real;
        }
    }

    public int StepGambleMoneyRewardId
    {
        get
        {
            return step_gamble_money_reward_id;

        }
    }

    public int StepGambleMoneyRewardIdCount
    {
        get
        {
            return step_gamble_money_reward_id_count;

        }
    }

    public int RewardGradeConfirm
    {
        get
        {
            return reward_grade_confirm;
        }
    }

    public int RewardGradeIncrease
    {
        get
        {
            return reward_grade_increase;
        }
    }

    public int RewardGradeCount
    {
        get
        {
            return reward_grade_count;
        }
    }

    public int BonusRewardGroupId
    {
        get
        {
            return bonus_reward_group_id;
        }
    }

    public int BonusRewardId1
    {
        get
        {
            return bonus_reward_id_1;
        }
    }

    public int BonusRewardCount1
    {
        get
        {
            return bonus_reward_count_1;
        }
    }

    public int BonusRewardId2
    {
        get
        {
            return bonus_reward_id_2;
        }
    }

    public int BonusRewardCount2
    {
        get
        {
            return bonus_reward_count_2;
        }
    }

    public int BonusRewardId3
    {
        get
        {
            return bonus_reward_id_3;
        }
    }

    public int BonusRewardCount3
    {
        get
        {
            return bonus_reward_count_3;
        }
    }

    public int RewardMileageValue
    {
        get
        {
            return reward_mileage_value;
        }
    }

    public string StepupAddEventIconName
    {
        get
        {
            return stepup_add_event_icon_name;
        }
    }

    public string StepupAddEventName
    {
        get
        {
            return stepup_add_event_name.Localize();
        }
    }

    public string StepDesc
    {
        get
        {
            return step_desc.Localize();
        }
    }

    public int StepupUiInfoType
    {
        get
        {
            return stepup_ui_info_type;
        }
    }

    public List<int> ListBonusRewardId
    {
        get
        {
            if (list_bonus_reward_id == null)
            {
                list_bonus_reward_id = new List<int>
                {
                    BonusRewardId1,
                    BonusRewardId2,
                    BonusRewardId3
                };
            }
            return list_bonus_reward_id;
        }
    }

    public List<int> ListBonusRewardCount
    {
        get
        {
            if (list_bonus_reward_count == null)
            {
                list_bonus_reward_count = new List<int>
                {
                    BonusRewardCount1,
                    BonusRewardCount2,
                    BonusRewardCount3
                };
            }
            return list_bonus_reward_count;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        group_id = reader.ReadInt32();
        step = reader.ReadInt32();
        step_gamble_group = reader.ReadInt32();
        step_limit_count = reader.ReadInt32();
        step_gamble_count = reader.ReadInt32();
        step_gamble_ticket_id = reader.ReadInt32();
        step_gamble_ticket_count_display = reader.ReadInt32();
        step_gamble_ticket_count_real = reader.ReadInt32();
        step_gamble_ticket_reward_id = reader.ReadInt32();
        step_gamble_ticket_reward_id_count = reader.ReadInt32();
        step_gamble_money_id = reader.ReadInt32();
        step_gamble_money_count_display = reader.ReadInt32();
        step_gamble_money_count_real = reader.ReadInt32();
        step_gamble_money_reward_id = reader.ReadInt32();
        step_gamble_money_reward_id_count = reader.ReadInt32();
        reward_grade_confirm = reader.ReadInt32();
        reward_grade_increase = reader.ReadInt32();
        reward_grade_count = reader.ReadInt32();
        bonus_reward_group_id = reader.ReadInt32();
        bonus_reward_id_1 = reader.ReadInt32();
        bonus_reward_count_1 = reader.ReadInt32();
        bonus_reward_id_2 = reader.ReadInt32();
        bonus_reward_count_2 = reader.ReadInt32();
        bonus_reward_id_3 = reader.ReadInt32();
        bonus_reward_count_3 = reader.ReadInt32();
        reward_mileage_value = reader.ReadInt32();
        stepup_add_event_icon_name = reader.ReadString();
        stepup_add_event_name = reader.ReadInt32();
        step_desc = reader.ReadInt32();
        stepup_ui_info_type = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int group_id;

    private int step;

    private int step_gamble_group;

    private int step_limit_count;

    private int step_gamble_count;

    private int step_gamble_ticket_id;

    private int step_gamble_ticket_count_display;

    private int step_gamble_ticket_count_real;

    private int step_gamble_ticket_reward_id;

    private int step_gamble_ticket_reward_id_count;

    private int step_gamble_money_id;

    private int step_gamble_money_count_display;

    private int step_gamble_money_count_real;

    private int step_gamble_money_reward_id;

    private int step_gamble_money_reward_id_count;

    private int reward_grade_confirm;

    private int reward_grade_increase;

    private int reward_grade_count;

    private int bonus_reward_group_id;

    private int bonus_reward_id_1;

    private int bonus_reward_count_1;

    private int bonus_reward_id_2;

    private int bonus_reward_count_2;

    private int bonus_reward_id_3;

    private int bonus_reward_count_3;

    private int reward_mileage_value;

    private string stepup_add_event_icon_name;

    private int stepup_add_event_name;

    private int step_desc;

    private int stepup_ui_info_type;

    private List<int> list_bonus_reward_id;

    private List<int> list_bonus_reward_count;
}

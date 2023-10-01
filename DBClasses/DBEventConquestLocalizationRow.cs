public class DBEventConquestLocalizationRow : ITableRowIndexer
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

    public string NoticeNotEnoughResourceItem
    {
        get
        {
            return notice_not_enough_resource_item.Localize();
        }
    }

    public string PopupConquestPopupEnemyClearAnswer
    {
        get
        {
            return popup_conquest_popup_enemy_clear_answer.Localize();
        }
    }

    public string NoticeConquestEnemyClear
    {
        get
        {
            return notice_conquest_enemy_clear.Localize();
        }
    }

    public string NoticeOpenNextStep
    {
        get
        {
            return notice_open_next_step.Localize();
        }
    }

    public string NoticeConquestEnemyAllClear
    {
        get
        {
            return notice_conquest_enemy_all_clear.Localize();
        }
    }

    public string PopupConquestProductionTitle
    {
        get
        {
            return popup_conquest_production_title.Localize();
        }
    }

    public string NoticeNotEnoughLevelUpItem
    {
        get
        {
            return notice_not_enough_level_up_item.Localize();
        }
    }

    public string NoticeProductOverflow
    {
        get
        {
            return notice_product_overflow.Localize();
        }
    }

    public string NoticeSelectFeverTarget
    {
        get
        {
            return notice_select_fever_target.Localize();
        }
    }

    public string PopupConquestMakeFeverItem
    {
        get
        {
            return popup_conquest_make_fever_item.Localize();
        }
    }

    public string PopupConquestNotEnoughMakeFeverItem
    {
        get
        {
            return popup_conquest_not_enough_make_fever_item.Localize();
        }
    }

    public string PopupConquestStoryReviewTitle
    {
        get
        {
            return popup_conquest_story_review_title.Localize();
        }
    }

    public string PopupConquestStoryReviewDesc
    {
        get
        {
            return popup_conquest_story_review_desc.Localize();
        }
    }

    public string PopupConquestProductionLevelRewardTitle
    {
        get
        {
            return popup_conquest_production_level_reward_title.Localize();
        }
    }

    public string PopupConquestProductionLevelRewardDesc
    {
        get
        {
            return popup_conquest_production_level_reward_desc.Localize();
        }
    }

    public string PopupConquestStrongPointClearRewardTitle
    {
        get
        {
            return popup_conquest_strong_point_clear_reward_title.Localize();
        }
    }

    public string NoticeConquestCharacterExit
    {
        get
        {
            return notice_conquest_character_exit.Localize();
        }
    }

    public string UiBattleEventDesc1
    {
        get
        {
            return ui_battle_event_desc_1.Localize();
        }
    }

    public string UiBattleEventDesc2
    {
        get
        {
            return ui_battle_event_desc_2.Localize();
        }
    }

    public string UiBattleEventDesc3
    {
        get
        {
            return ui_battle_event_desc_3.Localize();
        }
    }

    public string UiBattleEventDesc4
    {
        get
        {
            return ui_battle_event_desc_4.Localize();
        }
    }

    public string UiMenuBtnShowAlly
    {
        get
        {
            return ui_menu_btn_show_ally.Localize();
        }
    }

    public string UiMenuBtnShowEnemy
    {
        get
        {
            return ui_menu_btn_show_enemy.Localize();
        }
    }

    public string UiMenuBtnShowEnemyHp
    {
        get
        {
            return ui_menu_btn_show_enemy_hp.Localize();
        }
    }

    public string UiMenuBtnShowResources
    {
        get
        {
            return ui_menu_btn_show_resources.Localize();
        }
    }

    public string UiMenuBtnFever
    {
        get
        {
            return ui_menu_btn_fever.Localize();
        }
    }

    public List<string> ListUiBattleEventDesc
    {
        get
        {
            if (list_ui_battle_event_desc == null)
            {
                list_ui_battle_event_desc = new List<string>
                {
                    UiBattleEventDesc1,
                    UiBattleEventDesc2,
                    UiBattleEventDesc3,
                    UiBattleEventDesc4
                };
            }
            return list_ui_battle_event_desc;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        event_sub_index = reader.ReadInt32();
        notice_not_enough_resource_item = reader.ReadInt32();
        popup_conquest_popup_enemy_clear_answer = reader.ReadInt32();
        notice_conquest_enemy_clear = reader.ReadInt32();
        notice_open_next_step = reader.ReadInt32();
        notice_conquest_enemy_all_clear = reader.ReadInt32();
        popup_conquest_production_title = reader.ReadInt32();
        notice_not_enough_level_up_item = reader.ReadInt32();
        notice_product_overflow = reader.ReadInt32();
        notice_select_fever_target = reader.ReadInt32();
        popup_conquest_make_fever_item = reader.ReadInt32();
        popup_conquest_not_enough_make_fever_item = reader.ReadInt32();
        popup_conquest_story_review_title = reader.ReadInt32();
        popup_conquest_story_review_desc = reader.ReadInt32();
        popup_conquest_production_level_reward_title = reader.ReadInt32();
        popup_conquest_production_level_reward_desc = reader.ReadInt32();
        popup_conquest_strong_point_clear_reward_title = reader.ReadInt32();
        notice_conquest_character_exit = reader.ReadInt32();
        ui_battle_event_desc_1 = reader.ReadInt32();
        ui_battle_event_desc_2 = reader.ReadInt32();
        ui_battle_event_desc_3 = reader.ReadInt32();
        ui_battle_event_desc_4 = reader.ReadInt32();
        ui_menu_btn_show_ally = reader.ReadInt32();
        ui_menu_btn_show_enemy = reader.ReadInt32();
        ui_menu_btn_show_enemy_hp = reader.ReadInt32();
        ui_menu_btn_show_resources = reader.ReadInt32();
        ui_menu_btn_fever = reader.ReadInt32();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private int event_sub_index;

    private int notice_not_enough_resource_item;

    private int popup_conquest_popup_enemy_clear_answer;

    private int notice_conquest_enemy_clear;

    private int notice_open_next_step;

    private int notice_conquest_enemy_all_clear;

    private int popup_conquest_production_title;

    private int notice_not_enough_level_up_item;

    private int notice_product_overflow;

    private int notice_select_fever_target;

    private int popup_conquest_make_fever_item;

    private int popup_conquest_not_enough_make_fever_item;

    private int popup_conquest_story_review_title;

    private int popup_conquest_story_review_desc;

    private int popup_conquest_production_level_reward_title;

    private int popup_conquest_production_level_reward_desc;

    private int popup_conquest_strong_point_clear_reward_title;

    private int notice_conquest_character_exit;

    private int ui_battle_event_desc_1;

    private int ui_battle_event_desc_2;

    private int ui_battle_event_desc_3;

    private int ui_battle_event_desc_4;

    private int ui_menu_btn_show_ally;

    private int ui_menu_btn_show_enemy;

    private int ui_menu_btn_show_enemy_hp;

    private int ui_menu_btn_show_resources;

    private int ui_menu_btn_fever;

    private List<string> list_ui_battle_event_desc;
}
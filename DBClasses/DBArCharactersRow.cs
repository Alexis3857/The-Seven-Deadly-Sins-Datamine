public class DBArCharactersRow : ITableRowIndexer
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

    public int UnlockQuestId
    {
        get
        {
            return unlock_quest_id;
        }
    }

    public string Icon1
    {
        get
        {
            return icon_1;
        }
    }

    public string Head1
    {
        get
        {
            return head_1;
        }
    }

    public string Body1
    {
        get
        {
            return body_1;
        }
    }

    public string Icon2
    {
        get
        {
            return icon_2;
        }
    }

    public string Head2
    {
        get
        {
            return head_2;
        }
    }

    public string Body2
    {
        get
        {
            return body_2;
        }
    }

    public string DanceBgm
    {
        get
        {
            return dance_bgm;
        }
    }

    public string AnimEmotionIdle
    {
        get
        {
            return anim_emotion_idle;
        }
    }

    public string AnimEmotion1
    {
        get
        {
            return anim_emotion_1;
        }
    }

    public string AnimEmotion2
    {
        get
        {
            return anim_emotion_2;
        }
    }

    public string AnimEmotion3
    {
        get
        {
            return anim_emotion_3;
        }
    }

    public string AnimEmotion4
    {
        get
        {
            return anim_emotion_4;
        }
    }

    public string AnimEmotion5
    {
        get
        {
            return anim_emotion_5;
        }
    }

    public string AnimEmotionIcon1
    {
        get
        {
            return anim_emotion_icon_1;
        }
    }

    public string AnimEmotionIcon2
    {
        get
        {
            return anim_emotion_icon_2;
        }
    }

    public string AnimEmotionIcon3
    {
        get
        {
            return anim_emotion_icon_3;
        }
    }

    public string AnimEmotionIcon4
    {
        get
        {
            return anim_emotion_icon_4;
        }
    }

    public string AnimEmotionIcon5
    {
        get
        {
            return anim_emotion_icon_5;
        }
    }

    public string AnimDanceIdle
    {
        get
        {
            return anim_dance_idle;
        }
    }

    public string AnimDance1
    {
        get
        {
            return anim_dance_1;
        }
    }

    public string AnimDance2
    {
        get
        {
            return anim_dance_2;
        }
    }

    public string AnimDance3
    {
        get
        {
            return anim_dance_3;
        }
    }

    public string AnimDance4
    {
        get
        {
            return anim_dance_4;
        }
    }

    public string AnimDance5
    {
        get
        {
            return anim_dance_5;
        }
    }

    public string AnimDanceIcon1
    {
        get
        {
            return anim_dance_icon_1;
        }
    }

    public string AnimDanceIcon2
    {
        get
        {
            return anim_dance_icon_2;
        }
    }

    public string AnimDanceIcon3
    {
        get
        {
            return anim_dance_icon_3;
        }
    }

    public string AnimDanceIcon4
    {
        get
        {
            return anim_dance_icon_4;
        }
    }

    public string AnimDanceIcon5
    {
        get
        {
            return anim_dance_icon_5;
        }
    }

    public List<string> ListIcon
    {
        get
        {
            if (list_icon == null)
            {
                list_icon = new List<string>
                {
                    Icon1,
                    Icon2
                };
            }
            return list_icon;
        }
    }

    public List<string> ListHead
    {
        get
        {
            if (list_head == null)
            {
                list_head = new List<string>
                {
                    Head1,
                    Head2
                };
            }
            return list_head;
        }
    }

    public List<string> ListBody
    {
        get
        {
            if (list_body == null)
            {
                list_body = new List<string>
                {
                    Body1,
                    Body2
                };
            }
            return list_body;
        }
    }

    public List<string> ListAnimEmotion
    {
        get
        {
            if (list_anim_emotion == null)
            {
                list_anim_emotion = new List<string>
                {
                    AnimEmotion1,
                    AnimEmotion2,
                    AnimEmotion3,
                    AnimEmotion4,
                    AnimEmotion5
                };
            }
            return list_anim_emotion;
        }
    }

    public List<string> ListAnimEmotionIcon
    {
        get
        {
            if (list_anim_emotion_icon == null)
            {
                list_anim_emotion_icon = new List<string>
                {
                    AnimEmotionIcon1,
                    AnimEmotionIcon2,
                    AnimEmotionIcon3,
                    AnimEmotionIcon4,
                    AnimEmotionIcon5
                };
            }
            return list_anim_emotion_icon;
        }
    }

    public List<string> ListAnimDance
    {
        get
        {
            if (list_anim_dance == null)
            {
                list_anim_dance = new List<string>
                {
                    AnimDance1,
                    AnimDance2,
                    AnimDance3,
                    AnimDance4,
                    AnimDance5
                };
            }
            return list_anim_dance;
        }
    }

    public List<string> ListAnimDanceIcon
    {
        get
        {
            if (list_anim_dance_icon == null)
            {
                list_anim_dance_icon = new List<string>
                {
                    AnimDanceIcon1,
                    AnimDanceIcon2,
                    AnimDanceIcon3,
                    AnimDanceIcon4,
                    AnimDanceIcon5
                };
            }
            return list_anim_dance_icon;
        }
    }

    public bool ReadToStream(BinaryReader reader)
    {
        id = reader.ReadInt32();
        character_base = reader.ReadString();
        unlock_quest_id = reader.ReadInt32();
        icon_1 = reader.ReadString();
        head_1 = reader.ReadString();
        body_1 = reader.ReadString();
        icon_2 = reader.ReadString();
        head_2 = reader.ReadString();
        body_2 = reader.ReadString();
        dance_bgm = reader.ReadString();
        anim_emotion_idle = reader.ReadString();
        anim_emotion_1 = reader.ReadString();
        anim_emotion_2 = reader.ReadString();
        anim_emotion_3 = reader.ReadString();
        anim_emotion_4 = reader.ReadString();
        anim_emotion_5 = reader.ReadString();
        anim_emotion_icon_1 = reader.ReadString();
        anim_emotion_icon_2 = reader.ReadString();
        anim_emotion_icon_3 = reader.ReadString();
        anim_emotion_icon_4 = reader.ReadString();
        anim_emotion_icon_5 = reader.ReadString();
        anim_dance_idle = reader.ReadString();
        anim_dance_1 = reader.ReadString();
        anim_dance_2 = reader.ReadString();
        anim_dance_3 = reader.ReadString();
        anim_dance_4 = reader.ReadString();
        anim_dance_5 = reader.ReadString();
        anim_dance_icon_1 = reader.ReadString();
        anim_dance_icon_2 = reader.ReadString();
        anim_dance_icon_3 = reader.ReadString();
        anim_dance_icon_4 = reader.ReadString();
        anim_dance_icon_5 = reader.ReadString();
        return true;
    }

    public int GetRowIndex()
    {
        return Id;
    }

    private int id;

    private string character_base;

    private int unlock_quest_id;

    private string icon_1;

    private string head_1;

    private string body_1;

    private string icon_2;

    private string head_2;

    private string body_2;

    private string dance_bgm;

    private string anim_emotion_idle;

    private string anim_emotion_1;

    private string anim_emotion_2;

    private string anim_emotion_3;

    private string anim_emotion_4;

    private string anim_emotion_5;

    private string anim_emotion_icon_1;

    private string anim_emotion_icon_2;

    private string anim_emotion_icon_3;

    private string anim_emotion_icon_4;

    private string anim_emotion_icon_5;

    private string anim_dance_idle;

    private string anim_dance_1;

    private string anim_dance_2;

    private string anim_dance_3;

    private string anim_dance_4;

    private string anim_dance_5;

    private string anim_dance_icon_1;

    private string anim_dance_icon_2;

    private string anim_dance_icon_3;

    private string anim_dance_icon_4;

    private string anim_dance_icon_5;

    private List<string> list_icon;

    private List<string> list_head;

    private List<string> list_body;

    private List<string> list_anim_emotion;

    private List<string> list_anim_emotion_icon;

    private List<string> list_anim_dance;

    private List<string> list_anim_dance_icon;
}

using BirbShared.Config;

namespace SocializingSkill
{
    [ConfigClass(I18NNameSuffix = "", I18NTextSuffix = "")]
    internal class Config
    {
        [ConfigPageLink("Experience", "ExperienceModifiers")]
        [ConfigPageLink("Perks", "SkillPerkModifiers")]
        [ConfigPageLink("Professions", "ProfessionModifiers")]

        [ConfigPage("Experience")]
        [ConfigSectionTitle("ExperienceModifiers")]
        [ConfigOption(Min = 0, Max = 100, Interval = 1)]
        public int ExperienceFromTalking { get; set; } = 2;
        [ConfigOption(Min = 0, Max = 100, Interval = 1)]
        public int ExperienceFromGifts { get; set; } = 5;
        [ConfigOption(Min = 0, Max = 100, Interval = 1)]
        public int ExperienceFromEvents { get; set; } = 10;
        [ConfigOption(Min = 0, Max = 100, Interval = 1)]
        public int ExperienceFromQuests { get; set; } = 20;
        [ConfigOption(Min = 1, Max = 5, Interval = 0.1f)]
        public float LovedGiftExpMultiplier { get; set; } = 2;
        [ConfigOption(Min = 1, Max = 5, Interval = 0.1f)]
        public float BirthdayGiftExpMultiplier { get; set; } = 2;

        [ConfigPage("Perks")]
        [ConfigSectionTitle("SkillPerkModifiers")]
        [ConfigOption(Min = 1, Max = 10, Interval = 1)]
        public int ChanceNoFriendshipDecayPerLevel { get; set; } = 5;

        [ConfigPage("Professions")]
        [ConfigSectionTitle("ProfessionModifiers")]

        [ConfigSectionTitle("FriendlyProfessionModifiers")]
        [ConfigOption(Min = 0, Max = 100, Interval = 1)]
        public int FriendlyExtraFriendship { get; set; } = 10;


        [ConfigSectionTitle("SmoothTalkerProfessionModifiers")]
        [ConfigOption(Min = -5.0f, Max = 5.0f, Interval = 0.1f)]
        public float SmoothTalkerPositiveMultiplier { get; set; } = 2.0f;
        [ConfigOption(Min = -5.0f, Max = 5.0f, Interval = 0.1f)]
        public float SmoothTalkerNegativeMultiplier { get; set; } = 0.5f;


        [ConfigSectionTitle("GifterProfessionModifiers")]
        [ConfigOption(Min = 0, Max = 100, Interval = 1)]
        public int GifterLovedGiftExtraFriendship { get; set; } = 80;
        [ConfigOption(Min = 0, Max = 100, Interval = 1)]
        public int GifterLikedGiftExtraFriendship { get; set; } = 40;
        [ConfigOption(Min = 0, Max = 100, Interval = 1)]
        public int GifterNeutralGiftExtraFriendship { get; set; } = 20;

        [ConfigSectionTitle("HelpfulProfessionModifiers")]
        [ConfigOption(Min = 1.0f, Max = 5.0f, Interval = 0.1f)]
        public float HelpfulRewardMultiplier { get; set; } = 2.0f;


        [ConfigSectionTitle("HagglerProfessionModifiers")]
        [ConfigOption(Min = 1, Max = 10, Interval = 1)]
        public int HagglerMinHeartLevel { get; set; } = 6;
        [ConfigOption(Min = 0, Max = 10, Interval = 1)]
        public int HagglerDiscountPercentPerHeartLevel { get; set; } = 2;


        [ConfigSectionTitle("BelovedProfessionModifiers")]
        [ConfigOption(Min = 0, Max = 100, Interval = 1)]
        public int BelovedGiftPercentChance { get; set; } = 5;
        [ConfigOption(Min = 0, Max = 100, Interval = 1)]
        public int BelovedGiftRarePercentChance { get; set; } = 30;
        [ConfigOption(Min = 0, Max = 100, Interval = 1)]
        public int BelovedGiftSuperRarePercentChance { get; set; } = 30;
    }
}

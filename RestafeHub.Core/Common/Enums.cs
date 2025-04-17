namespace RestafeHub.Core.Common
{
    public enum Gender
    {
        Male = 1,
        Female = 2
    }
    public static class EnumConvert
    {
        public static string Gender(Gender gender)
        {
            switch (gender)
            {
                case Common.Gender.Male: return "مرد";
                case Common.Gender.Female: return "زن";
                default: return string.Empty;
            }
        }
        public static string GenderTitle(Gender gender)
        {
            switch (gender)
            {
                case Common.Gender.Male: return "آقای";
                case Common.Gender.Female: return "خانم";
                default: return string.Empty;
            }
        }
    }
}

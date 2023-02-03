using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportDashAI.Contracts.Consts
{
    public enum FeatureSettingType
    {
        String = 1,
        Number = 2,
        Boolean = 3,
    }
    public class FeatureSettingTemplate
    {
        public string Key { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public FeatureSettingType Type { get; set; }
    }
    public static class FeatureSettingsConsts
    {
        public static Dictionary<FeatureSettingType, string> Defaults = new Dictionary<FeatureSettingType, string>();

        public static List<FeatureSettingTemplate> Templates = new List<FeatureSettingTemplate>();

        static FeatureSettingsConsts()
        {
            Defaults.Add(FeatureSettingType.String, string.Empty);
            Defaults.Add(FeatureSettingType.Boolean, "false");
            Defaults.Add(FeatureSettingType.Number, "0");


            Templates.Add(new FeatureSettingTemplate()
            {
                Name = "OpenAI Token",
                Description = "SupportDashAI is based on OpenAI platform, so don't forget to obtain your own OpenAI token.",
                Type = FeatureSettingType.String,
                Key = "OpenAIToken",
            });
            Templates.Add(new FeatureSettingTemplate()
            {
                Name = "Content Compression",
                Description = "We may compress some of the user input, this may be a good option if you want to save you OpenAI tokens, but still get relevant and context-based tips.",
                Type = FeatureSettingType.Boolean,
                Key = "ContentCompression",
            });
            Templates.Add(new FeatureSettingTemplate()
            {
                Name = "SMTP Port",
                Description = "SMPT Mailing server port.",
                Type = FeatureSettingType.Number,
                Key = "SMTPPort",
            });
            Templates.Add(new FeatureSettingTemplate()
            {
                Name = "SMTP Host",
                Description = "SMPT Mailing host.",
                Type = FeatureSettingType.String,
                Key = "SMTPHost",
            });
            Templates.Add(new FeatureSettingTemplate()
            {
                Name = "SMTP Credentials User",
                Description = "SMPT Mailing Credentials user.",
                Type = FeatureSettingType.String,
                Key = "SMTPUser",
            });
            Templates.Add(new FeatureSettingTemplate()
            {
                Name = "SMTP Credentials Password",
                Description = "SMPT Mailing Credentials password.",
                Type = FeatureSettingType.String,
                Key = "SMTPPassword",
            });
        } 
    }
}

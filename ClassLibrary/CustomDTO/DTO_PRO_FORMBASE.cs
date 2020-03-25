using System.Collections.Generic;
namespace DTOModel
{
    public abstract class DTO_PRO_FORMBASE
    {
        public DTO_PRO_FORM_FormConfig FormConfigs { get; set; }
        public virtual void ParseConfigs(string json)
        {
            if (!string.IsNullOrWhiteSpace(json))
                this.FormConfigs = Newtonsoft.Json.JsonConvert.DeserializeObject<DTO_PRO_FORM_FormConfig>(json);
        }
        public virtual string StringifyConfigs()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this.FormConfigs);
        }

        public class DTO_PRO_FORM_FormConfig
        {
            public Dictionary<string, DTO_PRO_FORM_FormConfigBase_Table> Tables { get; set; }
        }
        public class DTO_PRO_FORM_FormConfigBase_Table
        {
            public List<int> HeaderWidths { get; set; }
        }
    }
}

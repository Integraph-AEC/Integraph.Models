using System;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
    public abstract class BaseIfc : IConvertibleToStep
    {
        public BaseIfc()
        {
            Id = Guid.NewGuid();
        }

        [JsonProperty("id")] public Guid Id { get; }

        public int StepId { get; set; }

        public virtual string ToStepValue(bool isSelectOption = false)
        {
            return $"#{StepId}";
        }

        public virtual string ToJson()
        {
            new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                TypeNameHandling = TypeNameHandling.Objects
            };
            return JsonConvert.SerializeObject(this);
        }

        public virtual string ToStep()
        {
            var ifcClass = GetType().Name.ToUpper();
            return $"#{StepId} = {ifcClass}({GetStepParameters()});";
        }

        public virtual string GetStepParameters()
        {
            return string.Empty;
        }
    }
}
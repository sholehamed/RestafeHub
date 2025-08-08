using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using RestafeHub.Business.Abstraction.Common;

namespace ApiServer.Util
{
    public class FilterConditionModelBinderProvider : IModelBinderProvider
    {
        public IModelBinder GetBinder(ModelBinderProviderContext context)
        {
            if (context.Metadata.ModelType == typeof(List<FilterCondition>))
            {
                return new BinderTypeModelBinder(typeof(FilterConditionModelBinder));
            }

            return null;
        }
    }
    public class FilterConditionModelBinder : IModelBinder
    {
        private static readonly string[] KnownOperators = [">=", "<=", "!=", ">", "<", "=", ":"];

        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            var rawValues = bindingContext.ValueProvider.GetValue("filter").Values;
            var rawValue = bindingContext.ValueProvider.GetValue("filter").Values.ToString();

            List<FilterCondition> filterConditions = new List<FilterCondition>();
            foreach (var item in rawValue.Split(','))
            {
                foreach (var op in KnownOperators.OrderByDescending(o => o.Length)) // مهم: ترتیب اهمیت!
                {
                    var index = item.IndexOf(op, StringComparison.Ordinal);
                    if (index > 0)
                    {

                        var f= new FilterCondition
                        {
                            Property = item[..index].Trim(),
                            Operator = op,
                            Value = item[(index + op.Length)..].Trim()
                        };
                        filterConditions.Add(f);
                    }
                }
            }
            bindingContext.Result = ModelBindingResult.Success(filterConditions);
            if (rawValues == ValueProviderResult.None)
            {
                bindingContext.Result = ModelBindingResult.Success(new List<FilterCondition>());
                return Task.CompletedTask;
            }

            return Task.CompletedTask;
        }
    }

}

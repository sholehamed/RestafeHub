using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace RestafeHub.Api.Util
{
    public class ComparableBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext ctx)
        {
            var keyPrefix = ctx.FieldName; // مثلاً "age"
            var query = ctx.HttpContext.Request.Query;

            var match = query.FirstOrDefault(q => q.Key.StartsWith(keyPrefix + ".", StringComparison.OrdinalIgnoreCase));
            if (string.IsNullOrEmpty(match.Key))
            {
                ctx.Result = ModelBindingResult.Success(null);
                return Task.CompletedTask;
            }

            var op = match.Key.Substring(keyPrefix.Length + 1); // "gt", "ne"...
            var val = match.Value.ToString();

            var type = Nullable.GetUnderlyingType(ctx.ModelType.GetGenericArguments()[0]) ?? ctx.ModelType.GetGenericArguments()[0];
            var converted = Convert.ChangeType(val, type);

            var model = Activator.CreateInstance(ctx.ModelType);
            model!.GetType().GetProperty("Operator")!.SetValue(model, op);
            model.GetType().GetProperty("Value")!.SetValue(model, converted);

            ctx.Result = ModelBindingResult.Success(model);
            return Task.CompletedTask;
        }
    }
}

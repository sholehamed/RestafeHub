using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using RestafeHub.Abstraction.Common;

namespace RestafeHub.Api.Util
{
    public class ComparableBinderProvider : IModelBinderProvider
    {
        public IModelBinder? GetBinder(ModelBinderProviderContext context)
        {
            var type = context.Metadata.ModelType;

            if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Comparable<>))
            {
                return new BinderTypeModelBinder(typeof(ComparableBinder));
            }

            return null;
        }
    }
}

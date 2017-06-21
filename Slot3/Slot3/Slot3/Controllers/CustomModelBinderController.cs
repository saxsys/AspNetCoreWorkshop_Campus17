using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Internal;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Slot3.Controllers
{
    public class CustomModel
    {
        public DateTime ATime { get; set; }
    }

    public class CustomModelBinderController : Controller
    {
        public IActionResult Index(CustomModel customModel)
        {
            return this.View(customModel);
        }
    }

    public class CustomModelBinderProvider : IModelBinderProvider
    {
        public IModelBinder GetBinder(ModelBinderProviderContext context)
        {
            if(context.Metadata.ModelType == typeof(CustomModel))
            {
                return new BinderTypeModelBinder(typeof(CustomModelBinder));
            }

            return null;
        }
    }

    public class CustomModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            var boundModel = new CustomModel
            {
                ATime = DateTime.Now
            };

            bindingContext.FieldName = "customModel";
            bindingContext.Model     = boundModel;
            bindingContext.Result    = ModelBindingResult.Success(boundModel);

            return TaskCache.CompletedTask;
        }
    }
}
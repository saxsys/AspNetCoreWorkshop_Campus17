using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Internal;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using System;
using System.Threading.Tasks;

namespace Slot3.Controllers
{
    public class CustomModel
    {
        public DateTime Now { get; set; }
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
            bindingContext.Model = new CustomModel
            {
                Now = DateTime.Now
            };

            return TaskCache.CompletedTask;
        }
    }
}
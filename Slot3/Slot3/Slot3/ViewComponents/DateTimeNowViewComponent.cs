using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Slot3.ViewComponents
{
    //[ViewComponent(Name = "Now")]
    public class DateTimeNowViewComponent: ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(bool tomorrow)
        {

            var timeNow = DateTime.Now;

            if (tomorrow)
            {
                timeNow = timeNow.AddDays(1);
            }
            
            return View(timeNow);
        }
    }
}

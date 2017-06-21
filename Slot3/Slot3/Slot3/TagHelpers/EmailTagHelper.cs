using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace Slot3.TagHelpers
{
    [HtmlTargetElement("email")]
    public class EmailTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";    // Replaces <email> with <a> tag
        }
    }
}
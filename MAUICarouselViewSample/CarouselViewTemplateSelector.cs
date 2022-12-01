using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUICarouselViewSample
{
    public class CarouselViewTemplateSelector : DataTemplateSelector
    {
        public DataTemplate CurveTemplate { get; set; }
        public DataTemplate SquareTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            BannerImage banner = (BannerImage)item;
            return banner.IsSquareView ? SquareTemplate : CurveTemplate;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUICarouselViewSample
{
    public class BannerImage
    {
        public ImageSource ImageUrl { get; set; }
        public string ImageName { get; set; }
        public string ImageDesc { get; set; } = "Lorem Ipsum is simply dummy text of the printing and typesetting industry";
        public bool IsSquareView { get; set; }
        public Color HeaderColor { get; set; }
        public bool IsLoading = true;
    }
}
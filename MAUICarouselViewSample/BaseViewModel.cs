using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MAUICarouselViewSample
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ObservableCollection<BannerImage> GetImageList1()
        {
            ObservableCollection<BannerImage> ImageList = new ObservableCollection<BannerImage>();

            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromArgb("#00FF00"),
                ImageName = "one.jpg",
                ImageUrl = ImageSource.FromFile("one.jpg")
            });

            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromArgb("#00FF00"),
                ImageName = "two.jpg",
                ImageUrl = ImageSource.FromFile("two.jpg")
            });

            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromArgb("#00FF00"),
                ImageName = "three.jpg",
                ImageUrl = ImageSource.FromFile("three.jpg")
            });

            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromArgb("#00FF00"),
                ImageName = "four.jpg",
                ImageUrl = ImageSource.FromFile("four.jpg")
            });

            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromArgb("#00FF00"),
                ImageName = "five.jpg",
                ImageUrl = ImageSource.FromFile("five.jpg")
            });

            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromArgb("#00FF00"),
                ImageName = "six.jpg",
                ImageUrl = ImageSource.FromFile("six.jpg")
            });

            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromArgb("#00FF00"),
                ImageName = "Image pexels-photo-257840",
                ImageUrl = ImageSource.FromFile("gif4.gif")
            });

            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromArgb("#F0048A"),
                ImageName = "Image pexels-photo-257840",
                ImageUrl = ImageSource.FromFile("gif5.gif")
            });

            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromArgb("#D7DBDD"),
                ImageName = "Image img5",
                ImageUrl = ImageSource.FromFile("img5.jpeg")
            });

            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromArgb("#F7DC6F"),
                ImageName = "Image img6",
                ImageUrl = ImageSource.FromFile("img6.jpg")
            });

            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromArgb("#7DCEA0"),
                ImageName = "Image img7",
                ImageUrl = ImageSource.FromFile("img7.jpg")
            });

            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromArgb("#7FB3D5"),
                ImageName = "Image img8",
                ImageUrl = ImageSource.FromFile("img8.jpeg")
            });

            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromArgb("#C39BD3"),
                ImageName = "Image img9",
                ImageUrl = ImageSource.FromFile("img9.jpeg")
            });

            return ImageList;
        }

        public ObservableCollection<BannerImage> GetImageList2()
        {
            ObservableCollection<BannerImage> ImageList = new ObservableCollection<BannerImage>();

            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromArgb("#00FF00"),
                ImageName = "five.jpg",
                ImageUrl = ImageSource.FromFile("five.jpg")
            });

            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromArgb("#00FF00"),
                ImageName = "six.jpg",
                ImageUrl = ImageSource.FromFile("six.jpg")
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image img9",
                ImageUrl = ImageSource.FromFile("img9.jpeg")
            });

            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromArgb("#00FF00"),
                ImageName = "one.jpg",
                ImageUrl = ImageSource.FromFile("one.jpg")
            });

            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromArgb("#00FF00"),
                ImageName = "two.jpg",
                ImageUrl = ImageSource.FromFile("two.jpg")
            });

            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromArgb("#00FF00"),
                ImageName = "three.jpg",
                ImageUrl = ImageSource.FromFile("three.jpg")
            });

            ImageList.Add(new BannerImage()
            {
                HeaderColor = Color.FromArgb("#00FF00"),
                ImageName = "four.jpg",
                ImageUrl = ImageSource.FromFile("four.jpg")
            });
            ImageList.Add(new BannerImage()
            {
                ImageName = "Image img6",
                ImageUrl = ImageSource.FromFile("img6.jpg")
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image img7",
                ImageUrl = ImageSource.FromFile("img7.jpg")
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image img8",
                ImageUrl = ImageSource.FromFile("img8.jpeg")
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image img5",
                ImageUrl = ImageSource.FromFile("img5.jpeg")
            });

            return ImageList;
        }

        public ObservableCollection<BannerImage> GetImageList3()
        {
            ObservableCollection<BannerImage> ImageList = new ObservableCollection<BannerImage>();

            ImageList.Add(new BannerImage()
            {
                ImageName = "seven.jpg",
                ImageUrl = ImageSource.FromFile("seven.jpg")
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "three.jpg",
                ImageUrl = ImageSource.FromFile("three.jpg")
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image img7",
                ImageUrl = ImageSource.FromFile("img7.jpg")
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image img6",
                ImageUrl = ImageSource.FromFile("img6.jpg")
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "four.jpg",
                ImageUrl = ImageSource.FromFile("four.jpg")
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image img8",
                ImageUrl = ImageSource.FromFile("img8.jpeg")
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image img9",
                ImageUrl = ImageSource.FromFile("img9.jpeg")
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "one.jpg",
                ImageUrl = ImageSource.FromFile("one.jpg")
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image img5",
                ImageUrl = ImageSource.FromFile("img5.jpeg")
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "six.jpg",
                ImageUrl = ImageSource.FromFile("six.jpg")
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "five.jpg",
                ImageUrl = ImageSource.FromFile("five.jpg")
            });

            return ImageList;
        }

        public ObservableCollection<BannerImage> GetImageList4()
        {
            ObservableCollection<BannerImage> ImageList = new ObservableCollection<BannerImage>();

            ImageList.Add(new BannerImage()
            {
                ImageName = "three.jpg",
                ImageUrl = ImageSource.FromFile("three.jpg")
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image img5",
                ImageUrl = ImageSource.FromFile("img5.jpeg")
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "two.jpg",
                ImageUrl = ImageSource.FromFile("two.jpg")
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image img8",
                ImageUrl = ImageSource.FromFile("img8.jpeg")
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image img9",
                ImageUrl = ImageSource.FromFile("img9.jpeg")
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "four.jpg",
                ImageUrl = ImageSource.FromFile("four.jpg")
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image img7",
                ImageUrl = ImageSource.FromFile("img7.jpg")
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "Image img6",
                ImageUrl = ImageSource.FromFile("img6.jpg")
            });

            ImageList.Add(new BannerImage()
            {
                ImageName = "five.jpg",
                ImageUrl = ImageSource.FromFile("five.jpg")
            });

            return ImageList;
        }

        public ObservableCollection<BannerImage> GetImageList5()
        {
            ObservableCollection<BannerImage> ImageList = new ObservableCollection<BannerImage>();

            ImageList.Add(new BannerImage()
            {
                IsSquareView = false,
                ImageName = "one.jpg",
                ImageUrl = ImageSource.FromFile("one.jpg")
            });

            ImageList.Add(new BannerImage()
            {
                IsSquareView = true,
                ImageName = "two.jpg",
                ImageUrl = ImageSource.FromFile("two.jpg")
            });

            ImageList.Add(new BannerImage()
            {
                IsSquareView = false,
                ImageName = "three.jpg",
                ImageUrl = ImageSource.FromFile("three.jpg")
            });

            ImageList.Add(new BannerImage()
            {
                IsSquareView = true,
                ImageName = "four.jpg",
                ImageUrl = ImageSource.FromFile("four.jpg")
            });

            ImageList.Add(new BannerImage()
            {
                IsSquareView = false,
                ImageName = "five.jpg",
                ImageUrl = ImageSource.FromFile("five.jpg")
            });

            ImageList.Add(new BannerImage()
            {
                IsSquareView = true,
                ImageName = "six.jpg",
                ImageUrl = ImageSource.FromFile("six.jpg")
            });

            ImageList.Add(new BannerImage()
            {
                IsSquareView = false,
                ImageName = "seven.jpg",
                ImageUrl = ImageSource.FromFile("seven.jpg")
            });

            return ImageList;
        }

        public ObservableCollection<BannerImage> GetImageList6()
        {
            ObservableCollection<BannerImage> ImageList = new ObservableCollection<BannerImage>();

            ImageList.Add(new BannerImage()
            {
                IsSquareView = true,
                ImageName = "Image img9",
                ImageUrl = ImageSource.FromFile("img9.jpeg")
            });

            ImageList.Add(new BannerImage()
            {
                IsSquareView = false,
                ImageName = "Image img5",
                ImageUrl = ImageSource.FromFile("img5.jpeg")
            });

            ImageList.Add(new BannerImage()
            {
                IsSquareView = true,
                ImageName = "Image img8",
                ImageUrl = ImageSource.FromFile("img8.jpeg")
            });

            ImageList.Add(new BannerImage()
            {
                IsSquareView = false,
                ImageName = "Image img7",
                ImageUrl = ImageSource.FromFile("img7.jpg")
            });

            ImageList.Add(new BannerImage()
            {
                IsSquareView = true,
                ImageName = "Image img6",
                ImageUrl = ImageSource.FromFile("img6.jpg")
            });

            return ImageList;
        }
    }
}

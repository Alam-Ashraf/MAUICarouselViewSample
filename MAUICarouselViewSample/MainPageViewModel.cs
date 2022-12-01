using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUICarouselViewSample
{
    public class MainPageViewModel : BaseViewModel
    {
        private ObservableCollection<BannerImage> _imageList1;
        private ObservableCollection<BannerImage> _imageList2;
        private ObservableCollection<BannerImage> _imageList3;
        private ObservableCollection<BannerImage> _imageList4;
        private ObservableCollection<BannerImage> _imageList5;
        private ObservableCollection<BannerImage> _imageList6;

        public MainPageViewModel()
        {
            Application.Current.Dispatcher.Dispatch(() =>
            {
                ImageList1 = GetImageList1();
                ImageList2 = GetImageList2();
                ImageList3 = GetImageList3();
                ImageList4 = GetImageList4();
                ImageList6 = GetImageList6();

                // Load 5th Banner list after 10 Second
                Task.Delay(10000).ContinueWith(t => Get5thBannerList());
            });
        }

        private void Get5thBannerList()
        {
            ImageList5 = GetImageList5();
        }

        public ObservableCollection<BannerImage> ImageList1
        {
            get => _imageList1;

            set
            {
                _imageList1 = value;

                OnPropertyChanged();
            }
        }

        public ObservableCollection<BannerImage> ImageList2
        {
            get => _imageList2;

            set
            {
                _imageList2 = value;

                OnPropertyChanged();
            }
        }

        public ObservableCollection<BannerImage> ImageList3
        {
            get => _imageList3;

            set
            {
                _imageList3 = value;

                OnPropertyChanged();
            }
        }

        public ObservableCollection<BannerImage> ImageList4
        {
            get => _imageList4;

            set
            {
                _imageList4 = value;

                OnPropertyChanged();
            }
        }

        public ObservableCollection<BannerImage> ImageList5
        {
            get => _imageList5;

            set
            {
                _imageList5 = value;

                OnPropertyChanged();
            }
        }

        public ObservableCollection<BannerImage> ImageList6
        {
            get => _imageList6;

            set
            {
                _imageList6 = value;

                OnPropertyChanged();
            }
        }

    }
}

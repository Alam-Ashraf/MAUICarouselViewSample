namespace MAUICarouselViewSample;

public partial class CarouselItemView2 : StackLayout
{
    private double _scale = 0;

    public CarouselItemView2()
    {
        InitializeComponent();

        _scale = FrameContainer.Scale;
    }

    protected override void OnParentSet()
    {
        base.OnParentSet();

        if (Parent is CarouselView carouselView)
        {
            carouselView.Scrolled += CarouselView_Scrolled;
        }
    }

    private async void CarouselView_Scrolled(object sender, ItemsViewScrolledEventArgs e)
    {
        await FrameContainer.ScaleTo(0.7, 100);
        await FrameContainer.ScaleTo(_scale * .7, 100);
        await FrameContainer.ScaleTo(_scale, 100);
    }

}
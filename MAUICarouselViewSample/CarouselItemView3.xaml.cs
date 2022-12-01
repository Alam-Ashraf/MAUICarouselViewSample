namespace MAUICarouselViewSample;

public partial class CarouselItemView3 : StackLayout
{
    private double _scale = 0;

    public CarouselItemView3()
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
        await FrameContainer.ScaleTo(_scale * 1.1, 400);
        await FrameContainer.ScaleTo(_scale, 400);
    }
}
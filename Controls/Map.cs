namespace MapDemo.Controls
{
    public partial class Map : View, IMap
    {
        public static readonly BindableProperty MapTypeProperty = BindableProperty.Create(nameof(MapType), typeof(MapType), typeof(Map), default(MapType));

        public static readonly BindableProperty IsShowingUserProperty = BindableProperty.Create(nameof(IsShowingUser), typeof(bool), typeof(Map), true);

        public static readonly BindableProperty HasTrafficEnabledProperty = BindableProperty.Create(nameof(HasTrafficEnabled), typeof(bool), typeof(Map), default(bool));

        public static readonly BindableProperty HasScrollEnabledProperty = BindableProperty.Create(nameof(HasScrollEnabled), typeof(bool), typeof(Map), true);

        public static readonly BindableProperty HasZoomEnabledProperty = BindableProperty.Create(nameof(HasZoomEnabled), typeof(bool), typeof(Map), true);

        public MapType MapType
        {
            get { return (MapType)GetValue(MapTypeProperty); }
            set { SetValue(MapTypeProperty, value); }
        }

        public bool HasScrollEnabled
        {
            //get { return (bool)GetValue(HasScrollEnabledProperty); }
            get => true;
            set { SetValue(HasScrollEnabledProperty, value); }
        }

        public bool HasZoomEnabled
        {
            //get { return (bool)GetValue(HasZoomEnabledProperty); }
            get => true;
            set { SetValue(HasZoomEnabledProperty, value); }
        }

        public bool IsShowingUser
        {
            //get { return (bool)GetValue(IsShowingUserProperty); }
            get => true;
            set { SetValue(IsShowingUserProperty, value); }
        }

        public bool HasTrafficEnabled
        {
            //get => (bool)GetValue(HasTrafficEnabledProperty);
            get => false;
            set => SetValue(HasTrafficEnabledProperty, value);
        }
    }
}

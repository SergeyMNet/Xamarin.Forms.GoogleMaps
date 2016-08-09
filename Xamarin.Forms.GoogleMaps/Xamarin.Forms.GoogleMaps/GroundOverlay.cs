﻿
namespace Xamarin.Forms.GoogleMaps
{
    public sealed class GroundOverlay : BindableObject
    {
        public static readonly BindableProperty IconProperty = BindableProperty.Create("Icon", typeof(BitmapDescriptor), typeof(GroundOverlay), default(BitmapDescriptor));
        public static readonly BindableProperty TransparencyProperty = BindableProperty.Create("Transparency", typeof(float), typeof(GroundOverlay), 0f);
        public static readonly BindableProperty BoundsProperty = BindableProperty.Create("Bounds", typeof(Bounds), typeof(GroundOverlay), default(Bounds));
        public static readonly BindableProperty BearingProperty = BindableProperty.Create("Bearing", typeof(float), typeof(GroundOverlay), 0f);
        public static readonly BindableProperty IsClickableProperty = BindableProperty.Create("IsClickable", typeof(bool), typeof(GroundOverlay), false);
        public static readonly BindableProperty AnchorProperty = BindableProperty.Create("Anchor", typeof(Point), typeof(GroundOverlay), new Point(0.5, 0.5));

        public BitmapDescriptor Icon
        {
            get { return (BitmapDescriptor)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public float Transparency
        {
            get { return (float)GetValue(TransparencyProperty); }
            set { SetValue(TransparencyProperty, value); }
        }

        public Bounds Bounds
        {
            get { return (Bounds)GetValue(BoundsProperty); }
            set { SetValue(BoundsProperty, value); }
        }

        public float Bearing
        {
            get { return (float)GetValue(BearingProperty); }
            set { SetValue(BearingProperty, value); }
        }

        public bool IsClickable
        {
            get { return (bool)GetValue(IsClickableProperty); }
            set { SetValue(IsClickableProperty, value); }
        }

        public Point Anchor
        {
            get { return (Point)GetValue(AnchorProperty); }
            set { SetValue(AnchorProperty, value); }
        }

        public object Tag { get; set; }

        public object NativeObject { get; internal set; }
    }
}
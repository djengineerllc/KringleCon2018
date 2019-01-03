using MahApps.Metro.Controls;
using System;
using System.Text;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;

namespace KringleCon2018.Classes
{
    public class HamburgerMenuGlyphRatingItem : HamburgerMenuGlyphItem
    {
        public string RatingText { get; set; }
        /// <summary>
        /// Identifies the <see cref="Rating"/> dependency property.
        /// </summary>
        public static DependencyProperty RatingProperty =
            DependencyProperty.Register(nameof(Rating), typeof(int), typeof(HamburgerMenuGlyphRatingItem),
                new PropertyMetadata(5,
                new PropertyChangedCallback(OnMaxRatingChanged),
                new CoerceValueCallback(CoerceMaxRatingValue)));
        public static DependencyProperty MinimumProperty =
            DependencyProperty.Register(nameof(Minimum), typeof(int), typeof(HamburgerMenuGlyphRatingItem),
                new PropertyMetadata(0));
        public static DependencyProperty MaximumProperty =
            DependencyProperty.Register(nameof(Maximum), typeof(int), typeof(HamburgerMenuGlyphRatingItem),
                new PropertyMetadata(10));
        private static object CoerceMaxRatingValue(DependencyObject d, object value)
        {
            var ratingItem = (HamburgerMenuGlyphRatingItem)d;
            var current = (int)value;
            if (current < ratingItem.Minimum) { current = ratingItem.Minimum; }
            if (current > ratingItem.Maximum) { current = ratingItem.Maximum; }
            return current;
        }
        private static void OnMaxRatingChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            d.CoerceValue(MinimumProperty);
            d.CoerceValue(MaximumProperty);
            var ratingItem = (HamburgerMenuGlyphRatingItem)d;
            SetupRating(ratingItem);
        }

        private static void SetupRating(HamburgerMenuGlyphRatingItem ratingItem)
        {
            var rating = ratingItem.Rating;
            //ratingItem.RatingText = new TextBlock();
            var ratedItem = new Glyphs {
                FontRenderingEmSize = 14d,
                FontUri = new Uri("pack://application:,,,/KringleCon2018;component/Resources/KGChristmasTrees.ttf"),
                UnicodeString = Repeat(ratingItem.RatingGlyph, ratingItem.Rating),
                Indices = string.Empty,
                Fill = Brushes.Red,
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Stretch
            };
            var unratedItem = new Glyphs {
                FontRenderingEmSize = 14d,
                FontUri = new Uri("pack://application:,,,/KringleCon2018;component/Resources/KGChristmasTrees.ttf"),
                UnicodeString = Repeat(ratingItem.RatingGlyph, ratingItem.MaxRating - ratingItem.Rating),
                Indices = string.Empty,
                Fill = Brushes.White,
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Stretch
            };
            ratingItem.RatingText += ratedItem;
            ratingItem.RatingText += unratedItem;
            ratingItem.Label = $"{ratingItem.RatingText} {ratingItem.Label}";
        }
        public static string Repeat(string value, int count) => new StringBuilder(value.Length * count).Insert(0, value, count).ToString();

        /// <summary>
        /// Identifies the <see cref="MaxRating"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty MaxRatingProperty = DependencyProperty.Register(nameof(MaxRating), typeof(int), typeof(HamburgerMenuGlyphItem), new PropertyMetadata(5));
        /// <summary>
        /// Identifies the <see cref="RatingGlyph"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty RatingGlyphProperty = DependencyProperty.Register(nameof(RatingGlyph), typeof(string), typeof(HamburgerMenuGlyphItem), new PropertyMetadata("1"));
        /// <summary>
        /// Gets or sets a value that specifies the Rating
        /// </summary>
        public int Rating
        {
            get => (int)GetValue(RatingProperty);
            set => SetValue(RatingProperty, value);
        }
        /// <summary>
        /// Gets or sets a value that specifies the MaxRating
        /// </summary>
        public int MaxRating
        {
            get => (int)GetValue(MaxRatingProperty);
            set => SetValue(MaxRatingProperty, value);
        }
        /// <summary>
        /// Gets or sets a value that specifies the RatingGlyph
        /// </summary>
        public string RatingGlyph
        {
            get => (string)GetValue(RatingGlyphProperty);
            set => SetValue(RatingGlyphProperty, value);
        }
        public int Minimum
        {
            get => (int)GetValue(MinimumProperty);
            set => SetValue(MinimumProperty, value);
        }
        public int Maximum
        {
            get => (int)GetValue(MaximumProperty);
            set => SetValue(MaximumProperty, value);
        }
    }
}
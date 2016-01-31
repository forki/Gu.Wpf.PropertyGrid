﻿namespace Gu.PropertyGrid
{
    using System.Windows;
    using System.Windows.Controls;
    using Gu.Units;

    public class SettingsControl : ItemsControl
    {
        public static readonly DependencyProperty ValueWidthProperty = SettingControl.ValueWidthProperty.AddOwner(
            typeof(SettingsControl),
            new FrameworkPropertyMetadata(130.0, FrameworkPropertyMetadataOptions.Inherits));

        public static readonly DependencyProperty SuffixWidthProperty = SettingControl.SuffixWidthProperty.AddOwner(
            typeof(SettingsControl),
            new FrameworkPropertyMetadata(75.0, FrameworkPropertyMetadataOptions.Inherits));

        public static readonly DependencyProperty SymbolFormatProperty = UnitSettingControl.SymbolFormatProperty.AddOwner(
            typeof(UnitSettingControl),
            new FrameworkPropertyMetadata(UnitSettingControl.DefaultSymbolFormat, FrameworkPropertyMetadataOptions.Inherits));

        static SettingsControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SettingsControl), new FrameworkPropertyMetadata(typeof(SettingsControl)));
            FocusableProperty.OverrideMetadata(typeof(Control), new FrameworkPropertyMetadata(BooleanBoxes.True));
        }

        public double ValueWidth
        {
            get { return (double)this.GetValue(ValueWidthProperty); }
            set { this.SetValue(ValueWidthProperty, value); }
        }

        public double SuffixWidth
        {
            get { return (double)this.GetValue(SuffixWidthProperty); }
            set { this.SetValue(SuffixWidthProperty, value); }
        }

        public SymbolFormat SymbolFormat
        {
            get { return (SymbolFormat)this.GetValue(SymbolFormatProperty); }
            set { this.SetValue(SymbolFormatProperty, value); }
        }
    }
}

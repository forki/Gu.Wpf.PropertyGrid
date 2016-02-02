﻿namespace Gu.Wpf.PropertyGrid.Tests
{
    using xunit.wpf;
    using Xunit;

    public class SettingControlBaseTests
    {
        [WpfFact]
        public void IsDirty()
        {
            var control = new SettingControlBaseImpl();
            Assert.Null(control.IsDirty);

            control.Value = 1;
            Assert.Null(control.IsDirty);

            control.OldValue = 2;
            Assert.True(control.IsDirty);

            control.OldValue = 1;
            Assert.False(control.IsDirty);

            control.Value = 3;
            Assert.True(control.IsDirty);

            control.OldValue = 3;
            Assert.False(control.IsDirty);
        }
    }
}
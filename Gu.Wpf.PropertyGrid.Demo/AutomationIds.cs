﻿namespace Gu.Wpf.PropertyGrid.Demo
{
    using System.Runtime.CompilerServices;

    public static class AutomationIds
    {
        public static readonly string MainWindowId = Create();

        public static readonly string StringSettingId = Create();
        public static readonly string ReadonlyStringSettingId = Create();

        public static readonly string DoubleSettingId = Create();
        public static readonly string LengthSettingId = Create();

        private static string Create([CallerMemberName] string name = null)
        {
            return name;
        }
    }
}
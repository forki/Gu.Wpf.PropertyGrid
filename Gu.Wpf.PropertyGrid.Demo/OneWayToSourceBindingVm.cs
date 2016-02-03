﻿namespace Gu.Wpf.PropertyGrid.Demo
{
    using System;
    using System.Collections;
    using System.ComponentModel;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using JetBrains.Annotations;

    public class OneWayToSourceBindingVm : INotifyDataErrorInfo, INotifyPropertyChanged
    {
        private string text;
        private bool hasErrors = false;
        private bool viewHasErrors;

        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;
        public string Text
        {
            get { return this.text; }
            set
            {
                if (value == this.text) return;
                this.text = value;
                this.OnPropertyChanged();
            }
        }

        public bool HasErrors
        {
            get { return this.hasErrors; }
            set
            {
                if (value == this.hasErrors)
                {
                    return;
                }
                this.hasErrors = value;
                this.OnPropertyChanged();
                this.OnErrorsChanged(nameof(this.Text));
            }
        }

        public bool ViewHasErrors
        {
            get { return this.viewHasErrors; }
            set
            {
                if (value == this.viewHasErrors) return;
                this.viewHasErrors = value;
                this.OnPropertyChanged();
            }
        }

        public IEnumerable GetErrors(string propertyName)
        {
            return this.hasErrors && propertyName == nameof(this.Text)
                 ? new[] { "Has error" }
                 : Enumerable.Empty<string>();
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected virtual void OnErrorsChanged([CallerMemberName] string propertyName = null)
        {
            this.ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
        }
    }
}
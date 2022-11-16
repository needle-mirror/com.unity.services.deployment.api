using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Unity.Services.DeploymentApi.Editor
{
    /// <summary>
    /// Concrete implementation of IDeploymentItem. Should be implemented over the interface.
    /// </summary>
    class DeploymentItem : IDeploymentItem, ITypedItem
    {
        protected string m_Name;
        protected string m_Path;
        protected string m_Type;
        protected float m_Progress;
        protected DeploymentStatus m_Status;
        protected ObservableCollection<AssetState> m_States = new ObservableCollection<AssetState>();

        public event PropertyChangedEventHandler PropertyChanged;

        public virtual string Name
        {
            get => m_Name;
            set => SetField(ref m_Name, value);
        }

        public virtual string Path
        {
            get => m_Path;
            set => SetField(ref m_Path, value);
        }

        public string Type
        {
            get => m_Type;
            set => SetField(ref m_Type, value);
        }

        public virtual float Progress
        {
            get => m_Progress;
            set => SetField(ref m_Progress, value);
        }

        public virtual DeploymentStatus Status
        {
            get => m_Status;
            set => SetField(ref m_Status, value);
        }

        public ObservableCollection<AssetState> States => m_States;

        protected void SetField<T>(
            ref T field,
            T value,
            Action<T> onFieldChanged = null,
            [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return;
            field = value;
            OnPropertyChanged(propertyName);
            onFieldChanged?.Invoke(field);
        }

        void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

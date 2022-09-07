using System.Collections.ObjectModel;

namespace Unity.Services.DeploymentApi.Editor
{
    class Deployments
    {
        public static Deployments Instance { get; } = new Deployments();

        public IEnvironmentProvider EnvironmentProvider { get; internal set; }
        public ObservableCollection<DeploymentProvider> DeploymentProviders { get; } = new ObservableCollection<DeploymentProvider>();
    }
}

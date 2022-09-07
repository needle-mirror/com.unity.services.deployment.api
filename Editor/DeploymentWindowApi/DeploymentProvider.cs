using System.Collections.ObjectModel;

namespace Unity.Services.DeploymentApi.Editor
{
    /// <summary>
    /// The class responsible for providing the deployment items and the commands that can be invoked on them.
    /// </summary>
    abstract class DeploymentProvider
    {
        /// <summary>
        /// Represents the name of a service (CloudCode, RemoteConfig etc.).
        /// </summary>
        public abstract string Service { get; }

        /// <summary>
        /// Collection of the items belonging to the specified service available for deployment.
        /// </summary>
        public ObservableCollection<IDeploymentItem> DeploymentItems { get; }

        /// <summary>
        /// Collection of the commands applicable to the deployment item type.
        /// </summary>
        public ObservableCollection<Command> Commands { get; }

        /// <summary>
        /// Command that specifies the deployment process.
        /// </summary>
        public abstract Command DeployCommand { get; }

        /// <summary>
        /// Command the specifies the double click behaviour on an item.
        /// </summary>
        public virtual Command OpenCommand => null;

        protected DeploymentProvider(ObservableCollection<IDeploymentItem> deploymentItems = null, ObservableCollection<Command> commands = null)
        {
            DeploymentItems = deploymentItems ?? new ObservableCollection<IDeploymentItem>();
            Commands = commands ?? new ObservableCollection<Command>();
        }

        protected DeploymentProvider()
        {
            DeploymentItems = new ObservableCollection<IDeploymentItem>();
            Commands = new ObservableCollection<Command>();
        }
    }
}

namespace Unity.Services.DeploymentApi.Editor
{
    interface ITypedItem
    {
        /// <summary>
        /// Represents the type of the deployment item.
        /// </summary>
        string Type { get; }
    }
}

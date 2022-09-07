namespace Unity.Services.DeploymentApi.Editor
{
    interface IEnvironmentProvider
    {
        string Current { get; }
    }
}

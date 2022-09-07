namespace Unity.Services.DeploymentApi.Editor
{
    /// <summary>
    /// Represents the possible relationships between the
    /// local resource and the remote resource
    /// </summary>
    enum SyncStatus
    {
        UpToDate,
        Ahead,
        DeletedLocally,
        Unknown
    }
}

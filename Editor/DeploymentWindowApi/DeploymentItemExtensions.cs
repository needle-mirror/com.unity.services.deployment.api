namespace Unity.Services.DeploymentApi.Editor
{
    static class DeploymentItemExtensions
    {
        public static void SetStatusDetail(this IDeploymentItem self, string detail)
        {
            var originalStatus = self.Status;
            self.Status = new DeploymentStatus(originalStatus.Message, detail, originalStatus.MessageSeverity);
        }

        public static void SetStatusDescription(this IDeploymentItem self, string description)
        {
            var originalStatus = self.Status;
            self.Status = new DeploymentStatus(description, originalStatus.MessageDetail, originalStatus.MessageSeverity);
        }

        public static void SetStatusSeverity(this IDeploymentItem self, SeverityLevel severityLevel)
        {
            var originalStatus = self.Status;
            self.Status = new DeploymentStatus(originalStatus.MessageDetail, originalStatus.Message, severityLevel);
        }
    }
}

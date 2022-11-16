## What's new in version [1.0.0-pre.5]

This update provides small changes to the API to help separate the concept of Deployment Status (the state of the local asset vs the remote asset), and Asset State (errors and warnings specific to the local asset(s)).

The main updates in this release include:
### Added

    - New interface ITypedItem to allow deployment items to specify a sub-type for their service assets.
    - `DeploymentStatus` has new pre-built statuses such as `DeploymentStatus.UpToDate` to facilitate status updates.

### Updated

    Updated [major updates]

### Fixed

    Fixed [major fixes]

For a full list of changes and updates in this version, see the [com.unity.services.deployment.api] package changelog.

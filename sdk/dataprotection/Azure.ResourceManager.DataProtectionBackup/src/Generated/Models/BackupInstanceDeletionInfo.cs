// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Deletion Info. </summary>
    public partial class BackupInstanceDeletionInfo
    {
        /// <summary> Initializes a new instance of BackupInstanceDeletionInfo. </summary>
        internal BackupInstanceDeletionInfo()
        {
        }

        /// <summary> Initializes a new instance of BackupInstanceDeletionInfo. </summary>
        /// <param name="deleteOn"> Specifies time of deletion. </param>
        /// <param name="billingEndOn"> Specifies billing end date. </param>
        /// <param name="scheduledPurgeOn"> Specifies purge time. </param>
        /// <param name="deleteActivityId"> Delete activity ID for troubleshooting purpose. </param>
        internal BackupInstanceDeletionInfo(DateTimeOffset? deleteOn, DateTimeOffset? billingEndOn, DateTimeOffset? scheduledPurgeOn, string deleteActivityId)
        {
            DeleteOn = deleteOn;
            BillingEndOn = billingEndOn;
            ScheduledPurgeOn = scheduledPurgeOn;
            DeleteActivityId = deleteActivityId;
        }

        /// <summary> Specifies time of deletion. </summary>
        public DateTimeOffset? DeleteOn { get; }
        /// <summary> Specifies billing end date. </summary>
        public DateTimeOffset? BillingEndOn { get; }
        /// <summary> Specifies purge time. </summary>
        public DateTimeOffset? ScheduledPurgeOn { get; }
        /// <summary> Delete activity ID for troubleshooting purpose. </summary>
        public string DeleteActivityId { get; }
    }
}

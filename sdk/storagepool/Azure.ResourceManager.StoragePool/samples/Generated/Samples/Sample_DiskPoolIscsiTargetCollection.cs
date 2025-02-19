// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.StoragePool;
using Azure.ResourceManager.StoragePool.Models;

namespace Azure.ResourceManager.StoragePool.Samples
{
    public partial class Sample_DiskPoolIscsiTargetCollection
    {
        // List Disk Pools by Resource Group
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListDiskPoolsByResourceGroup()
        {
            // Generated from example definition: specification/storagepool/resource-manager/Microsoft.StoragePool/stable/2021-08-01/examples/IscsiTargets_ListByDiskPool.json
            // this example is just showing the usage of "IscsiTargets_ListByDiskPool" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DiskPoolResource created on azure
            // for more information of creating DiskPoolResource, please refer to the document of DiskPoolResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string diskPoolName = "myDiskPool";
            ResourceIdentifier diskPoolResourceId = DiskPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, diskPoolName);
            DiskPoolResource diskPool = client.GetDiskPoolResource(diskPoolResourceId);

            // get the collection of this DiskPoolIscsiTargetResource
            DiskPoolIscsiTargetCollection collection = diskPool.GetDiskPoolIscsiTargets();

            // invoke the operation and iterate over the result
            await foreach (DiskPoolIscsiTargetResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DiskPoolIscsiTargetData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Create or Update iSCSI Target
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateISCSITarget()
        {
            // Generated from example definition: specification/storagepool/resource-manager/Microsoft.StoragePool/stable/2021-08-01/examples/IscsiTargets_Put.json
            // this example is just showing the usage of "IscsiTargets_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DiskPoolResource created on azure
            // for more information of creating DiskPoolResource, please refer to the document of DiskPoolResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string diskPoolName = "myDiskPool";
            ResourceIdentifier diskPoolResourceId = DiskPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, diskPoolName);
            DiskPoolResource diskPool = client.GetDiskPoolResource(diskPoolResourceId);

            // get the collection of this DiskPoolIscsiTargetResource
            DiskPoolIscsiTargetCollection collection = diskPool.GetDiskPoolIscsiTargets();

            // invoke the operation
            string iscsiTargetName = "myIscsiTarget";
            DiskPoolIscsiTargetCreateOrUpdateContent content = new DiskPoolIscsiTargetCreateOrUpdateContent(DiskPoolIscsiTargetAclMode.Dynamic)
            {
                TargetIqn = "iqn.2005-03.org.iscsi:server1",
                Luns =
{
new ManagedDiskIscsiLun("lun0",new ResourceIdentifier("/subscriptions/11111111-1111-1111-1111-111111111111/resourceGroups/myResourceGroup/providers/Microsoft.Compute/disks/vm-name_DataDisk_1"))
},
            };
            ArmOperation<DiskPoolIscsiTargetResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, iscsiTargetName, content);
            DiskPoolIscsiTargetResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DiskPoolIscsiTargetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get iSCSI Target
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetISCSITarget()
        {
            // Generated from example definition: specification/storagepool/resource-manager/Microsoft.StoragePool/stable/2021-08-01/examples/IscsiTargets_Get.json
            // this example is just showing the usage of "IscsiTargets_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DiskPoolResource created on azure
            // for more information of creating DiskPoolResource, please refer to the document of DiskPoolResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string diskPoolName = "myDiskPool";
            ResourceIdentifier diskPoolResourceId = DiskPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, diskPoolName);
            DiskPoolResource diskPool = client.GetDiskPoolResource(diskPoolResourceId);

            // get the collection of this DiskPoolIscsiTargetResource
            DiskPoolIscsiTargetCollection collection = diskPool.GetDiskPoolIscsiTargets();

            // invoke the operation
            string iscsiTargetName = "myIscsiTarget";
            DiskPoolIscsiTargetResource result = await collection.GetAsync(iscsiTargetName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DiskPoolIscsiTargetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get iSCSI Target
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetISCSITarget()
        {
            // Generated from example definition: specification/storagepool/resource-manager/Microsoft.StoragePool/stable/2021-08-01/examples/IscsiTargets_Get.json
            // this example is just showing the usage of "IscsiTargets_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DiskPoolResource created on azure
            // for more information of creating DiskPoolResource, please refer to the document of DiskPoolResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string diskPoolName = "myDiskPool";
            ResourceIdentifier diskPoolResourceId = DiskPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, diskPoolName);
            DiskPoolResource diskPool = client.GetDiskPoolResource(diskPoolResourceId);

            // get the collection of this DiskPoolIscsiTargetResource
            DiskPoolIscsiTargetCollection collection = diskPool.GetDiskPoolIscsiTargets();

            // invoke the operation
            string iscsiTargetName = "myIscsiTarget";
            bool result = await collection.ExistsAsync(iscsiTargetName);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}

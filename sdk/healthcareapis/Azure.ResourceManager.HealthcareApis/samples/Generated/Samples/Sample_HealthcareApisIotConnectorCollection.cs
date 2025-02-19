// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.HealthcareApis;
using Azure.ResourceManager.HealthcareApis.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HealthcareApis.Samples
{
    public partial class Sample_HealthcareApisIotConnectorCollection
    {
        // List iotconnectors
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListIotconnectors()
        {
            // Generated from example definition: specification/healthcareapis/resource-manager/Microsoft.HealthcareApis/stable/2022-06-01/examples/iotconnectors/iotconnector_List.json
            // this example is just showing the usage of "IotConnectors_ListByWorkspace" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HealthcareApisWorkspaceResource created on azure
            // for more information of creating HealthcareApisWorkspaceResource, please refer to the document of HealthcareApisWorkspaceResource
            string subscriptionId = "subid";
            string resourceGroupName = "testRG";
            string workspaceName = "workspace1";
            ResourceIdentifier healthcareApisWorkspaceResourceId = HealthcareApisWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            HealthcareApisWorkspaceResource healthcareApisWorkspace = client.GetHealthcareApisWorkspaceResource(healthcareApisWorkspaceResourceId);

            // get the collection of this HealthcareApisIotConnectorResource
            HealthcareApisIotConnectorCollection collection = healthcareApisWorkspace.GetHealthcareApisIotConnectors();

            // invoke the operation and iterate over the result
            await foreach (HealthcareApisIotConnectorResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                HealthcareApisIotConnectorData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get an IoT Connector
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAnIoTConnector()
        {
            // Generated from example definition: specification/healthcareapis/resource-manager/Microsoft.HealthcareApis/stable/2022-06-01/examples/iotconnectors/iotconnector_Get.json
            // this example is just showing the usage of "IotConnectors_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HealthcareApisWorkspaceResource created on azure
            // for more information of creating HealthcareApisWorkspaceResource, please refer to the document of HealthcareApisWorkspaceResource
            string subscriptionId = "subid";
            string resourceGroupName = "testRG";
            string workspaceName = "workspace1";
            ResourceIdentifier healthcareApisWorkspaceResourceId = HealthcareApisWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            HealthcareApisWorkspaceResource healthcareApisWorkspace = client.GetHealthcareApisWorkspaceResource(healthcareApisWorkspaceResourceId);

            // get the collection of this HealthcareApisIotConnectorResource
            HealthcareApisIotConnectorCollection collection = healthcareApisWorkspace.GetHealthcareApisIotConnectors();

            // invoke the operation
            string iotConnectorName = "blue";
            HealthcareApisIotConnectorResource result = await collection.GetAsync(iotConnectorName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HealthcareApisIotConnectorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get an IoT Connector
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetAnIoTConnector()
        {
            // Generated from example definition: specification/healthcareapis/resource-manager/Microsoft.HealthcareApis/stable/2022-06-01/examples/iotconnectors/iotconnector_Get.json
            // this example is just showing the usage of "IotConnectors_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HealthcareApisWorkspaceResource created on azure
            // for more information of creating HealthcareApisWorkspaceResource, please refer to the document of HealthcareApisWorkspaceResource
            string subscriptionId = "subid";
            string resourceGroupName = "testRG";
            string workspaceName = "workspace1";
            ResourceIdentifier healthcareApisWorkspaceResourceId = HealthcareApisWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            HealthcareApisWorkspaceResource healthcareApisWorkspace = client.GetHealthcareApisWorkspaceResource(healthcareApisWorkspaceResourceId);

            // get the collection of this HealthcareApisIotConnectorResource
            HealthcareApisIotConnectorCollection collection = healthcareApisWorkspace.GetHealthcareApisIotConnectors();

            // invoke the operation
            string iotConnectorName = "blue";
            bool result = await collection.ExistsAsync(iotConnectorName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Create an IoT Connector
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateAnIoTConnector()
        {
            // Generated from example definition: specification/healthcareapis/resource-manager/Microsoft.HealthcareApis/stable/2022-06-01/examples/iotconnectors/iotconnector_Create.json
            // this example is just showing the usage of "IotConnectors_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HealthcareApisWorkspaceResource created on azure
            // for more information of creating HealthcareApisWorkspaceResource, please refer to the document of HealthcareApisWorkspaceResource
            string subscriptionId = "subid";
            string resourceGroupName = "testRG";
            string workspaceName = "workspace1";
            ResourceIdentifier healthcareApisWorkspaceResourceId = HealthcareApisWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            HealthcareApisWorkspaceResource healthcareApisWorkspace = client.GetHealthcareApisWorkspaceResource(healthcareApisWorkspaceResourceId);

            // get the collection of this HealthcareApisIotConnectorResource
            HealthcareApisIotConnectorCollection collection = healthcareApisWorkspace.GetHealthcareApisIotConnectors();

            // invoke the operation
            string iotConnectorName = "blue";
            HealthcareApisIotConnectorData data = new HealthcareApisIotConnectorData(new AzureLocation("westus"))
            {
                IngestionEndpointConfiguration = new HealthcareApisIotConnectorEventHubIngestionConfiguration()
                {
                    EventHubName = "MyEventHubName",
                    ConsumerGroup = "ConsumerGroupA",
                    FullyQualifiedEventHubNamespace = "myeventhub.servicesbus.windows.net",
                },
                DeviceMappingContent = BinaryData.FromObjectAsJson(new Dictionary<string, object>()
                {
                    ["template"] = new object[] { new Dictionary<string, object>()
{
["template"] = new Dictionary<string, object>()
{
["deviceIdExpression"] = "$.deviceid",
["timestampExpression"] = "$.measurementdatetime",
["typeMatchExpression"] = "$..[?(@heartrate)]",
["typeName"] = "heartrate",
["values"] = new object[] { new Dictionary<string, object>()
{
["required"] = "true",
["valueExpression"] = "$.heartrate",
["valueName"] = "hr"} }},
["templateType"] = "JsonPathContent"} },
                    ["templateType"] = "CollectionContent"
                }),
                Identity = new ManagedServiceIdentity("SystemAssigned"),
                Tags =
{
["additionalProp1"] = "string",
["additionalProp2"] = "string",
["additionalProp3"] = "string",
},
            };
            ArmOperation<HealthcareApisIotConnectorResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, iotConnectorName, data);
            HealthcareApisIotConnectorResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HealthcareApisIotConnectorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.CognitiveServices;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.CognitiveServices.Samples
{
    public partial class Sample_CognitiveServicesDeletedAccountCollection
    {
        // Get Account
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAccount()
        {
            // Generated from example definition: specification/cognitiveservices/resource-manager/Microsoft.CognitiveServices/stable/2022-12-01/examples/GetDeletedAccount.json
            // this example is just showing the usage of "DeletedAccounts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this CognitiveServicesDeletedAccountResource
            CognitiveServicesDeletedAccountCollection collection = subscriptionResource.GetCognitiveServicesDeletedAccounts();

            // invoke the operation
            AzureLocation location = new AzureLocation("westus");
            string resourceGroupName = "myResourceGroup";
            string accountName = "myAccount";
            CognitiveServicesDeletedAccountResource result = await collection.GetAsync(location, resourceGroupName, accountName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CognitiveServicesAccountData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get Account
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetAccount()
        {
            // Generated from example definition: specification/cognitiveservices/resource-manager/Microsoft.CognitiveServices/stable/2022-12-01/examples/GetDeletedAccount.json
            // this example is just showing the usage of "DeletedAccounts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this CognitiveServicesDeletedAccountResource
            CognitiveServicesDeletedAccountCollection collection = subscriptionResource.GetCognitiveServicesDeletedAccounts();

            // invoke the operation
            AzureLocation location = new AzureLocation("westus");
            string resourceGroupName = "myResourceGroup";
            string accountName = "myAccount";
            bool result = await collection.ExistsAsync(location, resourceGroupName, accountName);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}

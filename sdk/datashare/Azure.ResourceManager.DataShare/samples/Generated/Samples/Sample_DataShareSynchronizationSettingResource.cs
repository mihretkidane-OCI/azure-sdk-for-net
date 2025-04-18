// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DataShare.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.DataShare.Samples
{
    public partial class Sample_DataShareSynchronizationSettingResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_SynchronizationSettingsGet()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/SynchronizationSettings_Get.json
            // this example is just showing the usage of "SynchronizationSettings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataShareSynchronizationSettingResource created on azure
            // for more information of creating DataShareSynchronizationSettingResource, please refer to the document of DataShareSynchronizationSettingResource
            string subscriptionId = "433a8dfd-e5d5-4e77-ad86-90acdc75eb1a";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "Account1";
            string shareName = "Share1";
            string synchronizationSettingName = "SynchronizationSetting1";
            ResourceIdentifier dataShareSynchronizationSettingResourceId = DataShareSynchronizationSettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareName, synchronizationSettingName);
            DataShareSynchronizationSettingResource dataShareSynchronizationSetting = client.GetDataShareSynchronizationSettingResource(dataShareSynchronizationSettingResourceId);

            // invoke the operation
            DataShareSynchronizationSettingResource result = await dataShareSynchronizationSetting.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataShareSynchronizationSettingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_SynchronizationSettingsDelete()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/SynchronizationSettings_Delete.json
            // this example is just showing the usage of "SynchronizationSettings_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataShareSynchronizationSettingResource created on azure
            // for more information of creating DataShareSynchronizationSettingResource, please refer to the document of DataShareSynchronizationSettingResource
            string subscriptionId = "433a8dfd-e5d5-4e77-ad86-90acdc75eb1a";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "Account1";
            string shareName = "Share1";
            string synchronizationSettingName = "SynchronizationSetting1";
            ResourceIdentifier dataShareSynchronizationSettingResourceId = DataShareSynchronizationSettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareName, synchronizationSettingName);
            DataShareSynchronizationSettingResource dataShareSynchronizationSetting = client.GetDataShareSynchronizationSettingResource(dataShareSynchronizationSettingResourceId);

            // invoke the operation
            ArmOperation<DataShareOperationResult> lro = await dataShareSynchronizationSetting.DeleteAsync(WaitUntil.Completed);
            DataShareOperationResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_SynchronizationSettingsCreate()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/SynchronizationSettings_Create.json
            // this example is just showing the usage of "SynchronizationSettings_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataShareSynchronizationSettingResource created on azure
            // for more information of creating DataShareSynchronizationSettingResource, please refer to the document of DataShareSynchronizationSettingResource
            string subscriptionId = "433a8dfd-e5d5-4e77-ad86-90acdc75eb1a";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "Account1";
            string shareName = "Share1";
            string synchronizationSettingName = "Dataset1";
            ResourceIdentifier dataShareSynchronizationSettingResourceId = DataShareSynchronizationSettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareName, synchronizationSettingName);
            DataShareSynchronizationSettingResource dataShareSynchronizationSetting = client.GetDataShareSynchronizationSettingResource(dataShareSynchronizationSettingResourceId);

            // invoke the operation
            DataShareSynchronizationSettingData data = new ScheduledSynchronizationSetting(DataShareSynchronizationRecurrenceInterval.Day, DateTimeOffset.Parse("2018-11-14T04:47:52.9614956Z"));
            ArmOperation<DataShareSynchronizationSettingResource> lro = await dataShareSynchronizationSetting.UpdateAsync(WaitUntil.Completed, data);
            DataShareSynchronizationSettingResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataShareSynchronizationSettingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}

# visma-raet-ops-teamup-workshop
Repository for use during the Cloud Ops TeamUp workshop/hackathon session.

# WebApp Deployment
to be defined

# SQLDeployment

Azure SQL Server and Azure SQL Database deployment using GitHub Actions.

It uses a YAML pipeline, which is in the /.github/workflows folder.

1. Define your susbscription and resource groups.
2. Deploy your credentials, you can do that by using this command:

Azure CLI Command (Replace server-name, subscription-id and resource-group)
   az ad sp create-for-rbac --name {server-name} --role contributor 
                            --scopes /subscriptions/{subscription-id}/resourceGroups/{resource-group} 
                            --sdk-auth

You will get a Json output similar to this one:

  {
    "clientId": "<GUID>",
    "clientSecret": "<GUID>",
    "subscriptionId": "<GUID>",
    "tenantId": "<GUID>",
    (...)
  }
  
3. Create your secrets in GitHub.

You must have tree secrets specified:

AZURE_SUBSCRIPTION, which contains the name of the susbcription where your resource group is located.
AZURE_RESOURCEGROUP, which contains the name of the resource group where you want to deploy your Azure SQL Server and database.
AZURE_CREDENTIALS, which contains the Json output with the role assignment credentials that provide access to your database.
  
4. Create the file that will deploy your SQL Server and SQL Database.
5. Create the workflow.

Documentation: https://docs.microsoft.com/en-us/azure/azure-sql/database/connect-github-actions-sql-db
               https://docs.microsoft.com/en-us/cli/azure/create-an-azure-service-principal-azure-cli
               https://www.kevinrchant.com/2020/11/23/deploying-to-azure-sql-database-using-github-actions
   

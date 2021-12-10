# VISMA Cloud Operations Workshop
To complete this workshop you need to follow next steps:
- Connect to github website
- Create new repository and copy current repository in your personal profile
- Create app service in Azure
- Link app service to this repository



## Connect to github website

Join to visma-raet organization pressing the button you have received through mail.

<p align="center">
    <image src="image/join-visma-raet.png"/>
</p>

Use you credentials to connect with the organization, in case you don't have it you need to create a new account in www.github.com page.


## Create new repository and copy current repository in your personal profile

To copy the repository from visma-raet organization you need to create a new repository in you personal profile. 
1. In the upper-right corner of any page, use the  drop-down menu, and select New repository.

<p align="center">
    <image src="image/new-repository.png"/>
</p>

2. In the Owner drop-down, select the account you wish to create the repository on.

![Repository account](image/repository-account.png)


3. Type a name for your repository, and an optional description.

![Repository name](image/create-repository-name.png)>

4. Choose private in a repository visibility.

![Repository visibility](image/create-repository-private.png)

5. Continue with Wesite or Terminal section

### Website

6. At the bottom of the resulting Quick Setup page, under "Import code from an old repository", you have to choose import a project to your new repository and click Import code.

![Repository import](image/import-repository.png)

![Repository copy](image/copy-repository.png)

7. Click Create repository.


### Terminal

6. Click Create repository.

7. Open Git Bash.

8. Create a bare clone of the repository.

```
$ git clone --bare https://github.com/exampleuser/old-repository.git
```

9. Mirror-push to the new repository.
```
$ cd old-repository
$ git push --mirror https://github.com/exampleuser/new-repository.git
```
10. Remove the temporary local repository you created earlier.
```
$ cd ..
$ rm -rf old-repository
```


## Create app service in Azure

## Link app service to this repository


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
   

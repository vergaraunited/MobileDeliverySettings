# MobileDeliverySettings
United Mobile Delivery Settings - standardized cross-platform settings library sub module shared amongst UMD Projects.

## Mobile Delivery Manager .Net Core Dockerized

### MobileDeliveryMangerAPI
#### WebSocket API IPad Delivery, Winform Manifest Generator, A/R Notifications.

## NuGet Package References
#### UMDNuGet - Azure Artifact Repository
##### nuget.config file
```xml
<configuration>
  <packageSources>
    <clear />
    <add key="UMDNuget" value="https://pkgs.dev.azure.com/unitedwindowmfg/1e4fcdac-b7c9-4478-823a-109475434848/_packaging/UMDNuget/nuget/v3/index.json" />
  </packageSources>
  <packageSourceCredentials>
    <UMDNuget>
        <add key="Username" value="any" />
        <add key="ClearTextPassword" value="w75dbjeqggfltkt5m65yf3e33fryf2olu22of55jxj4b3nmfkpaa" />
      </UMDNuget>
  </packageSourceCredentials>
</configuration>


```

Package Name            |  Version  |  Description
--------------------    |  -------  |  -----------
MobileDeliveryGeneral   |   1.4.3   |  Mobile Delivery General Code with Symbols

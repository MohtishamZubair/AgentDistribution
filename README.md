# AgentDistribution
Delivery system for agent to delivered the assigned parcels or deliveries, will contains 
 - MVC Web API for back end 
 - for front end Admin angularJS 2 + Typescript 2 (latest)
 
 
When you clone and build it will give this error if using VS2015 community

Error		This project references NuGet package(s) that are missing on this computer. Use NuGet Package Restore to download them.  For more information, see http://go.microsoft.com/fwlink/?LinkID=322105. The missing file is ..\packages\Microsoft.Net.Compilers.1.0.0\build\Microsoft.Net.Compilers.props.	AgentDistribution.API	..\AgentDistribution\src\AgentDistribution.API\AgentDistribution.API.csproj	

Follow the home page of wiki of to resolve nuget package issue for WEB API project (home)[https://github.com/MohtishamZubair/AgentDistribution/wiki]

To Setup only Angular2 in VS2015 wiki is 
https://github.com/MohtishamZubair/AgentDistribution/wiki/Setting-up-AngularJS2-in-VS2015-in-MVC5

# Angular2 Setup only

just download from this release

https://github.com/MohtishamZubair/AgentDistribution/releases/tag/angular2-typescript2--starter

And delete other two projects except AgentDistribution.FrontEnd (contains angular2 + typescript with Bootstrap3.0)
 
# Angular2 + Typescript2 + Bootstrap3

Please download this release

https://github.com/MohtishamZubair/AgentDistribution/releases/tag/bootstrap3


And delete other two projects except AgentDistribution.FrontEnd. Then build and run project as normal web application

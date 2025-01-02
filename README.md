# Frends.Community.GoogleApi
Frends Tasks for Google API

[![Actions Status](https://github.com/CommunityHiQ/Frends.Community.GoogleApi/workflows/PackAndPushAfterMerge/badge.svg)](https://github.com/CommunityHiQ/Frends.Community.GoogleApi/actions)
![MyGet](https://img.shields.io/myget/frends-community/v/Frends.Community.GoogleApi)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

- [Installing](#installing)
- [Tasks](#tasks)
  - [Get Service Account Access Token](#getserviceaccountaccesstoken)
- [Building](#building)
- [License](#license)
- [Contributing](#contributing)
- [Change Log](#change-log)

# Installing
You can install the Task via Frends UI Task View or you can find the NuGet package from the following NuGet feed
https://www.myget.org/F/frends-community/api/v3/index.json and in Gallery view in MyGet https://www.myget.org/feed/frends-community/package/nuget/Frends.Community.GoogleApi

# Tasks

## GetServiceAccountAccessToken

### Task Parameters

### Input

| Property   | Type     | Description                                   | Example                         |
|------------|----------|-----------------------------------------------|---------------------------------|
| SecretJson | string   | Secret JSON Key as string for authentication. | { "SecretKey" : "SecretValue" } |
| Scopes     | string[] | Scopes to which access token can access.      | ["user.profile"]                |

### Result

| Property    | Type   | Description                    | Example               |
| ------------|--------|--------------------------------|-----------------------|
| AccessToken | string | Service accounts access token. | dfdewmfkm�afnlkewmfew |

# Building

Clone a copy of the repo.

`git clone https://github.com/CommunityHiQ/Frends.Community.GoogleApi.git`

Build the project.

`dotnet build`

Run Tests.

`dotnet test`

Create a NuGet package.

`dotnet pack --configuration Release`

# License

This project is licensed under the MIT License - see the LICENSE file for details.

# Contributing
When contributing to this repository, please first discuss the change you wish to make via issue, email, or any other method with the owners of this repository before making a change.

1. Fork the repo on GitHub
2. Clone the project to your own machine
3. Commit changes to your own branch
4. Push your work back up to your fork
5. Submit a Pull request so that we can review your changes

NOTE: Be sure to merge the latest from "upstream" before making a pull request!

# Change Log

| Version | Changes                                                      |
|---------|--------------------------------------------------------------|
| 1.0.0   | Initial implementation of GetServiceAccountAccessToken-Task. |
| 1.1.0   | Added target frameworks net6 & net8. Dependencies updated: System.ComponentModel.Annotations to 5.0.0, Google.Apis.Auth to 1.68.0, NUnit3TestAdapter to 4.6.0, Microsoft.NET.Test.Sdk to 17.12.0 |

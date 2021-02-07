# A-bit-of-everything-template

Plan is to bring a sample app all together into one repo.

# Web API
A web api exposing some sample data in a MS SQL server.
Written in .net core, built into a docker container and hosted on an App Service

# MS SQL database
A database with some simple scheme and sample data

# Infrastructure As Code (IaC)
All the things are IaC

## ARM template
IaC as ARM for those inclined that way

## Terraform template
IaC as Terraform for those inclined that way

# Codespace
All the things are IaC even the dev env which is a Dev Container / Codespace

# DevOps pipelines

* build pipeline for the api
* Infra build pipeline for the ARM 
* Infra build pipeline for the Terraform
* DB scheme deployment pipeline
* App deployment pipeline to the App Service



# References

## Entity framework getting started guide
 * https://docs.microsoft.com/en-us/aspnet/core/data/ef-rp/intro?view=aspnetcore-5.0&tabs=visual-studio-code
 * https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/intro?view=aspnetcore-5.0
 * // Why does it seem lots of the vids want to use full VS? I am trying to use VSCode in Codespace. - https://www.youtube.com/playlist?list=PLdo4fOcmZ0oX7uTkjYwvCJDG2qhcSzwZ6

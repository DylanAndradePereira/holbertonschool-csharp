#!/usr/bin/env bash
dotnet new console -o 2-new_project
dotnet build 2-new_project -nologo
dotnet run --project 2-new_project

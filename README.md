To build / run
-----------

* `dotnet build`
* `dotnet run`
* `dotnet publish` <-- Once you're finally done with it


Install Paket in a project (alternative dependency manager)
------------
* `dotnet new tool-manifest`
* `dotnet tool install paket`
* `dotnet tool restore`
* Add this to .gitignore
    ```
    #Paket dependency manager
    .paket/
    paket-files/
    ```
* Chdir to solution root
* `dn paket init`
* Add reference to whatever package is required
    * `nuget FsHttp`
* Then run
    * dn paket install
* Add reference to the `fsproj` file
    ```
    <ItemGroup>
      <PackageReference Include="FsHttp" Version="0.9" />
    </ItemGroup>
    ```

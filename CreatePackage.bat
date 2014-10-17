::make sure nuget is up to date
nuget Update -self

DEL Genfr.*.nupkg /F /Q

::create the nuget package
.nuget\nuget pack Genfr.Repository.nuspec
.nuget\nuget pack Genfr.EntityFramework.nuspec

echo F | xcopy /Y Genfr.*.nupkg "C:\Users\Jon\Documents\USS Work\LocalNuget\Genfr.*.nupkg"
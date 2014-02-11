System.TypeInitializationException

If you get the following exception in RawBencher on the Telerik benchers: 

An unhandled exception of type 'System.TypeInitializationException' occurred in RawBencher.exe
Additional information: The type initializer for 'Telerik.Bencher.Model.DomainModel' threw an exception.

Then perform the following steps: 

1. Open file OpenAccesNuGet.targets in project Telerik.Bencher.Model and modify 
the UseXmlMapping setting to true. 


<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <!-- Default values of the Project Settings used in the enhancement process -->
  <PropertyGroup>
    <UseXmlMapping Condition="'$(UseXmlMapping)'==''">true</UseXmlMapping>

 
2. Then save the file and clean/recompile solution. 

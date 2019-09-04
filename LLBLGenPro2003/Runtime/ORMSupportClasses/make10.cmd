mkdir DotNET1.0\bin
nmake /nologo /f makefile_10 clean
nmake /nologo /f makefile_10

copy /y DotNet1.0\bin\SD.LLBLGen.Pro.ORMSupportClasses.NET10.dll ..\SqlServerDQE\DotNET1.0\bin


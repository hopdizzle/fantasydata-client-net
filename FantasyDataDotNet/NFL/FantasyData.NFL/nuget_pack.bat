﻿SET ABS_PATH=%~dp0
SET REL_PATH=..\..\nuget\nuget.exe
SET NUGET=%ABS_PATH%%REL_PATH%

SET VERSION=1.0.7.2

start /wait %NUGET% pack FantasyData.NFL.csproj -IncludeReferencedProjects -Version %VERSION%

start /wait %NUGET% setApiKey f618821a-a1a9-4764-b485-b5fcec9c272b

start /wait %NUGET% push FantasyData.NFL.%VERSION%.nupkg
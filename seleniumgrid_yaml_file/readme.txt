Install VNC Viewer https://www.realvnc.com/en/connect/download/viewer/

From powerShell navigate to this folder (CD to the folder)

Run following commands

To bring all containers UP
docker-compose up -d

Open VNC Viewer and conenct to 
localhost:4591
localhost:4592
localhost:4593
localhost:4594

Open Visual Studio and Build the Solution - SeleniumParallelTest.sln
You may have to use "Manage nuget package solution installer" and add NUnit3TestAdapter to the solution.
Open test explorer in Visual Studio and select all 4 tests
Run teh tests
Check in VNC Remote Desktop all test execution

To bring all containers Down
docker-compose down

Check logs
docker-compose logs


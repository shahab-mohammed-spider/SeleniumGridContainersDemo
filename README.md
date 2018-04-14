#SeleniumParallelSample
This is a sample project to showcase how to run parallel test using NUnit 3 and using Docker Containers
The code will send requests to Selenium Hub which will distribute it to the selenium nodes.
Selenium Hub and Selenium Node will be running in Docker Containers in Linux OS

#Instruction to run one Selenium Hub and 4 Seleinum nodes containers and JUnit test
Install VNC Viewer https://www.realvnc.com/en/connect/download/viewer/

From powerShell navigate to the seleniumgrid_yaml_file folder (CD to the folder)

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
Run the tests
Check in VNC Remote Desktop all test execution

To bring all containers Down
docker-compose down

Check logs
docker-compose logs

#Get free certification from Udemy - Dockers and Selenium
https://www.udemy.com/understanding-docker-performing-selenium-automation/learn/v4/overview

##More Information
The complete code base video is available in ExecuteAutomation YouTube channel 

https://www.youtube.com/watch?v=Txhpzx4NkOA

https://www.youtube.com/watch?v=18zrtO1l7EU


##Specflow parallel
https://www.youtube.com/watch?v=cruoQmKLq7Q 

###For more articles
Visit http://www.executeautomation.com


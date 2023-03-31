2nd March 2023
3:05PM
> Started assignment-2 in-class.
>Setting up rhe ASP.NET CORE 3.1(OUT OF SUPPORT)

3:10PM
>in the line of Startup.cs removed the perticular line of code
		>options => options.SignIn.RequireConfirmedAccount = true

3:11PM
>Reviewed the areas folder, Controller, Model, View...

3:14PM
>Edited the welcome page. ::tested::
>Reviewed the route pattern in Startyp.cs

3nd March 2023
3:14PM
>Confirmed the repository and running it for test.

3:35PM
>Created another README.md file from github and pulled it through local computer and tested it.

4:08PM
>went to bootswash.com website to pick a theme for this amazing bookstore.
>picked one and replaced current bootstrap lib to new one. (Morph Theme)
>old-one has new name now for back-up purpose (bootstrap_bk.cs)

9th March 2023
2:32PM
>Trying to add dropdown menu for my bookstore using bootswash. Visiting bootswash website now.

2:51PM
>Trying to add navigation dropdown menu but unfortunatly it is not working gotta need some help i think......

3:09PM
>oh yes!!!!, Got it all right to make it work dropdown menu is now working
>aria-labelledby="navbarDropdownMenuLink" it was this line that needed to be add in html code

24th March 2023
3:19PM
>1.4 Add and Modify Project
>Just Added one new project through solution file and named it as YashsBookStore.DataAccess
>Now going Forward....to commit the changes to github

3:23PM
>Created another Class Library called YashsBookStore.Models

3:25PM
>Created another Class Library called YashsBookStore.Utility

3:32PM
>Follwing the Tutorial deleted the data folder and pasted to the .DataAccess and then ran the command
> dotnet add package Microsoft.EntityFrameworkCore.SqlServer and then deleted the Migration folder.
>Now commiting to the github but before commiting the orignal i will be backing up my this project.

3:50PM
>Installed Microsoft.EntityFrameworkCore.Relational and Core.SqlServer packages and then
>Installed NuGet package:- Identity.EntityFrameworkCore and after that
>Modified the namespace toreflect the project and of course last step before build
>Deleted default Class1.cs file in all projects

30th March 2023
>Okay so as I expected I am facing some errors and since I was unable to resolve it , I will use my backed up files and will try again.
>New Repository Created and Named as YashsBookStore1

2:33PM
>Moved Models in to YashsBookStore.Models(deleted original)
>Deleted the Migration folder and deleted default class files.

3:24PM
>Renamed the folder Model with ViewModels
>Added Reference with DataAccess, and Models

3:26PM
>Was facing error .data which was being removed

3:32PM
>using YashsBookStore.Models.ViewModels; ADDED THIS TO HomeController

3:38PM
>In the Utility project, created a static details class called SD.cs
>Modified the properties of the class
>Added project reference to the main project
>In the DataAccess project added project references to Models and Utility

7:28PM
>Added new Area to Area folder and named it as "Customer" and then changed the routes in startup.cs file
>Moved the HomeController.cs to Customer>Controller folder and deleted data and model folder.
and saved all the files.

7:40PM
>Added new Area called "Admin" in Areas folder
>Done the files moving into here and there.
>Deleted the Controllers Folder.

7:43PM
>Finally. Done with the Part-1 of the Assignment yet not finished. good grief.

7:51PM
>Moving forward to 2.1 Create DataBase

8:07PM(Name of Migration Stamp)
>Successfully Created the database and 
>20230331000214_AddDefaultIdentityMigration

8:15PM
>Updated the database using update-database command
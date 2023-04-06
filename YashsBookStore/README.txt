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

8:44PM
>Exhausting this is taking a lot more than i thought.....
>okay so finally i have ran the command like add-migration and updated the database.
>and now i will commit all the changes to the branch....

>Now i am backing up my project so that i can use it in an emergency........

8:49PM
>Moving forward 2.2 Repository...

10:12PM
>Stuggling with the error and can not solve it.
>will do rest of the work tomorrow...

31st March 2023
9:23AM
>okay I dont know which error was causing this so i am going to restart the 2.2 REPOSITORY PART AGAIN i have deleted the repository folder and now will create again and will see....
>Starting just now...

9:45PM
>Okay succeessfully Created the folder called "Repository" and inside of it created interface and another folder Irepostory and also implemented the code part
>now going to modify the code and will see the changes.

10:09PM
>Modified the Repository.cs file and the IRepository.cs file
>Moving ahead....

10:47PM
>created SP_CALL.CS FILE
>By implemeting the code i am getting error on this line
	public Tuple<IEnumerable<T1>, IEnumerable<T2>> List<T1, T2>(string procedurename, DynamicParameters param = null)
	under the List
	>Now i am going to commit and save the work
	will work on this after words....

12:52PM
>Added IUnitOfWork.cs and UnitOfWork.cs files and implemeted code to both file but while registering them in startyp.cs file facing an error
	>services.AddScoped<IUnitOfWork, UnitOfWork>();
	trying to fix this but before that i will commit the code...

12:58PM
>However, error was resolved after I removed the "I" from the above of UnitOfWrok seems like resolved for now
>let us see if we face the error again in the future....

1:01PM
>Moving forward to 2.3 Category CRUD

1:18PM
>Created new Controller called CategoryController.cs
>implemented the code and facing error under public CategoryController(IUnitOfWork unitOfWork)
>Red line under the CategoryController
>Dont know what it is but facing it error Now i am going to commit and will see if error gets resolved

1:25PM
>As of now I am deleting the controller and going to paste the code of it here so that i can pick that up later
                using Microsoft.AspNetCore.Mvc;
                using System;
                using System.Collections.Generic;
                using System.Linq;
                using System.Threading.Tasks;
                using YashsBookStore.DataAccess.Repository.IRepository;


                namespace YashsBookStore.Areas.Admin.Controllers
                {
                    [Area("Admin")]
                    public class CategoryController : Controller
                    {
                        private readonly IUnitOfWork _unitOfWork;
                        public CategoryController(IUnitOfWork unitOfWork)
                        {
                            _unitOfWork = unitOfWork;
                        }
                        public IActionResult Index()
                        {
                            return View();
                        }

                        // API Call
                        #region API CALLs
                        [HttpGet]
                        public IActionResult GetAll()
                        {
                            // return NotFound();
                            var allObj = _unitOfWork.Category.GetAll();
                            return Json(new { data = allObj });
                        }
                        #endregion
                    }
                }

>Facing error under category controller.....

1:49PM
>Putting all the errors aside Done the part of Category Now removing the code which has the error
    >CategoryController.cs is half finished
    >Startup.cs Removed the I from the UNITOFWORK
>Now Commiting the code to the Repository

6th April 2023
2:05PM
>Started Further working on project today reviewd the errors and finally i solved it
    the error was actually inside of startup.cs file where we have implemented the line for addscope.

>Added the Category page link to the dropdown page.
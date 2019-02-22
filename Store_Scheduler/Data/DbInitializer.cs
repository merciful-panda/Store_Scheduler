using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Scheduler.Data
{
    public class DbInitializer
    {
        public static void Initialize(StoreSchedulerContext context)
        {
            context.Database.EnsureCreated();
            // if already records then skip
            if (context.users.Any())
            { return; }

           /*context.stores.Add(new Models.stores()
            {
                //storeID = 1,
                storeName = "NGS",
                address = "123 address ave",
                city = "Melrose Park",
                state = "IL",
                zipcode = "60160",
                phone = "7082759885"
            });*/

            /*context.sales.Add(new Models.sales()
            {
                storeID = 3,
                laborCost = 100.00,
                revenue = 10000.00,
                date = DateTime.Parse("2005-09-01")
            });*/

            /*context.departments.Add(new Models.departments()
            {
                name = "North Snacks",
                priority = 1,
                openspot = 8,
                status = 1,
                description = "Main place",
                storeID = 1
            });

            context.department_positions.Add(new Models.department_positions()
            {
                //positionID = 1,
                openSpots = 2,
                status = true,
                positionName = "Registers",
                skillLevel = 3,
                skillID = 1,
                departmentID = 1,
                shiftID = 1
            });

            context.shifts.Add(new Models.shifts()
            {
                startTime = DateTime.Parse("2005-09-01"),
                endTime = DateTime.Parse("2005-09-01"),
                assignedBy = 2,
                employeeID = 1,
                weeklyScheduleID = 1
            });

            context.weeklySchedule.Add(new Models.weeklySchedule()
            {
                employeeID = 1,
                date = DateTime.Parse("2005-09-01")
            });

            context.employee_stores.Add(new Models.employee_stores()
            {
                employeeID = 1,
                storeID = 1
            });

            context.employees.Add(new Models.employees()
            {
                employeeID = 1,
                status = true,
                payType = 1,
                userID = 1,
                roleID = 1
            });

            context.employees.Add(new Models.employees()
            {
                employeeID = 2,
                status = true,
                payType = 2,
                userID = 2,
                roleID = 2
            });

            context.roles.Add(new Models.roles()
            {
                //roleID = 1,
                name = "Employee"
            });

            context.roles.Add(new Models.roles()
            {
                //roleID = 2,
                name = "Manager"
            });

            context.employee_skills.Add(new Models.employee_skills()
            {
                //employeeID = 1,
                skillID = 1,
                experience = 3
            });

            context.employee_skills.Add(new Models.employee_skills()
            {
                //employeeID = 2,
                skillID = 2,
                experience = 3
            });

            context.skills.Add(new Models.skills()
            {
               // skillID = 1,
                name = "registers"
            });

            context.skills.Add(new Models.skills()
            {
                //skillID = 2,
                name = "managing"
            });*/

            context.SaveChanges();           
        }

    }
}

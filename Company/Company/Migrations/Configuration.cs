namespace Company.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Company.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Company.Models.CompanyDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Company.Models.CompanyDBContext";
        }

        protected override void Seed(Company.Models.CompanyDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Employees.AddOrUpdate(e => e.Firstname,
                new Employee
                {
                    Firstname = "Florencia",
                    Lastname = "Perez",
                    RegistrationDate = DateTime.Parse("22/02/2022"),
                    DateofBirth = DateTime.Parse("23/05/1995"),
                    Role = "Desarrollo"
                },
                new Employee
                {
                    Firstname = "Nicolas",
                    Lastname = "Diaz",
                    RegistrationDate = DateTime.Parse("26/11/2012"),
                    DateofBirth = DateTime.Parse("05/07/1994"),
                    Role = "Diseño"
                },
                new Employee
                {
                    Firstname = "Carmen",
                    Lastname = "Palermo",
                    RegistrationDate = DateTime.Parse("05/05/2020"),
                    DateofBirth = DateTime.Parse("24/10/1984"),
                    Role = "Estructura"
                },
                new Employee
                {
                    Firstname = "Facundo",
                    Lastname = "Gonzales",
                    RegistrationDate = DateTime.Parse("19/04/2018"),
                    DateofBirth = DateTime.Parse("30/01/1995"),
                    Role = "Desarrollo"
                },
                new Employee
                {
                    Firstname = "Ignacio",
                    Lastname = "Gimenez",
                    RegistrationDate = DateTime.Parse("23/12/2021"),
                    DateofBirth = DateTime.Parse("28/09/1998"),
                    Role = "Datos"
                },
                new Employee
                {
                    Firstname = "Miguel",
                    Lastname = "Gomez",
                    RegistrationDate = DateTime.Parse("15/04/2012"),
                    DateofBirth = DateTime.Parse("23/05/92"),
                    Role = "Estructura"
                },
                new Employee
                {
                    Firstname = "Camila",
                    Lastname = "Mendez",
                    RegistrationDate = DateTime.Parse("26/03/2017"),
                    DateofBirth = DateTime.Parse("14/01/1993"),
                    Role = "Diseño"
                },
                new Employee
                {
                    Firstname = "Federico",
                    Lastname = "Gutierrez",
                    RegistrationDate = DateTime.Parse("24/05/2015"),
                    DateofBirth = DateTime.Parse("12/07/1991"),
                    Role = "Datos"
                }
            );
        }
    }
}

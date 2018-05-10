using Entity.Entities;
using Entity.Entities.Auth;
using Entity.Enums;
using Service;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Entity.EntityFramework
{
    class Initializer : CreateDatabaseIfNotExists<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            #region employees
            var employees = new List<Employee>()
            {
                new Employee()
                {
                    Id = 1,
                    Name = "Andrey",
                    SecondName = "123123"
                },
                new Employee()
                {
                    Id = 2,
                    Name = "Egor",
                    SecondName = "123123"
                }
            };
            #endregion

            #region auth

            #region roles
            var roles = new List<Role>()
            {
                new Role()
                {
                    Id = 1,
                    Name = "Admin"
                },
                new Role()
                {
                    Id = 2,
                    Name = "User"
                }
            };
            context.Roles.AddRange(roles);
            context.SaveChanges();
            #endregion

            #region actors
            var actors = new List<Actor>()
            {
                new Actor()
                {
                    Login = "Andrey",
                    Password= EncryptionService.Encrypt("Andrey17"),
                    Employee = employees[0],
                    RoleId = 1
                },
                new Actor()
                {
                    Login = "Egor123",
                    Password= EncryptionService.Encrypt("Egor1123"),
                    Employee = employees[1],
                    RoleId = 2
                }
            };
            context.Actors.AddRange(actors);
            context.SaveChanges();
            #endregion

            #region permission types
            var permissionTypes = new List<PermissionType>()
            {
                new PermissionType()
                {
                    Id = (Int32)PermissionTypes.Read,
                    Name = PermissionTypes.Read.ToString()
                },
                new PermissionType()
                {
                    Id = (Int32)PermissionTypes.Add,
                    Name = PermissionTypes.Add.ToString()
                },
                new PermissionType()
                {
                    Id = (Int32)PermissionTypes.Delete,
                    Name = PermissionTypes.Delete.ToString()
                }
            };
            context.PermissionTypes.AddRange(permissionTypes);
            context.SaveChanges();
            #endregion

            #region admin unit types
            var adminUnits = new List<AdminUnit>()
            {
                new AdminUnit()
                {
                    Id = (Int32)AdminUnitType.Clients,
                    Name = AdminUnitType.Clients.ToString()
                },
                new AdminUnit()
                {
                    Id = (Int32)AdminUnitType.Employees,
                    Name = AdminUnitType.Employees.ToString()
                },
                new AdminUnit()
                {
                    Id = (Int32)AdminUnitType.Payments,
                    Name = AdminUnitType.Payments.ToString()
                },
                new AdminUnit()
                {
                    Id = (Int32)AdminUnitType.Rooms,
                    Name = AdminUnitType.Rooms.ToString()
                },
            };
            context.AdminUnits.AddRange(adminUnits);
            context.SaveChanges();
            #endregion

            #region permissions
            var permissions = new List<Permission>()
            {
                //admin permissions

                //clients admin unit for admin role
                new Permission()
                {
                    RoleId = 1,
                    PermissionTypeId = (Int32)PermissionTypes.Add,
                    AdminUnitId = (Int32)AdminUnitType.Clients
                },
                new Permission()
                {
                    RoleId = 1,
                    PermissionTypeId = (Int32)PermissionTypes.Delete,
                    AdminUnitId = (Int32)AdminUnitType.Clients
                },
                new Permission()
                {
                    RoleId = 1,
                    PermissionTypeId = (Int32)PermissionTypes.Read,
                    AdminUnitId = (Int32)AdminUnitType.Clients
                },

                //rooms admin unit for admin role
                new Permission()
                {
                    RoleId = 1,
                    PermissionTypeId = (Int32)PermissionTypes.Add,
                    AdminUnitId = (Int32)AdminUnitType.Rooms
                },
                new Permission()
                {
                    RoleId = 1,
                    PermissionTypeId = (Int32)PermissionTypes.Delete,
                    AdminUnitId = (Int32)AdminUnitType.Rooms
                },
                new Permission()
                {
                    RoleId = 1,
                    PermissionTypeId = (Int32)PermissionTypes.Read,
                    AdminUnitId = (Int32)AdminUnitType.Rooms
                },

                //payments admin unit for admin role
                new Permission()
                {
                    RoleId = 1,
                    PermissionTypeId = (Int32)PermissionTypes.Add,
                    AdminUnitId = (Int32)AdminUnitType.Payments
                },
                new Permission()
                {
                    RoleId = 1,
                    PermissionTypeId = (Int32)PermissionTypes.Delete,
                    AdminUnitId = (Int32)AdminUnitType.Payments
                },
                new Permission()
                {
                    RoleId = 1,
                    PermissionTypeId = (Int32)PermissionTypes.Read,
                    AdminUnitId = (Int32)AdminUnitType.Payments
                },

                //Employees admin unit for admin role
                new Permission()
                {
                    RoleId = 1,
                    PermissionTypeId = (Int32)PermissionTypes.Add,
                    AdminUnitId = (Int32)AdminUnitType.Employees
                },
                new Permission()
                {
                    RoleId = 1,
                    PermissionTypeId = (Int32)PermissionTypes.Delete,
                    AdminUnitId = (Int32)AdminUnitType.Employees
                },
                new Permission()
                {
                    RoleId = 1,
                    PermissionTypeId = (Int32)PermissionTypes.Read,
                    AdminUnitId = (Int32)AdminUnitType.Employees
                },
            };
            context.Permissions.AddRange(permissions);
            context.SaveChanges();
            #endregion

            #endregion

            #region Clients
            var clients = new List<Client>()
            {
                new Client()
                {
                    Name = "Andrey",
                    SecondName= "Cheroshey",
                    PassportNumber = "1231241245125",
                    DateOfBirth = new DateTimeOffset()
                },
                new Client()
                {
                    Name = "Egor",
                    SecondName= "Vasilev",
                    PassportNumber = "2343242434",
                    DateOfBirth = new DateTimeOffset()
                }
            };
            context.Clients.AddRange(clients);
            context.SaveChanges();
            #endregion

            #region RoomType

            var roomTypes = new List<RoomType>()
            {
                new RoomType()
                {
                    Id = (Int32)RoomTypes.Lux,
                    Name = RoomTypes.Lux.ToString()
                },
                new RoomType()
                {
                    Id = (Int32)RoomTypes.OneSleep,
                    Name = RoomTypes.OneSleep.ToString()
                },
                new RoomType()
                {
                    Id = (Int32)RoomTypes.TwoSleep,
                    Name = RoomTypes.TwoSleep.ToString()
                }
            };
            context.RoomTypes.AddRange(roomTypes);
            context.SaveChanges();
            #endregion

            #region Room
            var Rooms = new List<Room>()
            {
                new Room()
                {
                    Number = 1,
                    Status="Занята",
                    RoomTypeId = (Int32)RoomTypes.Lux,
                    Capacity = 2

                },
                new Room()
                {
                    Number = 2,
                    Status="Занята",
                    RoomTypeId = (Int32)RoomTypes.OneSleep,
                    Capacity = 3 
                    
                }
            };
            context.Rooms.AddRange(Rooms);
            context.SaveChanges();
            #endregion
        }
    }
}

using DAL.Entities;
using DAL.Entities.Auth;
using DAL.Enums;
using Services;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityFramework
{
    class Initializer : CreateDatabaseIfNotExists<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            #region permission type
            var permissionTypes = new List<PermissionType>()
            {
                new PermissionType()
                {
                    Id = (Int32)Enums.PermissionTypes.Read,
                    Name = Enums.PermissionTypes.Read.ToString()
                },
                new PermissionType()
                {
                    Id = (Int32)Enums.PermissionTypes.Write,
                    Name = Enums.PermissionTypes.Write.ToString()
                }
            };
            context.PermissionTypes.AddRange(permissionTypes);
            context.SaveChanges();

            #endregion

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

            #region Actor
            var Arc = new List<Actor>()
            {
                new Actor()
                {
                    Login = "Andrey",
                    Password= EncryptionService.Encrypt("Andrey17"),
                    Employee = employees[0]
                },
                new Actor()
                {
                    Login = "Egor123",
                    Password= EncryptionService.Encrypt("Egor1123"),
                    Employee = employees[1]
                }
            };
            context.Actors.AddRange(Arc);
            context.SaveChanges();
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

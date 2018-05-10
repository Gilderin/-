using Entity.EntityFramework;
using Entity.Enums;
using Model;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Entity.Service
{
    public static class IdentityService
    {
        public static Int32 AuthenticatedActorId { get; private set; }

        public static void ClaimIdentity(String login, String password)
        {
            var context = new ApplicationDbContext();
            var actor = context.Actors
                .Where(e => e.Login == login)
                .Select(e => new { EncryptedPassword = e.Password, e.Id })
                .SingleOrDefault();

            if (actor == null)
                throw new Exception("Wrong login");

            var verified = EncryptionService.Verify(password, actor.EncryptedPassword);
            if (!verified)
                throw new Exception("Wrong password");

            AuthenticatedActorId = actor.Id;
            return;
        }

        public static Dictionary<String, RightsModel> GetPermissions()
        {
            if (AuthenticatedActorId == 0)
                return null;

            var context = new ApplicationDbContext();
            var permissions = context.Roles
                .Where(e => e.ActorId == AuthenticatedActorId)
                .SelectMany(e => e.Permissions
                    .Select(e1 => new
                    {
                        AdminUnit = e1.AdminUnit.Name,
                        PermissionType = e1.PermissionType.Name
                    }))
                .ToArray();

            var rights = new Dictionary<String, RightsModel>();
            foreach (var adminUnitName in permissions.Select(e => e.AdminUnit))
                rights.Add(adminUnitName, new RightsModel());

            foreach (var item in permissions)
            {
                if (item.PermissionType == PermissionTypes.Read.ToString())
                    rights[item.AdminUnit].CanRead = true;
                if (item.PermissionType == PermissionTypes.Add.ToString())
                    rights[item.AdminUnit].CanAdd = true;
                if (item.PermissionType == PermissionTypes.Delete.ToString())
                    rights[item.AdminUnit].CanDelete = true;
            }
            return rights;
        }
    }
}

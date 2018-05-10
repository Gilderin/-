using Model;

namespace Entity.Service
{
    public static class RightsService
    {
        public static UserRightsModel GetUserRights()
        {
            var rights = new UserRightsModel();
            rights.ClientsRights = new RightsModel()
            {
                CanRead = true,
                CanAdd = true,
                CanDelete  = true
            }; //mock

            return rights;
        }
    }
}

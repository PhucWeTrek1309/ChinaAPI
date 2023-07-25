using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ChinaAPICommon.Untilities
{
    public static class PermissonChecked<T> where T : class
    {
        public static bool HasPermission( ClaimsIdentity identity)
        {
            var claims = identity.Claims;

            var hasPermission = false;

            switch (typeof(T).Name)
            {
                case "AdvertisementPositionDb":
                    hasPermission = claims!.Any(claim => claim.Value == Role.CreateAdvertisementPosition.ToString()) ||
                                    claims!.Any(claim => claim.Value == Role.EditAdvertisementPosition.ToString()) ||
                                    claims!.Any(claim => claim.Value == Role.ViewAdvertisementPosition.ToString()) ||
                                    claims!.Any(claim => claim.Value == Role.DeleteAdvertisementPosition.ToString());
                    break;
                case "AdvertisementsDb":
                    hasPermission = claims!.Any(claim => claim.Value == Role.CreateAdvertisement.ToString()) ||
                                    claims!.Any(claim => claim.Value == Role.EditAdvertisement.ToString()) ||
                                    claims!.Any(claim => claim.Value == Role.ViewAdvertisement.ToString()) ||
                                    claims!.Any(claim => claim.Value == Role.DeleteAdvertisement.ToString());
                    break;
                case "BillDb":
                    hasPermission = claims!.Any(claim => claim.Value == Role.CreateBill.ToString()) ||
                                    claims!.Any(claim => claim.Value == Role.EditBill.ToString()) ||
                                    claims!.Any(claim => claim.Value == Role.ViewBill.ToString()) ||
                                    claims!.Any(claim => claim.Value == Role.DeleteBill.ToString());
                    break;
                case "GroupDb":
                    hasPermission = claims!.Any(claim => claim.Value == Role.CreateGroup.ToString()) ||
                                    claims!.Any(claim => claim.Value == Role.EditGroup.ToString()) ||
                                    claims!.Any(claim => claim.Value == Role.ViewGroup.ToString()) ||
                                    claims!.Any(claim => claim.Value == Role.DeleteGroup.ToString());
                    break;
                case "Item":
                    hasPermission = claims!.Any(claim => claim.Value == Role.CreateItem.ToString()) ||
                                    claims!.Any(claim => claim.Value == Role.EditItem.ToString()) ||
                                    claims!.Any(claim => claim.Value == Role.ViewItem.ToString()) ||
                                    claims!.Any(claim => claim.Value == Role.DeleteItem.ToString());
                    break;
                case "MenuDb":
                    hasPermission = claims!.Any(claim => claim.Value == Role.CreateMenu.ToString()) ||
                                    claims!.Any(claim => claim.Value == Role.EditMenu.ToString()) ||
                                    claims!.Any(claim => claim.Value == Role.ViewMenu.ToString()) ||
                                    claims!.Any(claim => claim.Value == Role.DeleteMenu.ToString());
                    break;
                default:
                    break;
            }

            return hasPermission;
        }
    }
}

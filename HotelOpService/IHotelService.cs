using HotelOpService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace HotelOpService
{
    [ServiceContract]
    public interface IHotelService
    {
        [OperationContract]
        [WebGet(UriTemplate = "MainMenus", ResponseFormat = WebMessageFormat.Json)]
        List<MenuItem> GetMainMenus();

        [OperationContract]
        [WebGet(UriTemplate = "DailyMenus", ResponseFormat = WebMessageFormat.Json)]
        List<DailyMenu> GetDailyMenus();
    }
    
}

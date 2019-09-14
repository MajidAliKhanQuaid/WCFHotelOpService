using HotelOpService.Models;
using System;
using System.Collections.Generic;

namespace HotelOpService
{
    public class HotelService : IHotelService
    {
        public List<DailyMenu> GetDailyMenus()
        {
            List<DailyMenu> dailyMenus = new List<DailyMenu>();
            dailyMenus.Add(new DailyMenu() { Id = 111, Name = "111 - Chiken Cheese Burger", Tags = new string[] { "Chicken", "Cheese", "Juice" }, Price = 1000, Dated = DateTime.Now });
            dailyMenus.Add(new DailyMenu() { Id = 222, Name = "222 - Pasta", Tags = new string[] { "Mint", "Pasta", "Salad" }, Price = 1000, Dated = DateTime.Now });
            dailyMenus.Add(new DailyMenu() { Id = 333, Name = "333 - Beef Biryani", Tags = new string[] { "Beef", "Biryani", "Juice" }, Price = 1000, Dated = DateTime.Now });
            return dailyMenus;
        }

        public List<MenuItem> GetMainMenus()
        {
            List<MenuItem> menuItems = new List<MenuItem>();
            menuItems.Add(new MenuItem() { Id = 444, Name = "Chiken Cheese Burger", Tags = new string[] { "Chicken", "Cheese", "Juice" }, Price = 1000 });
            menuItems.Add(new MenuItem() { Id = 555, Name = "Pasta", Tags = new string[] { "Mint", "Pasta", "Salad" }, Price = 1000 });
            menuItems.Add(new MenuItem() { Id = 666, Name = "Beef Biryani", Tags = new string[] { "Beef", "Biryani", "Juice" }, Price = 1000 });
            return menuItems;
        }
    }
}

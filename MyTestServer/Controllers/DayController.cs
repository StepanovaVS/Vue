using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MyTestServer.Models;

namespace MyTestServer.Controllers
{
    public class DayController : Controller
    {
        public IActionResult Index()
        {
            List<Day> dayList = new List<Day>();
            dayList.Add(new Day() { Time = "7:30", Description = "Подъем" });
            dayList.Add(new Day() { Time = "8:30", Description = "Завтрак" });
            dayList.Add(new Day() { Time = "9:00", Description = "Сборы" });
            dayList.Add(new Day() { Time = "9:50", Description = "Выхожу из дома" });
            dayList.Add(new Day() { Time = "10:26", Description = "Сажусь в автобус" });
            dayList.Add(new Day() { Time = "10:45", Description = "Пересадка" });
            dayList.Add(new Day() { Time = "11:10", Description = "Иду в колледж" });
            dayList.Add(new Day() { Time = "14:50", Description = "Выхожу их колледжа" });
            dayList.Add(new Day() { Time = "15:10", Description = "Сажусь в маршрутку" });
            dayList.Add(new Day() { Time = "15:50", Description = "Пересадка" });
            dayList.Add(new Day() { Time = "16:30", Description = "Иду в магазин" });
            dayList.Add(new Day() { Time = "17:50", Description = "Еду домой" });
            dayList.Add(new Day() { Time = "18:10", Description = "Дома" });
            dayList.Add(new Day() { Time = "18:15", Description = "Кормлю животных" });
            dayList.Add(new Day() { Time = "18:30", Description = "Ем" });
            dayList.Add(new Day() { Time = "19:30", Description = "Долги" });
            dayList.Add(new Day() { Time = "20:50", Description = "Уборка" });
            dayList.Add(new Day() { Time = "21:15", Description = "Учеба" });
            dayList.Add(new Day() { Time = "22:00", Description = "YouTube" });
            dayList.Add(new Day() { Time = "23:00", Description = "Долги" });
            dayList.Add(new Day() { Time = "1:30", Description = "Сон" });
            return View(dayList);
        }
    }
}
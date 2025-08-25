using System;
using System.Diagnostics;

namespace lab_9
{
    public class RoomModel
    {
        private double _area;
        private double _height;
        private int _numberOfWindows;

        private static int _roomCount = 0;

        public static int TotalRoomsCreated
        {
            get { return _roomCount; }
        }

        public double Area { get { return _area; } }
        public double Height { get { return _height; } }
        public int NumberOfWindows { get { return _numberOfWindows; } }
        public string State
        {
            get
            {
                return $"Площа: {_area} м², Висота: {_height} м, К-сть вікон: {_numberOfWindows}";
            }
        }

        // Кімната
        public RoomModel()
        {
            _area = 15.5;
            _height = 2.6;
            _numberOfWindows = 1;

            _roomCount++;
            LogDescription("Створено кімнату за замовчуванням.");
        }

        public RoomModel(double area, double height, int numberOfWindows)
        {
            if (area <= 0) throw new ArgumentException("Площа повинна бути > 0.");
            if (height <= 0) throw new ArgumentException("Висота повинна бути > 0.");
            if (numberOfWindows < 0) throw new ArgumentException("К-сть вікон не може бути < 0.");

            _area = area;
            _height = height;
            _numberOfWindows = numberOfWindows;

            _roomCount++;
            LogDescription("Створено кімнату з параметрами користувача.");
        }

        public double CalculateArea()
        {
            return _area;
        }

        // Обчислення об'єму
        public double CalculateVolume()
        {
            return _area * _height;
        }

        public void LogDescription(string message)
        {
            // Записує дії в програмі в логи
            Debug.WriteLine("--- Log Entry ---");
            Debug.WriteLine(message);
            Debug.WriteLine($"Інформація про об'єкт: {this.State}");
            Debug.WriteLine($"Час створення: {DateTime.Now}");
            Debug.WriteLine("-----------------");
        }
    }
}
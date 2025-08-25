using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_9
{
    public partial class Room : Form
    {
        public Room()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double area = double.Parse(AreaTextBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture);
                double height = double.Parse(HeightTextBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture);
                int windows = int.Parse(windowsTextBox.Text);

                RoomModel room = new RoomModel(area, height, windows);
                double volume = room.CalculateVolume();

                string resultMessage = $"Об'єкт успішно створено!\n\n{room.State}\n\nОб'єм: {volume:F2} м³\n\n" +
                                       $"--- Демонстрація статичного елемента ---\n" +
                                       $"Загалом створено кімнат: {RoomModel.TotalRoomsCreated}";

                MessageBox.Show(resultMessage, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}", "Помилка вводу", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void defaultRoomButton_Click(object sender, EventArgs e)
        {
            try
            {
                RoomModel defaultRoom = new RoomModel();

                double volume = defaultRoom.CalculateVolume();

                string resultMessage = $"Створено кімнату за замовчуванням!\n\n{defaultRoom.State}\n\n" +
                                       $"Об'єм: {volume:F2} м³\n\n" +
                                       $"--- Демонстрація статичного елемента ---\n" +
                                       $"Загалом створено кімнат: {RoomModel.TotalRoomsCreated}";

                MessageBox.Show(resultMessage, "Кімната за замовчуванням", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталася непередбачена помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


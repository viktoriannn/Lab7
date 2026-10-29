using ClassLibrary1;
using System;
using System.Windows.Forms;

namespace ClassForm
{
    public partial class Form1 : Form
    {
        private CMassive obj;
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            dgvArray.AllowUserToAddRows = false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int size = (int)numericSize.Value;
            if (size <= 0) return;

            dgvArray.Columns.Clear();
            for (int i = 0; i < size; i++)
            {
                dgvArray.Columns.Add(i.ToString(), i.ToString());
                dgvArray.Columns[i].Width = 60;
            }
            dgvArray.RowCount = 1;
            for (int i = 0; i < size; i++)
            {
                double randomValue = Math.Round(random.NextDouble() * 20 - 10, 2);
                dgvArray[i, 0].Value = randomValue; 
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int size = dgvArray.ColumnCount;

                if (size == 0)
                {
                    MessageBox.Show("Сначала создайте массив");
                    return;
                }

                obj = new CMassive(size);
                for (int i = 0; i < size; i++)
                {
                    if (dgvArray.Rows[0].Cells[i].Value == null)
                    {
                        MessageBox.Show($"Ячейка {i} не заполнена!");
                        return;
                    }
                    obj[i] = Convert.ToDouble(dgvArray.Rows[0].Cells[i].Value);
                }

                int pos = (int)numericMinIndex.Value;
                if (pos < 0 || pos >= size)
                {
                    MessageBox.Show($"Индекс {pos} вне диапазона массива");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtMinValue.Text))
                {
                    MessageBox.Show("Введите минимальное значение");
                    return;
                }

                double thresh = Convert.ToDouble(txtMinValue.Text);

                int res1 = obj.GetCount();
                int res2 = obj.GetCount(pos);
                int res3 = obj.GetCount(thresh);

                string result = "Результаты:\n\n" +
                               $"Кол-во отрицательных эл-ов: {res1}\n" +
                               $"Кол-во эл-ов после индекса {pos}: {res2}\n" +
                               $"Кол-во отрицательных эл-ов больших {thresh}: {res3}";

                MessageBox.Show(result, "Результат");
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка: введите корректные числа в поля");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}
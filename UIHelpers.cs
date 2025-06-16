using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Курсовая_работа_за_3_семестр
{
    // Вспомогательный класс для заполнения ComboBox
    public class ComboItem<T>
    {
        public T Value { get; set; }
        public string Text { get; set; }

        public override string ToString()
        {
            return Text ?? Value?.ToString();
        }
    }


    public static class UIHelpers
    {
        // Заполняет ComboBox списком ComboItem<T>, отображает Text, сохраняет Value
        public static void FillCombo<T>(ComboBox cb, IEnumerable<T> items, Func<T, string> display)
        {
            var list = items
                .Select(x => new ComboItem<T> { Text = display(x), Value = x })
                .ToList();

            cb.DataSource = list;
            cb.DisplayMember = nameof(ComboItem<T>.Text);
            cb.ValueMember = nameof(ComboItem<T>.Value);
        }

        // Привязывает любой IEnumerable<object> к DataGridView
        public static void BindGrid(DataGridView dgv, IEnumerable<object> data)
        {
            dgv.DataSource = null;
            dgv.DataSource = data.ToList();
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.Tag = data; // сохраняем ссылку на данные контракта в гриде
        }


        // Удобный диалог
        public static void Notify(string text)
        {
            MessageBox.Show(text, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

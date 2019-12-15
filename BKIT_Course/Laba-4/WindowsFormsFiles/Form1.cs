using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;
using Laba_5;


namespace WindowsFormsFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        List<string> list = new List<string>(); /// Список слов

        private void buttonLoadFile_Click(object sender, EventArgs e) /// Кнопка, реализующая чтение из файла
        {
            OpenFileDialog fd = new OpenFileDialog(); /// Ограничение выбора только .txt файлами
            fd.Filter = "текстовые файлы|*.txt";
            
            if (fd.ShowDialog() == DialogResult.OK)
            {
                Stopwatch t = new Stopwatch();
                t.Start();

                
                string text = File.ReadAllText(fd.FileName); ///Чтение файла в виде строки методом ReadAllText

                //Разделительные символы для чтения из файла
                char[] separators = new char[] {' ','.',',','!','?','/','\t','\n'};

                string[] textArray = text.Split(separators);

                foreach (string strTemp in textArray)
                {
                    //Удаление пробелов в начале и конце строки
                    string str = strTemp.Trim();
                    //Добавление строки в список, если строка не содержится в списке
                    if (!list.Contains(str)) list.Add(str);
                }
                
                t.Stop();
                this.textBoxFileReadTime.Text = t.Elapsed.ToString();
                
            }
            else
            {
                MessageBox.Show("Необходимо выбрать файл");
            }
        }

        private void buttonExact_Click(object sender, EventArgs e)
        {
            //Слово для поиска
            string word = this.textBoxFind.Text.Trim();
            
            //Если слово для поиска не пусто
            if (!string.IsNullOrWhiteSpace(word) && list.Count > 0)
            {
                //Слово для поиска в верхнем регистре
                string wordUpper = word.ToUpper();

                //Временные результаты поиска
                List<string> tempList = new List<string>();

                Stopwatch t = new Stopwatch(); /// Вычисление времени поиска
                t.Start(); /// Начало таймера

                foreach (string str in list)
                {
                    if (str.ToUpper().Contains(wordUpper))
                    {
                        tempList.Add(str);
                    }
                }

                t.Stop();
                this.textBoxExactTime.Text = t.Elapsed.ToString();

                this.listBoxResult.BeginUpdate();

                //Очистка списка
                this.listBoxResult.Items.Clear();

                //Вывод результатов поиска 
                foreach (string str in tempList)
                {
                    this.listBoxResult.Items.Add(str);
                }
                this.listBoxResult.EndUpdate();
            }
            else
            {
                MessageBox.Show("Необходимо выбрать файл и ввести слово для поиска");
            }
        }

        private void buttonApprox_Click(object sender, EventArgs e)
        {
            //Слово для поиска
            string word = this.textBoxFind.Text.Trim();
            EditDistance L = new EditDistance();
            string wordUpper = word.ToUpper();

            //Если слово для поиска не пусто
            if (!string.IsNullOrWhiteSpace(word) && list.Count > 0)
            {
                int maxDist;
                if(!int.TryParse(this.textBoxMaxDist.Text.Trim(), out maxDist))
                {
                    MessageBox.Show("Необходимо указать максимальное расстояние");
                    return;
                }

                if (maxDist < 1 || maxDist > 5)
                {
                    MessageBox.Show("Максимальное расстояние должно быть в диапазоне от 1 до 5");
                    return;
                }

                

                Stopwatch timer = new Stopwatch();
                timer.Start();

                int distant, maxDistant;

                if (int.TryParse(textBoxMaxDist.Text, out maxDistant))
                {
                    listBoxResult.BeginUpdate();
                    listBoxResult.Items.Clear();

                    foreach (string str in list)
                    {
                        distant = L.Distance(str.ToUpper(), wordUpper);

                        if (distant <= maxDistant)
                        {
                            listBoxResult.Items.Add(str + "  (расстояние = " + distant.ToString() + ")");
                        }
                    }

                    if (listBoxResult.Items.Count == 0) listBoxResult.Items.Add("Слова не найдены! Введите расстояние Левенштейна бОльшее!");

                    listBoxResult.EndUpdate();
                }
                else
                {
                    textBoxMaxDist.Text = "Целое Число..";
                    listBoxResult.Items.Clear();
                }

                timer.Stop();

                
                

                //Окончание обновления списка результатов
                this.listBoxResult.EndUpdate();
            }
            else
            {
                MessageBox.Show("Необходимо выбрать файл и ввести слово для поиска");
            }

        }

        

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

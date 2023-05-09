using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Laba4
{

    public partial class Form1 : Form
    {
        private FileMethod _dataFile;
        private string _path;           //путь
        private const int n_def = 5;    //количество файлов по умолчанию
        private const int k_def = 1;   //количество файлов дубликатов по умолчанию
        private int _n = n_def;         //количество файлов
        private int _k = k_def;         //количество файлов дубликатов
        public string Path
        {
            get => _path;
            set
            {
                //если значение старое, то выходим
                if (_path == value) return;
                _path = value;
                //обновления формы
                PathChanged.Invoke(this, EventArgs.Empty);
            }
        }
        public event EventHandler PathChanged;

        //количество файлов
        public int N
        {
            get => _n;
            set
            {
                //если значение старое, то выходим
                if (_n == value) return;
                _n = value;
                //обновления формы
                NChanged.Invoke(this, EventArgs.Empty);
            }
        }
        public event EventHandler NChanged;
        public int K
        {
            get => _k;
            set
            {
                //если значение старое, то выходим
                if (_k == value) return;
                _k = value;
                //вызываем событие для обновления формы
                KChanged.Invoke(this, EventArgs.Empty);
            }
        }
        public event EventHandler KChanged;

        //переменные для связывания
        private readonly BindingSource bindingSource1 = new BindingSource();
        private readonly BindingSource bindingSource2 = new BindingSource();
        private readonly BindingSource bindingSource3 = new BindingSource();
        private readonly BindingSource bindingSource4 = new BindingSource();

        public Form1(FileMethod dataFile)
        {
            InitializeComponent();

            //при изменении пути меняются все 4 таблицы и диаграммы
            _dataFile = dataFile;
            PathChanged += UpdateDataGridView1;
            PathChanged += UpdateDataGridView2;
            PathChanged += UpdateDataGridView3;
            PathChanged += UpdateDataGridView4;

            //при изменении количества файлов меняется только вторая таблица и диаграмма
            NChanged += UpdateDataGridView2;
            //при изменении количества файлов дубликатов меняется только третья таблица и диаграмма
            KChanged += UpdateDataGridView3;
            //связываем свойства и конструкции в форме
            pathBox.DataBindings.Add("Text", this, "Path");
            pathBox.DataBindings[0].DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;

            numericNum.DataBindings.Add("Text", this, "N");
            numericNum.DataBindings[0].DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            numericUpDown1.DataBindings.Add("Text", this, "K");
            numericUpDown1.DataBindings[0].DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
        }


        //обновление таблицы и диаграммы 1 задания
        private void UpdateDataGridView1(object sender, EventArgs e)
        {
            //запускаем таймер
            var cnt_time = Stopwatch.StartNew();
            //возвращаем имя файла
            var file = _dataFile.FileBiggest(Path);
            //останавливаем таймер
            cnt_time.Stop();

            //выводим время на форму
            time1.Text = $"Время выполнения: {cnt_time.Elapsed.Seconds}.{cnt_time.Elapsed.Milliseconds} сек.";

            //добавляем имя файла в коллекцию и создаем объект для связывания
            bindingSource1.DataSource = new List<FileModel>() { file };
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        //обновление таблицы и диаграммы для 2 задания
        private void UpdateDataGridView2(object sender, EventArgs e)
        {
            //запускаем таймер
            var cnt_time = Stopwatch.StartNew();
            //возвращаем информацию о файлах
            var files = _dataFile.TopNFileName(Path, N);
            //останавливаем таймер
            cnt_time.Stop();

            //выводим время на форму
            time2.Text = $"Время выполнения: {cnt_time.Elapsed.Seconds}.{cnt_time.Elapsed.Milliseconds} сек.";
            //выводим количество N файлов
            label2.Text = $"Top-{N} файлов по длине";

            //создаем объект для связывания
            bindingSource2.DataSource = files;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.ReadOnly = true;
            dataGridView2.DataSource = bindingSource2;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            chart1.DataSource = files.Select(x => new { Name = x.Name.Length, Size = x.Size });
            chart1.Series["Series1"].ChartType = SeriesChartType.Column;
            //задаем значения по осям x и y
            chart1.Series[0].XValueMember = "Name";
            chart1.Series[0].YValueMembers = "Size";
            //убираем сетку на графике
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            //подписываем значения по опси x под углом
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -60;
            chart1.ChartAreas[0].AxisX.Title = "Длина названий";
            chart1.ChartAreas[0].AxisY.Title = "Размер";
        }

        //обновление таблицы и диаграммы для 3 задания
        private void UpdateDataGridView3(object sender, EventArgs e)
        {
            //запускаем таймер
            var cnt_time = Stopwatch.StartNew();
            //возвращаем информацию о файлах
            var files = _dataFile.FilesPseudo(Path, K);
            //останавливаем таймер
            cnt_time.Stop();

            //количество файлов
            var count = files.Count();

            //выводим время на форму
            time3.Text = $"Время выполнения: {cnt_time.Elapsed.Seconds}.{cnt_time.Elapsed.Milliseconds} сек.";
            bindingSource3.DataSource = files;
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.ReadOnly = true;
            dataGridView3.DataSource = bindingSource3;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            chart2.DataSource = files
               .GroupBy(x => x.Name)
               .Select(x => new { Name = x.Key, Count = x.Count() });
            chart2.Series["Series1"].ChartType = SeriesChartType.Line;

            //задаем значения по осям х и у
            chart2.Series[0].XValueMember = "Name";
            chart2.Series[0].YValueMembers = "Count";
            //убираем подписи на оси х
            chart2.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            //убираем сетку на графике
            chart2.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart2.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            //подписываем ось Y
            chart2.ChartAreas[0].AxisY.Title = "Число";
        }

        //обновление таблицы и диаграммы для 4 задания
        private void UpdateDataGridView4(object sender, EventArgs e)
        {
            //запускаем таймер
            var cnt_time = Stopwatch.StartNew();
            //возвращаем информацию о файлах
            var files = _dataFile.SubfolderSize(Path).OrderBy(x => x.Name);
            //останавливаем таймер
            cnt_time.Stop();

            //выводим время в форму
            time4.Text = $"Время выполнения: {cnt_time.Elapsed.Seconds}.{cnt_time.Elapsed.Milliseconds} сек.";

            //количетсво файлов
            var count = files.Count();
            filesColNum.Text = count.ToString();

            bindingSource4.DataSource = files.Select(x => new { x.Name, x.Size });
            dataGridView4.AllowUserToAddRows = false;
            dataGridView4.ReadOnly = true;
            dataGridView4.DataSource = bindingSource4;
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            chart3.DataSource = files.GroupBy(x => x.Size).Select(x => new { Size = x.Key, Count = x.Count() });
            //отключаем вывод названия на графике
            chart3.Series["Series1"]["PieLabelStyle"] = "Disabled";

            //задаем значения по осям x и y
            chart3.Series[0].XValueMember = "Size";
            chart3.Series[0].YValueMembers = "Count";
        }


        //смена на LINQ
        private void linqUp_CheckedChanged(object sender, EventArgs e)
        {
            _dataFile = new DataFileLinq();

            UpdateDataGridView1(sender, e);
            UpdateDataGridView2(sender, e);
            UpdateDataGridView3(sender, e);
            UpdateDataGridView4(sender, e);
        }

        //смена без LINQ
        private void linqDown_CheckedChanged(object sender, EventArgs e)
        {
            _dataFile = new DataFileNoLinq();

            UpdateDataGridView1(sender, e);
            UpdateDataGridView2(sender, e);
            UpdateDataGridView3(sender, e);
            UpdateDataGridView4(sender, e);
        }
    }

    //класс для хранения файла
    public class FileModel
    {
        //имя
        public string Name { get; set; } = "File not found";
        //расширение
        public string Extension { get; set; }
        //размер
        public long Size { get; set; }
    }
    //класс для хранения файла
    public class FileModelPsedo
    {
        //имя
        public string Name { get; set; } = "File not found";
        //расширение
        public string Extension { get; set; }
        //размер
        public long Size { get; set; }
        //имя
        public string NamePsedo { get; set; } = "File not found";
        //расширение
        public string ExtensionPsedo { get; set; }
        //размер
        public long SizePsedo { get; set; }
    }
    //интерфейс с главными методами
    public interface FileMethod
    {
        //самый большой файл
        FileModel FileBiggest(string path);

        //топ-N файлов по длине названия
        IEnumerable<FileModel> TopNFileName(string path, int n);

        //файлы-псевдодубликаты
        IEnumerable<FileModelPsedo> FilesPseudo(string path, int k);

        //распределение вложенных папок по размеру
        IEnumerable<FileModel> SubfolderSize(string path);
    }
    //реализация с использованием LINQ
    public class DataFileLinq : FileMethod
    {
        //самый большой файл
        public FileModel FileBiggest(string path)
        {
            //если такого пути не существует, возвращаем пустой файл
            if (!Directory.Exists(path))
                return new FileModel();
            //заходим в папку
            var startFolder = new DirectoryInfo(path);
            try
            {
                //все файлы из всех подкаталогов
                var files = startFolder.GetFiles("*", SearchOption.AllDirectories);
                return files.OrderByDescending(x => x.Length)
                    .Select(file => new FileModel { Name = file.Name, Extension = file.Extension, Size = file.Length })
                    .First();
            }
            catch (UnauthorizedAccessException)
            {
                //если ошибка, то возвращаем пустой файл
                return new FileModel { Name = "Reading system folder" };
            }
        }
        //топ-N файлов по длине имени
        public IEnumerable<FileModel> TopNFileName(string path, int n)
        {
            //если такого пути не существует, возвращаем пустой файл
            if (!Directory.Exists(path))
                return new List<FileModel>();
            //заходим в папку
            var startFolder = new DirectoryInfo(path);
            try
            {
                var files = startFolder.GetFiles("*", SearchOption.AllDirectories);
                //сортируем по длине имени, выбираем n файлов
                return files.OrderByDescending(x => x.Name.Length)
                    .Select(file => new FileModel { Name = file.Name, Extension = file.Extension, Size = file.Length })
                    .Take(n);
            }
            catch (UnauthorizedAccessException)
            {
                //если ошибка, то возвращаем пустой файл
                return new List<FileModel>();
            }
        }

        //файлы-псевдодубликаты
        public IEnumerable<FileModelPsedo> FilesPseudo(string path, int k)
        {
            if (!Directory.Exists(path))
                return new List<FileModelPsedo>();
            var startFolder = new DirectoryInfo(path);
            try
            {
                //файлы с одинаковым названием, но разным размером
                var files = from a in startFolder.GetFiles("*", SearchOption.AllDirectories)
                            join e in startFolder.GetFiles("*", SearchOption.AllDirectories)
                            on Path.GetFileNameWithoutExtension(a.Name) equals Path.GetFileNameWithoutExtension(e.Name)
                            where a.Length != e.Length
                            select new FileModelPsedo { Name = a.Name, Extension = a.Extension, Size = a.Length, NamePsedo = e.Name, ExtensionPsedo = e.Extension, SizePsedo = e.Length };
                //файлы с одинаковым размером, но разным именем
                var files1 = from a in startFolder.GetFiles("*", SearchOption.AllDirectories)
                             join e in startFolder.GetFiles("*", SearchOption.AllDirectories) on a.Length equals e.Length
                             where Path.GetFileNameWithoutExtension(a.Name) != Path.GetFileNameWithoutExtension(e.Name)
                             select new FileModelPsedo { Name = a.Name, Extension = a.Extension, Size = a.Length, NamePsedo = e.Name, ExtensionPsedo = e.Extension, SizePsedo = e.Length };
                //файлы с одинаковым названием и размером
                var duplicate = from a in startFolder.GetFiles("*", SearchOption.AllDirectories)
                                join e in startFolder.GetFiles("*", SearchOption.AllDirectories) on a.Length equals e.Length
                                where Path.GetFileNameWithoutExtension(a.Name) == Path.GetFileNameWithoutExtension(e.Name)
                                select new FileModelPsedo { Name = a.Name, Extension = a.Extension, Size = a.Length, NamePsedo = e.Name, ExtensionPsedo = e.Extension, SizePsedo = e.Length };
                return files.Union(files1).Except(duplicate).Distinct().Take(k);
            }
            catch (UnauthorizedAccessException)
            {
                //если ошибка, то возвращаем пустой файл
                return new List<FileModelPsedo>();
            }
        }

        //распределение вложенных папок по размеру
        public IEnumerable<FileModel> SubfolderSize(string path)
        {
            //если такого пути не существует, возвращаем пустой файл
            if (!Directory.Exists(path))
                return new List<FileModel>();
            var startFolder = new DirectoryInfo(path);
            try
            {
                return startFolder.GetDirectories("*", SearchOption.AllDirectories).OrderBy(x => x.Name)
                    .Select(x => new FileModel
                    {
                        Name = x.Name,
                        Size = directorySize(x)
                    });
            }
            catch (UnauthorizedAccessException)
            {
                //если ошибка, то возвращаем пустой файл
                return new List<FileModel>();
            }
        }
        //размер папки
        public static long directorySize(DirectoryInfo d)
        {
            var totalSize = d.EnumerateFiles().Sum(file => file.Length);
            totalSize += d.EnumerateDirectories().Sum(dir => directorySize(dir));
            return (totalSize);
        }

    }

    //реализация без использования LINQ
    public class DataFileNoLinq : FileMethod
    {
        //самый большой файл
        public FileModel FileBiggest(string path)
        {
            //если такого пути не существует, возвращаем пустой файл
            if (!Directory.Exists(path))
                return new FileModel();
            var startFolder = new DirectoryInfo(path);

            try
            {
                var files = startFolder.GetFiles("*", SearchOption.AllDirectories);

                //значение максимальный размер
                long max = 0;
                var resFile = new FileModel();

                //проходим по всем файлам и ищем самый большой
                foreach (var file in files)
                {
                    if (file.Length > max)
                    {
                        max = file.Length;
                        resFile.Name = file.Name;
                        resFile.Extension = file.Extension;
                        resFile.Size = file.Length;
                    }
                }

                return resFile;
            }
            catch (UnauthorizedAccessException)
            {
                //если ошибка, то возвращаем пустой файл
                return new FileModel { Name = "Reading system folder" };
            }
        }

        //топ-N файлов по длине имени
        public IEnumerable<FileModel> TopNFileName(string path, int n)
        {
            //если такого пути не существует, возвращаем пустой файл
            if (!Directory.Exists(path))
                return new List<FileModel>();
            var startFolder = new DirectoryInfo(path);
            var resFiles = new List<FileModel>();

            try
            {
                var files = startFolder.GetFiles("*", SearchOption.AllDirectories);
                //сортируем файлы по длине имени
                SortFiles(files);

                //проходим по всем найденным файлам
                foreach (var file in files)
                {
                    //добавляем файл в список
                    var fileModel = new FileModel()
                    {
                        Name = file.Name,
                        Extension = file.Extension,
                        Size = file.Length
                    };
                    resFiles.Add(fileModel);

                    //если нашли N файлов, выходим
                    if (--n == 0)
                        return resFiles;
                }
                return resFiles;
            }
            catch (UnauthorizedAccessException)
            {
                //если ошибка, то возвращаем пустой файл
                return new List<FileModel>();
            }
        }

        //сортировка по длине файла
        private static void SortFiles(FileInfo[] files)
        {
            for (int i = 0; i < files.Length - 1; i++)
            {
                for (int j = i; j < files.Length; j++)
                {
                    if (files[j].Name.Length > files[i].Name.Length)
                    {
                        (files[j], files[i]) = (files[i], files[j]);
                    }
                }
            }
        }

        //файлы-псевдодубликаты
        public IEnumerable<FileModelPsedo> FilesPseudo(string path, int k)
        {
            //если такого пути не существует, возвращаем пустой файл
            if (!Directory.Exists(path))
                return new List<FileModelPsedo>();
            var startFolder = new DirectoryInfo(path);
            var resFiles = new List<FileModelPsedo>();
            List<string> count = new List<string>();
            try
            {
                var files = startFolder.GetFiles("*", SearchOption.AllDirectories);

                for (int i = 0; i < files.Length - 1; i++)
                {
                    for (int j = i; j < files.Length; j++)
                    {
                        //смотрим файлы с одинаковым именем или длиной
                        if (((Path.GetFileNameWithoutExtension(files[i].Name) == Path.GetFileNameWithoutExtension(files[j].Name)) || (files[j].Length == files[i].Length)) && !((Path.GetFileNameWithoutExtension(files[i].Name) == Path.GetFileNameWithoutExtension(files[j].Name)) && (files[j].Length == files[i].Length)))
                        {
                            //если с таким i нет файла, то добавляем
                            if ((!count.Contains(i + "" + j)) || (!count.Contains(j + "" + i)))
                            {
                                count.Add(i + "" + j);
                                count.Add(j + "" + i);
                                resFiles.Add(
                                new FileModelPsedo()
                                {
                                    Name = files[i].Name,
                                    Extension = files[i].Extension,
                                    Size = files[i].Length,
                                    NamePsedo = files[j].Name,
                                    ExtensionPsedo = files[j].Extension,
                                    SizePsedo = files[j].Length
                                });
                                //если нашли N файлов, выходим
                                if (--k == 0)
                                    return resFiles;
                            }


                        }
                    }
                }
                return resFiles;
            }
            catch (UnauthorizedAccessException)
            {
                return new List<FileModelPsedo>();
            }
        }

        //распределение вложенных папок по размеру
        public IEnumerable<FileModel> SubfolderSize(string path)
        {
            //если такого пути не существует, возвращаем пустой файл
            if (!Directory.Exists(path))
                return new List<FileModel>();

           try
            {
                var dir = new DirectoryInfo(path).GetDirectories("*", SearchOption.AllDirectories);
                var resFiles = new List<FileModel>();
                foreach (var folder in dir)
                {
                    resFiles.Add(new FileModel
                    {
                        Name = folder.Name,
                        Size = DirSize(folder)
                    });
                }
                return resFiles;
            }
            catch (UnauthorizedAccessException)
            {
                //если ошибка, то возвращаем пустой файл
                return new List<FileModel>();
            }
        }
        //размер папки
        public static long DirSize(DirectoryInfo d)
        {
            long Size = 0;
            // Add file sizes.
            var fis = d.EnumerateFiles();
            foreach (FileInfo fi in fis)
            {
                Size += fi.Length;
            }
            // Add subdirectory sizes.
            var dis = d.EnumerateDirectories();
            foreach (DirectoryInfo di in dis)
            {
                Size += DirSize(di);
            }
            return (Size);
        }


    }
}

using System.Security.Cryptography;

namespace WinFormsAppSystProgr_5_1_240519
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartSettings();
            listViewSource.Columns.Add("Name", 200);
            listViewSource.Columns.Add("Size", 100);
            listViewSource.Columns.Add("Type", 50);
            listViewSource.Columns.Add("Is unique", 50);

            listViewReceiver.Columns.Add("Name", 200);
            listViewReceiver.Columns.Add("Size", 100);
            listViewReceiver.Columns.Add("Type", 50);
            listViewReceiver.Columns.Add("Is unique", 50);
        }
        private CancellationTokenSource cts = new CancellationTokenSource();
        private List<FileInfo> uniqueFilesSource = new List<FileInfo>();
        public void StartSettings()
        {


            listBoxReport.Items.Clear();
            labelSource.Text = "";
            labelReceiver.Text = "";

            buttonShowFiles.Visible = false;
            buttonTransferFiles.Visible = false;
            buttonCancel.Visible = false;
            buttonClear.Visible = false;

            pictureBoxReceiver.Visible = false;
            pictureBoxSource.Visible = false;


            listViewReceiver.Visible = false;
            listViewSource.Visible = false;


            labelMovedFiles.Visible = false;
            listBoxReport.Visible = false;

        }
        private void buttonSource_Click(object sender, EventArgs e)
        {
            using var folderDialog = new FolderBrowserDialog();

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = folderDialog.SelectedPath;
                labelSource.Text = selectedPath;

                buttonTransferFiles.Visible = false;
                buttonCancel.Visible = false;
                buttonClear.Visible = false;

                pictureBoxReceiver.Visible = false;
                pictureBoxSource.Visible = false;


                listViewReceiver.Visible = false;
                listViewSource.Visible = false;


                labelMovedFiles.Visible = false;
                listBoxReport.Visible = false;

                if (labelSource.Text.Length > 0 && labelReceiver.Text.Length > 0)
                {
                    if (labelSource.Text == labelReceiver.Text)
                    {
                        MessageBox.Show("Please choose two different folders", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    buttonShowFiles.Visible = true;
                    uniqueFilesSource.Clear();
                }

            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            using var folderDialog = new FolderBrowserDialog();

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                listViewReceiver.Items.Clear();
                string selectedPath = folderDialog.SelectedPath;
                labelReceiver.Text = selectedPath;
                buttonTransferFiles.Visible = false;
                buttonCancel.Visible = false;
                buttonClear.Visible = false;

                pictureBoxReceiver.Visible = false;
                pictureBoxSource.Visible = false;


                listViewReceiver.Visible = false;
                listViewSource.Visible = false;


                labelMovedFiles.Visible = false;
                listBoxReport.Visible = false;
                if (labelSource.Text.Length > 0 && labelReceiver.Text.Length > 0)
                {
                    if (labelSource.Text == labelReceiver.Text)
                    {
                        MessageBox.Show("Please choose two different folders", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    buttonShowFiles.Visible = true;
                }

            }
        }

        private async void ShowFiles()
        {
            Invoke(new Action(() => listViewSource.Items.Clear()));
            Invoke(new Action(() => listViewReceiver.Items.Clear()));
            Invoke(new Action(() => buttonShowFiles.Visible = false));
            Invoke(new Action(() => pictureBoxSource.Visible = true));
            Invoke(new Action(() => pictureBoxReceiver.Visible = true));



            Task task1 = Task.Run(() => DisplayFolderContents(labelSource.Text, listViewSource, 0, cts.Token), cts.Token);
            Task task2 = Task.Run(() => DisplayFolderContents(labelReceiver.Text, listViewReceiver, 1, cts.Token), cts.Token);

            List<Task> runningTasks = [task1, task2];
            await Task.WhenAll(runningTasks);
            Invoke(new Action(() => buttonTransferFiles.Visible = true));
            Invoke(new Action(() => buttonClear.Visible = true));



        }
        private async void buttonShowFiles_Click(object sender, EventArgs e)
        {
            ShowFiles();
        }
        private void DisplayFolderContents(string path, ListView listView, int number, CancellationToken token)
        {


            Invoke(new Action(() => listView.Items.Clear()));
            var directoryInfo = new DirectoryInfo(path);
            var fileDictionary = new Dictionary<string, List<FileInfo>>();
            List<FileInfo> uniqFiles = new List<FileInfo>();
            foreach (var file in directoryInfo.GetFiles())
            {
                if (token.IsCancellationRequested)
                {
                    return;
                }
                string fileKey = GenerateFileKey(file);
                if (!fileDictionary.ContainsKey(fileKey))
                {
                    fileDictionary[fileKey] = new List<FileInfo>();
                }
                fileDictionary[fileKey].Add(file);
            }
            var uniqueFiles = new List<FileInfo>();
            foreach (var fileGroup in fileDictionary.Values)
            {
                bool isUnique = fileGroup.Count == 1;
                foreach (var file in fileGroup)
                {
                    if (token.IsCancellationRequested)
                    {
                        return;
                    }
                    var listViewItem = new ListViewItem(file.Name);
                    listViewItem.SubItems.Add(file.Length.ToString());
                    listViewItem.SubItems.Add(file.Extension);
                    listViewItem.SubItems.Add(isUnique ? "Yes" : "No");
                    if (isUnique)
                    {
                        uniqueFiles.Add(file);
                    }
                    Invoke(new Action(() => listView.Items.Add(listViewItem)));

                }

            }
            Thread.Sleep(1500);
            if (number == 0)
            {
                Invoke(new Action(() => listViewSource.Visible = true));
                Invoke(new Action(() => pictureBoxSource.Visible = false));
                uniqueFilesSource = uniqueFiles;

                //передати л≥ст ун≥кальних файл≥в у глобальну зм≥нну-член класу
            }
            else
            {
                Invoke(new Action(() => listViewReceiver.Visible = true));
                Invoke(new Action(() => pictureBoxReceiver.Visible = false));
            }
            //foreach (var dir in directoryInfo.GetDirectories())
            //{
            //    var listViewItem = new ListViewItem(dir.Name);
            //    listViewItem.SubItems.Add(""); // ѕапки не мають розм≥ру
            //    listViewItem.SubItems.Add("Folder");
            //    listViewItem.SubItems.Add(dir.LastWriteTime.ToString());

            //    listView.Items.Add(listViewItem);
            //}
        }
        private string GenerateFileKey(FileInfo file)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = file.OpenRead())
                {
                    var hash = md5.ComputeHash(stream);
                    return Convert.ToBase64String(hash) + file.Length + file.Extension;
                }
            }
        }
        private void buttonTransferFiles_Click(object sender, EventArgs e)
        {
            if (uniqueFilesSource.Count == 0)
            {
                MessageBox.Show("There are no unique files in the source folder", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            listViewSource.Visible = false;
            listViewSource.Visible = false;
            Task task1 = Task.Run(() => Transfer(cts.Token), cts.Token);
        }
        private void Transfer(CancellationToken token)
        {

            Invoke(new Action(() => labelMovedFiles.Visible = true));
            Invoke(new Action(() => listBoxReport.Visible = true));
            Invoke(new Action(() => listBoxReport.Items.Clear()));




            int number = 0;
            foreach (var file in uniqueFilesSource)
            {
                if (token.IsCancellationRequested)
                {
                    return;
                }

                string destinationPath = Path.Combine(labelReceiver.Text, file.Name);
                if (File.Exists(destinationPath))
                {
                    var result = MessageBox.Show($"File {file.Name} already exists in the destination folder. Do you want to overwrite it?", "File Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        file.CopyTo(destinationPath, true);
                        file.Delete();
                        number++;
                        Invoke(new Action(() => listBoxReport.Items.Add($"{number}) {file.Name}")));



                    }
                }
                else
                {
                    file.MoveTo(destinationPath);
                    number++;
                    Invoke(new Action(() => listBoxReport.Items.Add($"{number}) {file.Name}")));

                }

            }
            ShowFiles();
            Invoke(new Action(() => listBoxReport.Items.Add("----------")));
            Invoke(new Action(() => listBoxReport.Items.Add($"Total files moved: {number}")));
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            cts.Cancel();
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            StartSettings();
        }
    }
}

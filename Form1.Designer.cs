namespace WinFormsAppSystProgr_5_1_240519
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            labelSource = new Label();
            label1 = new Label();
            label2 = new Label();
            buttonSource = new Button();
            labelReceiver = new Label();
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonShowFiles = new Button();
            buttonTransferFiles = new Button();
            buttonCancel = new Button();
            buttonClear = new Button();
            listBoxReport = new ListBox();
            panel1 = new Panel();
            splitContainer1 = new SplitContainer();
            listViewSource = new ListView();
            pictureBoxSource = new PictureBox();
            listViewReceiver = new ListView();
            pictureBoxReceiver = new PictureBox();
            labelMovedFiles = new Label();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxReceiver).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(labelSource, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(buttonSource, 0, 1);
            tableLayoutPanel1.Controls.Add(labelReceiver, 1, 2);
            tableLayoutPanel1.Controls.Add(button1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(874, 123);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // labelSource
            // 
            labelSource.AutoSize = true;
            labelSource.Dock = DockStyle.Left;
            labelSource.Location = new Point(13, 78);
            labelSource.Name = "labelSource";
            labelSource.Size = new Size(0, 35);
            labelSource.TabIndex = 3;
            labelSource.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(13, 10);
            label1.Name = "label1";
            label1.Size = new Size(421, 34);
            label1.TabIndex = 0;
            label1.Text = "Select the source folder";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(440, 10);
            label2.Name = "label2";
            label2.Size = new Size(421, 34);
            label2.TabIndex = 1;
            label2.Text = "Select the receiving folder";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonSource
            // 
            buttonSource.BackColor = Color.FromArgb(54, 47, 117);
            buttonSource.Dock = DockStyle.Left;
            buttonSource.FlatStyle = FlatStyle.Flat;
            buttonSource.ForeColor = Color.White;
            buttonSource.Location = new Point(13, 47);
            buttonSource.Name = "buttonSource";
            buttonSource.Size = new Size(75, 28);
            buttonSource.TabIndex = 2;
            buttonSource.Text = "Browse";
            buttonSource.UseVisualStyleBackColor = false;
            buttonSource.Click += buttonSource_Click;
            // 
            // labelReceiver
            // 
            labelReceiver.AutoSize = true;
            labelReceiver.Dock = DockStyle.Left;
            labelReceiver.Location = new Point(440, 78);
            labelReceiver.Name = "labelReceiver";
            labelReceiver.Size = new Size(0, 35);
            labelReceiver.TabIndex = 4;
            labelReceiver.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(54, 47, 117);
            button1.Dock = DockStyle.Left;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(440, 47);
            button1.Name = "button1";
            button1.Size = new Size(75, 28);
            button1.TabIndex = 5;
            button1.Text = "Browse";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(buttonShowFiles);
            flowLayoutPanel1.Controls.Add(buttonTransferFiles);
            flowLayoutPanel1.Controls.Add(buttonCancel);
            flowLayoutPanel1.Controls.Add(buttonClear);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 123);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(874, 52);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonShowFiles
            // 
            buttonShowFiles.BackColor = Color.FromArgb(54, 47, 117);
            buttonShowFiles.FlatStyle = FlatStyle.Flat;
            buttonShowFiles.ForeColor = Color.White;
            buttonShowFiles.Location = new Point(3, 3);
            buttonShowFiles.Name = "buttonShowFiles";
            buttonShowFiles.Padding = new Padding(10);
            buttonShowFiles.Size = new Size(189, 43);
            buttonShowFiles.TabIndex = 0;
            buttonShowFiles.Text = "Show files";
            buttonShowFiles.UseVisualStyleBackColor = false;
            buttonShowFiles.Visible = false;
            buttonShowFiles.Click += buttonShowFiles_Click;
            // 
            // buttonTransferFiles
            // 
            buttonTransferFiles.BackColor = Color.FromArgb(54, 47, 117);
            buttonTransferFiles.FlatStyle = FlatStyle.Flat;
            buttonTransferFiles.ForeColor = Color.White;
            buttonTransferFiles.Location = new Point(198, 3);
            buttonTransferFiles.Name = "buttonTransferFiles";
            buttonTransferFiles.Padding = new Padding(10);
            buttonTransferFiles.Size = new Size(180, 43);
            buttonTransferFiles.TabIndex = 1;
            buttonTransferFiles.Text = "Transfer unique files";
            buttonTransferFiles.UseVisualStyleBackColor = false;
            buttonTransferFiles.Visible = false;
            buttonTransferFiles.Click += buttonTransferFiles_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.FromArgb(54, 47, 117);
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(384, 3);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Padding = new Padding(10);
            buttonCancel.Size = new Size(179, 43);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Visible = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.FromArgb(54, 47, 117);
            buttonClear.FlatStyle = FlatStyle.Flat;
            buttonClear.ForeColor = Color.White;
            buttonClear.Location = new Point(569, 3);
            buttonClear.Name = "buttonClear";
            buttonClear.Padding = new Padding(10);
            buttonClear.Size = new Size(193, 43);
            buttonClear.TabIndex = 3;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Visible = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // listBoxReport
            // 
            listBoxReport.Dock = DockStyle.Bottom;
            listBoxReport.ForeColor = Color.FromArgb(54, 47, 117);
            listBoxReport.FormattingEnabled = true;
            listBoxReport.ItemHeight = 15;
            listBoxReport.Location = new Point(0, 436);
            listBoxReport.Name = "listBoxReport";
            listBoxReport.Size = new Size(874, 214);
            listBoxReport.TabIndex = 3;
            listBoxReport.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(splitContainer1);
            panel1.Controls.Add(labelMovedFiles);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 175);
            panel1.Name = "panel1";
            panel1.Size = new Size(874, 261);
            panel1.TabIndex = 4;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(listViewSource);
            splitContainer1.Panel1.Controls.Add(pictureBoxSource);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(listViewReceiver);
            splitContainer1.Panel2.Controls.Add(pictureBoxReceiver);
            splitContainer1.Size = new Size(874, 246);
            splitContainer1.SplitterDistance = 436;
            splitContainer1.TabIndex = 1;
            // 
            // listViewSource
            // 
            listViewSource.Dock = DockStyle.Fill;
            listViewSource.ForeColor = Color.FromArgb(54, 47, 117);
            listViewSource.Location = new Point(0, 0);
            listViewSource.Name = "listViewSource";
            listViewSource.Size = new Size(436, 246);
            listViewSource.TabIndex = 1;
            listViewSource.UseCompatibleStateImageBehavior = false;
            listViewSource.View = View.Details;
            listViewSource.Visible = false;
            // 
            // pictureBoxSource
            // 
            pictureBoxSource.BackColor = Color.White;
            pictureBoxSource.Dock = DockStyle.Fill;
            pictureBoxSource.Image = Res.processing;
            pictureBoxSource.Location = new Point(0, 0);
            pictureBoxSource.Name = "pictureBoxSource";
            pictureBoxSource.Size = new Size(436, 246);
            pictureBoxSource.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSource.TabIndex = 0;
            pictureBoxSource.TabStop = false;
            pictureBoxSource.Visible = false;
            // 
            // listViewReceiver
            // 
            listViewReceiver.Dock = DockStyle.Fill;
            listViewReceiver.ForeColor = Color.FromArgb(54, 47, 117);
            listViewReceiver.Location = new Point(0, 0);
            listViewReceiver.MinimumSize = new Size(434, 321);
            listViewReceiver.Name = "listViewReceiver";
            listViewReceiver.Size = new Size(434, 321);
            listViewReceiver.TabIndex = 2;
            listViewReceiver.UseCompatibleStateImageBehavior = false;
            listViewReceiver.View = View.Details;
            listViewReceiver.Visible = false;
            // 
            // pictureBoxReceiver
            // 
            pictureBoxReceiver.BackColor = Color.White;
            pictureBoxReceiver.Dock = DockStyle.Fill;
            pictureBoxReceiver.Image = Res.processing;
            pictureBoxReceiver.Location = new Point(0, 0);
            pictureBoxReceiver.Name = "pictureBoxReceiver";
            pictureBoxReceiver.Size = new Size(434, 246);
            pictureBoxReceiver.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxReceiver.TabIndex = 1;
            pictureBoxReceiver.TabStop = false;
            pictureBoxReceiver.Visible = false;
            // 
            // labelMovedFiles
            // 
            labelMovedFiles.AutoSize = true;
            labelMovedFiles.Dock = DockStyle.Bottom;
            labelMovedFiles.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelMovedFiles.Location = new Point(0, 246);
            labelMovedFiles.Name = "labelMovedFiles";
            labelMovedFiles.Size = new Size(75, 15);
            labelMovedFiles.TabIndex = 0;
            labelMovedFiles.Text = "Moved files:";
            labelMovedFiles.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(214, 220, 237);
            ClientSize = new Size(874, 650);
            Controls.Add(panel1);
            Controls.Add(listBoxReport);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(tableLayoutPanel1);
            ForeColor = Color.FromArgb(54, 47, 117);
            MinimumSize = new Size(890, 689);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transfer files";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxReceiver).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelSource;
        private Label label1;
        private Label label2;
        private Button buttonSource;
        private Label labelReceiver;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonShowFiles;
        private Button buttonTransferFiles;
        private Button buttonCancel;
        private ListBox listBoxReport;
        private Panel panel1;
        private Label labelMovedFiles;
        private SplitContainer splitContainer1;
        private PictureBox pictureBoxSource;
        private ListView listViewSource;
        private ListView listViewReceiver;
        private PictureBox pictureBoxReceiver;
        private Button buttonClear;
    }
}

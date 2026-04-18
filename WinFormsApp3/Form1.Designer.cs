namespace WinFormsApp3;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.tabControl = new System.Windows.Forms.TabControl();
        this.tabPageGenerate = new System.Windows.Forms.TabPage();
        this.lblArrayInfo = new System.Windows.Forms.Label();
        this.btnGenerateArray = new System.Windows.Forms.Button();
        this.txtArraySize = new System.Windows.Forms.TextBox();
        this.lblArraySize = new System.Windows.Forms.Label();
        this.tabPageAlgorithms = new System.Windows.Forms.TabPage();
        this.btnCompare = new System.Windows.Forms.Button();
        this.groupBoxShellSort = new System.Windows.Forms.GroupBox();
        this.lblShellSortStatus = new System.Windows.Forms.Label();
        this.lblShellSortSwaps = new System.Windows.Forms.Label();
        this.lblShellSortComparisons = new System.Windows.Forms.Label();
        this.lblShellSortTime = new System.Windows.Forms.Label();
        this.btnRunShellSort = new System.Windows.Forms.Button();
        this.groupBoxMergeSort = new System.Windows.Forms.GroupBox();
        this.lblMergeSortStatus = new System.Windows.Forms.Label();
        this.lblMergeSortSwaps = new System.Windows.Forms.Label();
        this.lblMergeSortComparisons = new System.Windows.Forms.Label();
        this.lblMergeSortTime = new System.Windows.Forms.Label();
        this.btnRunMergeSort = new System.Windows.Forms.Button();
        this.tabPageComparison = new System.Windows.Forms.TabPage();
        this.dataGridViewResults = new System.Windows.Forms.DataGridView();
        this.tabPageVisualization = new System.Windows.Forms.TabPage();
        this.btnVisualize = new System.Windows.Forms.Button();
        this.pictureBoxVisualization = new System.Windows.Forms.PictureBox();
        this.tabControl.SuspendLayout();
        this.tabPageGenerate.SuspendLayout();
        this.tabPageAlgorithms.SuspendLayout();
        this.groupBoxShellSort.SuspendLayout();
        this.groupBoxMergeSort.SuspendLayout();
        this.tabPageComparison.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
        this.tabPageVisualization.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVisualization)).BeginInit();
        this.SuspendLayout();

        // tabControl
        this.tabControl.Controls.Add(this.tabPageGenerate);
        this.tabControl.Controls.Add(this.tabPageAlgorithms);
        this.tabControl.Controls.Add(this.tabPageComparison);
        this.tabControl.Controls.Add(this.tabPageVisualization);
        this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tabControl.Location = new System.Drawing.Point(0, 0);
        this.tabControl.Name = "tabControl";
        this.tabControl.SelectedIndex = 0;
        this.tabControl.Size = new System.Drawing.Size(1024, 720);
        this.tabControl.TabIndex = 0;

        // tabPageGenerate
        this.tabPageGenerate.Controls.Add(this.lblArrayInfo);
        this.tabPageGenerate.Controls.Add(this.btnGenerateArray);
        this.tabPageGenerate.Controls.Add(this.txtArraySize);
        this.tabPageGenerate.Controls.Add(this.lblArraySize);
        this.tabPageGenerate.Location = new System.Drawing.Point(4, 29);
        this.tabPageGenerate.Name = "tabPageGenerate";
        this.tabPageGenerate.Padding = new System.Windows.Forms.Padding(3);
        this.tabPageGenerate.Size = new System.Drawing.Size(1016, 687);
        this.tabPageGenerate.TabIndex = 0;
        this.tabPageGenerate.Text = "Генерация массива";
        this.tabPageGenerate.UseVisualStyleBackColor = true;

        // lblArraySize
        this.lblArraySize.AutoSize = true;
        this.lblArraySize.Location = new System.Drawing.Point(20, 30);
        this.lblArraySize.Name = "lblArraySize";
        this.lblArraySize.Size = new System.Drawing.Size(150, 20);
        this.lblArraySize.TabIndex = 0;
        this.lblArraySize.Text = "Размер массива (100-10000):";

        // txtArraySize
        this.txtArraySize.Location = new System.Drawing.Point(200, 27);
        this.txtArraySize.Name = "txtArraySize";
        this.txtArraySize.Size = new System.Drawing.Size(120, 27);
        this.txtArraySize.TabIndex = 1;
        this.txtArraySize.Text = "1000";

        // btnGenerateArray
        this.btnGenerateArray.Location = new System.Drawing.Point(20, 70);
        this.btnGenerateArray.Name = "btnGenerateArray";
        this.btnGenerateArray.Size = new System.Drawing.Size(200, 35);
        this.btnGenerateArray.TabIndex = 2;
        this.btnGenerateArray.Text = "Сгенерировать массив";
        this.btnGenerateArray.UseVisualStyleBackColor = true;
        this.btnGenerateArray.Click += new System.EventHandler(this.btnGenerateArray_Click);

        // lblArrayInfo
        this.lblArrayInfo.AutoSize = true;
        this.lblArrayInfo.Location = new System.Drawing.Point(20, 120);
        this.lblArrayInfo.Name = "lblArrayInfo";
        this.lblArrayInfo.Size = new System.Drawing.Size(0, 20);
        this.lblArrayInfo.TabIndex = 3;

        // tabPageAlgorithms
        this.tabPageAlgorithms.Controls.Add(this.btnCompare);
        this.tabPageAlgorithms.Controls.Add(this.groupBoxShellSort);
        this.tabPageAlgorithms.Controls.Add(this.groupBoxMergeSort);
        this.tabPageAlgorithms.Location = new System.Drawing.Point(4, 29);
        this.tabPageAlgorithms.Name = "tabPageAlgorithms";
        this.tabPageAlgorithms.Padding = new System.Windows.Forms.Padding(3);
        this.tabPageAlgorithms.Size = new System.Drawing.Size(1016, 687);
        this.tabPageAlgorithms.TabIndex = 1;
        this.tabPageAlgorithms.Text = "Запуск алгоритмов";
        this.tabPageAlgorithms.UseVisualStyleBackColor = true;

        // groupBoxMergeSort
        this.groupBoxMergeSort.Controls.Add(this.lblMergeSortStatus);
        this.groupBoxMergeSort.Controls.Add(this.lblMergeSortSwaps);
        this.groupBoxMergeSort.Controls.Add(this.lblMergeSortComparisons);
        this.groupBoxMergeSort.Controls.Add(this.lblMergeSortTime);
        this.groupBoxMergeSort.Controls.Add(this.btnRunMergeSort);
        this.groupBoxMergeSort.Location = new System.Drawing.Point(20, 20);
        this.groupBoxMergeSort.Name = "groupBoxMergeSort";
        this.groupBoxMergeSort.Size = new System.Drawing.Size(450, 250);
        this.groupBoxMergeSort.TabIndex = 0;
        this.groupBoxMergeSort.TabStop = false;
        this.groupBoxMergeSort.Text = "Сортировка слиянием";

        // btnRunMergeSort
        this.btnRunMergeSort.Location = new System.Drawing.Point(20, 30);
        this.btnRunMergeSort.Name = "btnRunMergeSort";
        this.btnRunMergeSort.Size = new System.Drawing.Size(200, 35);
        this.btnRunMergeSort.TabIndex = 0;
        this.btnRunMergeSort.Text = "Запустить";
        this.btnRunMergeSort.UseVisualStyleBackColor = true;
        this.btnRunMergeSort.Enabled = false;
        this.btnRunMergeSort.Click += new System.EventHandler(this.btnRunMergeSort_Click);

        // lblMergeSortTime
        this.lblMergeSortTime.AutoSize = true;
        this.lblMergeSortTime.Location = new System.Drawing.Point(20, 80);
        this.lblMergeSortTime.Name = "lblMergeSortTime";
        this.lblMergeSortTime.Size = new System.Drawing.Size(0, 20);
        this.lblMergeSortTime.TabIndex = 1;

        // lblMergeSortComparisons
        this.lblMergeSortComparisons.AutoSize = true;
        this.lblMergeSortComparisons.Location = new System.Drawing.Point(20, 110);
        this.lblMergeSortComparisons.Name = "lblMergeSortComparisons";
        this.lblMergeSortComparisons.Size = new System.Drawing.Size(0, 20);
        this.lblMergeSortComparisons.TabIndex = 2;

        // lblMergeSortSwaps
        this.lblMergeSortSwaps.AutoSize = true;
        this.lblMergeSortSwaps.Location = new System.Drawing.Point(20, 140);
        this.lblMergeSortSwaps.Name = "lblMergeSortSwaps";
        this.lblMergeSortSwaps.Size = new System.Drawing.Size(0, 20);
        this.lblMergeSortSwaps.TabIndex = 3;

        // lblMergeSortStatus
        this.lblMergeSortStatus.AutoSize = true;
        this.lblMergeSortStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
        this.lblMergeSortStatus.Location = new System.Drawing.Point(20, 180);
        this.lblMergeSortStatus.Name = "lblMergeSortStatus";
        this.lblMergeSortStatus.Size = new System.Drawing.Size(0, 24);
        this.lblMergeSortStatus.TabIndex = 4;

        // groupBoxShellSort
        this.groupBoxShellSort.Controls.Add(this.lblShellSortStatus);
        this.groupBoxShellSort.Controls.Add(this.lblShellSortSwaps);
        this.groupBoxShellSort.Controls.Add(this.lblShellSortComparisons);
        this.groupBoxShellSort.Controls.Add(this.lblShellSortTime);
        this.groupBoxShellSort.Controls.Add(this.btnRunShellSort);
        this.groupBoxShellSort.Location = new System.Drawing.Point(500, 20);
        this.groupBoxShellSort.Name = "groupBoxShellSort";
        this.groupBoxShellSort.Size = new System.Drawing.Size(450, 250);
        this.groupBoxShellSort.TabIndex = 1;
        this.groupBoxShellSort.TabStop = false;
        this.groupBoxShellSort.Text = "Сортировка Шелла";

        // btnRunShellSort
        this.btnRunShellSort.Location = new System.Drawing.Point(20, 30);
        this.btnRunShellSort.Name = "btnRunShellSort";
        this.btnRunShellSort.Size = new System.Drawing.Size(200, 35);
        this.btnRunShellSort.TabIndex = 0;
        this.btnRunShellSort.Text = "Запустить";
        this.btnRunShellSort.UseVisualStyleBackColor = true;
        this.btnRunShellSort.Enabled = false;
        this.btnRunShellSort.Click += new System.EventHandler(this.btnRunShellSort_Click);

        // lblShellSortTime
        this.lblShellSortTime.AutoSize = true;
        this.lblShellSortTime.Location = new System.Drawing.Point(20, 80);
        this.lblShellSortTime.Name = "lblShellSortTime";
        this.lblShellSortTime.Size = new System.Drawing.Size(0, 20);
        this.lblShellSortTime.TabIndex = 1;

        // lblShellSortComparisons
        this.lblShellSortComparisons.AutoSize = true;
        this.lblShellSortComparisons.Location = new System.Drawing.Point(20, 110);
        this.lblShellSortComparisons.Name = "lblShellSortComparisons";
        this.lblShellSortComparisons.Size = new System.Drawing.Size(0, 20);
        this.lblShellSortComparisons.TabIndex = 2;

        // lblShellSortSwaps
        this.lblShellSortSwaps.AutoSize = true;
        this.lblShellSortSwaps.Location = new System.Drawing.Point(20, 140);
        this.lblShellSortSwaps.Name = "lblShellSortSwaps";
        this.lblShellSortSwaps.Size = new System.Drawing.Size(0, 20);
        this.lblShellSortSwaps.TabIndex = 3;

        // lblShellSortStatus
        this.lblShellSortStatus.AutoSize = true;
        this.lblShellSortStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
        this.lblShellSortStatus.Location = new System.Drawing.Point(20, 180);
        this.lblShellSortStatus.Name = "lblShellSortStatus";
        this.lblShellSortStatus.Size = new System.Drawing.Size(0, 24);
        this.lblShellSortStatus.TabIndex = 4;

        // btnCompare
        this.btnCompare.Location = new System.Drawing.Point(20, 300);
        this.btnCompare.Name = "btnCompare";
        this.btnCompare.Size = new System.Drawing.Size(300, 40);
        this.btnCompare.TabIndex = 2;
        this.btnCompare.Text = "Сравнить алгоритмы на разных размерах";
        this.btnCompare.UseVisualStyleBackColor = true;
        this.btnCompare.Enabled = false;
        this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);

        // tabPageComparison
        this.tabPageComparison.Controls.Add(this.dataGridViewResults);
        this.tabPageComparison.Location = new System.Drawing.Point(4, 29);
        this.tabPageComparison.Name = "tabPageComparison";
        this.tabPageComparison.Padding = new System.Windows.Forms.Padding(3);
        this.tabPageComparison.Size = new System.Drawing.Size(1016, 687);
        this.tabPageComparison.TabIndex = 2;
        this.tabPageComparison.Text = "Сравнение результатов";
        this.tabPageComparison.UseVisualStyleBackColor = true;

        // dataGridViewResults
        this.dataGridViewResults.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dataGridViewResults.Location = new System.Drawing.Point(3, 3);
        this.dataGridViewResults.Name = "dataGridViewResults";
        this.dataGridViewResults.Size = new System.Drawing.Size(1010, 681);
        this.dataGridViewResults.TabIndex = 0;

        // tabPageVisualization
        this.tabPageVisualization.Controls.Add(this.btnVisualize);
        this.tabPageVisualization.Controls.Add(this.pictureBoxVisualization);
        this.tabPageVisualization.Location = new System.Drawing.Point(4, 29);
        this.tabPageVisualization.Name = "tabPageVisualization";
        this.tabPageVisualization.Padding = new System.Windows.Forms.Padding(3);
        this.tabPageVisualization.Size = new System.Drawing.Size(1016, 687);
        this.tabPageVisualization.TabIndex = 3;
        this.tabPageVisualization.Text = "Визуализация";
        this.tabPageVisualization.UseVisualStyleBackColor = true;

        // pictureBoxVisualization
        this.pictureBoxVisualization.BackColor = System.Drawing.Color.White;
        this.pictureBoxVisualization.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.pictureBoxVisualization.Location = new System.Drawing.Point(3, 100);
        this.pictureBoxVisualization.Name = "pictureBoxVisualization";
        this.pictureBoxVisualization.Size = new System.Drawing.Size(1010, 584);
        this.pictureBoxVisualization.TabIndex = 0;
        this.pictureBoxVisualization.TabStop = false;

        // btnVisualize
        this.btnVisualize.Location = new System.Drawing.Point(20, 20);
        this.btnVisualize.Name = "btnVisualize";
        this.btnVisualize.Size = new System.Drawing.Size(200, 35);
        this.btnVisualize.TabIndex = 1;
        this.btnVisualize.Text = "Показать визуализацию";
        this.btnVisualize.UseVisualStyleBackColor = true;
        this.btnVisualize.Click += new System.EventHandler(this.btnVisualize_Click);

        // Form1
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1024, 720);
        this.Controls.Add(this.tabControl);
        this.Name = "Form1";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Лабораторная работа №3 | Вариант 17: Сортировка слиянием и Шелла";
        this.tabControl.ResumeLayout(false);
        this.tabPageGenerate.ResumeLayout(false);
        this.tabPageGenerate.PerformLayout();
        this.tabPageAlgorithms.ResumeLayout(false);
        this.groupBoxShellSort.ResumeLayout(false);
        this.groupBoxShellSort.PerformLayout();
        this.groupBoxMergeSort.ResumeLayout(false);
        this.groupBoxMergeSort.PerformLayout();
        this.tabPageComparison.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
        this.tabPageVisualization.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVisualization)).EndInit();
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.TabControl tabControl;
    private System.Windows.Forms.TabPage tabPageGenerate;
    private System.Windows.Forms.TabPage tabPageAlgorithms;
    private System.Windows.Forms.TabPage tabPageComparison;
    private System.Windows.Forms.TabPage tabPageVisualization;
    private System.Windows.Forms.Label lblArraySize;
    private System.Windows.Forms.TextBox txtArraySize;
    private System.Windows.Forms.Button btnGenerateArray;
    private System.Windows.Forms.Label lblArrayInfo;
    private System.Windows.Forms.GroupBox groupBoxMergeSort;
    private System.Windows.Forms.Button btnRunMergeSort;
    private System.Windows.Forms.Label lblMergeSortTime;
    private System.Windows.Forms.Label lblMergeSortComparisons;
    private System.Windows.Forms.Label lblMergeSortSwaps;
    private System.Windows.Forms.Label lblMergeSortStatus;
    private System.Windows.Forms.GroupBox groupBoxShellSort;
    private System.Windows.Forms.Button btnRunShellSort;
    private System.Windows.Forms.Label lblShellSortTime;
    private System.Windows.Forms.Label lblShellSortComparisons;
    private System.Windows.Forms.Label lblShellSortSwaps;
    private System.Windows.Forms.Label lblShellSortStatus;
    private System.Windows.Forms.Button btnCompare;
    private System.Windows.Forms.DataGridView dataGridViewResults;
    private System.Windows.Forms.PictureBox pictureBoxVisualization;
    private System.Windows.Forms.Button btnVisualize;
}
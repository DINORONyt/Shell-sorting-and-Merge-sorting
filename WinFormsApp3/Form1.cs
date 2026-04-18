using Lab03Variant17;

namespace WinFormsApp3;

public partial class Form1 : Form
{
    private int[] _currentArray = Array.Empty<int>();
    private SortingResult? _mergeSortResult;  // ← Nullable правильно
    private SortingResult? _shellSortResult;

    public Form1()
    {
        InitializeComponent();
        InitializeCustomSettings();
    }

    private void InitializeCustomSettings()
    {
        dataGridViewResults.ColumnCount = 5;
        dataGridViewResults.Columns[0].Name = "Размер массива";
        dataGridViewResults.Columns[1].Name = "Алгоритм";
        dataGridViewResults.Columns[2].Name = "Время (мс)";
        dataGridViewResults.Columns[3].Name = "Сравнения";
        dataGridViewResults.Columns[4].Name = "Перестановки";

        dataGridViewResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    }

    private void btnGenerateArray_Click(object sender, EventArgs e)
    {
        if (!TryGetArraySize(out int size))
            return;

        _currentArray = SortingAlgorithms.GenerateRandomArray(size);
        lblArrayInfo.Text = $"Сгенерирован массив: {size} элементов";
        btnRunMergeSort.Enabled = true;
        btnRunShellSort.Enabled = true;
        btnCompare.Enabled = true;
    }

    private void btnRunMergeSort_Click(object sender, EventArgs e)
    {
        if (_currentArray.Length == 0)
        {
            MessageBox.Show("Сначала сгенерируйте массив!", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        _mergeSortResult = SortingAlgorithms.MergeSort(_currentArray);

        // ← ИСПРАВЛЕНО: используем свойства с заглавной буквы!
        lblMergeSortTime.Text = $"Время: {_mergeSortResult.ExecutionTimeMs:F4} мс";
        lblMergeSortComparisons.Text = $"Сравнения: {_mergeSortResult.ComparisonCount}";
        lblMergeSortSwaps.Text = $"Перестановки: {_mergeSortResult.SwapCount}";

        bool isSorted = SortingAlgorithms.IsSorted(_mergeSortResult.SortedArray);
        lblMergeSortStatus.Text = isSorted ? "✓ Отсортировано" : "✗ Ошибка!";
        lblMergeSortStatus.ForeColor = isSorted ? Color.Green : Color.Red;
    }

    private void btnRunShellSort_Click(object sender, EventArgs e)
    {
        if (_currentArray.Length == 0)
        {
            MessageBox.Show("Сначала сгенерируйте массив!", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        _shellSortResult = SortingAlgorithms.ShellSort(_currentArray);

        // ← ИСПРАВЛЕНО: используем свойства с заглавной буквы!
        lblShellSortTime.Text = $"Время: {_shellSortResult.ExecutionTimeMs:F4} мс";
        lblShellSortComparisons.Text = $"Сравнения: {_shellSortResult.ComparisonCount}";
        lblShellSortSwaps.Text = $"Перестановки: {_shellSortResult.SwapCount}";

        bool isSorted = SortingAlgorithms.IsSorted(_shellSortResult.SortedArray);
        lblShellSortStatus.Text = isSorted ? "✓ Отсортировано" : "✗ Ошибка!";
        lblShellSortStatus.ForeColor = isSorted ? Color.Green : Color.Red;
    }

    private void btnCompare_Click(object sender, EventArgs e)
    {
        // ← ИСПРАВЛЕНО: правильная null-проверка
        if (_mergeSortResult == null || _shellSortResult == null)
        {
            MessageBox.Show("Запустите оба алгоритма для сравнения!", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        dataGridViewResults.Rows.Clear();

        int[] sizes = { 100, 500, 1000, 5000, 10000 };

        foreach (int size in sizes)
        {
            int[] testArray = SortingAlgorithms.GenerateRandomArray(size);

            var mergeResult = SortingAlgorithms.MergeSort(testArray);
            var shellResult = SortingAlgorithms.ShellSort(testArray);

            dataGridViewResults.Rows.Add(
                size, "Merge Sort",
                mergeResult.ExecutionTimeMs.ToString("F4"),
                mergeResult.ComparisonCount,
                mergeResult.SwapCount
            );

            dataGridViewResults.Rows.Add(
                size, "Shell Sort",
                shellResult.ExecutionTimeMs.ToString("F4"),
                shellResult.ComparisonCount,
                shellResult.SwapCount
            );
        }

        tabControl.SelectedIndex = 2;
    }

    private void btnVisualize_Click(object sender, EventArgs e)
    {
        if (_currentArray.Length == 0)
        {
            MessageBox.Show("Сначала сгенерируйте массив!", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        DrawArrayVisualization();
    }

    private void DrawArrayVisualization()
    {
        var g = pictureBoxVisualization.CreateGraphics();
        g.Clear(Color.White);

        int width = pictureBoxVisualization.Width;
        int height = pictureBoxVisualization.Height;
        int padding = 40;

        int barWidth = (width - 2 * padding) / Math.Min(_currentArray.Length, 100);
        int maxVal = _currentArray.Max();
        int minVal = _currentArray.Min();
        int range = maxVal - minVal == 0 ? 1 : maxVal - minVal;

        for (int i = 0; i < Math.Min(_currentArray.Length, 100); i++)
        {
            int normalizedValue = (_currentArray[i] - minVal) * (height - 2 * padding) / range;
            int barHeight = normalizedValue;

            int x = padding + i * barWidth;
            int y = height - padding - barHeight;

            using var brush = new SolidBrush(Color.Blue);
            g.FillRectangle(brush, x, y, barWidth - 1, barHeight);
        }

        g.DrawString($"Массив: {_currentArray.Length} элементов",
            new Font("Arial", 12), Brushes.Black, padding, 10);
    }

    private bool TryGetArraySize(out int size)
    {
        size = 0;

        if (!int.TryParse(txtArraySize.Text, out size))
        {
            MessageBox.Show("Введите корректное число!", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (!SortingAlgorithms.ValidateArraySize(size))
        {
            MessageBox.Show("Размер массива должен быть от 100 до 10000!", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }
}
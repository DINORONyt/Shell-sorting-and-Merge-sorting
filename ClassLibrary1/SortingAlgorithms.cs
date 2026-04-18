namespace Lab03Variant17;

/// <summary>
/// Результат выполнения алгоритма сортировки
/// </summary>
public record SortingResult(
    int[] SortedArray,
    long ComparisonCount,
    long SwapCount,
    double ExecutionTimeMs
);

/// Класс с реализацией алгоритмов сортировки

public static class SortingAlgorithms
{
    /// <summary>
    /// Сортировка слиянием
    /// Время: O(n log n) в лучшем, среднем и худшем случаях
    /// Память: O(n)
    /// </summary>
    public static SortingResult MergeSort(int[] array)
    {
        var startTime = System.Diagnostics.Stopwatch.StartNew();
        long comparisons = 0;
        long swaps = 0;

        int[] result = (int[])array.Clone();
        int[] temp = new int[result.Length];

        MergeSortRecursive(result, temp, 0, result.Length - 1, ref comparisons, ref swaps);

        startTime.Stop();

        return new SortingResult(
            result,
            comparisons,
            swaps,
            startTime.Elapsed.TotalMilliseconds
        );
    }

    private static void MergeSortRecursive(int[] array, int[] temp, int left, int right,
        ref long comparisons, ref long swaps)
    {
        if (left < right)
        {
            int middle = (left + right) / 2;

            MergeSortRecursive(array, temp, left, middle, ref comparisons, ref swaps);
            MergeSortRecursive(array, temp, middle + 1, right, ref comparisons, ref swaps);

            Merge(array, temp, left, middle, right, ref comparisons, ref swaps);
        }
    }

    private static void Merge(int[] array, int[] temp, int left, int middle, int right,
        ref long comparisons, ref long swaps)
    {
        for (int i = left; i <= right; i++)
        {
            temp[i] = array[i];
        }

        int leftIndex = left;
        int rightIndex = middle + 1;
        int currentIndex = left;

        while (leftIndex <= middle && rightIndex <= right)
        {
            comparisons++;

            if (temp[leftIndex] <= temp[rightIndex])
            {
                array[currentIndex] = temp[leftIndex];
                leftIndex++;
                swaps++;
            }
            else
            {
                array[currentIndex] = temp[rightIndex];
                rightIndex++;
                swaps++;
            }
            currentIndex++;
        }

        while (leftIndex <= middle)
        {
            array[currentIndex] = temp[leftIndex];
            leftIndex++;
            currentIndex++;
            swaps++;
        }
    }

    /// <summary>
    /// Сортировка Шелла
    /// Время: O(n log² n) в среднем, O(n²) в худшем
    /// Память: O(1)
    /// </summary>
    public static SortingResult ShellSort(int[] array)
    {
        var startTime = System.Diagnostics.Stopwatch.StartNew();
        long comparisons = 0;
        long swaps = 0;

        int[] result = (int[])array.Clone();
        int n = result.Length;

        for (int gap = n / 2; gap > 0; gap /= 2)
        {
            for (int i = gap; i < n; i++)
            {
                int temp = result[i];
                int j = i;

                while (j >= gap)
                {
                    comparisons++;

                    if (result[j - gap] > temp)
                    {
                        result[j] = result[j - gap];
                        j -= gap;
                        swaps++;
                    }
                    else
                    {
                        break;
                    }
                }
                result[j] = temp;
                if (j != i) swaps++;
            }
        }

        startTime.Stop();

        return new SortingResult(
            result,
            comparisons,
            swaps,
            startTime.Elapsed.TotalMilliseconds
        );
    }

    /// <summary>
    /// Генерация случайного массива
    /// </summary>
    public static int[] GenerateRandomArray(int size, int minValue = -1000, int maxValue = 1000)
    {
        var random = new Random();
        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(minValue, maxValue + 1);
        }

        return array;
    }

    /// <summary>
    /// Проверка отсортированности массива
    /// </summary>
    public static bool IsSorted(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i - 1] > array[i])
                return false;
        }
        return true;
    }

    /// <summary>
    /// Валидация размера массива
    /// </summary>
    public static bool ValidateArraySize(int size)
    {
        return size >= 100 && size <= 10000;
    }
}
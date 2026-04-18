using Lab03Variant17;
using Xunit;

namespace TestProject3;

public class SortingAlgorithmsTests
{
    #region Тесты для сортировки слиянием (Merge Sort)

    [Fact]
    public void MergeSort_SortsEmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] array = Array.Empty<int>();

        // Act
        var result = SortingAlgorithms.MergeSort(array);

        // Assert
        Assert.Empty(result.SortedArray);
        Assert.True(SortingAlgorithms.IsSorted(result.SortedArray));
        Assert.Equal(0, result.ComparisonCount);
    }

    [Fact]
    public void MergeSort_SortsSingleElement_ReturnsSameArray()
    {
        // Arrange
        int[] array = { 42 };

        // Act
        var result = SortingAlgorithms.MergeSort(array);

        // Assert
        Assert.Single(result.SortedArray);
        Assert.Equal(42, result.SortedArray[0]);
    }

    [Fact]
    public void MergeSort_SortsAlreadySortedArray_Correctly()
    {
        // Arrange
        int[] array = { 1, 2, 3, 4, 5 };

        // Act
        var result = SortingAlgorithms.MergeSort(array);

        // Assert
        Assert.Equal(new[] { 1, 2, 3, 4, 5 }, result.SortedArray);
        Assert.True(SortingAlgorithms.IsSorted(result.SortedArray));
    }

    [Fact]
    public void MergeSort_SortsReverseSortedArray_Correctly()
    {
        // Arrange
        int[] array = { 5, 4, 3, 2, 1 };

        // Act
        var result = SortingAlgorithms.MergeSort(array);

        // Assert
        Assert.Equal(new[] { 1, 2, 3, 4, 5 }, result.SortedArray);
        Assert.True(SortingAlgorithms.IsSorted(result.SortedArray));
    }

    [Fact]
    public void MergeSort_SortsRandomArray_Correctly()
    {
        // Arrange
        int[] array = SortingAlgorithms.GenerateRandomArray(1000);

        // Act
        var result = SortingAlgorithms.MergeSort(array);

        // Assert
        Assert.True(SortingAlgorithms.IsSorted(result.SortedArray));
        Assert.Equal(array.Length, result.SortedArray.Length);
    }

    [Fact]
    public void MergeSort_HandlesNegativeNumbers_Correctly()
    {
        // Arrange
        int[] array = { -5, 3, -1, 0, 2, -8, 7 };

        // Act
        var result = SortingAlgorithms.MergeSort(array);

        // Assert
        Assert.Equal(new[] { -8, -5, -1, 0, 2, 3, 7 }, result.SortedArray);
    }

    [Fact]
    public void MergeSort_HandlesDuplicates_Correctly()
    {
        // Arrange
        int[] array = { 3, 1, 4, 1, 5, 9, 2, 6, 5 };

        // Act
        var result = SortingAlgorithms.MergeSort(array);

        // Assert
        Assert.Equal(new[] { 1, 1, 2, 3, 4, 5, 5, 6, 9 }, result.SortedArray);
    }

    #endregion

    #region Тесты для сортировки Шелла (Shell Sort)

    [Fact]
    public void ShellSort_SortsEmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] array = Array.Empty<int>();

        // Act
        var result = SortingAlgorithms.ShellSort(array);

        // Assert
        Assert.Empty(result.SortedArray);
        Assert.True(SortingAlgorithms.IsSorted(result.SortedArray));
    }

    [Fact]
    public void ShellSort_SortsSingleElement_ReturnsSameArray()
    {
        // Arrange
        int[] array = { 42 };

        // Act
        var result = SortingAlgorithms.ShellSort(array);

        // Assert
        Assert.Single(result.SortedArray);
        Assert.Equal(42, result.SortedArray[0]);
    }

    [Fact]
    public void ShellSort_SortsAlreadySortedArray_Correctly()
    {
        // Arrange
        int[] array = { 1, 2, 3, 4, 5 };

        // Act
        var result = SortingAlgorithms.ShellSort(array);

        // Assert
        Assert.Equal(new[] { 1, 2, 3, 4, 5 }, result.SortedArray);
        Assert.True(SortingAlgorithms.IsSorted(result.SortedArray));
    }

    [Fact]
    public void ShellSort_SortsReverseSortedArray_Correctly()
    {
        // Arrange
        int[] array = { 5, 4, 3, 2, 1 };

        // Act
        var result = SortingAlgorithms.ShellSort(array);

        // Assert
        Assert.Equal(new[] { 1, 2, 3, 4, 5 }, result.SortedArray);
        Assert.True(SortingAlgorithms.IsSorted(result.SortedArray));
    }

    [Fact]
    public void ShellSort_SortsRandomArray_Correctly()
    {
        // Arrange
        int[] array = SortingAlgorithms.GenerateRandomArray(1000);

        // Act
        var result = SortingAlgorithms.ShellSort(array);

        // Assert
        Assert.True(SortingAlgorithms.IsSorted(result.SortedArray));
        Assert.Equal(array.Length, result.SortedArray.Length);
    }

    [Fact]
    public void ShellSort_HandlesNegativeNumbers_Correctly()
    {
        // Arrange
        int[] array = { -5, 3, -1, 0, 2, -8, 7 };

        // Act
        var result = SortingAlgorithms.ShellSort(array);

        // Assert
        Assert.Equal(new[] { -8, -5, -1, 0, 2, 3, 7 }, result.SortedArray);
    }

    [Fact]
    public void ShellSort_HandlesDuplicates_Correctly()
    {
        // Arrange
        int[] array = { 3, 1, 4, 1, 5, 9, 2, 6, 5 };

        // Act
        var result = SortingAlgorithms.ShellSort(array);

        // Assert
        Assert.Equal(new[] { 1, 1, 2, 3, 4, 5, 5, 6, 9 }, result.SortedArray);
    }

    #endregion

    #region Тесты для вспомогательных методов

    [Fact]
    public void GenerateRandomArray_GeneratesCorrectSize()
    {
        // Arrange & Act
        int size = 1000;
        var array = SortingAlgorithms.GenerateRandomArray(size);

        // Assert
        Assert.Equal(size, array.Length);
    }

    [Fact]
    public void GenerateRandomArray_GeneratesValuesInRange()
    {
        // Arrange & Act
        var array = SortingAlgorithms.GenerateRandomArray(100, -50, 50);

        // Assert
        foreach (var value in array)
        {
            Assert.InRange(value, -50, 50);
        }
    }

    [Fact]
    public void IsSorted_ReturnsTrueForSortedArray()
    {
        // Arrange
        int[] array = { 1, 2, 3, 4, 5 };

        // Act & Assert
        Assert.True(SortingAlgorithms.IsSorted(array));
    }

    [Fact]
    public void IsSorted_ReturnsFalseForUnsortedArray()
    {
        // Arrange
        int[] array = { 1, 3, 2, 4, 5 };

        // Act & Assert
        Assert.False(SortingAlgorithms.IsSorted(array));
    }

    [Fact]
    public void ValidateArraySize_ReturnsTrueForValidSize()
    {
        // Act & Assert
        Assert.True(SortingAlgorithms.ValidateArraySize(100));
        Assert.True(SortingAlgorithms.ValidateArraySize(5000));
        Assert.True(SortingAlgorithms.ValidateArraySize(10000));
    }

    [Fact]
    public void ValidateArraySize_ReturnsFalseForInvalidSize()
    {
        // Act & Assert
        Assert.False(SortingAlgorithms.ValidateArraySize(50));
        Assert.False(SortingAlgorithms.ValidateArraySize(15000));
        Assert.False(SortingAlgorithms.ValidateArraySize(0));
        Assert.False(SortingAlgorithms.ValidateArraySize(-10));
    }

    #endregion

    #region Тесты производительности (Performance Tests)

    [Fact]
    public void MergeSort_PerformanceTest_LargeArray_CompletesQuickly()
    {
        // Arrange
        int[] array = SortingAlgorithms.GenerateRandomArray(10000);

        // Act
        var result = SortingAlgorithms.MergeSort(array);

        // Assert
        Assert.True(SortingAlgorithms.IsSorted(result.SortedArray));
        // Для 10000 элементов время должно быть менее 1 секунды на современном ПК
        Assert.True(result.ExecutionTimeMs < 1000,
            $"Merge Sort took too long: {result.ExecutionTimeMs} ms");
    }

    [Fact]
    public void ShellSort_PerformanceTest_LargeArray_CompletesQuickly()
    {
        // Arrange
        int[] array = SortingAlgorithms.GenerateRandomArray(10000);

        // Act
        var result = SortingAlgorithms.ShellSort(array);

        // Assert
        Assert.True(SortingAlgorithms.IsSorted(result.SortedArray));
        // Для 10000 элементов время должно быть менее 1 секунды на современном ПК
        Assert.True(result.ExecutionTimeMs < 1000,
            $"Shell Sort took too long: {result.ExecutionTimeMs} ms");
    }

    [Fact]
    public void CompareAlgorithms_MergeSortVsShellSort_OnLargeDataset()
    {
        // Arrange
        int[] array = SortingAlgorithms.GenerateRandomArray(5000);

        // Act
        var mergeResult = SortingAlgorithms.MergeSort(array);
        var shellResult = SortingAlgorithms.ShellSort(array);

        // Assert
        // Оба алгоритма должны отсортировать массив корректно
        Assert.True(SortingAlgorithms.IsSorted(mergeResult.SortedArray));
        Assert.True(SortingAlgorithms.IsSorted(shellResult.SortedArray));

        // Результаты сортировки должны быть идентичны
        Assert.Equal(mergeResult.SortedArray, shellResult.SortedArray);
    }

    #endregion
}
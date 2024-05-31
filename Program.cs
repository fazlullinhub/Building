using System;
using System.Collections;
using System.Collections.Generic;

class Building : IComparable<Building>
{
    public int YearBuilt { get; set; }
    public int NumberOfOffices { get; set; }
    public int TotalArea { get; set; }

    public int CompareTo(Building other)
    {
        return this.YearBuilt.CompareTo(other.YearBuilt);
    }
}

class SortOfficeBuildingComparer : IComparer<Building>
{
    public int Compare(Building x, Building y)
    {
        return x.NumberOfOffices.CompareTo(y.NumberOfOffices);
    }
}

class SortAreaBuildingComparer : IComparer<Building>
{
    public int Compare(Building x, Building y)
    {
        return x.TotalArea.CompareTo(y.TotalArea);
    }
}
    class Program
    {
    static void Main()
    {
        List<Building> buildings = new List<Building>
        {
            new Building { YearBuilt = 2000, NumberOfOffices = 100, TotalArea = 5000 },
            new Building { YearBuilt = 1990, NumberOfOffices = 50, TotalArea = 3000 },
            new Building { YearBuilt = 2010, NumberOfOffices = 200, TotalArea = 200 },
        };

        buildings.Sort();
        Console.WriteLine("Сортировка по году постройки:");
        foreach (var building in buildings)
        {
            Console.WriteLine($"Год постройки: {building.YearBuilt}");
        }

        buildings.Sort(new SortOfficeBuildingComparer());
        Console.WriteLine("\nСортировка по количеству офисов:");
        foreach (var building in buildings)
        {
            Console.WriteLine($"Количество офисов: {building.NumberOfOffices}"); 
        }

        buildings.Sort(new SortAreaBuildingComparer());
        Console.WriteLine("\nСортировка по общей площади:");
        foreach (var building in buildings)
        {
            Console.WriteLine($"Общая площадь: {building.TotalArea}");
        }
    }
}







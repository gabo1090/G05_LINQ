namespace Extensions;

public static class MyEnumerable
{
	public static IEnumerable<T> MyWhere<T>(this IEnumerable<T> source, Predicate<T> predicate)
	{
		if (source == null) throw new ArgumentNullException(nameof(source));
		if (predicate == null) throw new ArgumentNullException(nameof(predicate));

		foreach (var item in source)
		{
			if (predicate(item))
			{
				yield return item;
			}
		}
	}

	public static IEnumerable<T> MyUnion<T>(this IEnumerable<T> first, IEnumerable<T> second)
	{

        if (first == null) throw new ArgumentNullException(nameof(first));
        if (second == null) throw new ArgumentNullException(nameof(second));

        HashSet<T> result = new HashSet<T>();

        foreach (var item in first)
        {
            result.Add(item);
        }

        foreach (var item in second)
        {
            result.Add(item);
        }

        return result;
    }

    public static IEnumerable<T> MyConcat<T>(this IEnumerable<T> first, IEnumerable<T> second)
    {
        if(first == null) throw new ArgumentNullException(nameof(first));
        if(second == null) throw new ArgumentNullException(nameof(second));

        foreach (var item in first)
        {
            yield return item;
        }

        foreach (var item in second)
        {
            yield return item;
        }
    }

    public static IEnumerable<T> MyExcept<T>(this IEnumerable<T> first, IEnumerable<T> second)
    {
        if (first == null) throw new ArgumentNullException(nameof(first));
        if (second == null) throw new ArgumentNullException(nameof(second));

        second = second.MyDistinct();

        foreach (var item in first)
        {
            if (!second.Contains(item))
            {
                yield return item;
            }
        }
    }

    public static IEnumerable<T> MyIntersect<T>(this IEnumerable<T> first, IEnumerable<T> second)
    {
        if(first == null) throw new ArgumentNullException(nameof(first));
        if(second == null) throw new ArgumentNullException(nameof(second));

        second = second.MyDistinct();

        foreach (var item in first)
        {
            if (second.Contains(item))
            {
                yield return item;
            }
        }

    }

    public static IEnumerable<T> MyDistinct<T>(this IEnumerable<T> collection)
    {
        if (collection == null) throw new ArgumentNullException(nameof(collection));

        HashSet<T> result = new HashSet<T>();

        foreach (var item in collection)
        {
            result.Add(item);
        }
        return result;
    }

}

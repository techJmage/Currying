using System.Diagnostics.CodeAnalysis;

namespace Currying;

public static class Extensions
{
    public static T? Clone<T>(this T obj)
    {
        var inst = typeof(T).GetMethod("MemberwiseClone", System.Reflection.BindingFlags.Instance);
        return inst == null? default: (T?)inst.Invoke(obj, null);
    }

    public static void ForEach<T>([NotNull] this IEnumerable<T> collection, Action<T> action)
    {
        foreach (T item in collection)
            action(item);
    }

    public static void Pipe<T>([NotNull] this T caller, params Action<T>[] actions) =>
        actions.ForEach(act => act(caller));

    public static void Pipe<T, R>([NotNull] this T caller, Action<T, R> act, R arg) => act(caller, arg);

    public static R Pipe<T, R>([NotNull] this T caller, Func<T, R> f) => f(caller);

    public static T Pipe<T>([NotNull] this T caller, bool immutable, params Func<T, T>[] functions)
    {
        var res = immutable ? caller.Clone() : caller;
        functions.ForEach(f => res = f(res));
        return res;
    }

    public static T Pipe<T>([NotNull] this T caller, params Func<T, T>[] functions) =>
        caller.Pipe(false, functions);

    public static R Pipe<T1, T2, R>([NotNull] this T1 caller, Func<T1, T2, R> f, T2 arg) => f(caller, arg);
}
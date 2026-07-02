using System.Diagnostics.CodeAnalysis;

namespace Currying;

/// <summary>
/// Provides a set of functional-style extension helpers for piping values through functions,
/// cloning by MemberwiseClone, and iterating collections with actions.
/// </summary>
public static class Extensions
{
    /// <summary>
    /// Provides object-level helpers for a generic instance of <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">The instance type the extensions apply to.</typeparam>
    extension<T>(T obj)
    {
        /// <summary>
        /// Creates a shallow copy of the current instance by invoking the protected <c>MemberwiseClone</c> method via reflection.
        /// </summary>
        /// <returns>
        /// A shallow copy of the current object as <typeparamref name="T"/>, or <see langword="default"/> if the clone operation is not available.
        /// </returns>
        public T? Clone()
        {
            var inst = typeof(T).GetMethod("MemberwiseClone", System.Reflection.BindingFlags.Instance);
            return inst == null ? default : (T?)inst.Invoke(obj, null);
        }
    }

    /// <summary>
    /// Enumerable-related extension members.
    /// </summary>
    /// <typeparam name="T">Element type of the <see cref="IEnumerable{T}"/>.</typeparam>
    extension<T>([NotNull] IEnumerable<T> collection)
    {
        /// <summary>
        /// Applies <paramref name="action"/> to each element in <paramref name="collection"/>.
        /// </summary>
        /// <param name="action">The action to execute for each element.</param>
        public void ForEach(Action<T> action)
        {
            foreach (T item in collection)
                action(item);
        }
    }

    /// <summary>
    /// Pipe-style extensions for instances of <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">Type of the caller value being piped.</typeparam>
    extension<T>([NotNull] T caller)
    {
        /// <summary>
        /// Pipes the caller into one or more <see cref="Action{T}"/> delegates.
        /// Each action is invoked with the caller as its argument.
        /// </summary>
        /// <param name="actions">Actions to invoke with the caller.</param>
        public void Pipe(params Action<T>[] actions) =>
        actions.ForEach(act => act(caller));

        /// <summary>
        /// Pipes the caller into a two-argument action along with an extra argument.
        /// </summary>
        /// <typeparam name="R">Type of the second argument accepted by <paramref name="act"/>.</typeparam>
        /// <param name="act">The action to invoke with the caller and <paramref name="arg"/>.</param>
        /// <param name="arg">The additional argument passed to <paramref name="act"/>.</param>
        public void Pipe<R>(Action<T, R> act, R arg) => act(caller, arg);

        /// <summary>
        /// Pipes the caller through a function and returns the function result.
        /// </summary>
        /// <typeparam name="R">Return type of the function <paramref name="f"/>.</typeparam>
        /// <param name="f">The function to apply to the caller.</param>
        /// <returns>The result of applying <paramref name="f"/> to the caller.</returns>
        public R Pipe<R>(Func<T, R> f) => f(caller);

        /// <summary>
        /// Pipes the caller through a sequence of transforming functions.
        /// When <paramref name="immutable"/> is <see langword="true"/>, the first step clones the caller using <see cref="Clone"/> and all functions operate on the cloned value.
        /// </summary>
        /// <param name="immutable">
        /// If <see langword="true"/>, a shallow clone of the caller is created before applying the functions; otherwise the caller may be mutated by the functions.
        /// </param>
        /// <param name="functions">Sequence of functions that transform the value.</param>
        /// <returns>The final transformed value after applying all <paramref name="functions"/>.</returns>
        public T Pipe(bool immutable, params Func<T, T>[] functions)
        {
            var res = immutable ? caller.Clone() : caller;
            functions.ForEach(f => res = f(res));
            return res;
        }

        /// <summary>
        /// Pipes the caller through a sequence of transforming functions (non-immutable overload).
        /// </summary>
        /// <param name="functions">Sequence of functions that transform the value.</param>
        /// <returns>The final transformed value after applying all <paramref name="functions"/>.</returns>
        public T Pipe(params Func<T, T>[] functions) =>
            caller.Pipe(false, functions);
    }

    /// <summary>
    /// Pipes a value into a two-argument function, returning the function result.
    /// </summary>
    /// <typeparam name="T1">Type of the caller value.</typeparam>
    /// <param name="caller">The value to be passed as the first argument to <paramref name="f"/>.</param>
    extension<T1>([NotNull] T1 caller)
    {
        /// <summary>
        /// Applies a function that accepts the caller and an additional argument, returning the result.
        /// </summary>
        /// <typeparam name="T2">Type of the additional argument.</typeparam>
        /// <typeparam name="R">Return type of the function.</typeparam>
        /// <param name="f">Function to apply.</param>
        /// <param name="arg">Additional argument passed to <paramref name="f"/>.</param>
        /// <returns>The result of <paramref name="f"/> invoked with <paramref name="caller"/> and <paramref name="arg"/>.</returns>
        public R Pipe<T2, R>(Func<T1, T2, R> f, T2 arg) => f(caller, arg);
    }

    /// <summary>
    /// Enables a forward "pipe" operator syntax that applies a function to a value: <c>value >> func</c>.
    /// </summary>
    /// <typeparam name="TSource">Type of the input value.</typeparam>
    /// <typeparam name="TResult">Type of the function result.</typeparam>
    /// <param name="caller">The value being piped.</param>
    extension<TSource, TResult>([NotNull] TSource caller)
    {
        /// <summary>
        /// Applies <paramref name="g"/> to <paramref name="arg"/> and returns the result.
        /// This allows using the operator form: <c>value >> func</c>.
        /// </summary>
        /// <param name="arg">The input value.</param>
        /// <param name="g">The function to apply.</param>
        /// <returns>The result of applying <paramref name="g"/> to <paramref name="arg"/>.</returns>
        public static TResult operator >>(TSource arg, Func<TSource, TResult> g) => g(arg);
    }

    /// <summary>
    /// Provides pipe-back helpers and an operator overload for functions so you can call <c>func >> value</c> as a shorthand for <c>func(value)</c>.
    /// </summary>
    /// <typeparam name="TSource">Type of the function input.</typeparam>
    /// <typeparam name="TResult">Type of the function output.</typeparam>
    /// <param name="f">The function being extended.</param>
    extension<TSource, TResult>([NotNull] Func<TSource, TResult> f)
    {
        /// <summary>
        /// Applies the function to <paramref name="arg"/> and returns the result.
        /// </summary>
        /// <param name="arg">Argument to pass to the function.</param>
        /// <returns>The result of invoking the function with <paramref name="arg"/>.</returns>
        public TResult PipeBack(TSource arg) => f(arg);

        /// <summary>
        /// Operator overload to support function-first pipe syntax: <c>func >> arg</c>.
        /// </summary>
        /// <param name="g">Function to apply.</param>
        /// <param name="arg">Argument to pass to <paramref name="g"/>.</param>
        /// <returns>The result of invoking <paramref name="g"/> with <paramref name="arg"/>.</returns>
        public static TResult operator >>(Func<TSource, TResult> g, TSource arg) => g(arg);
    }
}
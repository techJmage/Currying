#### [Currying](README.md 'README')

## Currying Assembly
### Namespaces

<a name='Currying'></a>

## Currying Namespace
### Classes

<a name='Currying.Extensions'></a>

## Extensions Class

Provides a set of functional\-style extension helpers for piping values through functions,
cloning by MemberwiseClone, and iterating collections with actions\.

```csharp
public static class Extensions
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; Extensions
### Methods

<a name='Currying.Extensions.Clone_T_(thisT)'></a>

## Extensions\.Clone\<T\>\(this T\) Method

Creates a shallow copy of the current instance by invoking the protected `MemberwiseClone` method via reflection\.

```csharp
public static T? Clone<T>(this T obj);
```
#### Type parameters

<a name='Currying.Extensions.Clone_T_(thisT).T'></a>

`T`
#### Parameters

<a name='Currying.Extensions.Clone_T_(thisT).obj'></a>

`obj` [T](README.md#Currying.Extensions.Clone_T_(thisT).T 'Currying\.Extensions\.Clone\<T\>\(this T\)\.T')

#### Returns
[T](README.md#Currying.Extensions.Clone_T_(thisT).T 'Currying\.Extensions\.Clone\<T\>\(this T\)\.T')  
A shallow copy of the current object as [T](README.md#Currying.Extensions.Clone_T_(thisT).T 'Currying\.Extensions\.Clone\<T\>\(this T\)\.T'), or [default](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/default') if the clone operation is not available\.

<a name='Currying.Extensions.ForEach_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Action_T_)'></a>

## Extensions\.ForEach\<T\>\(this IEnumerable\<T\>, Action\<T\>\) Method

Applies [action](README.md#Currying.Extensions.ForEach_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Action_T_).action 'Currying\.Extensions\.ForEach\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>, System\.Action\<T\>\)\.action') to each element in [collection](README.md#Currying.Extensions.ForEach_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Action_T_).collection 'Currying\.Extensions\.ForEach\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>, System\.Action\<T\>\)\.collection')\.

```csharp
public static void ForEach<T>(this System.Collections.Generic.IEnumerable<T> collection, System.Action<T> action);
```
#### Type parameters

<a name='Currying.Extensions.ForEach_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Action_T_).T'></a>

`T`
#### Parameters

<a name='Currying.Extensions.ForEach_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Action_T_).collection'></a>

`collection` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](README.md#Currying.Extensions.ForEach_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Action_T_).T 'Currying\.Extensions\.ForEach\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>, System\.Action\<T\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

<a name='Currying.Extensions.ForEach_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Action_T_).action'></a>

`action` [System\.Action&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.action-1 'System\.Action\`1')[T](README.md#Currying.Extensions.ForEach_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Action_T_).T 'Currying\.Extensions\.ForEach\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>, System\.Action\<T\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.action-1 'System\.Action\`1')

The action to execute for each element\.

<a name='Currying.Extensions.op_RightShift_TSource,TIntermediate,TResult_(System.Func_TSource,TIntermediate_,System.Func_TIntermediate,TResult_)'></a>

## Extensions\.op\_RightShift\<TSource,TIntermediate,TResult\>\(Func\<TSource,TIntermediate\>, Func\<TIntermediate,TResult\>\) Method

Enables function composition using the right\-shift operator: `f1 >> f2` is equivalent to `x => f2(f1(x))`\.

```csharp
public static System.Func<TSource,TResult> op_RightShift<TSource,TIntermediate,TResult>(System.Func<TSource,TIntermediate> f1, System.Func<TIntermediate,TResult> f2);
```
#### Type parameters

<a name='Currying.Extensions.op_RightShift_TSource,TIntermediate,TResult_(System.Func_TSource,TIntermediate_,System.Func_TIntermediate,TResult_).TSource'></a>

`TSource`

<a name='Currying.Extensions.op_RightShift_TSource,TIntermediate,TResult_(System.Func_TSource,TIntermediate_,System.Func_TIntermediate,TResult_).TIntermediate'></a>

`TIntermediate`

<a name='Currying.Extensions.op_RightShift_TSource,TIntermediate,TResult_(System.Func_TSource,TIntermediate_,System.Func_TIntermediate,TResult_).TResult'></a>

`TResult`
#### Parameters

<a name='Currying.Extensions.op_RightShift_TSource,TIntermediate,TResult_(System.Func_TSource,TIntermediate_,System.Func_TIntermediate,TResult_).f1'></a>

`f1` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[TSource](README.md#Currying.Extensions.op_RightShift_TSource,TIntermediate,TResult_(System.Func_TSource,TIntermediate_,System.Func_TIntermediate,TResult_).TSource 'Currying\.Extensions\.op\_RightShift\<TSource,TIntermediate,TResult\>\(System\.Func\<TSource,TIntermediate\>, System\.Func\<TIntermediate,TResult\>\)\.TSource')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[TIntermediate](README.md#Currying.Extensions.op_RightShift_TSource,TIntermediate,TResult_(System.Func_TSource,TIntermediate_,System.Func_TIntermediate,TResult_).TIntermediate 'Currying\.Extensions\.op\_RightShift\<TSource,TIntermediate,TResult\>\(System\.Func\<TSource,TIntermediate\>, System\.Func\<TIntermediate,TResult\>\)\.TIntermediate')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

<a name='Currying.Extensions.op_RightShift_TSource,TIntermediate,TResult_(System.Func_TSource,TIntermediate_,System.Func_TIntermediate,TResult_).f2'></a>

`f2` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[TIntermediate](README.md#Currying.Extensions.op_RightShift_TSource,TIntermediate,TResult_(System.Func_TSource,TIntermediate_,System.Func_TIntermediate,TResult_).TIntermediate 'Currying\.Extensions\.op\_RightShift\<TSource,TIntermediate,TResult\>\(System\.Func\<TSource,TIntermediate\>, System\.Func\<TIntermediate,TResult\>\)\.TIntermediate')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[TResult](README.md#Currying.Extensions.op_RightShift_TSource,TIntermediate,TResult_(System.Func_TSource,TIntermediate_,System.Func_TIntermediate,TResult_).TResult 'Currying\.Extensions\.op\_RightShift\<TSource,TIntermediate,TResult\>\(System\.Func\<TSource,TIntermediate\>, System\.Func\<TIntermediate,TResult\>\)\.TResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

#### Returns
[System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[TSource](README.md#Currying.Extensions.op_RightShift_TSource,TIntermediate,TResult_(System.Func_TSource,TIntermediate_,System.Func_TIntermediate,TResult_).TSource 'Currying\.Extensions\.op\_RightShift\<TSource,TIntermediate,TResult\>\(System\.Func\<TSource,TIntermediate\>, System\.Func\<TIntermediate,TResult\>\)\.TSource')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[TResult](README.md#Currying.Extensions.op_RightShift_TSource,TIntermediate,TResult_(System.Func_TSource,TIntermediate_,System.Func_TIntermediate,TResult_).TResult 'Currying\.Extensions\.op\_RightShift\<TSource,TIntermediate,TResult\>\(System\.Func\<TSource,TIntermediate\>, System\.Func\<TIntermediate,TResult\>\)\.TResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

<a name='Currying.Extensions.op_RightShift_TSource,TResult_(System.Func_TSource,TResult_,TSource)'></a>

## Extensions\.op\_RightShift\<TSource,TResult\>\(Func\<TSource,TResult\>, TSource\) Method

Operator overload to support function\-first pipe syntax: `func >> arg`\.

```csharp
public static TResult op_RightShift<TSource,TResult>(System.Func<TSource,TResult> f, TSource x);
```
#### Type parameters

<a name='Currying.Extensions.op_RightShift_TSource,TResult_(System.Func_TSource,TResult_,TSource).TSource'></a>

`TSource`

<a name='Currying.Extensions.op_RightShift_TSource,TResult_(System.Func_TSource,TResult_,TSource).TResult'></a>

`TResult`
#### Parameters

<a name='Currying.Extensions.op_RightShift_TSource,TResult_(System.Func_TSource,TResult_,TSource).f'></a>

`f` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[TSource](README.md#Currying.Extensions.op_RightShift_TSource,TResult_(System.Func_TSource,TResult_,TSource).TSource 'Currying\.Extensions\.op\_RightShift\<TSource,TResult\>\(System\.Func\<TSource,TResult\>, TSource\)\.TSource')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[TResult](README.md#Currying.Extensions.op_RightShift_TSource,TResult_(System.Func_TSource,TResult_,TSource).TResult 'Currying\.Extensions\.op\_RightShift\<TSource,TResult\>\(System\.Func\<TSource,TResult\>, TSource\)\.TResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

<a name='Currying.Extensions.op_RightShift_TSource,TResult_(System.Func_TSource,TResult_,TSource).x'></a>

`x` [TSource](README.md#Currying.Extensions.op_RightShift_TSource,TResult_(System.Func_TSource,TResult_,TSource).TSource 'Currying\.Extensions\.op\_RightShift\<TSource,TResult\>\(System\.Func\<TSource,TResult\>, TSource\)\.TSource')

#### Returns
[TResult](README.md#Currying.Extensions.op_RightShift_TSource,TResult_(System.Func_TSource,TResult_,TSource).TResult 'Currying\.Extensions\.op\_RightShift\<TSource,TResult\>\(System\.Func\<TSource,TResult\>, TSource\)\.TResult')  
The result of invoking [f](README.md#Currying.Extensions.op_RightShift_TSource,TResult_(System.Func_TSource,TResult_,TSource).f 'Currying\.Extensions\.op\_RightShift\<TSource,TResult\>\(System\.Func\<TSource,TResult\>, TSource\)\.f') with [x](README.md#Currying.Extensions.op_RightShift_TSource,TResult_(System.Func_TSource,TResult_,TSource).x 'Currying\.Extensions\.op\_RightShift\<TSource,TResult\>\(System\.Func\<TSource,TResult\>, TSource\)\.x')\.

<a name='Currying.Extensions.op_RightShift_TSource,TResult_(System.Func_TSource_,System.Func_TSource,TResult_)'></a>

## Extensions\.op\_RightShift\<TSource,TResult\>\(Func\<TSource\>, Func\<TSource,TResult\>\) Method

Enables function composition using the right\-shift operator: `f1 >> f2` is equivalent to `() => f2(f1())`\.

```csharp
public static System.Func<TResult> op_RightShift<TSource,TResult>(System.Func<TSource> f1, System.Func<TSource,TResult> f2);
```
#### Type parameters

<a name='Currying.Extensions.op_RightShift_TSource,TResult_(System.Func_TSource_,System.Func_TSource,TResult_).TSource'></a>

`TSource`

<a name='Currying.Extensions.op_RightShift_TSource,TResult_(System.Func_TSource_,System.Func_TSource,TResult_).TResult'></a>

`TResult`
#### Parameters

<a name='Currying.Extensions.op_RightShift_TSource,TResult_(System.Func_TSource_,System.Func_TSource,TResult_).f1'></a>

`f1` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-1 'System\.Func\`1')[TSource](README.md#Currying.Extensions.op_RightShift_TSource,TResult_(System.Func_TSource_,System.Func_TSource,TResult_).TSource 'Currying\.Extensions\.op\_RightShift\<TSource,TResult\>\(System\.Func\<TSource\>, System\.Func\<TSource,TResult\>\)\.TSource')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-1 'System\.Func\`1')

<a name='Currying.Extensions.op_RightShift_TSource,TResult_(System.Func_TSource_,System.Func_TSource,TResult_).f2'></a>

`f2` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[TSource](README.md#Currying.Extensions.op_RightShift_TSource,TResult_(System.Func_TSource_,System.Func_TSource,TResult_).TSource 'Currying\.Extensions\.op\_RightShift\<TSource,TResult\>\(System\.Func\<TSource\>, System\.Func\<TSource,TResult\>\)\.TSource')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[TResult](README.md#Currying.Extensions.op_RightShift_TSource,TResult_(System.Func_TSource_,System.Func_TSource,TResult_).TResult 'Currying\.Extensions\.op\_RightShift\<TSource,TResult\>\(System\.Func\<TSource\>, System\.Func\<TSource,TResult\>\)\.TResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

#### Returns
[System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-1 'System\.Func\`1')[TResult](README.md#Currying.Extensions.op_RightShift_TSource,TResult_(System.Func_TSource_,System.Func_TSource,TResult_).TResult 'Currying\.Extensions\.op\_RightShift\<TSource,TResult\>\(System\.Func\<TSource\>, System\.Func\<TSource,TResult\>\)\.TResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-1 'System\.Func\`1')

<a name='Currying.Extensions.op_RightShift_TSource,TResult_(TSource,System.Func_TSource,TResult_)'></a>

## Extensions\.op\_RightShift\<TSource,TResult\>\(TSource, Func\<TSource,TResult\>\) Method

Applies [g](README.md#Currying.Extensions.op_RightShift_TSource,TResult_(TSource,System.Func_TSource,TResult_).g 'Currying\.Extensions\.op\_RightShift\<TSource,TResult\>\(TSource, System\.Func\<TSource,TResult\>\)\.g') to [arg](README.md#Currying.Extensions.op_RightShift_TSource,TResult_(TSource,System.Func_TSource,TResult_).arg 'Currying\.Extensions\.op\_RightShift\<TSource,TResult\>\(TSource, System\.Func\<TSource,TResult\>\)\.arg') and returns the result\.
This allows using the operator form: `value >> func`\.

```csharp
public static TResult op_RightShift<TSource,TResult>(TSource arg, System.Func<TSource,TResult> g);
```
#### Type parameters

<a name='Currying.Extensions.op_RightShift_TSource,TResult_(TSource,System.Func_TSource,TResult_).TSource'></a>

`TSource`

<a name='Currying.Extensions.op_RightShift_TSource,TResult_(TSource,System.Func_TSource,TResult_).TResult'></a>

`TResult`
#### Parameters

<a name='Currying.Extensions.op_RightShift_TSource,TResult_(TSource,System.Func_TSource,TResult_).arg'></a>

`arg` [TSource](README.md#Currying.Extensions.op_RightShift_TSource,TResult_(TSource,System.Func_TSource,TResult_).TSource 'Currying\.Extensions\.op\_RightShift\<TSource,TResult\>\(TSource, System\.Func\<TSource,TResult\>\)\.TSource')

The input value\.

<a name='Currying.Extensions.op_RightShift_TSource,TResult_(TSource,System.Func_TSource,TResult_).g'></a>

`g` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[TSource](README.md#Currying.Extensions.op_RightShift_TSource,TResult_(TSource,System.Func_TSource,TResult_).TSource 'Currying\.Extensions\.op\_RightShift\<TSource,TResult\>\(TSource, System\.Func\<TSource,TResult\>\)\.TSource')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[TResult](README.md#Currying.Extensions.op_RightShift_TSource,TResult_(TSource,System.Func_TSource,TResult_).TResult 'Currying\.Extensions\.op\_RightShift\<TSource,TResult\>\(TSource, System\.Func\<TSource,TResult\>\)\.TResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

The function to apply\.

#### Returns
[TResult](README.md#Currying.Extensions.op_RightShift_TSource,TResult_(TSource,System.Func_TSource,TResult_).TResult 'Currying\.Extensions\.op\_RightShift\<TSource,TResult\>\(TSource, System\.Func\<TSource,TResult\>\)\.TResult')  
The result of applying [g](README.md#Currying.Extensions.op_RightShift_TSource,TResult_(TSource,System.Func_TSource,TResult_).g 'Currying\.Extensions\.op\_RightShift\<TSource,TResult\>\(TSource, System\.Func\<TSource,TResult\>\)\.g') to [arg](README.md#Currying.Extensions.op_RightShift_TSource,TResult_(TSource,System.Func_TSource,TResult_).arg 'Currying\.Extensions\.op\_RightShift\<TSource,TResult\>\(TSource, System\.Func\<TSource,TResult\>\)\.arg')\.

<a name='Currying.Extensions.Pipe_T,R_(thisT,System.Action_T,R_,R)'></a>

## Extensions\.Pipe\<T,R\>\(this T, Action\<T,R\>, R\) Method

Pipes the caller into a two\-argument action along with an extra argument\.

```csharp
public static void Pipe<T,R>(this T caller, System.Action<T,R> act, R arg);
```
#### Type parameters

<a name='Currying.Extensions.Pipe_T,R_(thisT,System.Action_T,R_,R).T'></a>

`T`

<a name='Currying.Extensions.Pipe_T,R_(thisT,System.Action_T,R_,R).R'></a>

`R`

Type of the second argument accepted by [act](README.md#Currying.Extensions.Pipe_T,R_(thisT,System.Action_T,R_,R).act 'Currying\.Extensions\.Pipe\<T,R\>\(this T, System\.Action\<T,R\>, R\)\.act')\.
#### Parameters

<a name='Currying.Extensions.Pipe_T,R_(thisT,System.Action_T,R_,R).caller'></a>

`caller` [T](README.md#Currying.Extensions.Pipe_T,R_(thisT,System.Action_T,R_,R).T 'Currying\.Extensions\.Pipe\<T,R\>\(this T, System\.Action\<T,R\>, R\)\.T')

<a name='Currying.Extensions.Pipe_T,R_(thisT,System.Action_T,R_,R).act'></a>

`act` [System\.Action&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.action-2 'System\.Action\`2')[T](README.md#Currying.Extensions.Pipe_T,R_(thisT,System.Action_T,R_,R).T 'Currying\.Extensions\.Pipe\<T,R\>\(this T, System\.Action\<T,R\>, R\)\.T')[,](https://learn.microsoft.com/en-us/dotnet/api/system.action-2 'System\.Action\`2')[R](README.md#Currying.Extensions.Pipe_T,R_(thisT,System.Action_T,R_,R).R 'Currying\.Extensions\.Pipe\<T,R\>\(this T, System\.Action\<T,R\>, R\)\.R')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.action-2 'System\.Action\`2')

The action to invoke with the caller and [arg](README.md#Currying.Extensions.Pipe_T,R_(thisT,System.Action_T,R_,R).arg 'Currying\.Extensions\.Pipe\<T,R\>\(this T, System\.Action\<T,R\>, R\)\.arg')\.

<a name='Currying.Extensions.Pipe_T,R_(thisT,System.Action_T,R_,R).arg'></a>

`arg` [R](README.md#Currying.Extensions.Pipe_T,R_(thisT,System.Action_T,R_,R).R 'Currying\.Extensions\.Pipe\<T,R\>\(this T, System\.Action\<T,R\>, R\)\.R')

The additional argument passed to [act](README.md#Currying.Extensions.Pipe_T,R_(thisT,System.Action_T,R_,R).act 'Currying\.Extensions\.Pipe\<T,R\>\(this T, System\.Action\<T,R\>, R\)\.act')\.

<a name='Currying.Extensions.Pipe_T,R_(thisT,System.Func_T,R_)'></a>

## Extensions\.Pipe\<T,R\>\(this T, Func\<T,R\>\) Method

Pipes the caller through a function and returns the function result\.

```csharp
public static R Pipe<T,R>(this T caller, System.Func<T,R> f);
```
#### Type parameters

<a name='Currying.Extensions.Pipe_T,R_(thisT,System.Func_T,R_).T'></a>

`T`

<a name='Currying.Extensions.Pipe_T,R_(thisT,System.Func_T,R_).R'></a>

`R`

Return type of the function [f](README.md#Currying.Extensions.Pipe_T,R_(thisT,System.Func_T,R_).f 'Currying\.Extensions\.Pipe\<T,R\>\(this T, System\.Func\<T,R\>\)\.f')\.
#### Parameters

<a name='Currying.Extensions.Pipe_T,R_(thisT,System.Func_T,R_).caller'></a>

`caller` [T](README.md#Currying.Extensions.Pipe_T,R_(thisT,System.Func_T,R_).T 'Currying\.Extensions\.Pipe\<T,R\>\(this T, System\.Func\<T,R\>\)\.T')

<a name='Currying.Extensions.Pipe_T,R_(thisT,System.Func_T,R_).f'></a>

`f` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[T](README.md#Currying.Extensions.Pipe_T,R_(thisT,System.Func_T,R_).T 'Currying\.Extensions\.Pipe\<T,R\>\(this T, System\.Func\<T,R\>\)\.T')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[R](README.md#Currying.Extensions.Pipe_T,R_(thisT,System.Func_T,R_).R 'Currying\.Extensions\.Pipe\<T,R\>\(this T, System\.Func\<T,R\>\)\.R')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

The function to apply to the caller\.

#### Returns
[R](README.md#Currying.Extensions.Pipe_T,R_(thisT,System.Func_T,R_).R 'Currying\.Extensions\.Pipe\<T,R\>\(this T, System\.Func\<T,R\>\)\.R')  
The result of applying [f](README.md#Currying.Extensions.Pipe_T,R_(thisT,System.Func_T,R_).f 'Currying\.Extensions\.Pipe\<T,R\>\(this T, System\.Func\<T,R\>\)\.f') to the caller\.

<a name='Currying.Extensions.Pipe_T1,T2,R_(thisT1,System.Func_T1,T2,R_,T2)'></a>

## Extensions\.Pipe\<T1,T2,R\>\(this T1, Func\<T1,T2,R\>, T2\) Method

Applies a function that accepts the caller and an additional argument, returning the result\.

```csharp
public static R Pipe<T1,T2,R>(this T1 caller, System.Func<T1,T2,R> f, T2 arg);
```
#### Type parameters

<a name='Currying.Extensions.Pipe_T1,T2,R_(thisT1,System.Func_T1,T2,R_,T2).T1'></a>

`T1`

<a name='Currying.Extensions.Pipe_T1,T2,R_(thisT1,System.Func_T1,T2,R_,T2).T2'></a>

`T2`

Type of the additional argument\.

<a name='Currying.Extensions.Pipe_T1,T2,R_(thisT1,System.Func_T1,T2,R_,T2).R'></a>

`R`

Return type of the function\.
#### Parameters

<a name='Currying.Extensions.Pipe_T1,T2,R_(thisT1,System.Func_T1,T2,R_,T2).caller'></a>

`caller` [T1](README.md#Currying.Extensions.Pipe_T1,T2,R_(thisT1,System.Func_T1,T2,R_,T2).T1 'Currying\.Extensions\.Pipe\<T1,T2,R\>\(this T1, System\.Func\<T1,T2,R\>, T2\)\.T1')

<a name='Currying.Extensions.Pipe_T1,T2,R_(thisT1,System.Func_T1,T2,R_,T2).f'></a>

`f` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[T1](README.md#Currying.Extensions.Pipe_T1,T2,R_(thisT1,System.Func_T1,T2,R_,T2).T1 'Currying\.Extensions\.Pipe\<T1,T2,R\>\(this T1, System\.Func\<T1,T2,R\>, T2\)\.T1')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[T2](README.md#Currying.Extensions.Pipe_T1,T2,R_(thisT1,System.Func_T1,T2,R_,T2).T2 'Currying\.Extensions\.Pipe\<T1,T2,R\>\(this T1, System\.Func\<T1,T2,R\>, T2\)\.T2')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[R](README.md#Currying.Extensions.Pipe_T1,T2,R_(thisT1,System.Func_T1,T2,R_,T2).R 'Currying\.Extensions\.Pipe\<T1,T2,R\>\(this T1, System\.Func\<T1,T2,R\>, T2\)\.R')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')

Function to apply\.

<a name='Currying.Extensions.Pipe_T1,T2,R_(thisT1,System.Func_T1,T2,R_,T2).arg'></a>

`arg` [T2](README.md#Currying.Extensions.Pipe_T1,T2,R_(thisT1,System.Func_T1,T2,R_,T2).T2 'Currying\.Extensions\.Pipe\<T1,T2,R\>\(this T1, System\.Func\<T1,T2,R\>, T2\)\.T2')

Additional argument passed to [f](README.md#Currying.Extensions.Pipe_T1,T2,R_(thisT1,System.Func_T1,T2,R_,T2).f 'Currying\.Extensions\.Pipe\<T1,T2,R\>\(this T1, System\.Func\<T1,T2,R\>, T2\)\.f')\.

#### Returns
[R](README.md#Currying.Extensions.Pipe_T1,T2,R_(thisT1,System.Func_T1,T2,R_,T2).R 'Currying\.Extensions\.Pipe\<T1,T2,R\>\(this T1, System\.Func\<T1,T2,R\>, T2\)\.R')  
The result of [f](README.md#Currying.Extensions.Pipe_T1,T2,R_(thisT1,System.Func_T1,T2,R_,T2).f 'Currying\.Extensions\.Pipe\<T1,T2,R\>\(this T1, System\.Func\<T1,T2,R\>, T2\)\.f') invoked with [caller](README.md#Currying.Extensions.Pipe_T1,T2,R_(thisT1,System.Func_T1,T2,R_,T2).caller 'Currying\.Extensions\.Pipe\<T1,T2,R\>\(this T1, System\.Func\<T1,T2,R\>, T2\)\.caller') and [arg](README.md#Currying.Extensions.Pipe_T1,T2,R_(thisT1,System.Func_T1,T2,R_,T2).arg 'Currying\.Extensions\.Pipe\<T1,T2,R\>\(this T1, System\.Func\<T1,T2,R\>, T2\)\.arg')\.

<a name='Currying.Extensions.Pipe_T_(thisT,bool,System.Func_T,T_[])'></a>

## Extensions\.Pipe\<T\>\(this T, bool, Func\<T,T\>\[\]\) Method

Pipes the caller through a sequence of transforming functions\.
When [immutable](README.md#Currying.Extensions.Pipe_T_(thisT,bool,System.Func_T,T_[]).immutable 'Currying\.Extensions\.Pipe\<T\>\(this T, bool, System\.Func\<T,T\>\[\]\)\.immutable') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool'), the first step clones the caller using [Clone&lt;T&gt;\(this T\)](README.md#Currying.Extensions.Clone_T_(thisT) 'Currying\.Extensions\.Clone\<T\>\(this T\)') and all functions operate on the cloned value\.

```csharp
public static T Pipe<T>(this T caller, bool immutable, params System.Func<T,T>[] functions);
```
#### Type parameters

<a name='Currying.Extensions.Pipe_T_(thisT,bool,System.Func_T,T_[]).T'></a>

`T`
#### Parameters

<a name='Currying.Extensions.Pipe_T_(thisT,bool,System.Func_T,T_[]).caller'></a>

`caller` [T](README.md#Currying.Extensions.Pipe_T_(thisT,bool,System.Func_T,T_[]).T 'Currying\.Extensions\.Pipe\<T\>\(this T, bool, System\.Func\<T,T\>\[\]\)\.T')

<a name='Currying.Extensions.Pipe_T_(thisT,bool,System.Func_T,T_[]).immutable'></a>

`immutable` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

If [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool'), a shallow clone of the caller is created before applying the functions; otherwise the caller may be mutated by the functions\.

<a name='Currying.Extensions.Pipe_T_(thisT,bool,System.Func_T,T_[]).functions'></a>

`functions` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[T](README.md#Currying.Extensions.Pipe_T_(thisT,bool,System.Func_T,T_[]).T 'Currying\.Extensions\.Pipe\<T\>\(this T, bool, System\.Func\<T,T\>\[\]\)\.T')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[T](README.md#Currying.Extensions.Pipe_T_(thisT,bool,System.Func_T,T_[]).T 'Currying\.Extensions\.Pipe\<T\>\(this T, bool, System\.Func\<T,T\>\[\]\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

Sequence of functions that transform the value\.

#### Returns
[T](README.md#Currying.Extensions.Pipe_T_(thisT,bool,System.Func_T,T_[]).T 'Currying\.Extensions\.Pipe\<T\>\(this T, bool, System\.Func\<T,T\>\[\]\)\.T')  
The final transformed value after applying all [functions](README.md#Currying.Extensions.Pipe_T_(thisT,bool,System.Func_T,T_[]).functions 'Currying\.Extensions\.Pipe\<T\>\(this T, bool, System\.Func\<T,T\>\[\]\)\.functions')\.

<a name='Currying.Extensions.Pipe_T_(thisT,System.Action_T_[])'></a>

## Extensions\.Pipe\<T\>\(this T, Action\<T\>\[\]\) Method

Pipes the caller into one or more [System\.Action&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.action-1 'System\.Action\`1') delegates\.
Each action is invoked with the caller as its argument\.

```csharp
public static void Pipe<T>(this T caller, params System.Action<T>[] actions);
```
#### Type parameters

<a name='Currying.Extensions.Pipe_T_(thisT,System.Action_T_[]).T'></a>

`T`
#### Parameters

<a name='Currying.Extensions.Pipe_T_(thisT,System.Action_T_[]).caller'></a>

`caller` [T](README.md#Currying.Extensions.Pipe_T_(thisT,System.Action_T_[]).T 'Currying\.Extensions\.Pipe\<T\>\(this T, System\.Action\<T\>\[\]\)\.T')

<a name='Currying.Extensions.Pipe_T_(thisT,System.Action_T_[]).actions'></a>

`actions` [System\.Action&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.action-1 'System\.Action\`1')[T](README.md#Currying.Extensions.Pipe_T_(thisT,System.Action_T_[]).T 'Currying\.Extensions\.Pipe\<T\>\(this T, System\.Action\<T\>\[\]\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.action-1 'System\.Action\`1')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

Actions to invoke with the caller\.

<a name='Currying.Extensions.Pipe_T_(thisT,System.Func_T,T_[])'></a>

## Extensions\.Pipe\<T\>\(this T, Func\<T,T\>\[\]\) Method

Pipes the caller through a sequence of transforming functions \(non\-immutable overload\)\.

```csharp
public static T Pipe<T>(this T caller, params System.Func<T,T>[] functions);
```
#### Type parameters

<a name='Currying.Extensions.Pipe_T_(thisT,System.Func_T,T_[]).T'></a>

`T`
#### Parameters

<a name='Currying.Extensions.Pipe_T_(thisT,System.Func_T,T_[]).caller'></a>

`caller` [T](README.md#Currying.Extensions.Pipe_T_(thisT,System.Func_T,T_[]).T 'Currying\.Extensions\.Pipe\<T\>\(this T, System\.Func\<T,T\>\[\]\)\.T')

<a name='Currying.Extensions.Pipe_T_(thisT,System.Func_T,T_[]).functions'></a>

`functions` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[T](README.md#Currying.Extensions.Pipe_T_(thisT,System.Func_T,T_[]).T 'Currying\.Extensions\.Pipe\<T\>\(this T, System\.Func\<T,T\>\[\]\)\.T')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[T](README.md#Currying.Extensions.Pipe_T_(thisT,System.Func_T,T_[]).T 'Currying\.Extensions\.Pipe\<T\>\(this T, System\.Func\<T,T\>\[\]\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

Sequence of functions that transform the value\.

#### Returns
[T](README.md#Currying.Extensions.Pipe_T_(thisT,System.Func_T,T_[]).T 'Currying\.Extensions\.Pipe\<T\>\(this T, System\.Func\<T,T\>\[\]\)\.T')  
The final transformed value after applying all [functions](README.md#Currying.Extensions.Pipe_T_(thisT,System.Func_T,T_[]).functions 'Currying\.Extensions\.Pipe\<T\>\(this T, System\.Func\<T,T\>\[\]\)\.functions')\.

<a name='Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_'></a>

## Extensions\.\<G\>$8048A6C8BE30A622530249B904B537EB\<$T0\> Class

```csharp
public sealed class Extensions.<G>$8048A6C8BE30A622530249B904B537EB<$T0>
```
#### Type parameters

<a name='Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_.$T0'></a>

`$T0`

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; \<G\>$8048A6C8BE30A622530249B904B537EB\<$T0\>
### Methods

<a name='Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_.Clone()'></a>

## Extensions\.\<G\>$8048A6C8BE30A622530249B904B537EB\<$T0\>\.Clone\(\) Method

Creates a shallow copy of the current instance by invoking the protected `MemberwiseClone` method via reflection\.

```csharp
public $T0? Clone();
```

#### Returns
[$T0](README.md#Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_.$T0 'Currying\.Extensions\.\<G\>$8048A6C8BE30A622530249B904B537EB\<$T0\>\.$T0')  
A shallow copy of the current object as T, or [default](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/default') if the clone operation is not available\.

<a name='Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_.Pipe(bool,System.Func_$T0,$T0_[])'></a>

## Extensions\.\<G\>$8048A6C8BE30A622530249B904B537EB\<$T0\>\.Pipe\(bool, Func\<$T0,$T0\>\[\]\) Method

Pipes the caller through a sequence of transforming functions\.
When [immutable](README.md#Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_.Pipe(bool,System.Func_$T0,$T0_[]).immutable 'Currying\.Extensions\.\<G\>$8048A6C8BE30A622530249B904B537EB\<$T0\>\.Pipe\(bool, System\.Func\<$T0,$T0\>\[\]\)\.immutable') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool'), the first step clones the caller using [Clone&lt;T&gt;\(this T\)](README.md#Currying.Extensions.Clone_T_(thisT) 'Currying\.Extensions\.Clone\<T\>\(this T\)') and all functions operate on the cloned value\.

```csharp
public $T0 Pipe(bool immutable, params System.Func<$T0,$T0>[] functions);
```
#### Parameters

<a name='Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_.Pipe(bool,System.Func_$T0,$T0_[]).immutable'></a>

`immutable` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

If [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool'), a shallow clone of the caller is created before applying the functions; otherwise the caller may be mutated by the functions\.

<a name='Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_.Pipe(bool,System.Func_$T0,$T0_[]).functions'></a>

`functions` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[$T0](README.md#Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_.$T0 'Currying\.Extensions\.\<G\>$8048A6C8BE30A622530249B904B537EB\<$T0\>\.$T0')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[$T0](README.md#Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_.$T0 'Currying\.Extensions\.\<G\>$8048A6C8BE30A622530249B904B537EB\<$T0\>\.$T0')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

Sequence of functions that transform the value\.

#### Returns
[$T0](README.md#Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_.$T0 'Currying\.Extensions\.\<G\>$8048A6C8BE30A622530249B904B537EB\<$T0\>\.$T0')  
The final transformed value after applying all [functions](README.md#Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_.Pipe(bool,System.Func_$T0,$T0_[]).functions 'Currying\.Extensions\.\<G\>$8048A6C8BE30A622530249B904B537EB\<$T0\>\.Pipe\(bool, System\.Func\<$T0,$T0\>\[\]\)\.functions')\.

<a name='Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_.Pipe(System.Action_$T0_[])'></a>

## Extensions\.\<G\>$8048A6C8BE30A622530249B904B537EB\<$T0\>\.Pipe\(Action\<$T0\>\[\]\) Method

Pipes the caller into one or more [System\.Action&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.action-1 'System\.Action\`1') delegates\.
Each action is invoked with the caller as its argument\.

```csharp
public void Pipe(params System.Action<$T0>[] actions);
```
#### Parameters

<a name='Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_.Pipe(System.Action_$T0_[]).actions'></a>

`actions` [System\.Action&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.action-1 'System\.Action\`1')[$T0](README.md#Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_.$T0 'Currying\.Extensions\.\<G\>$8048A6C8BE30A622530249B904B537EB\<$T0\>\.$T0')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.action-1 'System\.Action\`1')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

Actions to invoke with the caller\.

<a name='Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_.Pipe(System.Func_$T0,$T0_[])'></a>

## Extensions\.\<G\>$8048A6C8BE30A622530249B904B537EB\<$T0\>\.Pipe\(Func\<$T0,$T0\>\[\]\) Method

Pipes the caller through a sequence of transforming functions \(non\-immutable overload\)\.

```csharp
public $T0 Pipe(params System.Func<$T0,$T0>[] functions);
```
#### Parameters

<a name='Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_.Pipe(System.Func_$T0,$T0_[]).functions'></a>

`functions` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[$T0](README.md#Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_.$T0 'Currying\.Extensions\.\<G\>$8048A6C8BE30A622530249B904B537EB\<$T0\>\.$T0')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[$T0](README.md#Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_.$T0 'Currying\.Extensions\.\<G\>$8048A6C8BE30A622530249B904B537EB\<$T0\>\.$T0')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

Sequence of functions that transform the value\.

#### Returns
[$T0](README.md#Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_.$T0 'Currying\.Extensions\.\<G\>$8048A6C8BE30A622530249B904B537EB\<$T0\>\.$T0')  
The final transformed value after applying all [functions](README.md#Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_.Pipe(System.Func_$T0,$T0_[]).functions 'Currying\.Extensions\.\<G\>$8048A6C8BE30A622530249B904B537EB\<$T0\>\.Pipe\(System\.Func\<$T0,$T0\>\[\]\)\.functions')\.

<a name='Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_.Pipe_R_(System.Action_$T0,R_,R)'></a>

## Extensions\.\<G\>$8048A6C8BE30A622530249B904B537EB\<$T0\>\.Pipe\<R\>\(Action\<$T0,R\>, R\) Method

Pipes the caller into a two\-argument action along with an extra argument\.

```csharp
public void Pipe<R>(System.Action<$T0,R> act, R arg);
```
#### Type parameters

<a name='Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_.Pipe_R_(System.Action_$T0,R_,R).R'></a>

`R`

Type of the second argument accepted by [act](README.md#Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_.Pipe_R_(System.Action_$T0,R_,R).act 'Currying\.Extensions\.\<G\>$8048A6C8BE30A622530249B904B537EB\<$T0\>\.Pipe\<R\>\(System\.Action\<$T0,R\>, R\)\.act')\.
#### Parameters

<a name='Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_.Pipe_R_(System.Action_$T0,R_,R).act'></a>

`act` [System\.Action&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.action-2 'System\.Action\`2')[$T0](README.md#Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_.$T0 'Currying\.Extensions\.\<G\>$8048A6C8BE30A622530249B904B537EB\<$T0\>\.$T0')[,](https://learn.microsoft.com/en-us/dotnet/api/system.action-2 'System\.Action\`2')[R](README.md#Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_.Pipe_R_(System.Action_$T0,R_,R).R 'Currying\.Extensions\.\<G\>$8048A6C8BE30A622530249B904B537EB\<$T0\>\.Pipe\<R\>\(System\.Action\<$T0,R\>, R\)\.R')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.action-2 'System\.Action\`2')

The action to invoke with the caller and [arg](README.md#Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_.Pipe_R_(System.Action_$T0,R_,R).arg 'Currying\.Extensions\.\<G\>$8048A6C8BE30A622530249B904B537EB\<$T0\>\.Pipe\<R\>\(System\.Action\<$T0,R\>, R\)\.arg')\.

<a name='Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_.Pipe_R_(System.Action_$T0,R_,R).arg'></a>

`arg` [R](README.md#Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_.Pipe_R_(System.Action_$T0,R_,R).R 'Currying\.Extensions\.\<G\>$8048A6C8BE30A622530249B904B537EB\<$T0\>\.Pipe\<R\>\(System\.Action\<$T0,R\>, R\)\.R')

The additional argument passed to [act](README.md#Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_.Pipe_R_(System.Action_$T0,R_,R).act 'Currying\.Extensions\.\<G\>$8048A6C8BE30A622530249B904B537EB\<$T0\>\.Pipe\<R\>\(System\.Action\<$T0,R\>, R\)\.act')\.

<a name='Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_.Pipe_R_(System.Func_$T0,R_)'></a>

## Extensions\.\<G\>$8048A6C8BE30A622530249B904B537EB\<$T0\>\.Pipe\<R\>\(Func\<$T0,R\>\) Method

Pipes the caller through a function and returns the function result\.

```csharp
public R Pipe<R>(System.Func<$T0,R> f);
```
#### Type parameters

<a name='Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_.Pipe_R_(System.Func_$T0,R_).R'></a>

`R`

Return type of the function [f](README.md#Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_.Pipe_R_(System.Func_$T0,R_).f 'Currying\.Extensions\.\<G\>$8048A6C8BE30A622530249B904B537EB\<$T0\>\.Pipe\<R\>\(System\.Func\<$T0,R\>\)\.f')\.
#### Parameters

<a name='Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_.Pipe_R_(System.Func_$T0,R_).f'></a>

`f` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[$T0](README.md#Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_.$T0 'Currying\.Extensions\.\<G\>$8048A6C8BE30A622530249B904B537EB\<$T0\>\.$T0')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[R](README.md#Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_.Pipe_R_(System.Func_$T0,R_).R 'Currying\.Extensions\.\<G\>$8048A6C8BE30A622530249B904B537EB\<$T0\>\.Pipe\<R\>\(System\.Func\<$T0,R\>\)\.R')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

The function to apply to the caller\.

#### Returns
[R](README.md#Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_.Pipe_R_(System.Func_$T0,R_).R 'Currying\.Extensions\.\<G\>$8048A6C8BE30A622530249B904B537EB\<$T0\>\.Pipe\<R\>\(System\.Func\<$T0,R\>\)\.R')  
The result of applying [f](README.md#Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_.Pipe_R_(System.Func_$T0,R_).f 'Currying\.Extensions\.\<G\>$8048A6C8BE30A622530249B904B537EB\<$T0\>\.Pipe\<R\>\(System\.Func\<$T0,R\>\)\.f') to the caller\.

<a name='Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_.Pipe_T2,R_(System.Func_$T0,T2,R_,T2)'></a>

## Extensions\.\<G\>$8048A6C8BE30A622530249B904B537EB\<$T0\>\.Pipe\<T2,R\>\(Func\<$T0,T2,R\>, T2\) Method

Applies a function that accepts the caller and an additional argument, returning the result\.

```csharp
public R Pipe<T2,R>(System.Func<$T0,T2,R> f, T2 arg);
```
#### Type parameters

<a name='Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_.Pipe_T2,R_(System.Func_$T0,T2,R_,T2).T2'></a>

`T2`

Type of the additional argument\.

<a name='Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_.Pipe_T2,R_(System.Func_$T0,T2,R_,T2).R'></a>

`R`

Return type of the function\.
#### Parameters

<a name='Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_.Pipe_T2,R_(System.Func_$T0,T2,R_,T2).f'></a>

`f` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[$T0](README.md#Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_.$T0 'Currying\.Extensions\.\<G\>$8048A6C8BE30A622530249B904B537EB\<$T0\>\.$T0')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[T2](README.md#Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_.Pipe_T2,R_(System.Func_$T0,T2,R_,T2).T2 'Currying\.Extensions\.\<G\>$8048A6C8BE30A622530249B904B537EB\<$T0\>\.Pipe\<T2,R\>\(System\.Func\<$T0,T2,R\>, T2\)\.T2')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[R](README.md#Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_.Pipe_T2,R_(System.Func_$T0,T2,R_,T2).R 'Currying\.Extensions\.\<G\>$8048A6C8BE30A622530249B904B537EB\<$T0\>\.Pipe\<T2,R\>\(System\.Func\<$T0,T2,R\>, T2\)\.R')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')

Function to apply\.

<a name='Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_.Pipe_T2,R_(System.Func_$T0,T2,R_,T2).arg'></a>

`arg` [T2](README.md#Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_.Pipe_T2,R_(System.Func_$T0,T2,R_,T2).T2 'Currying\.Extensions\.\<G\>$8048A6C8BE30A622530249B904B537EB\<$T0\>\.Pipe\<T2,R\>\(System\.Func\<$T0,T2,R\>, T2\)\.T2')

Additional argument passed to [f](README.md#Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_.Pipe_T2,R_(System.Func_$T0,T2,R_,T2).f 'Currying\.Extensions\.\<G\>$8048A6C8BE30A622530249B904B537EB\<$T0\>\.Pipe\<T2,R\>\(System\.Func\<$T0,T2,R\>, T2\)\.f')\.

#### Returns
[R](README.md#Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_.Pipe_T2,R_(System.Func_$T0,T2,R_,T2).R 'Currying\.Extensions\.\<G\>$8048A6C8BE30A622530249B904B537EB\<$T0\>\.Pipe\<T2,R\>\(System\.Func\<$T0,T2,R\>, T2\)\.R')  
The result of [f](README.md#Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_.Pipe_T2,R_(System.Func_$T0,T2,R_,T2).f 'Currying\.Extensions\.\<G\>$8048A6C8BE30A622530249B904B537EB\<$T0\>\.Pipe\<T2,R\>\(System\.Func\<$T0,T2,R\>, T2\)\.f') invoked with caller and [arg](README.md#Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_.Pipe_T2,R_(System.Func_$T0,T2,R_,T2).arg 'Currying\.Extensions\.\<G\>$8048A6C8BE30A622530249B904B537EB\<$T0\>\.Pipe\<T2,R\>\(System\.Func\<$T0,T2,R\>, T2\)\.arg')\.

<a name='Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_._M_$52F2F8F0E9337F24B89A66DE590D3F24'></a>

## Extensions\.\<G\>$8048A6C8BE30A622530249B904B537EB\<$T0\>\.\<M\>$52F2F8F0E9337F24B89A66DE590D3F24 Class

Pipe\-style extensions for instances of T\.

```csharp
public static class Extensions.<G>$8048A6C8BE30A622530249B904B537EB<$T0>.<M>$52F2F8F0E9337F24B89A66DE590D3F24
```
#### Type parameters

<a name='Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_._M_$52F2F8F0E9337F24B89A66DE590D3F24.$T0'></a>

`$T0`

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; \<M\>$52F2F8F0E9337F24B89A66DE590D3F24

<a name='Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_._M_$547F3ED9A1D1A8FC90B4F3B89689A128'></a>

## Extensions\.\<G\>$8048A6C8BE30A622530249B904B537EB\<$T0\>\.\<M\>$547F3ED9A1D1A8FC90B4F3B89689A128 Class

Pipes a value into a two\-argument function, returning the function result\.

```csharp
public static class Extensions.<G>$8048A6C8BE30A622530249B904B537EB<$T0>.<M>$547F3ED9A1D1A8FC90B4F3B89689A128
```
#### Type parameters

<a name='Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_._M_$547F3ED9A1D1A8FC90B4F3B89689A128.$T0'></a>

`$T0`

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; \<M\>$547F3ED9A1D1A8FC90B4F3B89689A128

<a name='Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_._M_$9693FCD04DC098E818044F36B6B87842'></a>

## Extensions\.\<G\>$8048A6C8BE30A622530249B904B537EB\<$T0\>\.\<M\>$9693FCD04DC098E818044F36B6B87842 Class

Provides object\-level helpers for a generic instance of T\.

```csharp
public static class Extensions.<G>$8048A6C8BE30A622530249B904B537EB<$T0>.<M>$9693FCD04DC098E818044F36B6B87842
```
#### Type parameters

<a name='Currying.Extensions._G_$8048A6C8BE30A622530249B904B537EB_$T0_._M_$9693FCD04DC098E818044F36B6B87842.$T0'></a>

`$T0`

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; \<M\>$9693FCD04DC098E818044F36B6B87842

<a name='Currying.Extensions._G_$8FDFD8333A6C4A7CB52CB3816594344D_$T0,$T1_'></a>

## Extensions\.\<G\>$8FDFD8333A6C4A7CB52CB3816594344D\<$T0,$T1\> Class

```csharp
public sealed class Extensions.<G>$8FDFD8333A6C4A7CB52CB3816594344D<$T0,$T1>
```
#### Type parameters

<a name='Currying.Extensions._G_$8FDFD8333A6C4A7CB52CB3816594344D_$T0,$T1_.$T0'></a>

`$T0`

<a name='Currying.Extensions._G_$8FDFD8333A6C4A7CB52CB3816594344D_$T0,$T1_.$T1'></a>

`$T1`

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; \<G\>$8FDFD8333A6C4A7CB52CB3816594344D\<$T0,$T1\>
### Operators

<a name='Currying.Extensions._G_$8FDFD8333A6C4A7CB52CB3816594344D_$T0,$T1_.op_RightShift(System.Func_$T0_,System.Func_$T0,$T1_)'></a>

## Extensions\.\<G\>$8FDFD8333A6C4A7CB52CB3816594344D\<$T0,$T1\>\.operator \>\>\(Func\<$T0\>, Func\<$T0,$T1\>\) Operator

Enables function composition using the right\-shift operator: `f1 >> f2` is equivalent to `() => f2(f1())`\.

```csharp
public static System.Func<$T1> operator >>(System.Func<$T0> f1, System.Func<$T0,$T1> f2);
```
#### Parameters

<a name='Currying.Extensions._G_$8FDFD8333A6C4A7CB52CB3816594344D_$T0,$T1_.op_RightShift(System.Func_$T0_,System.Func_$T0,$T1_).f1'></a>

`f1` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-1 'System\.Func\`1')[$T0](README.md#Currying.Extensions._G_$8FDFD8333A6C4A7CB52CB3816594344D_$T0,$T1_.$T0 'Currying\.Extensions\.\<G\>$8FDFD8333A6C4A7CB52CB3816594344D\<$T0,$T1\>\.$T0')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-1 'System\.Func\`1')

<a name='Currying.Extensions._G_$8FDFD8333A6C4A7CB52CB3816594344D_$T0,$T1_.op_RightShift(System.Func_$T0_,System.Func_$T0,$T1_).f2'></a>

`f2` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[$T0](README.md#Currying.Extensions._G_$8FDFD8333A6C4A7CB52CB3816594344D_$T0,$T1_.$T0 'Currying\.Extensions\.\<G\>$8FDFD8333A6C4A7CB52CB3816594344D\<$T0,$T1\>\.$T0')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[$T1](README.md#Currying.Extensions._G_$8FDFD8333A6C4A7CB52CB3816594344D_$T0,$T1_.$T1 'Currying\.Extensions\.\<G\>$8FDFD8333A6C4A7CB52CB3816594344D\<$T0,$T1\>\.$T1')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

#### Returns
[System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-1 'System\.Func\`1')[$T1](README.md#Currying.Extensions._G_$8FDFD8333A6C4A7CB52CB3816594344D_$T0,$T1_.$T1 'Currying\.Extensions\.\<G\>$8FDFD8333A6C4A7CB52CB3816594344D\<$T0,$T1\>\.$T1')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-1 'System\.Func\`1')

<a name='Currying.Extensions._G_$94714F2E1CB57D8C2C6720D994DCC5BA_$T0,$T1,$T2_'></a>

## Extensions\.\<G\>$94714F2E1CB57D8C2C6720D994DCC5BA\<$T0,$T1,$T2\> Class

```csharp
public sealed class Extensions.<G>$94714F2E1CB57D8C2C6720D994DCC5BA<$T0,$T1,$T2>
```
#### Type parameters

<a name='Currying.Extensions._G_$94714F2E1CB57D8C2C6720D994DCC5BA_$T0,$T1,$T2_.$T0'></a>

`$T0`

<a name='Currying.Extensions._G_$94714F2E1CB57D8C2C6720D994DCC5BA_$T0,$T1,$T2_.$T1'></a>

`$T1`

<a name='Currying.Extensions._G_$94714F2E1CB57D8C2C6720D994DCC5BA_$T0,$T1,$T2_.$T2'></a>

`$T2`

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; \<G\>$94714F2E1CB57D8C2C6720D994DCC5BA\<$T0,$T1,$T2\>
### Operators

<a name='Currying.Extensions._G_$94714F2E1CB57D8C2C6720D994DCC5BA_$T0,$T1,$T2_.op_RightShift(System.Func_$T0,$T1_,System.Func_$T1,$T2_)'></a>

## Extensions\.\<G\>$94714F2E1CB57D8C2C6720D994DCC5BA\<$T0,$T1,$T2\>\.operator \>\>\(Func\<$T0,$T1\>, Func\<$T1,$T2\>\) Operator

Enables function composition using the right\-shift operator: `f1 >> f2` is equivalent to `x => f2(f1(x))`\.

```csharp
public static System.Func<$T0,$T2> operator >>(System.Func<$T0,$T1> f1, System.Func<$T1,$T2> f2);
```
#### Parameters

<a name='Currying.Extensions._G_$94714F2E1CB57D8C2C6720D994DCC5BA_$T0,$T1,$T2_.op_RightShift(System.Func_$T0,$T1_,System.Func_$T1,$T2_).f1'></a>

`f1` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[$T0](README.md#Currying.Extensions._G_$94714F2E1CB57D8C2C6720D994DCC5BA_$T0,$T1,$T2_.$T0 'Currying\.Extensions\.\<G\>$94714F2E1CB57D8C2C6720D994DCC5BA\<$T0,$T1,$T2\>\.$T0')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[$T1](README.md#Currying.Extensions._G_$94714F2E1CB57D8C2C6720D994DCC5BA_$T0,$T1,$T2_.$T1 'Currying\.Extensions\.\<G\>$94714F2E1CB57D8C2C6720D994DCC5BA\<$T0,$T1,$T2\>\.$T1')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

<a name='Currying.Extensions._G_$94714F2E1CB57D8C2C6720D994DCC5BA_$T0,$T1,$T2_.op_RightShift(System.Func_$T0,$T1_,System.Func_$T1,$T2_).f2'></a>

`f2` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[$T1](README.md#Currying.Extensions._G_$94714F2E1CB57D8C2C6720D994DCC5BA_$T0,$T1,$T2_.$T1 'Currying\.Extensions\.\<G\>$94714F2E1CB57D8C2C6720D994DCC5BA\<$T0,$T1,$T2\>\.$T1')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[$T2](README.md#Currying.Extensions._G_$94714F2E1CB57D8C2C6720D994DCC5BA_$T0,$T1,$T2_.$T2 'Currying\.Extensions\.\<G\>$94714F2E1CB57D8C2C6720D994DCC5BA\<$T0,$T1,$T2\>\.$T2')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

#### Returns
[System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[$T0](README.md#Currying.Extensions._G_$94714F2E1CB57D8C2C6720D994DCC5BA_$T0,$T1,$T2_.$T0 'Currying\.Extensions\.\<G\>$94714F2E1CB57D8C2C6720D994DCC5BA\<$T0,$T1,$T2\>\.$T0')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[$T2](README.md#Currying.Extensions._G_$94714F2E1CB57D8C2C6720D994DCC5BA_$T0,$T1,$T2_.$T2 'Currying\.Extensions\.\<G\>$94714F2E1CB57D8C2C6720D994DCC5BA\<$T0,$T1,$T2\>\.$T2')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

<a name='Currying.Extensions._G_$9A0204638C6A592B54686EAB5A687859_$T0,$T1_'></a>

## Extensions\.\<G\>$9A0204638C6A592B54686EAB5A687859\<$T0,$T1\> Class

```csharp
public sealed class Extensions.<G>$9A0204638C6A592B54686EAB5A687859<$T0,$T1>
```
#### Type parameters

<a name='Currying.Extensions._G_$9A0204638C6A592B54686EAB5A687859_$T0,$T1_.$T0'></a>

`$T0`

<a name='Currying.Extensions._G_$9A0204638C6A592B54686EAB5A687859_$T0,$T1_.$T1'></a>

`$T1`

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; \<G\>$9A0204638C6A592B54686EAB5A687859\<$T0,$T1\>
### Operators

<a name='Currying.Extensions._G_$9A0204638C6A592B54686EAB5A687859_$T0,$T1_.op_RightShift(System.Func_$T0,$T1_,$T0)'></a>

## Extensions\.\<G\>$9A0204638C6A592B54686EAB5A687859\<$T0,$T1\>\.operator \>\>\(Func\<$T0,$T1\>, $T0\) Operator

Operator overload to support function\-first pipe syntax: `func >> arg`\.

```csharp
public static $T1 operator >>(System.Func<$T0,$T1> f, $T0 x);
```
#### Parameters

<a name='Currying.Extensions._G_$9A0204638C6A592B54686EAB5A687859_$T0,$T1_.op_RightShift(System.Func_$T0,$T1_,$T0).f'></a>

`f` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[$T0](README.md#Currying.Extensions._G_$9A0204638C6A592B54686EAB5A687859_$T0,$T1_.$T0 'Currying\.Extensions\.\<G\>$9A0204638C6A592B54686EAB5A687859\<$T0,$T1\>\.$T0')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[$T1](README.md#Currying.Extensions._G_$9A0204638C6A592B54686EAB5A687859_$T0,$T1_.$T1 'Currying\.Extensions\.\<G\>$9A0204638C6A592B54686EAB5A687859\<$T0,$T1\>\.$T1')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

<a name='Currying.Extensions._G_$9A0204638C6A592B54686EAB5A687859_$T0,$T1_.op_RightShift(System.Func_$T0,$T1_,$T0).x'></a>

`x` [$T0](README.md#Currying.Extensions._G_$9A0204638C6A592B54686EAB5A687859_$T0,$T1_.$T0 'Currying\.Extensions\.\<G\>$9A0204638C6A592B54686EAB5A687859\<$T0,$T1\>\.$T0')

#### Returns
[$T1](README.md#Currying.Extensions._G_$9A0204638C6A592B54686EAB5A687859_$T0,$T1_.$T1 'Currying\.Extensions\.\<G\>$9A0204638C6A592B54686EAB5A687859\<$T0,$T1\>\.$T1')  
The result of invoking [f](README.md#Currying.Extensions._G_$9A0204638C6A592B54686EAB5A687859_$T0,$T1_.op_RightShift(System.Func_$T0,$T1_,$T0).f 'Currying\.Extensions\.\<G\>$9A0204638C6A592B54686EAB5A687859\<$T0,$T1\>\.op\_RightShift\(System\.Func\<$T0,$T1\>, $T0\)\.f') with [x](README.md#Currying.Extensions._G_$9A0204638C6A592B54686EAB5A687859_$T0,$T1_.op_RightShift(System.Func_$T0,$T1_,$T0).x 'Currying\.Extensions\.\<G\>$9A0204638C6A592B54686EAB5A687859\<$T0,$T1\>\.op\_RightShift\(System\.Func\<$T0,$T1\>, $T0\)\.x')\.

<a name='Currying.Extensions._G_$9A0204638C6A592B54686EAB5A687859_$T0,$T1_._M_$5A2238FFFAB0868ADDC676FC9919C98F'></a>

## Extensions\.\<G\>$9A0204638C6A592B54686EAB5A687859\<$T0,$T1\>\.\<M\>$5A2238FFFAB0868ADDC676FC9919C98F Class

Provides pipe\-back helpers and an operator overload for functions so you can call `func >> value` as a shorthand for `func(value)`\.

```csharp
public static class Extensions.<G>$9A0204638C6A592B54686EAB5A687859<$T0,$T1>.<M>$5A2238FFFAB0868ADDC676FC9919C98F
```
#### Type parameters

<a name='Currying.Extensions._G_$9A0204638C6A592B54686EAB5A687859_$T0,$T1_._M_$5A2238FFFAB0868ADDC676FC9919C98F.$T0'></a>

`$T0`

<a name='Currying.Extensions._G_$9A0204638C6A592B54686EAB5A687859_$T0,$T1_._M_$5A2238FFFAB0868ADDC676FC9919C98F.$T1'></a>

`$T1`

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; \<M\>$5A2238FFFAB0868ADDC676FC9919C98F

<a name='Currying.Extensions._G_$B7F0343159FB3A22D67EC9801612841A_$T0,$T1_'></a>

## Extensions\.\<G\>$B7F0343159FB3A22D67EC9801612841A\<$T0,$T1\> Class

```csharp
public sealed class Extensions.<G>$B7F0343159FB3A22D67EC9801612841A<$T0,$T1>
```
#### Type parameters

<a name='Currying.Extensions._G_$B7F0343159FB3A22D67EC9801612841A_$T0,$T1_.$T0'></a>

`$T0`

<a name='Currying.Extensions._G_$B7F0343159FB3A22D67EC9801612841A_$T0,$T1_.$T1'></a>

`$T1`

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; \<G\>$B7F0343159FB3A22D67EC9801612841A\<$T0,$T1\>
### Operators

<a name='Currying.Extensions._G_$B7F0343159FB3A22D67EC9801612841A_$T0,$T1_.op_RightShift($T0,System.Func_$T0,$T1_)'></a>

## Extensions\.\<G\>$B7F0343159FB3A22D67EC9801612841A\<$T0,$T1\>\.operator \>\>\($T0, Func\<$T0,$T1\>\) Operator

Applies [g](README.md#Currying.Extensions._G_$B7F0343159FB3A22D67EC9801612841A_$T0,$T1_.op_RightShift($T0,System.Func_$T0,$T1_).g 'Currying\.Extensions\.\<G\>$B7F0343159FB3A22D67EC9801612841A\<$T0,$T1\>\.op\_RightShift\($T0, System\.Func\<$T0,$T1\>\)\.g') to [arg](README.md#Currying.Extensions._G_$B7F0343159FB3A22D67EC9801612841A_$T0,$T1_.op_RightShift($T0,System.Func_$T0,$T1_).arg 'Currying\.Extensions\.\<G\>$B7F0343159FB3A22D67EC9801612841A\<$T0,$T1\>\.op\_RightShift\($T0, System\.Func\<$T0,$T1\>\)\.arg') and returns the result\.
This allows using the operator form: `value >> func`\.

```csharp
public static $T1 operator >>($T0 arg, System.Func<$T0,$T1> g);
```
#### Parameters

<a name='Currying.Extensions._G_$B7F0343159FB3A22D67EC9801612841A_$T0,$T1_.op_RightShift($T0,System.Func_$T0,$T1_).arg'></a>

`arg` [$T0](README.md#Currying.Extensions._G_$B7F0343159FB3A22D67EC9801612841A_$T0,$T1_.$T0 'Currying\.Extensions\.\<G\>$B7F0343159FB3A22D67EC9801612841A\<$T0,$T1\>\.$T0')

The input value\.

<a name='Currying.Extensions._G_$B7F0343159FB3A22D67EC9801612841A_$T0,$T1_.op_RightShift($T0,System.Func_$T0,$T1_).g'></a>

`g` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[$T0](README.md#Currying.Extensions._G_$B7F0343159FB3A22D67EC9801612841A_$T0,$T1_.$T0 'Currying\.Extensions\.\<G\>$B7F0343159FB3A22D67EC9801612841A\<$T0,$T1\>\.$T0')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[$T1](README.md#Currying.Extensions._G_$B7F0343159FB3A22D67EC9801612841A_$T0,$T1_.$T1 'Currying\.Extensions\.\<G\>$B7F0343159FB3A22D67EC9801612841A\<$T0,$T1\>\.$T1')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

The function to apply\.

#### Returns
[$T1](README.md#Currying.Extensions._G_$B7F0343159FB3A22D67EC9801612841A_$T0,$T1_.$T1 'Currying\.Extensions\.\<G\>$B7F0343159FB3A22D67EC9801612841A\<$T0,$T1\>\.$T1')  
The result of applying [g](README.md#Currying.Extensions._G_$B7F0343159FB3A22D67EC9801612841A_$T0,$T1_.op_RightShift($T0,System.Func_$T0,$T1_).g 'Currying\.Extensions\.\<G\>$B7F0343159FB3A22D67EC9801612841A\<$T0,$T1\>\.op\_RightShift\($T0, System\.Func\<$T0,$T1\>\)\.g') to [arg](README.md#Currying.Extensions._G_$B7F0343159FB3A22D67EC9801612841A_$T0,$T1_.op_RightShift($T0,System.Func_$T0,$T1_).arg 'Currying\.Extensions\.\<G\>$B7F0343159FB3A22D67EC9801612841A\<$T0,$T1\>\.op\_RightShift\($T0, System\.Func\<$T0,$T1\>\)\.arg')\.

<a name='Currying.Extensions._G_$B7F0343159FB3A22D67EC9801612841A_$T0,$T1_._M_$9582521347D3786323CD533C7B4F1FAF'></a>

## Extensions\.\<G\>$B7F0343159FB3A22D67EC9801612841A\<$T0,$T1\>\.\<M\>$9582521347D3786323CD533C7B4F1FAF Class

Enables a forward "pipe" operator syntax that applies a function to a value: `value >> func`\.

```csharp
public static class Extensions.<G>$B7F0343159FB3A22D67EC9801612841A<$T0,$T1>.<M>$9582521347D3786323CD533C7B4F1FAF
```
#### Type parameters

<a name='Currying.Extensions._G_$B7F0343159FB3A22D67EC9801612841A_$T0,$T1_._M_$9582521347D3786323CD533C7B4F1FAF.$T0'></a>

`$T0`

<a name='Currying.Extensions._G_$B7F0343159FB3A22D67EC9801612841A_$T0,$T1_._M_$9582521347D3786323CD533C7B4F1FAF.$T1'></a>

`$T1`

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; \<M\>$9582521347D3786323CD533C7B4F1FAF

<a name='Currying.Extensions._G_$E09FCB5EB13C1AE2FC524F6744DE5322_$T0_'></a>

## Extensions\.\<G\>$E09FCB5EB13C1AE2FC524F6744DE5322\<$T0\> Class

```csharp
public sealed class Extensions.<G>$E09FCB5EB13C1AE2FC524F6744DE5322<$T0>
```
#### Type parameters

<a name='Currying.Extensions._G_$E09FCB5EB13C1AE2FC524F6744DE5322_$T0_.$T0'></a>

`$T0`

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; \<G\>$E09FCB5EB13C1AE2FC524F6744DE5322\<$T0\>
### Methods

<a name='Currying.Extensions._G_$E09FCB5EB13C1AE2FC524F6744DE5322_$T0_.ForEach(System.Action_$T0_)'></a>

## Extensions\.\<G\>$E09FCB5EB13C1AE2FC524F6744DE5322\<$T0\>\.ForEach\(Action\<$T0\>\) Method

Applies [action](README.md#Currying.Extensions._G_$E09FCB5EB13C1AE2FC524F6744DE5322_$T0_.ForEach(System.Action_$T0_).action 'Currying\.Extensions\.\<G\>$E09FCB5EB13C1AE2FC524F6744DE5322\<$T0\>\.ForEach\(System\.Action\<$T0\>\)\.action') to each element in collection\.

```csharp
public void ForEach(System.Action<$T0> action);
```
#### Parameters

<a name='Currying.Extensions._G_$E09FCB5EB13C1AE2FC524F6744DE5322_$T0_.ForEach(System.Action_$T0_).action'></a>

`action` [System\.Action&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.action-1 'System\.Action\`1')[$T0](README.md#Currying.Extensions._G_$E09FCB5EB13C1AE2FC524F6744DE5322_$T0_.$T0 'Currying\.Extensions\.\<G\>$E09FCB5EB13C1AE2FC524F6744DE5322\<$T0\>\.$T0')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.action-1 'System\.Action\`1')

The action to execute for each element\.

<a name='Currying.Extensions._G_$E09FCB5EB13C1AE2FC524F6744DE5322_$T0_._M_$8259634A4E4CB557CC70F4A642AD6D15'></a>

## Extensions\.\<G\>$E09FCB5EB13C1AE2FC524F6744DE5322\<$T0\>\.\<M\>$8259634A4E4CB557CC70F4A642AD6D15 Class

Enumerable\-related extension members\.

```csharp
public static class Extensions.<G>$E09FCB5EB13C1AE2FC524F6744DE5322<$T0>.<M>$8259634A4E4CB557CC70F4A642AD6D15
```
#### Type parameters

<a name='Currying.Extensions._G_$E09FCB5EB13C1AE2FC524F6744DE5322_$T0_._M_$8259634A4E4CB557CC70F4A642AD6D15.$T0'></a>

`$T0`

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; \<M\>$8259634A4E4CB557CC70F4A642AD6D15
# Filter&lt;TObservableTreeNode&gt; 方法


过滤树 - Filter Tree



## Definition
**命名空间：** <a href="N_Winemonk_Tree_Observable">Winemonk.Tree.Observable</a>  
**程序集：** Winemonk.Tree.Observable (在 Winemonk.Tree.Observable.dll 中) 版本：1.0.0+2bb30cbc0daacccd5108f4a17cd871186e9019c7

**C#**
``` C#
public static TObservableTreeNode Filter<TObservableTreeNode>(
	this IObservableTree<TObservableTreeNode> tree,
	Func<TObservableTreeNode, bool> expression,
	bool isClone = false
)
where TObservableTreeNode : class, Object, IObservableTree<TObservableTreeNode>

```



#### 参数
<dl><dt>  <a href="T_Winemonk_Tree_Observable_IObservableTree_1">IObservableTree</a>(TObservableTreeNode)</dt><dd>树实例 - Tree instance</dd><dt>  Func(TObservableTreeNode, Boolean)</dt><dd>过滤验证表达式 - Filter validation expressions</dd><dt>  Boolean  (Optional)</dt><dd>过滤结果是否以新生成的拷贝对象返回 - Is the filtering result returned as a newly generated copy object</dd></dl>

#### 类型参数
<dl><dt /><dd>树类型 - Tree type</dd></dl>

#### 返回值
TObservableTreeNode  
过滤后的树实例。 - Filtered tree instance.

#### 备注
在 Visual Basic 和 C# 中，这个方法可以当成为类型 <a href="T_Winemonk_Tree_Observable_IObservableTree_1">IObservableTree</a>(TObservableTreeNode) 的实例方法来调用。在采用实例方法语法调用这个方法时，请省略第一个参数。请参考 <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">

扩展方法 (Visual Basic)</a> 或 <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">

扩展方法 (C# 编程指南)</a> 获取更多信息。

## 异常
<table>
<tr>
<td>ArgumentNullException</td>
<td>参数为空异常 - Parameter null exception</td></tr>
<tr>
<td>NotSupportedException</td>
<td>树类型不支持此方法异常 - Tree type does not support this method exception</td></tr>
<tr>
<td>InvalidOperationException</td>
<td>克隆失败异常 - Clone failed exception</td></tr>
</table>

## 参见


#### 引用
<a href="T_Winemonk_Tree_Observable_IObservableTreeExtension">IObservableTreeExtension 类</a>  
<a href="N_Winemonk_Tree_Observable">Winemonk.Tree.Observable 命名空间</a>  

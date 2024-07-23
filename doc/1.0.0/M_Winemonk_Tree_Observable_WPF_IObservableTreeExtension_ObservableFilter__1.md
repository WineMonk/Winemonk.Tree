# ObservableFilter&lt;TTreeObservableNode&gt; 方法


过滤树，只在视图显示符合条件的节点，不修改原树结构。 - Filter tree, only display nodes that meet the criteria in the view, without modifying the original tree structure.



## Definition
**命名空间：** <a href="N_Winemonk_Tree_Observable_WPF">Winemonk.Tree.Observable.WPF</a>  
**程序集：** Winemonk.Tree.Observable.WPF (在 Winemonk.Tree.Observable.WPF.dll 中) 版本：1.0.0+2bb30cbc0daacccd5108f4a17cd871186e9019c7

**C#**
``` C#
public static void ObservableFilter<TTreeObservableNode>(
	this IObservableTree<TTreeObservableNode> tree,
	Func<TTreeObservableNode, bool> expression
)
where TTreeObservableNode : class, Object, IObservableTree<TTreeObservableNode>

```



#### 参数
<dl><dt>  <a href="T_Winemonk_Tree_Observable_IObservableTree_1">IObservableTree</a>(TTreeObservableNode)</dt><dd>树实例 - Tree instance</dd><dt>  Func(TTreeObservableNode, Boolean)</dt><dd>过滤验证表达式 - Filter validation expressions</dd></dl>

#### 类型参数
<dl><dt /><dd>树类型 - Tree type</dd></dl>

#### 备注
在 Visual Basic 和 C# 中，这个方法可以当成为类型 <a href="T_Winemonk_Tree_Observable_IObservableTree_1">IObservableTree</a>(TTreeObservableNode) 的实例方法来调用。在采用实例方法语法调用这个方法时，请省略第一个参数。请参考 <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">

扩展方法 (Visual Basic)</a> 或 <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">

扩展方法 (C# 编程指南)</a> 获取更多信息。

## 异常
<table>
<tr>
<td>ArgumentNullException</td>
<td>参数为空异常 - Parameter null exception</td></tr>
</table>

## 参见


#### 引用
<a href="T_Winemonk_Tree_Observable_WPF_IObservableTreeExtension">IObservableTreeExtension 类</a>  
<a href="N_Winemonk_Tree_Observable_WPF">Winemonk.Tree.Observable.WPF 命名空间</a>  

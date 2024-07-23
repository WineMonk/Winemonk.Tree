# Traversal&lt;TTreeNode&gt;(ITree&lt;TTreeNode&gt;, Action&lt;TTreeNode&gt;) 方法


遍历树 - Traverse the tree



## Definition
**命名空间：** <a href="N_Winemonk_Tree.md">Winemonk.Tree</a>  
**程序集：** Winemonk.Tree (在 Winemonk.Tree.dll 中) 版本：1.0.0+94f2fcb0c15f0cda11677227f4ab0456f1fd5d70

**C#**
``` C#
public static void Traversal<TTreeNode>(
	this ITree<TTreeNode> tree,
	Action<TTreeNode> expression
)
where TTreeNode : class, Object, ITree<TTreeNode>

```



#### 参数
<dl><dt>  <a href="T_Winemonk_Tree_ITree_1.md">ITree</a>(TTreeNode)</dt><dd>树实例 - Tree instance</dd><dt>  Action(TTreeNode)</dt><dd>遍历表达式 - Traverse expression</dd></dl>

#### 类型参数
<dl><dt /><dd>树类型 - Tree type</dd></dl>

#### 备注
在 Visual Basic 和 C# 中，这个方法可以当成为类型 <a href="T_Winemonk_Tree_ITree_1.md">ITree</a>(TTreeNode) 的实例方法来调用。在采用实例方法语法调用这个方法时，请省略第一个参数。请参考 <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">

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
</table>

## 参见


#### 引用
<a href="T_Winemonk_Tree_ITreeExtension.md">ITreeExtension 类</a>  
<a href="Overload_Winemonk_Tree_ITreeExtension_Traversal.md">Traversal 重载</a>  
<a href="N_Winemonk_Tree.md">Winemonk.Tree 命名空间</a>  

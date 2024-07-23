# IObservableTree&lt;TTreeNode&gt; 接口


可感知树接口 - Perceived tree interface



## Definition
**命名空间：** <a href="N_Winemonk_Tree_Observable.md">Winemonk.Tree.Observable</a>  
**程序集：** Winemonk.Tree.Observable (在 Winemonk.Tree.Observable.dll 中) 版本：1.0.0+94f2fcb0c15f0cda11677227f4ab0456f1fd5d70

**C#**
``` C#
public interface IObservableTree<TTreeNode>
where TTreeNode : Object, IObservableTree<TTreeNode>

```



#### 类型参数
<dl><dt /><dd>节点类型 - Node type</dd></dl>

## 属性
<table>
<tr>
<td><a href="P_Winemonk_Tree_Observable_IObservableTree_1_Children.md">Children</a></td>
<td>子节点 - Children nodes</td></tr>
<tr>
<td><a href="P_Winemonk_Tree_Observable_IObservableTree_1_Parent.md">Parent</a></td>
<td>父节点 - Parent node</td></tr>
</table>

## 方法
<table>
<tr>
<td><a href="M_Winemonk_Tree_Observable_IObservableTree_1_Clone.md">Clone</a></td>
<td>克隆 - Clone</td></tr>
</table>

## 扩展方法
<table>
<tr>
<td><a href="M_Winemonk_Tree_Observable_IObservableTreeExtension_Filter__1.md">Filter(TObservableTreeNode)</a></td>
<td>过滤树 - Filter Tree<br />(由 <a href="T_Winemonk_Tree_Observable_IObservableTreeExtension.md">IObservableTreeExtension</a> 定义。)</td></tr>
<tr>
<td><a href="M_Winemonk_Tree_Observable_WPF_IObservableTreeExtension_ObservableFilter__1.md">ObservableFilter(TTreeObservableNode)</a></td>
<td>过滤树，只在视图显示符合条件的节点，不修改原树结构。 - Filter tree, only display nodes that meet the criteria in the view, without modifying the original tree structure.<br />(由 <a href="T_Winemonk_Tree_Observable_WPF_IObservableTreeExtension.md">IObservableTreeExtension</a> 定义。)</td></tr>
<tr>
<td><a href="M_Winemonk_Tree_Observable_IObservableTreeExtension_Traversal__1.md">Traversal(TObservableTreeNode)</a></td>
<td>遍历树 - Traverse the tree<br />(由 <a href="T_Winemonk_Tree_Observable_IObservableTreeExtension.md">IObservableTreeExtension</a> 定义。)</td></tr>
</table>

## 参见


#### 引用
<a href="N_Winemonk_Tree_Observable.md">Winemonk.Tree.Observable 命名空间</a>  

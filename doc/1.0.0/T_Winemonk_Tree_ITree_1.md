# ITree&lt;TTreeNode&gt; 接口


树接口 - Tree interface



## Definition
**命名空间：** <a href="N_Winemonk_Tree.md">Winemonk.Tree</a>  
**程序集：** Winemonk.Tree (在 Winemonk.Tree.dll 中) 版本：1.0.0+94f2fcb0c15f0cda11677227f4ab0456f1fd5d70

**C#**
``` C#
public interface ITree<TTreeNode>
where TTreeNode : Object, ITree<TTreeNode>

```



#### 类型参数
<dl><dt /><dd>节点类型 - Node type</dd></dl>

## 属性
<table>
<tr>
<td><a href="P_Winemonk_Tree_ITree_1_Children.md">Children</a></td>
<td>子节点 - Child nodes</td></tr>
<tr>
<td><a href="P_Winemonk_Tree_ITree_1_Parent.md">Parent</a></td>
<td>父节点 - Parent Node</td></tr>
</table>

## 方法
<table>
<tr>
<td><a href="M_Winemonk_Tree_ITree_1_Clone.md">Clone</a></td>
<td>克隆 - Clone</td></tr>
</table>

## 扩展方法
<table>
<tr>
<td><a href="M_Winemonk_Tree_ITreeExtension_Filter__1.md">Filter(TTreeNode)</a></td>
<td>过滤树 - Filter Tree<br />(由 <a href="T_Winemonk_Tree_ITreeExtension.md">ITreeExtension</a> 定义。)</td></tr>
<tr>
<td><a href="M_Winemonk_Tree_ITreeExtension_Traversal__1.md">Traversal(TTreeNode)</a></td>
<td>遍历树 - Traverse the tree<br />(由 <a href="T_Winemonk_Tree_ITreeExtension.md">ITreeExtension</a> 定义。)</td></tr>
</table>

## 参见


#### 引用
<a href="N_Winemonk_Tree.md">Winemonk.Tree 命名空间</a>  

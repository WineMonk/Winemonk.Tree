# ITree&lt;TKey, TTreeNode&gt; 接口


拥有键的树接口 - Tree interface with keys



## Definition
**命名空间：** <a href="N_Winemonk_Tree.md">Winemonk.Tree</a>  
**程序集：** Winemonk.Tree (在 Winemonk.Tree.dll 中) 版本：1.0.0+94f2fcb0c15f0cda11677227f4ab0456f1fd5d70

**C#**
``` C#
public interface ITree<TKey, TTreeNode>
where TTreeNode : Object, ITree<TKey, TTreeNode>

```



#### 类型参数
<dl><dt /><dd>键类型 - Key type</dd><dt /><dd>节点类型 - Node type</dd></dl>

## 属性
<table>
<tr>
<td><a href="P_Winemonk_Tree_ITree_2_Children.md">Children</a></td>
<td>子节点 - Child nodes</td></tr>
<tr>
<td><a href="P_Winemonk_Tree_ITree_2_Item.md">Item</a></td>
<td>子节点索引器 - Child node indexer</td></tr>
<tr>
<td><a href="P_Winemonk_Tree_ITree_2_Key.md">Key</a></td>
<td>键 - Key</td></tr>
<tr>
<td><a href="P_Winemonk_Tree_ITree_2_Parent.md">Parent</a></td>
<td>父节点 - Parent Node</td></tr>
<tr>
<td><a href="P_Winemonk_Tree_ITree_2_PKey.md">PKey</a></td>
<td>父节点键 - Parent node key</td></tr>
</table>

## 方法
<table>
<tr>
<td><a href="M_Winemonk_Tree_ITree_2_Clone.md">Clone</a></td>
<td>克隆 - Clone</td></tr>
</table>

## 参见


#### 引用
<a href="N_Winemonk_Tree.md">Winemonk.Tree 命名空间</a>  

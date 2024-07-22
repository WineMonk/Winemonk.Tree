using System.Collections.Generic;

namespace Winemonk.Tree
{
    /// <summary>
    ///     树接口 - Tree interface
    /// </summary>
    /// <typeparam name="TTreeNode">
    ///     节点类型 - Node type
    /// </typeparam>
    public interface ITree<TTreeNode> where TTreeNode : ITree<TTreeNode>
    {
        /// <summary>
        ///     父节点 - Parent Node
        /// </summary>
        /// <remarks>
        ///     序列化时需要忽略此属性！- This attribute needs to be ignored during serialization!
        /// </remarks>
        TTreeNode Parent { get; set; }
        /// <summary>
        ///     子节点 - Child nodes
        /// </summary>
        List<TTreeNode> Children { get; set; }
        /// <summary>
        ///     克隆 - Clone
        /// </summary>
        /// <returns>
        ///     克隆实例。 - Cloned instance.
        /// </returns>
        TTreeNode Clone();
    }
}

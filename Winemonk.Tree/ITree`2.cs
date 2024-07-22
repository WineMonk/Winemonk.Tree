using System.Collections.Generic;

namespace Winemonk.Tree
{
    /// <summary>
    ///     拥有键的树接口 - Tree interface with keys
    /// </summary>
    /// <typeparam name="TKey">键类型 - Key type</typeparam>
    /// <typeparam name="TTreeNode">节点类型 - Node type</typeparam>
#if NET5_0_OR_GREATER
    public interface ITree<TKey, TTreeNode> where TTreeNode : ITree<TKey, TTreeNode> where TKey : notnull
#else
    public interface ITree<TKey, TTreeNode> where TTreeNode : ITree<TKey, TTreeNode>
#endif
    {
        /// <summary>
        ///     键 - Key
        /// </summary>
        TKey Key { get; set; }
        /// <summary>
        ///     父节点键 - Parent node key
        /// </summary>
        TKey PKey { get; }
        /// <summary>
        ///     父节点 - Parent Node
        /// </summary>
        /// <remarks>
        ///     序列化时需要忽略此属性！ - This attribute needs to be ignored during serialization!
        /// </remarks>
        TTreeNode Parent { get; set; }
        /// <summary>
        ///     子节点 - Child nodes
        /// </summary>
        Dictionary<TKey, TTreeNode> Children { get; set; }
        /// <summary>
        ///     子节点索引器 - Child node indexer
        /// </summary>
        /// <param name="key">键 - Key</param>
        /// <returns>
        ///     对应子节点。 - Corresponding child nodes.
        /// </returns>
        TTreeNode this[TKey key] { get; set; }
        /// <summary>
        ///     克隆 - Clone
        /// </summary>
        /// <returns>
        ///     克隆实例。 - Clone instance.
        /// </returns>
        TTreeNode Clone();
    }
}

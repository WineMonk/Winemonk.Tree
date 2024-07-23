using System.Collections.ObjectModel;

namespace Winemonk.Tree.Observable
{
    /// <summary>
    ///     可感知树接口 - Perceived tree interface
    /// </summary>
    /// <typeparam name="TTreeNode">节点类型 - Node type</typeparam>
    public interface IObservableTree<TTreeNode> where TTreeNode : IObservableTree<TTreeNode>
    {
        /// <summary>
        ///     父节点 - Parent node
        /// </summary>
        /// <remarks>
        ///     序列化时需要忽略此属性！ - This property should be ignored when serializing!
        /// </remarks>
        TTreeNode Parent { get; set; }
        /// <summary>
        ///     子节点 - Children nodes
        /// </summary>
        ObservableCollection<TTreeNode> Children { get; set; }
        /// <summary>
        ///     克隆 - Clone
        /// </summary>
        /// <returns>
        ///     克隆实例。 - Clone instance.
        /// </returns>
        TTreeNode Clone();
    }
}

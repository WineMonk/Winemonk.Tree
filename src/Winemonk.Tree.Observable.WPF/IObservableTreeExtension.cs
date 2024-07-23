using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;

namespace Winemonk.Tree.Observable.WPF
{
    /// <summary>
    ///     可感知树扩展 - Perceived tree extension
    /// </summary>
    public static class IObservableTreeExtension
    {
        /// <summary>
        ///     过滤树，只在视图显示符合条件的节点，不修改原树结构。 - Filter tree, only display nodes that meet the criteria in the view, without modifying the original tree structure.
        /// </summary>
        /// <typeparam name="TTreeObservableNode">树类型 - Tree type</typeparam>
        /// <param name="tree">树实例 - Tree instance</param>
        /// <param name="expression">过滤验证表达式 - Filter validation expressions</param>
        /// <exception cref="ArgumentNullException">参数为空异常 - Parameter null exception</exception>
        public static void ObservableFilter<TTreeObservableNode>(this IObservableTree<TTreeObservableNode> tree, Func<TTreeObservableNode, bool> expression) where TTreeObservableNode : class, IObservableTree<TTreeObservableNode>
        {
            if (tree == null)
            {
                throw new ArgumentNullException(nameof(tree));
            }
            if (expression == null)
            {
                throw new ArgumentNullException(nameof(expression));
            }
            ObservableFilterRec(tree, expression);
        }
        private static bool ObservableFilterRec<TObservableTreeNode>(IObservableTree<TObservableTreeNode> tree, Func<TObservableTreeNode, bool> expression) where TObservableTreeNode : class, IObservableTree<TObservableTreeNode>
        {
            if (tree?.Children == null)
            {
                return false;
            }
            List<TObservableTreeNode> conformingNodes = new List<TObservableTreeNode>();
            foreach (var child in tree.Children)
            {
                if (ObservableFilterRec(child, expression))
                {
                    conformingNodes.Add(child);
                }
            }
            ObservableCollection<TObservableTreeNode> children = tree.Children;
            ICollectionView _collectionView = CollectionViewSource.GetDefaultView(children);
            if (_collectionView == null)
            {
                return false;
            }
            _collectionView.Filter = n => n is TObservableTreeNode node && (conformingNodes.Contains(node) || expression(node));
            return !_collectionView.IsEmpty;
        }
    }
}

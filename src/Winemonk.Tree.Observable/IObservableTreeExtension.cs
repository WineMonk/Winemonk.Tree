using System;
using System.Collections.ObjectModel;

namespace Winemonk.Tree.Observable
{
    /// <summary>
    ///     可感知树扩展 - Perceived tree extension
    /// </summary>
    public static class IObservableTreeExtension
    {
        /// <summary>
        ///     过滤树 - Filter Tree
        /// </summary>
        /// <typeparam name="TObservableTreeNode">树类型 - Tree type</typeparam>
        /// <param name="tree">树实例 - Tree instance</param>
        /// <param name="expression">过滤验证表达式 - Filter validation expressions</param>
        /// <param name="isClone">过滤结果是否以新生成的拷贝对象返回 - Is the filtering result returned as a newly generated copy object</param>
        /// <returns>
        ///     过滤后的树实例。 - Filtered tree instance.
        /// </returns>
        /// <exception cref="ArgumentNullException">参数为空异常 - Parameter null exception</exception>
        /// <exception cref="NotSupportedException">树类型不支持此方法异常 - Tree type does not support this method exception</exception>
        /// <exception cref="InvalidOperationException">克隆失败异常 - Clone failed exception</exception>
        public static TObservableTreeNode Filter<TObservableTreeNode>(this IObservableTree<TObservableTreeNode> tree, Func<TObservableTreeNode, bool> expression, bool isClone = false) where TObservableTreeNode : class, IObservableTree<TObservableTreeNode>
        {
            if (tree == null)
            {
                throw new ArgumentNullException(nameof(tree));
            }
            if (expression == null)
            {
                throw new ArgumentNullException(nameof(expression));
            }
            if (!(tree is TObservableTreeNode treeNode))
            {
                throw new NotSupportedException($"{tree.GetType().Name} is not supported.");
            }
            TObservableTreeNode operateTree = treeNode;
            if (isClone)
            {
                operateTree = tree.Clone();
                if (operateTree == null)
                {
                    throw new InvalidOperationException("Clone method is not supported.");
                }
            }
            FilterRec(operateTree, expression);
            return operateTree;
        }
        private static bool FilterRec<TObservableTreeNode>(IObservableTree<TObservableTreeNode> recTree, Func<TObservableTreeNode, bool> expression) where TObservableTreeNode : class, IObservableTree<TObservableTreeNode>
        {
            if (recTree == null || recTree.Children == null || recTree.Children.Count == 0)
            {
                return false;
            }
            ObservableCollection<TObservableTreeNode> conformingNodes = new ObservableCollection<TObservableTreeNode>();
            foreach (var child in recTree.Children)
            {
                bool conform = FilterRec(child, expression);
                if (conform)
                {
                    conformingNodes.Add(child);
                }
            }
            recTree.Children = conformingNodes;
            return conformingNodes.Count > 0 || (recTree is TObservableTreeNode tn && expression(tn));
        }

        /// <summary>
        /// 遍历树 - Traverse the tree
        /// </summary>
        /// <typeparam name="TObservableTreeNode">树类型 - Tree type</typeparam>
        /// <param name="tree">树实例 - Tree instance</param>
        /// <param name="expression">过滤验证表达式 - Filter validation expressions</param>
        /// <exception cref="ArgumentNullException">参数为空异常 - Parameter null exception</exception>
        /// <exception cref="NotSupportedException">树类型不支持此方法异常 - Tree type does not support this method exception</exception>
        public static void Traversal<TObservableTreeNode>(this IObservableTree<TObservableTreeNode> tree, Action<TObservableTreeNode> expression) where TObservableTreeNode : class, IObservableTree<TObservableTreeNode>
        {
            if (tree is null)
            {
                throw new ArgumentNullException(nameof(tree));
            }
            if (expression is null)
            {
                throw new ArgumentNullException(nameof(expression));
            }
            if (!(tree is TObservableTreeNode treeNode))
            {
                throw new NotSupportedException($"{tree.GetType().Name} is not supported.");
            }
            expression(treeNode);
            if (tree.Children != null && tree.Children.Count > 0)
            {
                foreach (var child in tree.Children)
                {
                    Traversal(child, expression);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace Winemonk.Tree
{
    /// <summary>
    ///     树扩展 - Tree Extension
    /// </summary>
    public static class ITreeExtension
    {
        #region ITree`1

        /// <summary>
        ///     过滤树 - Filter Tree
        /// </summary>
        /// <typeparam name="TTreeNode">树类型 - Tree type</typeparam>
        /// <param name="tree">树实例 - Tree instance</param>
        /// <param name="expression">过滤验证表达式 - Filter validation expressions</param>
        /// <param name="isClone">过滤结果是否以新生成的拷贝对象返回 - Is the filtering result returned as a newly generated copy object</param>
        /// <returns>
        ///     过滤后的树实例。 - Filtered tree instance.
        /// </returns>
        /// <exception cref="ArgumentNullException">参数为空异常 - Parameter null exception</exception>
        /// <exception cref="NotSupportedException">树类型不支持此方法异常 - Tree type does not support this method exception</exception>
        /// <exception cref="InvalidOperationException">克隆失败异常 - Clone failed exception</exception>
        public static TTreeNode Filter<TTreeNode>(this ITree<TTreeNode> tree, Func<TTreeNode, bool> expression, bool isClone = false) where TTreeNode : class, ITree<TTreeNode>
        {
            if (tree == null)
            {
                throw new ArgumentNullException(nameof(tree));
            }
            if (expression == null)
            {
                throw new ArgumentNullException(nameof(expression));
            }
            if (!(tree is TTreeNode treeNode))
            {
                throw new NotSupportedException($"{tree.GetType().Name} is not supported.");
            }
            TTreeNode operateTree = treeNode;
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
        private static bool FilterRec<TTreeNode>(ITree<TTreeNode> recTree, Func<TTreeNode, bool> expression) where TTreeNode : class, ITree<TTreeNode>
        {
            if (recTree == null || recTree.Children == null || recTree.Children.Count == 0)
            {
                return false;
            }
            List<TTreeNode> conformingNodes = new List<TTreeNode>();
            foreach (var child in recTree.Children)
            {
                bool conform = FilterRec(child, expression);
                if (conform)
                {
                    conformingNodes.Add(child);
                }
            }
            recTree.Children = conformingNodes;
            return conformingNodes.Count > 0 || (recTree is TTreeNode tn && expression(tn));
        }

        /// <summary>
        ///     遍历树 - Traverse the tree
        /// </summary>
        /// <typeparam name="TTreeNode">树类型 - Tree type</typeparam>
        /// <param name="tree">树实例 - Tree instance</param>
        /// <param name="expression">遍历表达式 - Traverse expression</param>
        /// <exception cref="ArgumentNullException">参数为空异常 - Parameter null exception</exception>
        /// <exception cref="NotSupportedException">树类型不支持此方法异常 - Tree type does not support this method exception</exception>
        public static void Traversal<TTreeNode>(this ITree<TTreeNode> tree, Action<TTreeNode> expression) where TTreeNode : class, ITree<TTreeNode>
        {
            if (tree is null)
            {
                throw new ArgumentNullException(nameof(tree));
            }
            if (expression is null)
            {
                throw new ArgumentNullException(nameof(expression));
            }
            if (!(tree is TTreeNode treeNode))
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

        #endregion ITree`1

        #region ITree`2

        /// <summary>
        ///     过滤树 - Filter Tree
        /// </summary>
        /// <typeparam name="TKey">键类型 - Key type</typeparam>
        /// <typeparam name="TTreeNode">树类型 - Tree type</typeparam>
        /// <param name="tree">树实例 - Tree instance</param>
        /// <param name="expression">过滤验证表达式 - Filter validation expressions</param>
        /// <param name="isClone">过滤结果是否以新生成的拷贝对象返回 - Is the filtering result returned as a newly generated copy object</param>
        /// <returns>
        ///     过滤后的树实例。 - Filtered tree instance.
        /// </returns>
        /// <exception cref="ArgumentNullException">参数为空异常 - Parameter null exception</exception>
        /// <exception cref="NotSupportedException">树类型不支持此方法异常 - Tree type does not support this method exception</exception>
        /// <exception cref="InvalidOperationException">克隆失败异常 - Clone failed exception</exception>
#if NET5_0_OR_GREATER
        public static TTreeNode Filter<TKey, TTreeNode>(this ITree<TKey, TTreeNode> tree, Func<TTreeNode, bool> expression, bool isClone = false) where TTreeNode : class, ITree<TKey, TTreeNode> where TKey : notnull
#else
        public static TTreeNode Filter<TKey, TTreeNode>(this ITree<TKey, TTreeNode> tree, Func<TTreeNode, bool> expression, bool isClone = false) where TTreeNode : class, ITree<TKey, TTreeNode>
#endif
        {
            if (tree == null)
            {
                throw new ArgumentNullException(nameof(tree));
            }
            if (expression == null)
            {
                throw new ArgumentNullException(nameof(expression));
            }
            if (!(tree is TTreeNode treeNode))
            {
                throw new NotSupportedException($"{tree.GetType().Name} is not supported.");
            }
            TTreeNode operateTree = treeNode;
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
#if NET5_0_OR_GREATER
        private static bool FilterRec<TKey, TTreeNode>(ITree<TKey, TTreeNode> recTree, Func<TTreeNode, bool> expression) where TTreeNode : class, ITree<TKey, TTreeNode> where TKey : notnull
#else
        private static bool FilterRec<TKey, TTreeNode>(ITree<TKey, TTreeNode> recTree, Func<TTreeNode, bool> expression) where TTreeNode : class, ITree<TKey, TTreeNode>
#endif
        {
            if (recTree == null || recTree.Children == null || recTree.Children.Count == 0)
            {
                return false;
            }

            Dictionary<TKey, TTreeNode> conformingNodes = new Dictionary<TKey, TTreeNode>();
            foreach (var child in recTree.Children)
            {
                bool conform = FilterRec(child.Value, expression);
                if (conform)
                {
                    conformingNodes.Add(child.Key, child.Value);
                }
            }
            recTree.Children = conformingNodes;
            return conformingNodes.Count > 0 || (recTree is TTreeNode tn && expression(tn));
        }

        /// <summary>
        ///     遍历树 - Traverse the tree
        /// </summary>
        /// <typeparam name="TKey">键类型 - Key type</typeparam>
        /// <typeparam name="TTreeNode">树类型 - Tree type</typeparam>
        /// <param name="tree">树实例 - Tree instance</param>
        /// <param name="expression">遍历表达式 - Traverse expression</param>
        /// <exception cref="ArgumentNullException">参数为空异常 - Parameter null exception</exception>
        /// <exception cref="NotSupportedException">树类型不支持此方法异常 - Tree type does not support this method exception</exception>
#if NET5_0_OR_GREATER
        public static void Traversal<TKey, TTreeNode>(this ITree<TKey, TTreeNode> tree, Action<TTreeNode> expression) where TTreeNode : class, ITree<TKey, TTreeNode> where TKey : notnull
#else
        public static void Traversal<TKey, TTreeNode>(this ITree<TKey, TTreeNode> tree, Action<TTreeNode> expression) where TTreeNode : class, ITree<TKey, TTreeNode>
#endif
        {
            if (tree is null)
            {
                throw new ArgumentNullException(nameof(tree));
            }
            if (expression is null)
            {
                throw new ArgumentNullException(nameof(expression));
            }
            if (!(tree is TTreeNode treeNode))
            {
                throw new NotSupportedException($"{tree.GetType().Name} is not supported.");
            }
            expression.Invoke(treeNode);
            if (tree.Children != null && tree.Children.Count > 0)
            {
                foreach (var child in tree.Children.Values)
                {
                    Traversal(child, expression);
                }
            }
        }

        #endregion ITree`2
    }
}

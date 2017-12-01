using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
	public class LinkBinaryTree<T>
	{
		public TreeNode<T> RootNode { get; set; }

		public LinkBinaryTree()
		{
		}

		public LinkBinaryTree(T value, TreeNode<T> leftChild = default, TreeNode<T> rightChild = default)
		{
			if (value == null)
				return;
			RootNode = new TreeNode<T>(value, leftChild, rightChild);
		}

		/// <summary>
		/// 判断是否是空二叉树
		/// </summary>
		/// <returns></returns>
		public bool IsEmpty()
		{
			return RootNode == null;
		}

		/// <summary>
		/// 获取跟结点
		/// </summary>
		/// <returns></returns>
		public TreeNode<T> Root()
		{
			return RootNode;
		}

		/// <summary>
		/// 获取结点的左子树
		/// </summary>
		/// <param name="node"></param>
		/// <returns></returns>
		public TreeNode<T> LeftChild(TreeNode<T> node)
		{
			return node.LeftChild;
		}

		/// <summary>
		/// 获取结点的右子树
		/// </summary>
		/// <param name="node"></param>
		/// <returns></returns>
		public TreeNode<T> RightChild(TreeNode<T> node)
		{
			return node.RightChild;
		}

		/// <summary>
		/// 给指定的结点插入左子树
		/// </summary>
		/// <param name="value"></param>
		/// <param name="node">要插入的结点</param>
		public void InsertLeftChild(T value, TreeNode<T> node)
		{
			node.LeftChild = new TreeNode<T>(value) { LeftChild = node.LeftChild };
		}

		/// <summary>
		/// 给指定的结点插入右子树
		/// </summary>
		/// <param name="value"></param>
		/// <param name="node">要插入的结点</param>
		public void InsertRightChild(T value, TreeNode<T> node)
		{
			node.RightChild = new TreeNode<T>(value) { RightChild = node.RightChild };
		}

		/// <summary>
		/// 删除左子树
		/// </summary>
		/// <param name="node"></param>
		public void RemoveLeftChild(TreeNode<T> node)
		{
			node.LeftChild = null;
		}

		/// <summary>
		/// 删除右子树
		/// </summary>
		/// <param name="node"></param>
		public void RemoveRightChild(TreeNode<T> node)
		{
			node.RightChild = null;
		}

		/// <summary>
		/// 判断是否是叶子结点
		/// </summary>
		/// <param name="node"></param>
		/// <returns></returns>9+
		public bool IsLeaf(TreeNode<T> node)
		{
			return node != null && node.LeftChild == null && node.RightChild == null;
		}

		/// <summary>
		/// 先序递归查找（根—左—右）
		/// </summary>
		/// <param name="value"></param>
		/// <param name="startNode">开始的结点，默认从数的根结点开始</param>
		/// <returns></returns>
		public TreeNode<T> PreOrderSearch(T value, TreeNode<T> startNode)
		{
			//if (startNode == null)
			//	startNode = RootNode;
			//if (startNode.Value.Equals(value))
			//	return startNode;
			Console.WriteLine(startNode.Value);
			if (startNode.LeftChild != null)
				return PreOrderSearch(value, startNode.LeftChild);
			if (startNode.RightChild != null)
				return PreOrderSearch(value, startNode.RightChild);
			return null;
		}

		/// <summary>
		/// 先序递归遍历
		/// </summary>
		/// <param name="startNode"></param>
		public void PreRecurrsive(TreeNode<T> startNode)
		{
			if (startNode != null)
			{
				Console.Write(startNode.Value + "  ");
				PreRecurrsive(startNode.LeftChild);
				PreRecurrsive(startNode.RightChild);
			}
		}
		/// <summary>
		/// 先序非递归遍历
		/// </summary>
		/// <param name="startNode"></param>
		public void PreTraverse(TreeNode<T> startNode)
		{
			if (startNode == null)
				return;
			var stack = new Stack<TreeNode<T>>();
			Console.Write(startNode.Value + "  ");
			stack.Push(startNode);
			var temp = startNode.LeftChild;
			while (stack.Count > 0 || temp != null)
			{
				//先遍历左子树
				while (temp != null)
				{
					Console.Write(temp.Value + "  ");
					stack.Push(temp);
					temp = temp.LeftChild;
				}
				//左子树遍历完毕，进入父结点的右子树
				temp = stack.Pop();
				temp = temp.RightChild;
			}
		}

		/// <summary>
		/// 中序递归遍历
		/// </summary>
		/// <param name="startNode"></param>
		public void InRecurrsive(TreeNode<T> startNode)
		{
			if (startNode != null)
			{
				InRecurrsive(startNode.LeftChild);
				Console.Write(startNode.Value + "  ");
				InRecurrsive(startNode.RightChild);
			}
		}

		/// <summary>
		/// 中序非递归遍历
		/// </summary>
		/// <param name="startNode"></param>
		public void InTraverse(TreeNode<T> startNode)
		{
			if (startNode == null)
				return;
			var stack = new Stack<TreeNode<T>>();
			stack.Push(startNode);
			var temp = startNode.LeftChild;
			while (stack.Count > 0 || temp != null)
			{
				while (temp != null)
				{
					stack.Push(temp);
					temp = temp.LeftChild;
				}
				temp = stack.Pop();
				Console.Write(temp.Value + "  ");
				temp = temp.RightChild;
			}
		}
		public void AfterRecurrsive(TreeNode<T> startNode)
		{
			if (startNode != null)
			{
				AfterRecurrsive(startNode.LeftChild);
				AfterRecurrsive(startNode.RightChild);
				Console.Write(startNode.Value + "  ");
			}
		}


	}
}

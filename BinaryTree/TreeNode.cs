namespace BinaryTree
{
	/// <summary>
	/// 二叉链表结点类
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class TreeNode<T>
	{
		public TreeNode(T value = default, TreeNode<T> leftChild = default, TreeNode<T> rightChild = default)
		{
			Value = value;
			LeftChild = leftChild;
			RightChild = rightChild;
		}
		/// <summary>
		/// 左子树
		/// </summary>
		public TreeNode<T> LeftChild { get; set; }

		/// <summary>
		/// 右子树
		/// </summary>
		public TreeNode<T> RightChild { get; set; }

		/// <summary>
		/// 值
		/// </summary>
		public T Value { get; set; }
	}
}

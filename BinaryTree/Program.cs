using System;

namespace BinaryTree
{
	class Program
	{
		static void Main(string[] args)
		{
			var left = new TreeNode<int>(2, new TreeNode<int>(4, new TreeNode<int>(8), new TreeNode<int>(9)), new TreeNode<int>(5, new TreeNode<int>(10), new TreeNode<int>(11)));
			var right = new TreeNode<int>(3, new TreeNode<int>(6, new TreeNode<int>(12), new TreeNode<int>(13)), new TreeNode<int>(7, new TreeNode<int>(14), new TreeNode<int>(15)));
			var tree = new LinkBinaryTree<int>(1, left, right);
			Console.WriteLine("先序递归：");
			tree.PreRecurrsive(tree.RootNode);

			Console.WriteLine("\n");
			Console.WriteLine("先序非递归：");
			tree.PreTraverse(tree.RootNode);

			Console.WriteLine("\n");
			Console.WriteLine("中序递归：");
			tree.InRecurrsive(tree.RootNode);

			Console.WriteLine("\n");
			Console.WriteLine("中序非递归：");
			tree.InTraverse(tree.RootNode);


			Console.WriteLine("\n");
			Console.WriteLine("后序递归：");
			tree.AfterRecurrsive(tree.RootNode);



			Console.ReadKey();
		}
	}
}

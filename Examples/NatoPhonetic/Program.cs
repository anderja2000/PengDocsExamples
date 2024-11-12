using System;
using System.Collections.Generic;

namespace NatoPhonetic
{


	class Program
	{

		static void Main(string[] args)
		{

			// Test case
			int[] nums1 = { 1, 2, 3, 0, 0, 0 }; // Initial array with extra space
			int m = 3; // Number of initialized elements in nums1
			int[] nums2 = { 2, 5, 6 }; // Second array
			int n = 3; // Number of elements in nums2

			Solution solution = new Solution();
			solution.Merge(nums1, m, nums2, n); // Call the merge function
		}
	}
}
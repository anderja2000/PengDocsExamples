public class Solution
{


	public void Merge(int[] nums1, int m, int[] nums2, int n)
	{
		int a1IndexLast = m - 1;
		int a2IndexLast = n - 1;
		int mergedIndexLast = m + n - 1;

		while (a1IndexLast >= 0 && a2IndexLast >= 0)
		{
			if (nums1[a1IndexLast] > nums2[a2IndexLast])
			{
				nums1[mergedIndexLast--] = nums1[a1IndexLast--];
			}
			else
			{
				nums1[mergedIndexLast--] = nums2[a2IndexLast--];
			}
		}

		// if there are remaining elements within array 2 
		while (a2IndexLast >= 0)
		{
			nums1[mergedIndexLast--] = nums2[a2IndexLast--];
		}
		// Prepare data for visualization
		
		Console.WriteLine(nums1);
	}
}
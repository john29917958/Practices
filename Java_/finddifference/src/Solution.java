import java.util.ArrayList;
import java.util.HashSet;
import java.util.List;
import java.util.Set;

class Solution {
    public List<List<Integer>> findDifference(int[] nums1, int[] nums2) {
        List<List<Integer>> answer = getDiffs(nums1, nums2);
        return answer;
    }

    private List<List<Integer>> getDiffs(int[] nums1, int[] nums2) {
        Set<Integer> onlyInNums1 = getNumsSetExcludes(nums1, nums2);
        Set<Integer> onlyInNums2 = getNumsSetExcludes(nums2, nums1);
        List<List<Integer>> diffs = new ArrayList<List<Integer>>();
        diffs.add(new ArrayList<>(onlyInNums1));
        diffs.add(new ArrayList<>(onlyInNums2));
        return diffs;
    }

    private Set<Integer> getNumsSetExcludes(int[] nums, int[] numsToExclude) {
        Set<Integer> onlyInNums = new HashSet<Integer>();
        for (int currNum : nums) {
            if (!isNumInNums(currNum, numsToExclude)) {
                onlyInNums.add(currNum);
            }
        }
        return onlyInNums;
    }

    private boolean isNumInNums(int num, int[] nums) {
        for (int currNum : nums) {
            if (num == currNum) {
                return true;
            }
        }

        return false;
    }
}

import java.util.List;

public class App {
    public static void main(String[] args) throws Exception {
        Solution s = new Solution();
        int[] nums1 = { 1, 2, 3 };
        int[] nums2 = { 2, 7 };
        List<List<Integer>> answer = s.findDifference(nums1, nums2);
        String differences = answer.toString();
        System.out.println(differences);
    }
}

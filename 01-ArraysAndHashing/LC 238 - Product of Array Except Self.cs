// o(1) extra space as res isn't counted as extra same approach except we just use res to save the left product
public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        var res = new int[n];
        
        // Pass 1: Store left (prefix) products directly inside res
        res[0] = 1;
        for (int i = 1; i < n; i++) {
            res[i] = res[i - 1] * nums[i - 1];
        }
        
        // Pass 2: Multiply by right (suffix) product on the fly
        int rightProduct = 1;
        for (int i = n - 1; i >= 0; i--) {
            res[i] *= rightProduct;
            rightProduct *= nums[i]; // Accumulate right product for next index left
        }
        
        return res;
    }
}

// Intial approach using all space I can
// public class Solution {
//     public int[] ProductExceptSelf(int[] nums) {
//         var leftProductArr = new int[nums.Length];
//         var rightProductArr = new int[nums.Length];
//         int product = 1;
//         for (int i=0; i<nums.Length; i++){
//             leftProductArr[i]= product;
//             product = product * nums[i]; 

//         }
//         product = 1;
//         for (int i=nums.Length-1; i>=0; i--){
//             rightProductArr[i]= product;
//             product = product * nums[i]; 

//         }
//         var res = new int[nums.Length];
//         for (int i=0; i<nums.Length;i++){
//             res[i]=leftProductArr[i]*rightProductArr[i];
//         }
//         return res;

//     }
// }
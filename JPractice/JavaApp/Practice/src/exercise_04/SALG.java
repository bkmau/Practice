package exercise_04;

public class SALG {

	public static void main(String[] args) {
			
		
//		int[] data = {67,23,56,12,89,8};
//		System.out.println("Length of Data : " + data.length);
//		
//		System.out.println("Starting Merge Sort...");
		
		/* Merge Sort's Pseudo Code
		 * key: the process of sort data is going to merge the min unit
		 * 
		 * 	
		 * 	 
		 * 	
		 * 	
		 * 
		 */
		
//		int len = 2;
//		while(len < data.length) {
//			for(int i = 0; i < data.length; i = i + len) {
//				data = Merge(data, i, data, i, (i + len/2 - 1), data, (i + len/2), (i + len/2 - 1));
//			}
//		}	
//
//		
////		InsertionSort(data);
//	
//		
//		for(int l=0; l < data.length; l = l + 1) {
//			System.out.print(data[l] + ",");
//		}
		
		
	}
	
	private static int[] SelectionSort(int[] data) {
		/* Selection Sort's Pseudo Code
		 * declare a variable for record the max value
		 * for(i starts from data's length - 1 and decrease to 0) {
		 * 	for(j starts from 0 and increase to less than i) {
		 * 	 (data[i] > max) ? assign data[i] to max : do nothing
		 * 	}
		 * 	Swap(data[max],data[i])
		 * }
		 */
		int max;
		for(int i = data.length - 1 ; i > 0; i = i - 1) {
			max = i;
			for(int j = 0; j < i; j = j + 1) {
				if(data[j] > data[max]) {
					max = j;
				}
			}
			Swap(data, max, i);
		}
		
		return data;
	}
	
	private static int[] InsertionSort(int[] data) {
		/* Insertion Sort's Pseudo Code
		 * 
		 * for(i starts from 0 and increase to data's length - 1) {
		 *	j starts from i's value
		 *	while((j > 0) && (data[j-1] > target)) {
		 *		swap data[j-1] for data[j]
		 *		j decrease by one
		 *	}
		 *	assign target to data[j]
		 * }
		 */
		for(int i = 1; i < data.length; i = i + 1) {
			int target = data[i];
			int j = i;
			while( (j > 0) && (data[j-1] > target) ) {
				data[j] = data[j-1];
				j = j - 1;
			}
			data[j] = target;
		}
		return data;
	}
	
	private static int[] BubbleSort(int[] data) {
		/* Bubble Sort's Pseudo Code
		 * for(i starts from data's length - 1 and decrease to 0) {
		 * 	for(j starts from 0 and increase to less than i) {
		 * 	 (data[i] > data[i+1]) ? swap(data[i],data[i+1]) : do nothing
		 * 	}
		 * }
		 */
		for(int i = data.length - 1; i > 0 ; i = i - 1) {
			for(int j = 0; j < i; j = j + 1) {
				if(data[j] > data[j+1]) {
					data = Swap(data, j, j+1);
				}
			}	
		}
		
		return data;
	}
	
	private static int[] ShellSort(int[] data) {
		return data;
	}
	
	private static int[] MergeSort(int[] data) {
		return data;
	}
	
	private static int[] QuickSort(int[] data) {
		return data;
	}
	
	private static int[] RadixSort(int[] data) {
		return data;
	}
	
	private static int[] HeapSort(int[] data) {
		return data;
	}
	
	private static int[] Swap(int[] data, int locateA, int locateB) {
		/* Swap's Pseudo Code 
		 * TMP = A
		 * A = B
		 * B = TMP 
		 */
		
		int tmp = 0;
		
		tmp = data[locateA];
		data[locateA] = data[locateB];
		data[locateB] = tmp;
		
		return data;
	}
	
//	private static int[] Sort(int[] data) {
//		if((data.length == 1)) {
//			return data;
//		} else {
//			for(int i = 0; i < data.length; i = i + 1) {
//				if(data[i] > data[i+1]) {
//					Swap(data, i, i+1);
//				}
//			}
//			return data;
//		}
//	}
	
	private static int[] Merge(int[] m, int locate_M, int[] a, int len_A, int locate_A, int[] b, int len_B, int locate_B) {
		/* Merge's Pseudo Code
		 * while array a's, b's, and merged's location less than size of itself 
		 * then compare value of a's element with b's
		 * put the bigger to merged array then increase the location value
		 * after one of a's or b's location is equals itself's size - 1 
		 * then put remaining data to merged one by one
		 */
	
		while((locate_A < len_A) && (locate_B < len_B)) {
			if(a[locate_A] > b[locate_B]) {
				m[locate_M++] = b[locate_B++];
//				locate_B = locate_B + 1;
//				locate_Merged = locate_Merged + 1;
			} else if(a[locate_A] <= b[locate_B]) {
				m[locate_M++] = a[locate_A++];
//				locate_A = locate_A + 1;
//				locate_Merged = locate_Merged + 1;
			}
		}
		
//		int i = 0;
//		System.out.println("i++ :" + i++);
//		System.out.println("i : " + i);
//		int[] test = {67,23,56,12,89,8};
//		System.out.println("test[i++] :" + test[i++]);
//		System.out.println("test[i] : " + test[i]);
		
		
		while(locate_A < len_A) {
			m[locate_M++] = a[locate_A++];
		}
		
		while(locate_B < len_B) {
			m[locate_M++] = b[locate_B++];
		}

		return m;
	}
}

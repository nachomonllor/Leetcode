https://leetcode.com/problems/valid-mountain-array/
1.	#include <iostream>
2.	#include <stdio.h>
3.	#include <vector>
4.	 
5.	using namespace std;
6.	 
7.	bool validMountainArray(vector<int>& A) {
8.	   
9.	   if (A.size() < 3) return false;
10.	   int max = INT_MIN;
11.	   int ind_max = -1;
12.	   for(int i =0; i <A.size(); i++) {
13.	        if(A[i] > max) {
14.	            max = A[i];
15.	            ind_max = i;
16.	        }
17.	   }
18.	   
19.	   if(ind_max == 0 ||ind_max == A.size() - 1) return false;
20.	   
21.	   for(int i =0; i < ind_max; i++) {
22.	        if(A[i] >= A[i+1]) return false;
23.	   }
24.	   
25.	   for(int i =ind_max; i<A.size(); i++) {
26.	        if(A[i] <= A[i+1]) return false;
27.	   }
28.	   return true;
29.	}
30.	 
31.	int main() {
32.	   
33.	    int arr[] =  {0,3,2,1};
34.	    int size = sizeof(arr)/sizeof(int);
35.	   
36.	    std::vector<int> v;
37.	    for(int i =0; i<size; i++) {
38.	        v.push_back(arr[i]);
39.	    }
40.	   
41.	    cout << validMountainArray(v) << endl;
42.	   
43.	   
44.	    return 0;
45.	}

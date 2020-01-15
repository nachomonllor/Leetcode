public int singleNumber(int[] A) {
HashMap<Integer, Integer> hash = new HashMap<Integer, Integer>();
for(int i = 0; i < A.length; i++) {
int key = A[i];
if(hash.containsKey(key)) {
hash.put(key, hash.get(key) + 1);
} else{
hash.put(key, 1);
}
}
int single = 0;
for(int k : hash.keySet()){
if(hash.get(k) == 1){
single = k;
break;
}
}
return single;
}
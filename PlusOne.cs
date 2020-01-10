 public static int[] plusOne(int[] digits) {
   	     int u = digits.length - 1;
	     
	     digits[u]++;
	     
	     while(u > 0 && digits[u] > 9){
	    	 digits[u] = 0;
	    	 u--;
	    	 digits[u]++;
	     }
	     
	     if(digits[0] > 9){
	    	 int[] copia = new int[digits.length+1];
	    	 copia[0] = 1;
	    	 copia[1] = 0;
	    	 for(int i=1; i<digits.length; i++){
	    		 copia[i] = digits[i];
	    	 }
	    	 return copia;
	     }
		 
	     return digits;
    }


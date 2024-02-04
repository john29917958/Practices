class MergeSort {
    public static void main(String[] args) {
        System.out.println("Input: " + args[0]);
        String result = MergeSort.mergeSort(args[0]);
        System.out.println("Result: " + result);
    }

    private static String mergeSort(String str) {
        if (str.length() == 1) {
            return str;
        }

        int middleIndex = str.length() / 2;
        String strLeft = MergeSort.substr(str, 0, middleIndex);
        String strRight = MergeSort.substr(str, middleIndex, str.length() - middleIndex);

        strLeft = MergeSort.mergeSort(strLeft);
        strRight = MergeSort.mergeSort(strRight);

        String longerStr, shorterStr;
        if (strLeft.length() > strRight.length()) {
            longerStr = strLeft;
            shorterStr = strRight;
        }
        else {
            longerStr = strRight;
            shorterStr = strLeft;
        }

        int shortStrPointer = 0;
        int longStrPointer = 0;
        String sortedStr = "";
        while (shortStrPointer < shorterStr.length() && longStrPointer < longerStr.length()) {
            if (shorterStr.charAt(shortStrPointer) > longerStr.charAt(longStrPointer)) {
                sortedStr += shorterStr.charAt(shortStrPointer);
                shortStrPointer += 1;
            }
            else if (shorterStr.charAt(shortStrPointer) < longerStr.charAt(longStrPointer)) {
                sortedStr += longerStr.charAt(longStrPointer);
                longStrPointer += 1;
            }
            else {
                sortedStr += shorterStr.charAt(shortStrPointer);
                sortedStr += longerStr.charAt(longStrPointer);
                shortStrPointer += 1;
                longStrPointer += 1;
            }
        }

        while (shortStrPointer < shorterStr.length()) {
            sortedStr += shorterStr.charAt(shortStrPointer);
            shortStrPointer += 1;
        }
        
        while (longStrPointer < longerStr.length()) {            
            sortedStr += longerStr.charAt(longStrPointer);
            longStrPointer += 1;
        }

        return sortedStr;
    }

    private static String substr(String str, int start, int length) {
        String substring = "";
        for (int i = start; i < start + length; i++) {
            substring += str.charAt(i);
        }
        return substring;
    }
}
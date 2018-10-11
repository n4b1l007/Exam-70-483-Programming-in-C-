namespace Exam_70_483_Programming_in_C_ {
    public class ConversionOperators {
        public int Pro { get; set; }
        public static explicit operator ConversionOperators (int i) {
            ConversionOperators temp = new ConversionOperators ();
            temp.Pro = i;
            // code to convert from int to SampleClass...

            return temp;
        }
    }
}
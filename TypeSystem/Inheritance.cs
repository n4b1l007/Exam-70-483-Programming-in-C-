using System;

namespace Exam_70_483_Programming_in_C_ {

    public class A {
        public A () {
            Console.WriteLine ("Log from class A");
        }
    }
    public class B : A {
        public B () {
            Console.WriteLine ("Log from class B");
        }
    }

    public class C : B {
        public C () {
            Console.WriteLine ("Log from class C");
        }
    }
    public class Inheritance {
        public Inheritance () {
            var a = new C ();
        }
    }
}
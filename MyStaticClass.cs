using Microsoft.JSInterop;

namespace blazorBridge
{
    public static class MyStaticClass
    {   

        [JSInvokableAttribute("MyClass.checkDotNetLoaded")]
        public static string getMessage2()
        {
            return "Hello from DotNet!";
        }

        [JSInvokableAttribute("MyClass.addNumbers")]
        public static int addNumbers(int a, int b)
        {
            return a + b;
        }
    }

}

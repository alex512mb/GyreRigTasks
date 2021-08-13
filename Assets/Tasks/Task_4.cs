
namespace Task_4
{
    public static class ApiSetupExtension
    {
        public static void SetupObjectA(this ApiSetup<ObjectA> apiSetup)
        {

        }
        public static void SetupObjectB(this ApiSetup<ObjectB> apiSetup)
        {

        }
    }
    public struct ApiSetup<T>
    {
        private T obj;

        public ApiSetup(T obj)
        {
            this.obj = obj;
        }
    }
    class Api
    {
        public ApiSetup<T> For<T>(T obj)
        {
            return new ApiSetup<T>(obj);
        }
    }
    public interface ISomeInterfaceA
    { }
    public interface ISomeInterfaceB
    { }
    public class ObjectA : ISomeInterfaceA
    { }
    public class ObjectB : ISomeInterfaceB
    { }
    class SomeClass
    {
        public void Setup()
        {
            Api apiObject = new Api();

            apiObject.For(new ObjectA()).SetupObjectA();
            apiObject.For(new ObjectB()).SetupObjectB();
        }
    }
}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Task_3
{
    interface ISomeInterface
    {
        void Call();
    }
    struct SomeStruct : ISomeInterface
    {
        public void Call()
        { }
    }
    class SomeClass
    {
        public void Run()
        {
            var someStruct = new SomeStruct();
            SomeMethod(someStruct);
        }
        //заменил тип аргумента с ISomeInterface на SomeStruct
        //теперь в метод передается параметр типа значения а не ссылочного типа
        //ISomeInterface это ссылочный тип, поэтому в момент передачи структуры методу происходит boxing
        public void SomeMethod(SomeStruct someStruct)
        {
            someStruct.Call();
        }
    }
}


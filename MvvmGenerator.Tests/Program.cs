using System;

namespace MvvmGenerator.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class MainPageViewModel
    {
        [AutoNotify]
        private string _firstName;

        [AutoNotify]
        private string _lastName;
    }
}

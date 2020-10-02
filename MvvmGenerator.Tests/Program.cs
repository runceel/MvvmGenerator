using System;

namespace MvvmGenerator.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            var vm = new MainPageViewModel();
        }
    }

    public partial class MainPageViewModel
    {
        [AutoNotify("Xxxx")]
        private string _firstName;

        [AutoNotify]
        private string _lastName;

        
    }
}

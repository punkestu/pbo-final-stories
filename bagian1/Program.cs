using bagian1.app.controller;
using bagian1.app.repo;

namespace bagian1
{
    internal class Program
    {
        private static Controller _controller;
        public static void Main(string[] args)
        {
            Repo repo = new Repo();
            _controller = new Controller(repo);
            button1_click();
        }

        private static void button1_click()
        {
            _controller.BisnisProses1(10);
            _controller.BisnisProses2(10, "bima");
        }
    }
}
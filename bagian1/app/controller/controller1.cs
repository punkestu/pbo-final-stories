using bagian1.app.model;
using bagian1.app.repo;

namespace bagian1.app.controller
{
    public class Controller
    {
        private Repo _repo;

        public Controller(Repo repo)
        {
            _repo = repo;
        }

        public string BisnisProses1(int id)
        {
            Model data = _repo.GetData(id);
            return data.Name;
        }

        public int BisnisProses2(int id, string name)
        {
            Model data = _repo.GetData(id);
            if (data.Name != name)
            {
                return 0;
            }

            return data.Id;
        }
    }
}
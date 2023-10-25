using bagian1.app.model;

namespace bagian1.app.repo
{
    public class Repo
    {
        public Model GetData(int searchId)
        {
            // SELECT * FROM tabel WHERE id=searchId;
            return new Model(1, "bima ganteng");
        }

        public Model SaveData(Model model)
        {
            // INSERT INTO tabel VALUES (model.id, model.name);
            return model;
        }
    }
}
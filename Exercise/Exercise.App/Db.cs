using Exercise.Domain.Models;
using Newtonsoft.Json;

namespace Exercise.App
{
    public class Db<T> where T : BaseEntity
    {
        private string _dbDirectory;
        private string _dbFile;
        private int _id = 0;

        public Db()
        {
            _dbDirectory = @"..\..\..\DbData";
            _dbFile = $@"{_dbDirectory}\{typeof(T).Name}s.json";
            if (!Directory.Exists(_dbDirectory))
            {
                Directory.CreateDirectory(_dbDirectory);
            }
            if (!File.Exists(_dbFile))
            {
                File.Create(_dbFile).Close();
            }
            List<T> list = Read();
           
            
            if(list.Count > 0)
            {
                _id = list.Count;
            }
        }

        private List<T> Read()
        {
            try
            {
                using (StreamReader sr = new StreamReader(_dbFile))
                {
                    string data = sr.ReadToEnd();
                    if (string.IsNullOrEmpty(data))
                    {
                        return new List<T>();
                    }
                    return JsonConvert.DeserializeObject<List<T>>(data);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        private bool Write(List<T> entities)
        {
            try
            {
                using(StreamWriter sw = new StreamWriter(_dbFile, true))
                {
                    string data = JsonConvert.SerializeObject(entities);
                    sw.WriteLine(data);
                }
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public List<T> GetAll()
        {
            return Read();
        }
        public T GetById(int id)
        {
            List<T> data = GetAll();
            return data.SingleOrDefault(x => x.Id == id);

        }
        public int Insert(T entity)
        {
            List<T> data = GetAll();
            entity.Id = ++_id;
            data.Add(entity);
            Write(data);
            return entity.Id;
        }
        
    }
}

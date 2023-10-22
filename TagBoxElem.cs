using System.Data;

namespace TikTask
{
    public class TagBoxElem
    {
        public string id, name;
        public TagBoxElem(DataRow source) 
        {
            id = source["id"].ToString();
            name = source["name"].ToString();
        }
        public override string ToString()
        {
            return name;
        }
    }
}

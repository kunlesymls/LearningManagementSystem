using System.Collections.Generic;

namespace LMSModel
{
    public class Module
    {
        public int ModuleId { get; set; }
        public string ModuleName { get; set; }
        public string ModuleDescription { get; set; }
        public int ExpectedTime { get; set; }
        public virtual Course Course { get; set; }
        public virtual ICollection<Topic> Topics { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OqtaneOpenAIConfigurator
{
    public class TreeNode
    {
        [Key]
        public int Id { get; set; }
        public string NodeName { get; set; }
        public List<TreeNode> Children { get; set; }
    }
}

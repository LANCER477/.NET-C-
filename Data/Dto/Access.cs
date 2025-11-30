using MainProj.Data.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProj.Data.Dto
{
    [TableName("Access")]
    internal class Access
    {
        public Guid Id { get; set; }
        public Guid ManagerId { get; set; }
        public String Login { get; set; } = null!;
        public String Salt { get; set; } = null!;
        public String Dk { get; set; } = null!;

        public override string? ToString() => $"{Login} --- ({Id.ToString()[..3]}...{Id.ToString()[^3..]})";
    }

}

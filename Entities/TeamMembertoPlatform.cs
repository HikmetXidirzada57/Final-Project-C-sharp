using Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class TeamMembertoPlatform:IEntity
    {
        public int Id { get; set; }
        public int TeamMemberId { get; set; }
        public int PlatformId { get; set; }
    }
}

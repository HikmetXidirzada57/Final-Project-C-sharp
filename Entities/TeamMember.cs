using Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class TeamMember:IEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? PhotoUrl { get; set; }
        public string? Speciality { get; set; }
        //public int CommentId { get; set; }
        //public  virtual List<Comment>? Comments { get; set; }
        public virtual List<SocialPlatform>? SocialPlatforms { get; set; }
    }
}

using CleanArchitecture.Domain.Core.Commands;

namespace CleanArchitecture.Domain.Commands
{
    public abstract class CourseCommand : Command
    {
        public String? Name { get; protected set; }
        public String? Description { get; protected set; }
        public String? ImageUrl {  get; protected set; }
    }
}

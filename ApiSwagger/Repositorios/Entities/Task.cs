namespace Repositories.Entities
{
    public class Task : BaseEntity
    {
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        public virtual TakenState State { get; set; }
        public virtual Person AssignedTo { get; protected set; }
    }

    public enum TakenState : int
    {
        /// <summary>  
        /// The task is Open.  
        /// </summary>  
        Open = 0,
        /// <summary>  
        /// The task is active.  
        /// </summary>  
        Active = 1,
        /// <summary>  
        /// The task is completed.  
        /// </summary>  
        Completed = 2,
        /// <summary>  
        /// The task is closed.  
        /// </summary>  
        Closed = 3
    }
}

using System.Collections.Generic;
using TechShop_Web.Models;

namespace TechShop_Web.Persistence.Interfaces
{
    public interface ITodoTaskRepository : IRepository<TodoTask>
    {
        IEnumerable<TodoTask> GetAssignedTodoTasks(Staff staff);
        IEnumerable<TodoTask> GetAssociatedTodoTasks(Staff staff);
        IEnumerable<TodoTask> GetPublicTodoTasks(Staff staff);
        IEnumerable<TodoTask> GetOtherTodoTasks(Staff staff);
        IEnumerable<Comment> GetComments(TodoTask todoTask);
        void AddComment(Comment comment);
        void UpdateTodoTaskPartners(TodoTask todoTask, int[] todoTaskPartnerIds);
    }
}
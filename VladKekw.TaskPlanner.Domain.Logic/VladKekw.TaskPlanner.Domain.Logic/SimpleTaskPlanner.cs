using VladKekw.TaskPlanner.Domain.Models;

namespace VladKekw.TaskPlanner.Domain.Logic
{
    public class SimpleTaskPlanner
    {
        public WorkItem[] CreatePlan(WorkItem[] items)
        {
            var itemsAsList = items.ToList();

            itemsAsList.Sort(CompareWorkItems);

            return itemsAsList.ToArray();
        }

        private static int CompareWorkItems(WorkItem first, WorkItem second)
        {
            if (first.Priority != second.Priority)
            {
                return second.Priority.CompareTo(first.Priority);
            }
               
            if (first.DueDate != second.DueDate)
            {
                return first.DueDate.CompareTo(second.DueDate);
            }
                
            return string.Compare(first.Title, second.Title, StringComparison.Ordinal);
        }

    }
}

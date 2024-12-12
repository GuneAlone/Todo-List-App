namespace Todo_List_App_WinForms
{
    public class PriorityTask : TaskItem
    {
        protected override Image GetStarImage()
        {
            return Properties.Resources.redStar; 
        }
    }
}

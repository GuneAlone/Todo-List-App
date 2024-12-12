using System.Text.Json.Serialization;

namespace Todo_List_App_WinForms
{
    public class BasicTask : TaskItem
    {
        public BasicTask()
        {       
        }

        protected override Image GetStarImage()
        {
            return  Properties.Resources.yellowStar;
        }
    }
}

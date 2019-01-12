namespace ClassLibrary1.Models
{
	public class ProjectWithWorkHours
	{
		public Project Project { get; set; }
		public int WorkHours { get; set; }

		public override string ToString()
		{
			return $"{Project.ToString()} Work hours: {WorkHours}";
		}
	}
}

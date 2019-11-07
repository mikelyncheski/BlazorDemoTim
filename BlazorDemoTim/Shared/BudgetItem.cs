namespace BlazorDemoTim.Shared
{
	public class BudgetItem
	{
		public string Name { get; set; }
		public decimal Amount { get; set; }

		public BudgetItem(string name)
		{
			Name = name;
		}
	}
}

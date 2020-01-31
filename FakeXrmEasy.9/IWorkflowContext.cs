namespace FakeXrmEasy
{
	public interface IWorkflowContext : Microsoft.Xrm.Sdk.IExecutionContext
	{
		string StageName
		{
			get;
		}

		int WorkflowCategory
		{
			get;
		}

		int WorkflowMode
		{
			get;
		}

		IWorkflowContext ParentContext
		{
			get;
		}
	}
}

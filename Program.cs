namespace ComputerForNumber
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.

			computerForNumber![0] = 2;
			computerForNumber[1] = 0;
			computerForNumber[2] = 0;
			computerForNumber[3] = 0;

			ApplicationConfiguration.Initialize();

			Application.Run(form1=new Form1());

        }
		internal static Form1? form1=null;
		internal static NumberView? numberView = null;
		internal static RunForm? runForm = null;
		public static ComputerForNumber computerForNumber => cFNFramework.CFN;
		public readonly static CFNFramework cFNFramework = new(8);
		internal static StringForm? stringForm = null;
		public static short BitLength => cFNFramework.BitLength;
	}
}
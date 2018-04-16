using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
     /// <summary>
	    /// Show list of branches
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void AppCenterBuildBranchesList(this ICakeContext context, AppCenterBuildBranchesListSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterBuildBranchesListSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("build branches list", settings ?? new AppCenterBuildBranchesListSettings(), arguments);
		}
	}
}
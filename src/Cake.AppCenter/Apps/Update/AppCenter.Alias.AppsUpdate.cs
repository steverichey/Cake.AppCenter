using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
     /// <summary>
	    /// Update an app
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void AppCenterAppsUpdate(this ICakeContext context, AppCenterAppsUpdateSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterAppsUpdateSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("apps update", settings ?? new AppCenterAppsUpdateSettings(), arguments);
		}
	}
}

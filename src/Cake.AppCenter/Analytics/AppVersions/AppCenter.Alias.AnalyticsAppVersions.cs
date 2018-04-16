using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
     /// <summary>
	    /// Shows versions of the application
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void AppCenterAnalyticsAppVersions(this ICakeContext context, AppCenterAnalyticsAppVersionsSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterAnalyticsAppVersionsSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("analytics app-versions", settings ?? new AppCenterAnalyticsAppVersionsSettings(), arguments);
		}
	}
}

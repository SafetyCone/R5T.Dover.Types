using System;

using Microsoft.Extensions.Logging;

using Microsoft.AspNetCore.Builder;

using R5T.Richmond;


namespace R5T.Dover
{
    public abstract class WebStartupBase : StartupBase, IWebStartup
    {
        public WebStartupBase(ILogger<WebStartupBase> logger)
            : base(logger)
        {
        }

        public void Configure(IApplicationBuilder applicationBuilder)
        {
            // Now call the ASP.NET Core web-application configure method.
            this.Logger.LogDebug("Starting configure of web-application service provider...");

            this.ConfigureBody(applicationBuilder);

            this.Logger.LogDebug("Finished configure of web-application service provider.");
        }

        /// <summary>
        /// Base implementation does nothing.
        /// </summary>
        protected virtual void ConfigureBody(IApplicationBuilder applicationBuilder)
        {
            // Do nothing.
        }
    }
}

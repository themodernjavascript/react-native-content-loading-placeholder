using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Content.Loading.Placeholder.RNContentLoadingPlaceholder
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNContentLoadingPlaceholderModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNContentLoadingPlaceholderModule"/>.
        /// </summary>
        internal RNContentLoadingPlaceholderModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNContentLoadingPlaceholder";
            }
        }
    }
}

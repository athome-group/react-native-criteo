using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Criteo.RNCriteo
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNCriteoModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNCriteoModule"/>.
        /// </summary>
        internal RNCriteoModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNCriteo";
            }
        }
    }
}

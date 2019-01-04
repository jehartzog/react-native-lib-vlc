using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Lib.Vlc.RNLibVlc
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNLibVlcModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNLibVlcModule"/>.
        /// </summary>
        internal RNLibVlcModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNLibVlc";
            }
        }
    }
}

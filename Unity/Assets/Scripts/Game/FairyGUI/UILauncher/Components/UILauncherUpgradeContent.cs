/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using Cysharp.Threading.Tasks;
using FairyGUI.Utils;
using GameFrameX.Runtime;

namespace Game.Model
{
    public sealed partial class UILauncherUpgradeContent : FUI
    {
        public const string UIPackageName = "UILauncher";
        public const string UIResName = "UILauncherUpgradeContent";
        public const string URL = "ui://u7deosq0qew11f";

        /// <summary>
        /// {uiResName}的组件类型(GComponent、GButton、GProcessBar等)，它们都是GObject的子类。
        /// </summary>
        public GLabel self { get; private set; }




        public static UILauncherUpgradeContent Create(GObject go, FUI parent = null, object userData = null)
        {
            return new UILauncherUpgradeContent(go, userData, parent);
        }
        /*
        /// <summary>
        /// 通过此方法获取的FUI，在Dispose时不会释放GObject，需要自行管理（一般在配合FGUI的Pool机制时使用）。
        /// </summary>
        public static UILauncherUpgradeContent GetFormPool(GObject go)
        {
            var fui =  go.Get<UILauncherUpgradeContent>();
            if(fui == null)
            {
                fui = Create(go);
            }
            fui.isFromFGUIPool = true;
            return fui;
        }
        */

        protected override void InitView()
        {
            if(GObject == null)
            {
                return;
            }

            self = (GLabel)GObject;
            
            var com = GObject.asCom;
            if(com != null)
            {

            }
        }

        public override void Dispose()
        {
            if (IsDisposed)
            {
                return;
            }

            base.Dispose();

            self = null;            
        }

        private UILauncherUpgradeContent(GObject gObject, object userData, FUI parent = null) : base(gObject, parent, userData)
        {
            // Awake(gObject);
        }
    }
}
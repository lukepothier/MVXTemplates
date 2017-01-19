using System;
using Android.Widget;
using MvvmCross.Binding;
using MvvmCross.Binding.Bindings.Target;

namespace $rootnamespace$
{
    // For more information on custom bindings, see:
    // https://mvvmcross.com/docs/customize-app#section-registering-custom-bindings
    // http://slodge.blogspot.co.za/2013/06/n28-custom-bindings-n1-days-of-mvvmcross.html
    public class $safeitemname$ : MvxConvertingTargetBinding
    {
        public $safeitemname$(ControlType target) : base(target)
        {
        }
    
        public override Type TargetType => typeof(ControlType);

        // For more information on the different binding mode options see:
        // https://mvvmcross.com/docs/data-binding#section-binding-modes
        public override MvxBindingMode DefaultMode => MvxBindingMode.OneWay;
    
        protected override void SetValueImpl(object target, object value)
        {
            throw new NotImplementedException();
        }
    }
}

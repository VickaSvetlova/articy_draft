//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Articy.ManiacManfred;
using Articy.Unity;
using Articy.Unity.Constraints;
using Articy.Unity.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Articy.ManiacManfred.Features
{
    
    
    public class MoraleFeatureConstraint
    {
        
        private Boolean mLoadedConstraints;
        
        private NumberConstraint mMoraleValue;
        
        public NumberConstraint MoraleValue
        {
            get
            {
                EnsureConstraints();
                return mMoraleValue;
            }
        }
        
        public virtual void EnsureConstraints()
        {
            if ((mLoadedConstraints == true))
            {
                return;
            }
            mLoadedConstraints = true;
            mMoraleValue = new Articy.Unity.Constraints.NumberConstraint(-3.40282346638529E+38D, 3.40282346638529E+38D, 0, 0, 0, null);
        }
    }
}

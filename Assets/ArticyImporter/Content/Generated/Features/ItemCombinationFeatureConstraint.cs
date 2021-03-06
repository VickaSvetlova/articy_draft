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
    
    
    public class ItemCombinationFeatureConstraint
    {
        
        private Boolean mLoadedConstraints;
        
        private ReferenceSlotConstraint mValidCombination;
        
        private ReferenceSlotConstraint mCombinationResult;
        
        private ReferenceSlotConstraint mLinkIfSuccess;
        
        private ReferenceSlotConstraint mLinkIfFailure;
        
        public ReferenceSlotConstraint ValidCombination
        {
            get
            {
                EnsureConstraints();
                return mValidCombination;
            }
        }
        
        public ReferenceSlotConstraint CombinationResult
        {
            get
            {
                EnsureConstraints();
                return mCombinationResult;
            }
        }
        
        public ReferenceSlotConstraint LinkIfSuccess
        {
            get
            {
                EnsureConstraints();
                return mLinkIfSuccess;
            }
        }
        
        public ReferenceSlotConstraint LinkIfFailure
        {
            get
            {
                EnsureConstraints();
                return mLinkIfFailure;
            }
        }
        
        public virtual void EnsureConstraints()
        {
            if ((mLoadedConstraints == true))
            {
                return;
            }
            mLoadedConstraints = true;
            mValidCombination = new Articy.Unity.Constraints.ReferenceSlotConstraint("Entity;", "", "None;", "Item;");
            mCombinationResult = new Articy.Unity.Constraints.ReferenceSlotConstraint("Entity;", "", "None;", "Item;");
            mLinkIfSuccess = new Articy.Unity.Constraints.ReferenceSlotConstraint("DialogueFragment;Dialogue;", "", "None;", "");
            mLinkIfFailure = new Articy.Unity.Constraints.ReferenceSlotConstraint("DialogueFragment;Dialogue;", "", "None;", "");
        }
    }
}

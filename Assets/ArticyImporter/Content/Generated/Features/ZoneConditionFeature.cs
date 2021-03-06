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
using Articy.Unity.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Articy.ManiacManfred.Features
{
    
    
    [Serializable()]
    public class ZoneConditionFeature : IArticyBaseObject, IPropertyProvider
    {
        
        [SerializeField()]
        private ArticyValueArticyObject mIfConditionTrue = new ArticyValueArticyObject();
        
        [SerializeField()]
        private ArticyValueArticyObject mIfConditionFalse = new ArticyValueArticyObject();
        
        [SerializeField()]
        private MouseCursor mCursorIfConditionTrue = new MouseCursor();
        
        [SerializeField()]
        private MouseCursor mCursorIfConditionFalse = new MouseCursor();
        
        [SerializeField()]
        private ArticyValueArticyObject mItemToInteractWith = new ArticyValueArticyObject();
        
        [SerializeField()]
        private ArticyValueArticyObject mLinkIfItemValid = new ArticyValueArticyObject();
        
        [SerializeField()]
        private ArticyValueArticyObject mLinkIfItemInvalid = new ArticyValueArticyObject();
        
        [SerializeField()]
        private ArticyValueArticyScriptCondition mClickCondition = new ArticyValueArticyScriptCondition();
        
        [SerializeField()]
        private ArticyValueArticyScriptInstruction mOnClickInstruction = new ArticyValueArticyScriptInstruction();
        
        [SerializeField()]
        private ArticyValueArticyScriptCondition mInteractionCondition = new ArticyValueArticyScriptCondition();
        
        [SerializeField()]
        private ArticyValueArticyScriptInstruction mInstructionIfItemValid = new ArticyValueArticyScriptInstruction();
        
        [SerializeField()]
        private UInt64 mOwnerId;
        
        [SerializeField()]
        private UInt32 mOwnerInstanceId;
        
        public ArticyObject IfConditionTrue
        {
            get
            {
                return mIfConditionTrue.GetValue();
            }
            set
            {
                var oldValue = mIfConditionTrue;
                mIfConditionTrue.SetValue(value);
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(OwnerId, OwnerInstanceId, "ZoneCondition.IfConditionTrue", oldValue.GetValue(), mIfConditionTrue.GetValue());
            }
        }
        
        public ArticyObject IfConditionFalse
        {
            get
            {
                return mIfConditionFalse.GetValue();
            }
            set
            {
                var oldValue = mIfConditionFalse;
                mIfConditionFalse.SetValue(value);
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(OwnerId, OwnerInstanceId, "ZoneCondition.IfConditionFalse", oldValue.GetValue(), mIfConditionFalse.GetValue());
            }
        }
        
        public MouseCursor CursorIfConditionTrue
        {
            get
            {
                return mCursorIfConditionTrue;
            }
            set
            {
                var oldValue = mCursorIfConditionTrue;
                mCursorIfConditionTrue = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(OwnerId, OwnerInstanceId, "ZoneCondition.CursorIfConditionTrue", oldValue, mCursorIfConditionTrue);
            }
        }
        
        public MouseCursor CursorIfConditionFalse
        {
            get
            {
                return mCursorIfConditionFalse;
            }
            set
            {
                var oldValue = mCursorIfConditionFalse;
                mCursorIfConditionFalse = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(OwnerId, OwnerInstanceId, "ZoneCondition.CursorIfConditionFalse", oldValue, mCursorIfConditionFalse);
            }
        }
        
        public ArticyObject ItemToInteractWith
        {
            get
            {
                return mItemToInteractWith.GetValue();
            }
            set
            {
                var oldValue = mItemToInteractWith;
                mItemToInteractWith.SetValue(value);
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(OwnerId, OwnerInstanceId, "ZoneCondition.ItemToInteractWith", oldValue.GetValue(), mItemToInteractWith.GetValue());
            }
        }
        
        public ArticyObject LinkIfItemValid
        {
            get
            {
                return mLinkIfItemValid.GetValue();
            }
            set
            {
                var oldValue = mLinkIfItemValid;
                mLinkIfItemValid.SetValue(value);
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(OwnerId, OwnerInstanceId, "ZoneCondition.LinkIfItemValid", oldValue.GetValue(), mLinkIfItemValid.GetValue());
            }
        }
        
        public ArticyObject LinkIfItemInvalid
        {
            get
            {
                return mLinkIfItemInvalid.GetValue();
            }
            set
            {
                var oldValue = mLinkIfItemInvalid;
                mLinkIfItemInvalid.SetValue(value);
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(OwnerId, OwnerInstanceId, "ZoneCondition.LinkIfItemInvalid", oldValue.GetValue(), mLinkIfItemInvalid.GetValue());
            }
        }
        
        public ArticyScriptCondition ClickCondition
        {
            get
            {
                return mClickCondition.GetValue();
            }
            set
            {
                var oldValue = mClickCondition;
                mClickCondition.SetValue(value);
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(OwnerId, OwnerInstanceId, "ZoneCondition.ClickCondition", oldValue.GetValue(), mClickCondition.GetValue());
            }
        }
        
        public ArticyScriptInstruction OnClickInstruction
        {
            get
            {
                return mOnClickInstruction.GetValue();
            }
            set
            {
                var oldValue = mOnClickInstruction;
                mOnClickInstruction.SetValue(value);
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(OwnerId, OwnerInstanceId, "ZoneCondition.OnClickInstruction", oldValue.GetValue(), mOnClickInstruction.GetValue());
            }
        }
        
        public ArticyScriptCondition InteractionCondition
        {
            get
            {
                return mInteractionCondition.GetValue();
            }
            set
            {
                var oldValue = mInteractionCondition;
                mInteractionCondition.SetValue(value);
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(OwnerId, OwnerInstanceId, "ZoneCondition.InteractionCondition", oldValue.GetValue(), mInteractionCondition.GetValue());
            }
        }
        
        public ArticyScriptInstruction InstructionIfItemValid
        {
            get
            {
                return mInstructionIfItemValid.GetValue();
            }
            set
            {
                var oldValue = mInstructionIfItemValid;
                mInstructionIfItemValid.SetValue(value);
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(OwnerId, OwnerInstanceId, "ZoneCondition.InstructionIfItemValid", oldValue.GetValue(), mInstructionIfItemValid.GetValue());
            }
        }
        
        public UInt64 OwnerId
        {
            get
            {
                return mOwnerId;
            }
            set
            {
                mOwnerId = value;
            }
        }
        
        public UInt32 OwnerInstanceId
        {
            get
            {
                return mOwnerInstanceId;
            }
            set
            {
                mOwnerInstanceId = value;
            }
        }
        
        private void CloneProperties(object aClone, Articy.Unity.ArticyObject aFirstClassParent)
        {
            Articy.ManiacManfred.Features.ZoneConditionFeature newClone = ((Articy.ManiacManfred.Features.ZoneConditionFeature)(aClone));
            if ((mIfConditionTrue != null))
            {
                newClone.mIfConditionTrue = ((ArticyValueArticyObject)(mIfConditionTrue.CloneObject(newClone, aFirstClassParent)));
            }
            if ((mIfConditionFalse != null))
            {
                newClone.mIfConditionFalse = ((ArticyValueArticyObject)(mIfConditionFalse.CloneObject(newClone, aFirstClassParent)));
            }
            newClone.CursorIfConditionTrue = CursorIfConditionTrue;
            newClone.CursorIfConditionFalse = CursorIfConditionFalse;
            if ((mItemToInteractWith != null))
            {
                newClone.mItemToInteractWith = ((ArticyValueArticyObject)(mItemToInteractWith.CloneObject(newClone, aFirstClassParent)));
            }
            if ((mLinkIfItemValid != null))
            {
                newClone.mLinkIfItemValid = ((ArticyValueArticyObject)(mLinkIfItemValid.CloneObject(newClone, aFirstClassParent)));
            }
            if ((mLinkIfItemInvalid != null))
            {
                newClone.mLinkIfItemInvalid = ((ArticyValueArticyObject)(mLinkIfItemInvalid.CloneObject(newClone, aFirstClassParent)));
            }
            if ((ClickCondition != null))
            {
                newClone.ClickCondition = ((ArticyScriptCondition)(ClickCondition.CloneObject(newClone, aFirstClassParent)));
            }
            if ((OnClickInstruction != null))
            {
                newClone.OnClickInstruction = ((ArticyScriptInstruction)(OnClickInstruction.CloneObject(newClone, aFirstClassParent)));
            }
            if ((InteractionCondition != null))
            {
                newClone.InteractionCondition = ((ArticyScriptCondition)(InteractionCondition.CloneObject(newClone, aFirstClassParent)));
            }
            if ((InstructionIfItemValid != null))
            {
                newClone.InstructionIfItemValid = ((ArticyScriptInstruction)(InstructionIfItemValid.CloneObject(newClone, aFirstClassParent)));
            }
            newClone.OwnerId = OwnerId;
        }
        
        public object CloneObject(object aParent, Articy.Unity.ArticyObject aFirstClassParent)
        {
            Articy.ManiacManfred.Features.ZoneConditionFeature clone = new Articy.ManiacManfred.Features.ZoneConditionFeature();
            CloneProperties(clone, aFirstClassParent);
            return clone;
        }
        
        public virtual bool IsLocalizedPropertyOverwritten(string aProperty)
        {
            return false;
        }
        
        #region property provider interface
        public void setProp(string aProperty, object aValue)
        {
            if ((aProperty == "IfConditionTrue"))
            {
                IfConditionTrue = Articy.Unity.Interfaces.BaseScriptFragments.ObjectToModelRep(aValue);
                return;
            }
            if ((aProperty == "IfConditionFalse"))
            {
                IfConditionFalse = Articy.Unity.Interfaces.BaseScriptFragments.ObjectToModelRep(aValue);
                return;
            }
            if ((aProperty == "CursorIfConditionTrue"))
            {
                CursorIfConditionTrue = ((MouseCursor)(aValue));
                return;
            }
            if ((aProperty == "CursorIfConditionFalse"))
            {
                CursorIfConditionFalse = ((MouseCursor)(aValue));
                return;
            }
            if ((aProperty == "ItemToInteractWith"))
            {
                ItemToInteractWith = Articy.Unity.Interfaces.BaseScriptFragments.ObjectToModelRep(aValue);
                return;
            }
            if ((aProperty == "LinkIfItemValid"))
            {
                LinkIfItemValid = Articy.Unity.Interfaces.BaseScriptFragments.ObjectToModelRep(aValue);
                return;
            }
            if ((aProperty == "LinkIfItemInvalid"))
            {
                LinkIfItemInvalid = Articy.Unity.Interfaces.BaseScriptFragments.ObjectToModelRep(aValue);
                return;
            }
            if ((aProperty == "ClickCondition"))
            {
                ClickCondition = ((ArticyScriptCondition)(aValue));
                return;
            }
            if ((aProperty == "OnClickInstruction"))
            {
                OnClickInstruction = ((ArticyScriptInstruction)(aValue));
                return;
            }
            if ((aProperty == "InteractionCondition"))
            {
                InteractionCondition = ((ArticyScriptCondition)(aValue));
                return;
            }
            if ((aProperty == "InstructionIfItemValid"))
            {
                InstructionIfItemValid = ((ArticyScriptInstruction)(aValue));
                return;
            }
        }
        
        public Articy.Unity.Interfaces.ScriptDataProxy getProp(string aProperty)
        {
            if ((aProperty == "IfConditionTrue"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(IfConditionTrue);
            }
            if ((aProperty == "IfConditionFalse"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(IfConditionFalse);
            }
            if ((aProperty == "CursorIfConditionTrue"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(CursorIfConditionTrue);
            }
            if ((aProperty == "CursorIfConditionFalse"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(CursorIfConditionFalse);
            }
            if ((aProperty == "ItemToInteractWith"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(ItemToInteractWith);
            }
            if ((aProperty == "LinkIfItemValid"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(LinkIfItemValid);
            }
            if ((aProperty == "LinkIfItemInvalid"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(LinkIfItemInvalid);
            }
            if ((aProperty == "ClickCondition"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(ClickCondition);
            }
            if ((aProperty == "OnClickInstruction"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(OnClickInstruction);
            }
            if ((aProperty == "InteractionCondition"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(InteractionCondition);
            }
            if ((aProperty == "InstructionIfItemValid"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(InstructionIfItemValid);
            }
            return null;
        }
        #endregion
    }
}

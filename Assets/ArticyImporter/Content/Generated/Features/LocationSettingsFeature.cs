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
    public class LocationSettingsFeature : IArticyBaseObject, IPropertyProvider
    {
        
        [SerializeField()]
        private ArticyValueArticyObject mInitialDialog = new ArticyValueArticyObject();
        
        [SerializeField()]
        private Boolean mIsStartLocation = new Boolean();
        
        [SerializeField()]
        private ArticyValueArticyModelList mBackgrounds = new ArticyValueArticyModelList();
        
        [SerializeField()]
        private ArticyValueArticyScriptCondition mInitialDialogCondition = new ArticyValueArticyScriptCondition();
        
        [SerializeField()]
        private UInt64 mOwnerId;
        
        [SerializeField()]
        private UInt32 mOwnerInstanceId;
        
        public ArticyObject InitialDialog
        {
            get
            {
                return mInitialDialog.GetValue();
            }
            set
            {
                var oldValue = mInitialDialog;
                mInitialDialog.SetValue(value);
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(OwnerId, OwnerInstanceId, "LocationSettings.InitialDialog", oldValue.GetValue(), mInitialDialog.GetValue());
            }
        }
        
        public Boolean IsStartLocation
        {
            get
            {
                return mIsStartLocation;
            }
            set
            {
                var oldValue = mIsStartLocation;
                mIsStartLocation = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(OwnerId, OwnerInstanceId, "LocationSettings.IsStartLocation", oldValue, mIsStartLocation);
            }
        }
        
        public List<ArticyObject> Backgrounds
        {
            get
            {
                return mBackgrounds.GetValue();
            }
            set
            {
                var oldValue = mBackgrounds;
                mBackgrounds.SetValue(value);
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(OwnerId, OwnerInstanceId, "LocationSettings.Backgrounds", oldValue.GetValue(), mBackgrounds.GetValue());
            }
        }
        
        public ArticyScriptCondition InitialDialogCondition
        {
            get
            {
                return mInitialDialogCondition.GetValue();
            }
            set
            {
                var oldValue = mInitialDialogCondition;
                mInitialDialogCondition.SetValue(value);
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(OwnerId, OwnerInstanceId, "LocationSettings.InitialDialogCondition", oldValue.GetValue(), mInitialDialogCondition.GetValue());
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
            Articy.ManiacManfred.Features.LocationSettingsFeature newClone = ((Articy.ManiacManfred.Features.LocationSettingsFeature)(aClone));
            if ((mInitialDialog != null))
            {
                newClone.mInitialDialog = ((ArticyValueArticyObject)(mInitialDialog.CloneObject(newClone, aFirstClassParent)));
            }
            newClone.IsStartLocation = IsStartLocation;
            mBackgrounds.CustomClone(newClone.mBackgrounds);
            if ((InitialDialogCondition != null))
            {
                newClone.InitialDialogCondition = ((ArticyScriptCondition)(InitialDialogCondition.CloneObject(newClone, aFirstClassParent)));
            }
            newClone.OwnerId = OwnerId;
        }
        
        public object CloneObject(object aParent, Articy.Unity.ArticyObject aFirstClassParent)
        {
            Articy.ManiacManfred.Features.LocationSettingsFeature clone = new Articy.ManiacManfred.Features.LocationSettingsFeature();
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
            if ((aProperty == "InitialDialog"))
            {
                InitialDialog = Articy.Unity.Interfaces.BaseScriptFragments.ObjectToModelRep(aValue);
                return;
            }
            if ((aProperty == "IsStartLocation"))
            {
                IsStartLocation = System.Convert.ToBoolean(aValue);
                return;
            }
            if ((aProperty == "Backgrounds"))
            {
                Backgrounds = ((List<ArticyObject>)(aValue));
                return;
            }
            if ((aProperty == "InitialDialogCondition"))
            {
                InitialDialogCondition = ((ArticyScriptCondition)(aValue));
                return;
            }
        }
        
        public Articy.Unity.Interfaces.ScriptDataProxy getProp(string aProperty)
        {
            if ((aProperty == "InitialDialog"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(InitialDialog);
            }
            if ((aProperty == "IsStartLocation"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(IsStartLocation);
            }
            if ((aProperty == "Backgrounds"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(Backgrounds);
            }
            if ((aProperty == "InitialDialogCondition"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(InitialDialogCondition);
            }
            return null;
        }
        #endregion
    }
}

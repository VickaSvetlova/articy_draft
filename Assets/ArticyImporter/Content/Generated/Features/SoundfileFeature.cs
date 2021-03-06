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
    public class SoundfileFeature : IArticyBaseObject, IPropertyProvider
    {
        
        [SerializeField()]
        private ArticyValueArticyObject mSound = new ArticyValueArticyObject();
        
        [SerializeField()]
        private UInt64 mOwnerId;
        
        [SerializeField()]
        private UInt32 mOwnerInstanceId;
        
        public ArticyObject Sound
        {
            get
            {
                return mSound.GetValue();
            }
            set
            {
                var oldValue = mSound;
                mSound.SetValue(value);
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(OwnerId, OwnerInstanceId, "Soundfile.Sound", oldValue.GetValue(), mSound.GetValue());
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
            Articy.ManiacManfred.Features.SoundfileFeature newClone = ((Articy.ManiacManfred.Features.SoundfileFeature)(aClone));
            if ((mSound != null))
            {
                newClone.mSound = ((ArticyValueArticyObject)(mSound.CloneObject(newClone, aFirstClassParent)));
            }
            newClone.OwnerId = OwnerId;
        }
        
        public object CloneObject(object aParent, Articy.Unity.ArticyObject aFirstClassParent)
        {
            Articy.ManiacManfred.Features.SoundfileFeature clone = new Articy.ManiacManfred.Features.SoundfileFeature();
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
            if ((aProperty == "Sound"))
            {
                Sound = Articy.Unity.Interfaces.BaseScriptFragments.ObjectToModelRep(aValue);
                return;
            }
        }
        
        public Articy.Unity.Interfaces.ScriptDataProxy getProp(string aProperty)
        {
            if ((aProperty == "Sound"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(Sound);
            }
            return null;
        }
        #endregion
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Articy.Unity;
using Articy.Unity.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


namespace Articy.ManiacManfred
{
    
    
    [Serializable()]
    public class OutputPin : ArticyPrimitive, IOutputPin
    {
        
        [SerializeField()]
        private ArticyValueArticyScriptInstruction mText = new ArticyValueArticyScriptInstruction();
        
        [SerializeField()]
        private UInt64 mOwner;
        
        [SerializeField()]
        private ArticyValueListOutgoingConnection mConnections = new ArticyValueListOutgoingConnection();
        
        [SerializeField()]
        private UInt32 mOwnerInstanceId;
        
        public ArticyScriptInstruction Text
        {
            get
            {
                return mText.GetValue();
            }
            set
            {
                mText.SetValue(value);
            }
        }
        
        public UInt64 Owner
        {
            get
            {
                return mOwner;
            }
            set
            {
                mOwner = value;
            }
        }
        
        public List<OutgoingConnection> Connections
        {
            get
            {
                return mConnections.GetValue();
            }
            set
            {
                mConnections.SetValue(value);
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
        
        public List<Articy.Unity.Interfaces.IOutgoingConnection> GetOutgoingConnections()
        {
            return Connections.Cast<IOutgoingConnection>().ToList();
        }
        
        public void Evaluate([System.Runtime.InteropServices.OptionalAttribute()] Articy.Unity.IBaseScriptMethodProvider aMethodProvider, [System.Runtime.InteropServices.OptionalAttribute()] Articy.Unity.Interfaces.IGlobalVariables aGlobalVariables)
        {
            Text.CallScript(aMethodProvider, aGlobalVariables);
        }
        
        protected void CloneProperties(object aClone, Articy.Unity.ArticyObject aFirstClassParent)
        {
            OutputPin newClone = ((OutputPin)(aClone));
            if ((Text != null))
            {
                newClone.Text = ((ArticyScriptInstruction)(Text.CloneObject(newClone, aFirstClassParent)));
            }
            newClone.Owner = Owner;
            List<OutgoingConnection> temp_Connections = new List<OutgoingConnection>();
            int i = 0;
            for (i = 0; (i < Connections.Count); i = (i + 1))
            {
                temp_Connections.Add(((OutgoingConnection)(Connections[i].CloneObject(newClone, aFirstClassParent))));
            }
            newClone.Connections = temp_Connections;
            newClone.Id = Id;
            newClone.OwnerInstanceId = aFirstClassParent.InstanceId;
        }
        
        public override object CloneObject(object aParent, Articy.Unity.ArticyObject aFirstClassParent)
        {
            OutputPin clone = new OutputPin();
            CloneProperties(clone, aFirstClassParent);
            return clone;
        }
        
        public override bool IsLocalizedPropertyOverwritten(string aProperty)
        {
            return base.IsLocalizedPropertyOverwritten(aProperty);
        }
    }
}

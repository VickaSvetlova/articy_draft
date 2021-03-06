//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Articy.ManiacManfred.Features;
using Articy.Unity;
using Articy.Unity.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Articy.ManiacManfred
{
    
    
    public class DialogChoice : DialogueFragment, IDialogueFragment, IPropertyProvider, IObjectWithFeatureSoundfile, IObjectWithFeatureDialogChoice
    {
        
        [SerializeField()]
        private ArticyValueDialogChoiceTemplate mTemplate = new ArticyValueDialogChoiceTemplate();
        
        private static Articy.ManiacManfred.Templates.DialogChoiceTemplateConstraint mConstraints = new Articy.ManiacManfred.Templates.DialogChoiceTemplateConstraint();
        
        public Articy.ManiacManfred.Templates.DialogChoiceTemplate Template
        {
            get
            {
                return mTemplate.GetValue();
            }
            set
            {
                mTemplate.SetValue(value);
            }
        }
        
        public static Articy.ManiacManfred.Templates.DialogChoiceTemplateConstraint Constraints
        {
            get
            {
                return mConstraints;
            }
        }
        
        public SoundfileFeature GetFeatureSoundfile()
        {
            return Template.Soundfile;
        }
        
        public DialogChoiceFeature GetFeatureDialogChoice()
        {
            return Template.DialogChoice;
        }
        
        protected override void CloneProperties(object aClone, Articy.Unity.ArticyObject aFirstClassParent)
        {
            DialogChoice newClone = ((DialogChoice)(aClone));
            if ((Template != null))
            {
                newClone.Template = ((Articy.ManiacManfred.Templates.DialogChoiceTemplate)(Template.CloneObject(newClone, aFirstClassParent)));
            }
            base.CloneProperties(newClone, aFirstClassParent);
        }
        
        public override bool IsLocalizedPropertyOverwritten(string aProperty)
        {
            return base.IsLocalizedPropertyOverwritten(aProperty);
        }
        
        #region property provider interface
        public override void setProp(string aProperty, object aValue)
        {
            if (aProperty.Contains("."))
            {
                Template.setProp(aProperty, aValue);
                return;
            }
            base.setProp(aProperty, aValue);
        }
        
        public override Articy.Unity.Interfaces.ScriptDataProxy getProp(string aProperty)
        {
            if (aProperty.Contains("."))
            {
                return Template.getProp(aProperty);
            }
            return base.getProp(aProperty);
        }
        #endregion
    }
}

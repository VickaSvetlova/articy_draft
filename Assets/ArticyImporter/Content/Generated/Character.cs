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
    
    
    public class Character : Entity, IEntity, IPropertyProvider, IObjectWithFeatureCharacter
    {
        
        [SerializeField()]
        private ArticyValueCharacterTemplate mTemplate = new ArticyValueCharacterTemplate();
        
        private static Articy.ManiacManfred.Templates.CharacterTemplateConstraint mConstraints = new Articy.ManiacManfred.Templates.CharacterTemplateConstraint();
        
        public Articy.ManiacManfred.Templates.CharacterTemplate Template
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
        
        public static Articy.ManiacManfred.Templates.CharacterTemplateConstraint Constraints
        {
            get
            {
                return mConstraints;
            }
        }
        
        public CharacterFeature GetFeatureCharacter()
        {
            return Template.Character;
        }
        
        protected override void CloneProperties(object aClone, Articy.Unity.ArticyObject aFirstClassParent)
        {
            Character newClone = ((Character)(aClone));
            if ((Template != null))
            {
                newClone.Template = ((Articy.ManiacManfred.Templates.CharacterTemplate)(Template.CloneObject(newClone, aFirstClassParent)));
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

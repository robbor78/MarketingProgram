﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class root {
    
    private rootPerson[] personField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("person")]
    public rootPerson[] person {
        get {
            return this.personField;
        }
        set {
            this.personField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class rootPerson {
    
    private string firstnameField;
    
    private string surnameField;
    
    private string emailField;
    
    private string referencenoField;
    
    private rootPersonOrder[] ordersField;
    
    /// <remarks/>
    public string firstname {
        get {
            return this.firstnameField;
        }
        set {
            this.firstnameField = value;
        }
    }
    
    /// <remarks/>
    public string surname {
        get {
            return this.surnameField;
        }
        set {
            this.surnameField = value;
        }
    }
    
    /// <remarks/>
    public string email {
        get {
            return this.emailField;
        }
        set {
            this.emailField = value;
        }
    }
    
    /// <remarks/>
    public string referenceno {
        get {
            return this.referencenoField;
        }
        set {
            this.referencenoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("order", IsNullable=false)]
    public rootPersonOrder[] orders {
        get {
            return this.ordersField;
        }
        set {
            this.ordersField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class rootPersonOrder {
    
    private string orderreferenceField;
    
    private string ordernameField;
    
    private decimal ordervalueField;
    
    /// <remarks/>
    public string orderreference {
        get {
            return this.orderreferenceField;
        }
        set {
            this.orderreferenceField = value;
        }
    }
    
    /// <remarks/>
    public string ordername {
        get {
            return this.ordernameField;
        }
        set {
            this.ordernameField = value;
        }
    }
    
    /// <remarks/>
    public decimal ordervalue {
        get {
            return this.ordervalueField;
        }
        set {
            this.ordervalueField = value;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClearanceTeeTimes.Mobile {
    using System;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    
    
    public partial class UserRegisterInfo : global::Xamarin.Forms.ContentPage {
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Entry firstName;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Entry lastName;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Entry emailEntryBox;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Entry phoneNumber;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Entry password;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Entry confirmPassword;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Entry address1;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Entry address2;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Picker country;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Entry zipEntryBox;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Entry cityEntryBox;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Entry stateEntryBox;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.DatePicker birthDate;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Picker genderEntryBox;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private void InitializeComponent() {
            this.LoadFromXaml(typeof(UserRegisterInfo));
            firstName = this.FindByName<global::Xamarin.Forms.Entry>("firstName");
            lastName = this.FindByName<global::Xamarin.Forms.Entry>("lastName");
            emailEntryBox = this.FindByName<global::Xamarin.Forms.Entry>("emailEntryBox");
            phoneNumber = this.FindByName<global::Xamarin.Forms.Entry>("phoneNumber");
            password = this.FindByName<global::Xamarin.Forms.Entry>("password");
            confirmPassword = this.FindByName<global::Xamarin.Forms.Entry>("confirmPassword");
            address1 = this.FindByName<global::Xamarin.Forms.Entry>("address1");
            address2 = this.FindByName<global::Xamarin.Forms.Entry>("address2");
            country = this.FindByName<global::Xamarin.Forms.Picker>("country");
            zipEntryBox = this.FindByName<global::Xamarin.Forms.Entry>("zipEntryBox");
            cityEntryBox = this.FindByName<global::Xamarin.Forms.Entry>("cityEntryBox");
            stateEntryBox = this.FindByName<global::Xamarin.Forms.Entry>("stateEntryBox");
            birthDate = this.FindByName<global::Xamarin.Forms.DatePicker>("birthDate");
            genderEntryBox = this.FindByName<global::Xamarin.Forms.Picker>("genderEntryBox");
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CadastroVeiculos.Domain.Entities.Validations {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ValidationMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ValidationMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CadastroVeiculos.Domain.Entities.Validations.ValidationMessages", typeof(ValidationMessages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CPF do Proprietário é Inválido.
        /// </summary>
        internal static string ProprietarioCpfIsInvalid {
            get {
                return ResourceManager.GetString("ProprietarioCpfIsInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CPF do Proprietário é Obrigatório.
        /// </summary>
        internal static string ProprietarioCpfIsRequired {
            get {
                return ResourceManager.GetString("ProprietarioCpfIsRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nome do Proprietário é Obrigatório.
        /// </summary>
        internal static string ProprietarioNomeIsRequired {
            get {
                return ResourceManager.GetString("ProprietarioNomeIsRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ID do Arquivo de Foto do Veículo é Obrigatório.
        /// </summary>
        internal static string VeiculoFotoArquivoIsRequired {
            get {
                return ResourceManager.GetString("VeiculoFotoArquivoIsRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ID do Veículo da Foto é Obrigatório.
        /// </summary>
        internal static string VeiculoFotoVeiculoIDIsRequired {
            get {
                return ResourceManager.GetString("VeiculoFotoVeiculoIDIsRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Placa do Veículo é Inválida.
        /// </summary>
        internal static string VeiculoPlacaIsInvalid {
            get {
                return ResourceManager.GetString("VeiculoPlacaIsInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Placa do Veículo é Obrigatória.
        /// </summary>
        internal static string VeiculoPlacaIsRequired {
            get {
                return ResourceManager.GetString("VeiculoPlacaIsRequired", resourceCulture);
            }
        }
    }
}

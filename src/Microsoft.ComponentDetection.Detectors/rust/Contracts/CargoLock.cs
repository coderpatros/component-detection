﻿using System.Diagnostics.CodeAnalysis;
using Nett;

namespace Microsoft.ComponentDetection.Detectors.Rust.Contracts
{
    // Represents Cargo.Lock file structure.
    public class CargoLock
    {
        [SuppressMessage("StyleCop.CSharp.NamingRules", "SA1300:ElementMustBeginWithUpperCaseLetter", Justification = "Deserialization contract. Casing cannot be overwritten.")]
        public CargoPackage[] package { get; set; }

        [SuppressMessage("StyleCop.CSharp.NamingRules", "SA1300:ElementMustBeginWithUpperCaseLetter", Justification = "Deserialization contract. Casing cannot be overwritten.")]
        public TomlTable metadata { get; set; }
    }
}

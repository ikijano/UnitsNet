//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using UnitsNet.Units;

namespace UnitsNet
{
    /// <inheritdoc />
    /// <summary>
    ///     Specific entropy is an amount of energy required to raise temperature of a substance by 1 Kelvin per unit mass.
    /// </summary>
    public struct  SpecificEntropy
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly SpecificEntropyUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public SpecificEntropyUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public SpecificEntropy(double value, SpecificEntropyUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static SpecificEntropyUnit BaseUnit { get; } = SpecificEntropyUnit.JoulePerKilogramKelvin;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static SpecificEntropy MaxValue { get; } = new SpecificEntropy(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static SpecificEntropy MinValue { get; } = new SpecificEntropy(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static SpecificEntropy Zero { get; } = new SpecificEntropy(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets this <see cref="SpecificEntropy"/> converted into <see cref="SpecificEntropyUnit.BtuPerPoundFahrenheit"/> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToBtusPerPoundFahrenheit property.")]
        public double BtusPerPoundFahrenheit => As(SpecificEntropyUnit.BtuPerPoundFahrenheit);

        /// <summary>
        ///     Gets this <see cref="SpecificEntropy"/> converted into <see cref="SpecificEntropyUnit.CaloriePerGramKelvin"/> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToCaloriesPerGramKelvin property.")]
        public double CaloriesPerGramKelvin => As(SpecificEntropyUnit.CaloriePerGramKelvin);

        /// <summary>
        ///     Gets this <see cref="SpecificEntropy"/> converted into <see cref="SpecificEntropyUnit.JoulePerKilogramDegreeCelsius"/> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToJoulesPerKilogramDegreeCelsius property.")]
        public double JoulesPerKilogramDegreeCelsius => As(SpecificEntropyUnit.JoulePerKilogramDegreeCelsius);

        /// <summary>
        ///     Gets this <see cref="SpecificEntropy"/> converted into <see cref="SpecificEntropyUnit.JoulePerKilogramKelvin"/> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToJoulesPerKilogramKelvin property.")]
        public double JoulesPerKilogramKelvin => As(SpecificEntropyUnit.JoulePerKilogramKelvin);

        /// <summary>
        ///     Gets this <see cref="SpecificEntropy"/> converted into <see cref="SpecificEntropyUnit.KilocaloriePerGramKelvin"/> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToKilocaloriesPerGramKelvin property.")]
        public double KilocaloriesPerGramKelvin => As(SpecificEntropyUnit.KilocaloriePerGramKelvin);

        /// <summary>
        ///     Gets this <see cref="SpecificEntropy"/> converted into <see cref="SpecificEntropyUnit.KilojoulePerKilogramDegreeCelsius"/> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToKilojoulesPerKilogramDegreeCelsius property.")]
        public double KilojoulesPerKilogramDegreeCelsius => As(SpecificEntropyUnit.KilojoulePerKilogramDegreeCelsius);

        /// <summary>
        ///     Gets this <see cref="SpecificEntropy"/> converted into <see cref="SpecificEntropyUnit.KilojoulePerKilogramKelvin"/> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToKilojoulesPerKilogramKelvin property.")]
        public double KilojoulesPerKilogramKelvin => As(SpecificEntropyUnit.KilojoulePerKilogramKelvin);

        /// <summary>
        ///     Gets this <see cref="SpecificEntropy"/> converted into <see cref="SpecificEntropyUnit.MegajoulePerKilogramDegreeCelsius"/> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToMegajoulesPerKilogramDegreeCelsius property.")]
        public double MegajoulesPerKilogramDegreeCelsius => As(SpecificEntropyUnit.MegajoulePerKilogramDegreeCelsius);

        /// <summary>
        ///     Gets this <see cref="SpecificEntropy"/> converted into <see cref="SpecificEntropyUnit.MegajoulePerKilogramKelvin"/> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToMegajoulesPerKilogramKelvin property.")]
        public double MegajoulesPerKilogramKelvin => As(SpecificEntropyUnit.MegajoulePerKilogramKelvin);

        /// <summary>
        ///     Gets this <see cref="SpecificEntropy"/> converted into <see cref="SpecificEntropyUnit.BtuPerPoundFahrenheit"/>.
        /// </summary>
        public SpecificEntropy ToBtusPerPoundFahrenheit => ToUnit(SpecificEntropyUnit.BtuPerPoundFahrenheit);

        /// <summary>
        ///     Gets this <see cref="SpecificEntropy"/> converted into <see cref="SpecificEntropyUnit.CaloriePerGramKelvin"/>.
        /// </summary>
        public SpecificEntropy ToCaloriesPerGramKelvin => ToUnit(SpecificEntropyUnit.CaloriePerGramKelvin);

        /// <summary>
        ///     Gets this <see cref="SpecificEntropy"/> converted into <see cref="SpecificEntropyUnit.JoulePerKilogramDegreeCelsius"/>.
        /// </summary>
        public SpecificEntropy ToJoulesPerKilogramDegreeCelsius => ToUnit(SpecificEntropyUnit.JoulePerKilogramDegreeCelsius);

        /// <summary>
        ///     Gets this <see cref="SpecificEntropy"/> converted into <see cref="SpecificEntropyUnit.JoulePerKilogramKelvin"/>.
        /// </summary>
        public SpecificEntropy ToJoulesPerKilogramKelvin => ToUnit(SpecificEntropyUnit.JoulePerKilogramKelvin);

        /// <summary>
        ///     Gets this <see cref="SpecificEntropy"/> converted into <see cref="SpecificEntropyUnit.KilocaloriePerGramKelvin"/>.
        /// </summary>
        public SpecificEntropy ToKilocaloriesPerGramKelvin => ToUnit(SpecificEntropyUnit.KilocaloriePerGramKelvin);

        /// <summary>
        ///     Gets this <see cref="SpecificEntropy"/> converted into <see cref="SpecificEntropyUnit.KilojoulePerKilogramDegreeCelsius"/>.
        /// </summary>
        public SpecificEntropy ToKilojoulesPerKilogramDegreeCelsius => ToUnit(SpecificEntropyUnit.KilojoulePerKilogramDegreeCelsius);

        /// <summary>
        ///     Gets this <see cref="SpecificEntropy"/> converted into <see cref="SpecificEntropyUnit.KilojoulePerKilogramKelvin"/>.
        /// </summary>
        public SpecificEntropy ToKilojoulesPerKilogramKelvin => ToUnit(SpecificEntropyUnit.KilojoulePerKilogramKelvin);

        /// <summary>
        ///     Gets this <see cref="SpecificEntropy"/> converted into <see cref="SpecificEntropyUnit.MegajoulePerKilogramDegreeCelsius"/>.
        /// </summary>
        public SpecificEntropy ToMegajoulesPerKilogramDegreeCelsius => ToUnit(SpecificEntropyUnit.MegajoulePerKilogramDegreeCelsius);

        /// <summary>
        ///     Gets this <see cref="SpecificEntropy"/> converted into <see cref="SpecificEntropyUnit.MegajoulePerKilogramKelvin"/>.
        /// </summary>
        public SpecificEntropy ToMegajoulesPerKilogramKelvin => ToUnit(SpecificEntropyUnit.MegajoulePerKilogramKelvin);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="SpecificEntropy"/> from <see cref="SpecificEntropyUnit.BtuPerPoundFahrenheit"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificEntropy FromBtusPerPoundFahrenheit(double btusperpoundfahrenheit) => new SpecificEntropy(btusperpoundfahrenheit, SpecificEntropyUnit.BtuPerPoundFahrenheit);

        /// <summary>
        ///     Creates a <see cref="SpecificEntropy"/> from <see cref="SpecificEntropyUnit.CaloriePerGramKelvin"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificEntropy FromCaloriesPerGramKelvin(double caloriespergramkelvin) => new SpecificEntropy(caloriespergramkelvin, SpecificEntropyUnit.CaloriePerGramKelvin);

        /// <summary>
        ///     Creates a <see cref="SpecificEntropy"/> from <see cref="SpecificEntropyUnit.JoulePerKilogramDegreeCelsius"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificEntropy FromJoulesPerKilogramDegreeCelsius(double joulesperkilogramdegreecelsius) => new SpecificEntropy(joulesperkilogramdegreecelsius, SpecificEntropyUnit.JoulePerKilogramDegreeCelsius);

        /// <summary>
        ///     Creates a <see cref="SpecificEntropy"/> from <see cref="SpecificEntropyUnit.JoulePerKilogramKelvin"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificEntropy FromJoulesPerKilogramKelvin(double joulesperkilogramkelvin) => new SpecificEntropy(joulesperkilogramkelvin, SpecificEntropyUnit.JoulePerKilogramKelvin);

        /// <summary>
        ///     Creates a <see cref="SpecificEntropy"/> from <see cref="SpecificEntropyUnit.KilocaloriePerGramKelvin"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificEntropy FromKilocaloriesPerGramKelvin(double kilocaloriespergramkelvin) => new SpecificEntropy(kilocaloriespergramkelvin, SpecificEntropyUnit.KilocaloriePerGramKelvin);

        /// <summary>
        ///     Creates a <see cref="SpecificEntropy"/> from <see cref="SpecificEntropyUnit.KilojoulePerKilogramDegreeCelsius"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificEntropy FromKilojoulesPerKilogramDegreeCelsius(double kilojoulesperkilogramdegreecelsius) => new SpecificEntropy(kilojoulesperkilogramdegreecelsius, SpecificEntropyUnit.KilojoulePerKilogramDegreeCelsius);

        /// <summary>
        ///     Creates a <see cref="SpecificEntropy"/> from <see cref="SpecificEntropyUnit.KilojoulePerKilogramKelvin"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificEntropy FromKilojoulesPerKilogramKelvin(double kilojoulesperkilogramkelvin) => new SpecificEntropy(kilojoulesperkilogramkelvin, SpecificEntropyUnit.KilojoulePerKilogramKelvin);

        /// <summary>
        ///     Creates a <see cref="SpecificEntropy"/> from <see cref="SpecificEntropyUnit.MegajoulePerKilogramDegreeCelsius"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificEntropy FromMegajoulesPerKilogramDegreeCelsius(double megajoulesperkilogramdegreecelsius) => new SpecificEntropy(megajoulesperkilogramdegreecelsius, SpecificEntropyUnit.MegajoulePerKilogramDegreeCelsius);

        /// <summary>
        ///     Creates a <see cref="SpecificEntropy"/> from <see cref="SpecificEntropyUnit.MegajoulePerKilogramKelvin"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificEntropy FromMegajoulesPerKilogramKelvin(double megajoulesperkilogramkelvin) => new SpecificEntropy(megajoulesperkilogramkelvin, SpecificEntropyUnit.MegajoulePerKilogramKelvin);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="SpecificEntropyUnit" /> to <see cref="SpecificEntropy" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>SpecificEntropy unit value.</returns>
        public static SpecificEntropy From(double value, SpecificEntropyUnit fromUnit)
        {
            return new SpecificEntropy(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(SpecificEntropyUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public SpecificEntropy ToUnit(SpecificEntropyUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new SpecificEntropy(convertedValue, unit);
        }

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double GetValueInBaseUnit()
        {
            return Unit switch
            {
                SpecificEntropyUnit.BtuPerPoundFahrenheit => _value * 4.1868e3,
                SpecificEntropyUnit.CaloriePerGramKelvin => _value * 4.184e3,
                SpecificEntropyUnit.JoulePerKilogramDegreeCelsius => _value,
                SpecificEntropyUnit.JoulePerKilogramKelvin => _value,
                SpecificEntropyUnit.KilocaloriePerGramKelvin => (_value * 4.184e3) * 1e3d,
                SpecificEntropyUnit.KilojoulePerKilogramDegreeCelsius => (_value) * 1e3d,
                SpecificEntropyUnit.KilojoulePerKilogramKelvin => (_value) * 1e3d,
                SpecificEntropyUnit.MegajoulePerKilogramDegreeCelsius => (_value) * 1e6d,
                SpecificEntropyUnit.MegajoulePerKilogramKelvin => (_value) * 1e6d,
                _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
            };
        }

        private double GetValueAs(SpecificEntropyUnit unit)
        {
            if (Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            return unit switch
            {
                SpecificEntropyUnit.BtuPerPoundFahrenheit => baseUnitValue / 4.1868e3,
                SpecificEntropyUnit.CaloriePerGramKelvin => baseUnitValue / 4.184e3,
                SpecificEntropyUnit.JoulePerKilogramDegreeCelsius => baseUnitValue,
                SpecificEntropyUnit.JoulePerKilogramKelvin => baseUnitValue,
                SpecificEntropyUnit.KilocaloriePerGramKelvin => (baseUnitValue / 4.184e3) / 1e3d,
                SpecificEntropyUnit.KilojoulePerKilogramDegreeCelsius => (baseUnitValue) / 1e3d,
                SpecificEntropyUnit.KilojoulePerKilogramKelvin => (baseUnitValue) / 1e3d,
                SpecificEntropyUnit.MegajoulePerKilogramDegreeCelsius => (baseUnitValue) / 1e6d,
                SpecificEntropyUnit.MegajoulePerKilogramKelvin => (baseUnitValue) / 1e6d,
                _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
            };
        }

        #endregion
    }
}


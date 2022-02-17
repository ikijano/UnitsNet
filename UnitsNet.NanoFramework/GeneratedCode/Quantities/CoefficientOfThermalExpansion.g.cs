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
    ///     A unit that represents a fractional change in size in response to a change in temperature.
    /// </summary>
    public struct  CoefficientOfThermalExpansion
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly CoefficientOfThermalExpansionUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public CoefficientOfThermalExpansionUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public CoefficientOfThermalExpansion(double value, CoefficientOfThermalExpansionUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static CoefficientOfThermalExpansionUnit BaseUnit { get; } = CoefficientOfThermalExpansionUnit.InverseKelvin;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static CoefficientOfThermalExpansion MaxValue { get; } = new CoefficientOfThermalExpansion(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static CoefficientOfThermalExpansion MinValue { get; } = new CoefficientOfThermalExpansion(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static CoefficientOfThermalExpansion Zero { get; } = new CoefficientOfThermalExpansion(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets this <see cref="CoefficientOfThermalExpansion"/> converted into <see cref="CoefficientOfThermalExpansionUnit.InverseDegreeCelsius">InverseDegreeCelsius</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToInverseDegreeCelsius property.")]
        public double InverseDegreeCelsius => As(CoefficientOfThermalExpansionUnit.InverseDegreeCelsius);

        /// <summary>
        ///     Gets this <see cref="CoefficientOfThermalExpansion"/> converted into <see cref="CoefficientOfThermalExpansionUnit.InverseDegreeFahrenheit">InverseDegreeFahrenheit</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToInverseDegreeFahrenheit property.")]
        public double InverseDegreeFahrenheit => As(CoefficientOfThermalExpansionUnit.InverseDegreeFahrenheit);

        /// <summary>
        ///     Gets this <see cref="CoefficientOfThermalExpansion"/> converted into <see cref="CoefficientOfThermalExpansionUnit.InverseKelvin">InverseKelvin</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToInverseKelvin property.")]
        public double InverseKelvin => As(CoefficientOfThermalExpansionUnit.InverseKelvin);

        /// <summary>
        ///     Gets this <see cref="CoefficientOfThermalExpansion"/> converted into <see cref="CoefficientOfThermalExpansionUnit.InverseDegreeCelsius">InverseDegreeCelsius</see>.
        /// </summary>
        public CoefficientOfThermalExpansion ToInverseDegreeCelsius => ToUnit(CoefficientOfThermalExpansionUnit.InverseDegreeCelsius);

        /// <summary>
        ///     Gets this <see cref="CoefficientOfThermalExpansion"/> converted into <see cref="CoefficientOfThermalExpansionUnit.InverseDegreeFahrenheit">InverseDegreeFahrenheit</see>.
        /// </summary>
        public CoefficientOfThermalExpansion ToInverseDegreeFahrenheit => ToUnit(CoefficientOfThermalExpansionUnit.InverseDegreeFahrenheit);

        /// <summary>
        ///     Gets this <see cref="CoefficientOfThermalExpansion"/> converted into <see cref="CoefficientOfThermalExpansionUnit.InverseKelvin">InverseKelvin</see>.
        /// </summary>
        public CoefficientOfThermalExpansion ToInverseKelvin => ToUnit(CoefficientOfThermalExpansionUnit.InverseKelvin);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="CoefficientOfThermalExpansion"/> from <see cref="CoefficientOfThermalExpansionUnit.InverseDegreeCelsius"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static CoefficientOfThermalExpansion FromInverseDegreeCelsius(double inversedegreecelsius) => new CoefficientOfThermalExpansion(inversedegreecelsius, CoefficientOfThermalExpansionUnit.InverseDegreeCelsius);

        /// <summary>
        ///     Creates a <see cref="CoefficientOfThermalExpansion"/> from <see cref="CoefficientOfThermalExpansionUnit.InverseDegreeFahrenheit"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static CoefficientOfThermalExpansion FromInverseDegreeFahrenheit(double inversedegreefahrenheit) => new CoefficientOfThermalExpansion(inversedegreefahrenheit, CoefficientOfThermalExpansionUnit.InverseDegreeFahrenheit);

        /// <summary>
        ///     Creates a <see cref="CoefficientOfThermalExpansion"/> from <see cref="CoefficientOfThermalExpansionUnit.InverseKelvin"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static CoefficientOfThermalExpansion FromInverseKelvin(double inversekelvin) => new CoefficientOfThermalExpansion(inversekelvin, CoefficientOfThermalExpansionUnit.InverseKelvin);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="CoefficientOfThermalExpansionUnit" /> to <see cref="CoefficientOfThermalExpansion" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>CoefficientOfThermalExpansion unit value.</returns>
        public static CoefficientOfThermalExpansion From(double value, CoefficientOfThermalExpansionUnit fromUnit)
        {
            return new CoefficientOfThermalExpansion(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(CoefficientOfThermalExpansionUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public CoefficientOfThermalExpansion ToUnit(CoefficientOfThermalExpansionUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new CoefficientOfThermalExpansion(convertedValue, unit);
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
                CoefficientOfThermalExpansionUnit.InverseDegreeCelsius => _value,
                CoefficientOfThermalExpansionUnit.InverseDegreeFahrenheit => _value * 9 / 5,
                CoefficientOfThermalExpansionUnit.InverseKelvin => _value,
                _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
            };
        }

        private double GetValueAs(CoefficientOfThermalExpansionUnit unit)
        {
            if (Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            return unit switch
            {
                CoefficientOfThermalExpansionUnit.InverseDegreeCelsius => baseUnitValue,
                CoefficientOfThermalExpansionUnit.InverseDegreeFahrenheit => baseUnitValue * 5 / 9,
                CoefficientOfThermalExpansionUnit.InverseKelvin => baseUnitValue,
                _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
            };
        }

        #endregion
    }
}


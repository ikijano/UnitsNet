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
    ///     A geometric property of an area that reflects how its points are distributed with regard to an axis.
    /// </summary>
    public struct  AreaMomentOfInertia
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly AreaMomentOfInertiaUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public AreaMomentOfInertiaUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public AreaMomentOfInertia(double value, AreaMomentOfInertiaUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static AreaMomentOfInertiaUnit BaseUnit { get; } = AreaMomentOfInertiaUnit.MeterToTheFourth;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static AreaMomentOfInertia MaxValue { get; } = new AreaMomentOfInertia(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static AreaMomentOfInertia MinValue { get; } = new AreaMomentOfInertia(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static AreaMomentOfInertia Zero { get; } = new AreaMomentOfInertia(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets this <see cref="AreaMomentOfInertia"/> converted into <see cref="AreaMomentOfInertiaUnit.CentimeterToTheFourth">CentimetersToTheFourth</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToCentimetersToTheFourth property.")]
        public double CentimetersToTheFourth => As(AreaMomentOfInertiaUnit.CentimeterToTheFourth);

        /// <summary>
        ///     Gets this <see cref="AreaMomentOfInertia"/> converted into <see cref="AreaMomentOfInertiaUnit.DecimeterToTheFourth">DecimetersToTheFourth</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToDecimetersToTheFourth property.")]
        public double DecimetersToTheFourth => As(AreaMomentOfInertiaUnit.DecimeterToTheFourth);

        /// <summary>
        ///     Gets this <see cref="AreaMomentOfInertia"/> converted into <see cref="AreaMomentOfInertiaUnit.FootToTheFourth">FeetToTheFourth</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToFeetToTheFourth property.")]
        public double FeetToTheFourth => As(AreaMomentOfInertiaUnit.FootToTheFourth);

        /// <summary>
        ///     Gets this <see cref="AreaMomentOfInertia"/> converted into <see cref="AreaMomentOfInertiaUnit.InchToTheFourth">InchesToTheFourth</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToInchesToTheFourth property.")]
        public double InchesToTheFourth => As(AreaMomentOfInertiaUnit.InchToTheFourth);

        /// <summary>
        ///     Gets this <see cref="AreaMomentOfInertia"/> converted into <see cref="AreaMomentOfInertiaUnit.MeterToTheFourth">MetersToTheFourth</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToMetersToTheFourth property.")]
        public double MetersToTheFourth => As(AreaMomentOfInertiaUnit.MeterToTheFourth);

        /// <summary>
        ///     Gets this <see cref="AreaMomentOfInertia"/> converted into <see cref="AreaMomentOfInertiaUnit.MillimeterToTheFourth">MillimetersToTheFourth</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToMillimetersToTheFourth property.")]
        public double MillimetersToTheFourth => As(AreaMomentOfInertiaUnit.MillimeterToTheFourth);

        /// <summary>
        ///     Gets this <see cref="AreaMomentOfInertia"/> converted into <see cref="AreaMomentOfInertiaUnit.CentimeterToTheFourth">CentimetersToTheFourth</see>.
        /// </summary>
        public AreaMomentOfInertia ToCentimetersToTheFourth => ToUnit(AreaMomentOfInertiaUnit.CentimeterToTheFourth);

        /// <summary>
        ///     Gets this <see cref="AreaMomentOfInertia"/> converted into <see cref="AreaMomentOfInertiaUnit.DecimeterToTheFourth">DecimetersToTheFourth</see>.
        /// </summary>
        public AreaMomentOfInertia ToDecimetersToTheFourth => ToUnit(AreaMomentOfInertiaUnit.DecimeterToTheFourth);

        /// <summary>
        ///     Gets this <see cref="AreaMomentOfInertia"/> converted into <see cref="AreaMomentOfInertiaUnit.FootToTheFourth">FeetToTheFourth</see>.
        /// </summary>
        public AreaMomentOfInertia ToFeetToTheFourth => ToUnit(AreaMomentOfInertiaUnit.FootToTheFourth);

        /// <summary>
        ///     Gets this <see cref="AreaMomentOfInertia"/> converted into <see cref="AreaMomentOfInertiaUnit.InchToTheFourth">InchesToTheFourth</see>.
        /// </summary>
        public AreaMomentOfInertia ToInchesToTheFourth => ToUnit(AreaMomentOfInertiaUnit.InchToTheFourth);

        /// <summary>
        ///     Gets this <see cref="AreaMomentOfInertia"/> converted into <see cref="AreaMomentOfInertiaUnit.MeterToTheFourth">MetersToTheFourth</see>.
        /// </summary>
        public AreaMomentOfInertia ToMetersToTheFourth => ToUnit(AreaMomentOfInertiaUnit.MeterToTheFourth);

        /// <summary>
        ///     Gets this <see cref="AreaMomentOfInertia"/> converted into <see cref="AreaMomentOfInertiaUnit.MillimeterToTheFourth">MillimetersToTheFourth</see>.
        /// </summary>
        public AreaMomentOfInertia ToMillimetersToTheFourth => ToUnit(AreaMomentOfInertiaUnit.MillimeterToTheFourth);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="AreaMomentOfInertia"/> from <see cref="AreaMomentOfInertiaUnit.CentimeterToTheFourth"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AreaMomentOfInertia FromCentimetersToTheFourth(double centimeterstothefourth) => new AreaMomentOfInertia(centimeterstothefourth, AreaMomentOfInertiaUnit.CentimeterToTheFourth);

        /// <summary>
        ///     Creates a <see cref="AreaMomentOfInertia"/> from <see cref="AreaMomentOfInertiaUnit.DecimeterToTheFourth"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AreaMomentOfInertia FromDecimetersToTheFourth(double decimeterstothefourth) => new AreaMomentOfInertia(decimeterstothefourth, AreaMomentOfInertiaUnit.DecimeterToTheFourth);

        /// <summary>
        ///     Creates a <see cref="AreaMomentOfInertia"/> from <see cref="AreaMomentOfInertiaUnit.FootToTheFourth"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AreaMomentOfInertia FromFeetToTheFourth(double feettothefourth) => new AreaMomentOfInertia(feettothefourth, AreaMomentOfInertiaUnit.FootToTheFourth);

        /// <summary>
        ///     Creates a <see cref="AreaMomentOfInertia"/> from <see cref="AreaMomentOfInertiaUnit.InchToTheFourth"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AreaMomentOfInertia FromInchesToTheFourth(double inchestothefourth) => new AreaMomentOfInertia(inchestothefourth, AreaMomentOfInertiaUnit.InchToTheFourth);

        /// <summary>
        ///     Creates a <see cref="AreaMomentOfInertia"/> from <see cref="AreaMomentOfInertiaUnit.MeterToTheFourth"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AreaMomentOfInertia FromMetersToTheFourth(double meterstothefourth) => new AreaMomentOfInertia(meterstothefourth, AreaMomentOfInertiaUnit.MeterToTheFourth);

        /// <summary>
        ///     Creates a <see cref="AreaMomentOfInertia"/> from <see cref="AreaMomentOfInertiaUnit.MillimeterToTheFourth"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static AreaMomentOfInertia FromMillimetersToTheFourth(double millimeterstothefourth) => new AreaMomentOfInertia(millimeterstothefourth, AreaMomentOfInertiaUnit.MillimeterToTheFourth);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="AreaMomentOfInertiaUnit" /> to <see cref="AreaMomentOfInertia" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>AreaMomentOfInertia unit value.</returns>
        public static AreaMomentOfInertia From(double value, AreaMomentOfInertiaUnit fromUnit)
        {
            return new AreaMomentOfInertia(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(AreaMomentOfInertiaUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public AreaMomentOfInertia ToUnit(AreaMomentOfInertiaUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new AreaMomentOfInertia(convertedValue, unit);
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
                AreaMomentOfInertiaUnit.CentimeterToTheFourth => _value / 1e8,
                AreaMomentOfInertiaUnit.DecimeterToTheFourth => _value / 1e4,
                AreaMomentOfInertiaUnit.FootToTheFourth => _value * 0.0086309748412416,
                AreaMomentOfInertiaUnit.InchToTheFourth => _value * 0.0000004162314256,
                AreaMomentOfInertiaUnit.MeterToTheFourth => _value,
                AreaMomentOfInertiaUnit.MillimeterToTheFourth => _value / 1e12,
                _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
            };
        }

        private double GetValueAs(AreaMomentOfInertiaUnit unit)
        {
            if (Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            return unit switch
            {
                AreaMomentOfInertiaUnit.CentimeterToTheFourth => baseUnitValue * 1e8,
                AreaMomentOfInertiaUnit.DecimeterToTheFourth => baseUnitValue * 1e4,
                AreaMomentOfInertiaUnit.FootToTheFourth => baseUnitValue / 0.0086309748412416,
                AreaMomentOfInertiaUnit.InchToTheFourth => baseUnitValue / 0.0000004162314256,
                AreaMomentOfInertiaUnit.MeterToTheFourth => baseUnitValue,
                AreaMomentOfInertiaUnit.MillimeterToTheFourth => baseUnitValue * 1e12,
                _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
            };
        }

        #endregion
    }
}


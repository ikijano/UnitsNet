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
    ///     Reciprocal (Inverse) Length is used in various fields of science and mathematics. It is defined as the inverse value of a length unit.
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/Reciprocal_length
    /// </remarks>
    public struct  ReciprocalLength
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly ReciprocalLengthUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public ReciprocalLengthUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public ReciprocalLength(double value, ReciprocalLengthUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static ReciprocalLengthUnit BaseUnit { get; } = ReciprocalLengthUnit.InverseMeter;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static ReciprocalLength MaxValue { get; } = new ReciprocalLength(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static ReciprocalLength MinValue { get; } = new ReciprocalLength(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static ReciprocalLength Zero { get; } = new ReciprocalLength(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets this <see cref="ReciprocalLength"/> converted into <see cref="ReciprocalLengthUnit.InverseCentimeter">InverseCentimeters</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToInverseCentimeters property.")]
        public double InverseCentimeters => As(ReciprocalLengthUnit.InverseCentimeter);

        /// <summary>
        ///     Gets this <see cref="ReciprocalLength"/> converted into <see cref="ReciprocalLengthUnit.InverseFoot">InverseFeet</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToInverseFeet property.")]
        public double InverseFeet => As(ReciprocalLengthUnit.InverseFoot);

        /// <summary>
        ///     Gets this <see cref="ReciprocalLength"/> converted into <see cref="ReciprocalLengthUnit.InverseInch">InverseInches</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToInverseInches property.")]
        public double InverseInches => As(ReciprocalLengthUnit.InverseInch);

        /// <summary>
        ///     Gets this <see cref="ReciprocalLength"/> converted into <see cref="ReciprocalLengthUnit.InverseMeter">InverseMeters</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToInverseMeters property.")]
        public double InverseMeters => As(ReciprocalLengthUnit.InverseMeter);

        /// <summary>
        ///     Gets this <see cref="ReciprocalLength"/> converted into <see cref="ReciprocalLengthUnit.InverseMicroinch">InverseMicroinches</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToInverseMicroinches property.")]
        public double InverseMicroinches => As(ReciprocalLengthUnit.InverseMicroinch);

        /// <summary>
        ///     Gets this <see cref="ReciprocalLength"/> converted into <see cref="ReciprocalLengthUnit.InverseMil">InverseMils</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToInverseMils property.")]
        public double InverseMils => As(ReciprocalLengthUnit.InverseMil);

        /// <summary>
        ///     Gets this <see cref="ReciprocalLength"/> converted into <see cref="ReciprocalLengthUnit.InverseMile">InverseMiles</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToInverseMiles property.")]
        public double InverseMiles => As(ReciprocalLengthUnit.InverseMile);

        /// <summary>
        ///     Gets this <see cref="ReciprocalLength"/> converted into <see cref="ReciprocalLengthUnit.InverseMillimeter">InverseMillimeters</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToInverseMillimeters property.")]
        public double InverseMillimeters => As(ReciprocalLengthUnit.InverseMillimeter);

        /// <summary>
        ///     Gets this <see cref="ReciprocalLength"/> converted into <see cref="ReciprocalLengthUnit.InverseUsSurveyFoot">InverseUsSurveyFeet</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToInverseUsSurveyFeet property.")]
        public double InverseUsSurveyFeet => As(ReciprocalLengthUnit.InverseUsSurveyFoot);

        /// <summary>
        ///     Gets this <see cref="ReciprocalLength"/> converted into <see cref="ReciprocalLengthUnit.InverseYard">InverseYards</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToInverseYards property.")]
        public double InverseYards => As(ReciprocalLengthUnit.InverseYard);

        /// <summary>
        ///     Gets this <see cref="ReciprocalLength"/> converted into <see cref="ReciprocalLengthUnit.InverseCentimeter">InverseCentimeters</see>.
        /// </summary>
        public ReciprocalLength ToInverseCentimeters => ToUnit(ReciprocalLengthUnit.InverseCentimeter);

        /// <summary>
        ///     Gets this <see cref="ReciprocalLength"/> converted into <see cref="ReciprocalLengthUnit.InverseFoot">InverseFeet</see>.
        /// </summary>
        public ReciprocalLength ToInverseFeet => ToUnit(ReciprocalLengthUnit.InverseFoot);

        /// <summary>
        ///     Gets this <see cref="ReciprocalLength"/> converted into <see cref="ReciprocalLengthUnit.InverseInch">InverseInches</see>.
        /// </summary>
        public ReciprocalLength ToInverseInches => ToUnit(ReciprocalLengthUnit.InverseInch);

        /// <summary>
        ///     Gets this <see cref="ReciprocalLength"/> converted into <see cref="ReciprocalLengthUnit.InverseMeter">InverseMeters</see>.
        /// </summary>
        public ReciprocalLength ToInverseMeters => ToUnit(ReciprocalLengthUnit.InverseMeter);

        /// <summary>
        ///     Gets this <see cref="ReciprocalLength"/> converted into <see cref="ReciprocalLengthUnit.InverseMicroinch">InverseMicroinches</see>.
        /// </summary>
        public ReciprocalLength ToInverseMicroinches => ToUnit(ReciprocalLengthUnit.InverseMicroinch);

        /// <summary>
        ///     Gets this <see cref="ReciprocalLength"/> converted into <see cref="ReciprocalLengthUnit.InverseMil">InverseMils</see>.
        /// </summary>
        public ReciprocalLength ToInverseMils => ToUnit(ReciprocalLengthUnit.InverseMil);

        /// <summary>
        ///     Gets this <see cref="ReciprocalLength"/> converted into <see cref="ReciprocalLengthUnit.InverseMile">InverseMiles</see>.
        /// </summary>
        public ReciprocalLength ToInverseMiles => ToUnit(ReciprocalLengthUnit.InverseMile);

        /// <summary>
        ///     Gets this <see cref="ReciprocalLength"/> converted into <see cref="ReciprocalLengthUnit.InverseMillimeter">InverseMillimeters</see>.
        /// </summary>
        public ReciprocalLength ToInverseMillimeters => ToUnit(ReciprocalLengthUnit.InverseMillimeter);

        /// <summary>
        ///     Gets this <see cref="ReciprocalLength"/> converted into <see cref="ReciprocalLengthUnit.InverseUsSurveyFoot">InverseUsSurveyFeet</see>.
        /// </summary>
        public ReciprocalLength ToInverseUsSurveyFeet => ToUnit(ReciprocalLengthUnit.InverseUsSurveyFoot);

        /// <summary>
        ///     Gets this <see cref="ReciprocalLength"/> converted into <see cref="ReciprocalLengthUnit.InverseYard">InverseYards</see>.
        /// </summary>
        public ReciprocalLength ToInverseYards => ToUnit(ReciprocalLengthUnit.InverseYard);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="ReciprocalLength"/> from <see cref="ReciprocalLengthUnit.InverseCentimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ReciprocalLength FromInverseCentimeters(double inversecentimeters) => new ReciprocalLength(inversecentimeters, ReciprocalLengthUnit.InverseCentimeter);

        /// <summary>
        ///     Creates a <see cref="ReciprocalLength"/> from <see cref="ReciprocalLengthUnit.InverseFoot"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ReciprocalLength FromInverseFeet(double inversefeet) => new ReciprocalLength(inversefeet, ReciprocalLengthUnit.InverseFoot);

        /// <summary>
        ///     Creates a <see cref="ReciprocalLength"/> from <see cref="ReciprocalLengthUnit.InverseInch"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ReciprocalLength FromInverseInches(double inverseinches) => new ReciprocalLength(inverseinches, ReciprocalLengthUnit.InverseInch);

        /// <summary>
        ///     Creates a <see cref="ReciprocalLength"/> from <see cref="ReciprocalLengthUnit.InverseMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ReciprocalLength FromInverseMeters(double inversemeters) => new ReciprocalLength(inversemeters, ReciprocalLengthUnit.InverseMeter);

        /// <summary>
        ///     Creates a <see cref="ReciprocalLength"/> from <see cref="ReciprocalLengthUnit.InverseMicroinch"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ReciprocalLength FromInverseMicroinches(double inversemicroinches) => new ReciprocalLength(inversemicroinches, ReciprocalLengthUnit.InverseMicroinch);

        /// <summary>
        ///     Creates a <see cref="ReciprocalLength"/> from <see cref="ReciprocalLengthUnit.InverseMil"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ReciprocalLength FromInverseMils(double inversemils) => new ReciprocalLength(inversemils, ReciprocalLengthUnit.InverseMil);

        /// <summary>
        ///     Creates a <see cref="ReciprocalLength"/> from <see cref="ReciprocalLengthUnit.InverseMile"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ReciprocalLength FromInverseMiles(double inversemiles) => new ReciprocalLength(inversemiles, ReciprocalLengthUnit.InverseMile);

        /// <summary>
        ///     Creates a <see cref="ReciprocalLength"/> from <see cref="ReciprocalLengthUnit.InverseMillimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ReciprocalLength FromInverseMillimeters(double inversemillimeters) => new ReciprocalLength(inversemillimeters, ReciprocalLengthUnit.InverseMillimeter);

        /// <summary>
        ///     Creates a <see cref="ReciprocalLength"/> from <see cref="ReciprocalLengthUnit.InverseUsSurveyFoot"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ReciprocalLength FromInverseUsSurveyFeet(double inverseussurveyfeet) => new ReciprocalLength(inverseussurveyfeet, ReciprocalLengthUnit.InverseUsSurveyFoot);

        /// <summary>
        ///     Creates a <see cref="ReciprocalLength"/> from <see cref="ReciprocalLengthUnit.InverseYard"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ReciprocalLength FromInverseYards(double inverseyards) => new ReciprocalLength(inverseyards, ReciprocalLengthUnit.InverseYard);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ReciprocalLengthUnit" /> to <see cref="ReciprocalLength" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ReciprocalLength unit value.</returns>
        public static ReciprocalLength From(double value, ReciprocalLengthUnit fromUnit)
        {
            return new ReciprocalLength(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(ReciprocalLengthUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public ReciprocalLength ToUnit(ReciprocalLengthUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new ReciprocalLength(convertedValue, unit);
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
                ReciprocalLengthUnit.InverseCentimeter => _value * 1e2,
                ReciprocalLengthUnit.InverseFoot => _value / 0.3048,
                ReciprocalLengthUnit.InverseInch => _value / 2.54e-2,
                ReciprocalLengthUnit.InverseMeter => _value,
                ReciprocalLengthUnit.InverseMicroinch => _value / 2.54e-8,
                ReciprocalLengthUnit.InverseMil => _value / 2.54e-5,
                ReciprocalLengthUnit.InverseMile => _value / 1609.34,
                ReciprocalLengthUnit.InverseMillimeter => _value * 1e3,
                ReciprocalLengthUnit.InverseUsSurveyFoot => _value * 3937 / 1200,
                ReciprocalLengthUnit.InverseYard => _value / 0.9144,
                _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
            };
        }

        private double GetValueAs(ReciprocalLengthUnit unit)
        {
            if (Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            return unit switch
            {
                ReciprocalLengthUnit.InverseCentimeter => baseUnitValue / 1e2,
                ReciprocalLengthUnit.InverseFoot => baseUnitValue * 0.3048,
                ReciprocalLengthUnit.InverseInch => baseUnitValue * 2.54e-2,
                ReciprocalLengthUnit.InverseMeter => baseUnitValue,
                ReciprocalLengthUnit.InverseMicroinch => baseUnitValue * 2.54e-8,
                ReciprocalLengthUnit.InverseMil => baseUnitValue * 2.54e-5,
                ReciprocalLengthUnit.InverseMile => baseUnitValue * 1609.34,
                ReciprocalLengthUnit.InverseMillimeter => baseUnitValue / 1e3,
                ReciprocalLengthUnit.InverseUsSurveyFoot => baseUnitValue * 1200 / 3937,
                ReciprocalLengthUnit.InverseYard => baseUnitValue * 0.9144,
                _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
            };
        }

        #endregion
    }
}


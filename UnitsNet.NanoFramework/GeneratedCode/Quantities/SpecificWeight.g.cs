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
    ///     The SpecificWeight, or more precisely, the volumetric weight density, of a substance is its weight per unit volume.
    /// </summary>
    /// <remarks>
    ///     http://en.wikipedia.org/wiki/Specificweight
    /// </remarks>
    public struct  SpecificWeight
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly SpecificWeightUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public SpecificWeightUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public SpecificWeight(double value, SpecificWeightUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static SpecificWeightUnit BaseUnit { get; } = SpecificWeightUnit.NewtonPerCubicMeter;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static SpecificWeight MaxValue { get; } = new SpecificWeight(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static SpecificWeight MinValue { get; } = new SpecificWeight(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static SpecificWeight Zero { get; } = new SpecificWeight(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets this <see cref="SpecificWeight"/> converted into <see cref="SpecificWeightUnit.KilogramForcePerCubicCentimeter">KilogramsForcePerCubicCentimeter</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToKilogramsForcePerCubicCentimeter property.")]
        public double KilogramsForcePerCubicCentimeter => As(SpecificWeightUnit.KilogramForcePerCubicCentimeter);

        /// <summary>
        ///     Gets this <see cref="SpecificWeight"/> converted into <see cref="SpecificWeightUnit.KilogramForcePerCubicMeter">KilogramsForcePerCubicMeter</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToKilogramsForcePerCubicMeter property.")]
        public double KilogramsForcePerCubicMeter => As(SpecificWeightUnit.KilogramForcePerCubicMeter);

        /// <summary>
        ///     Gets this <see cref="SpecificWeight"/> converted into <see cref="SpecificWeightUnit.KilogramForcePerCubicMillimeter">KilogramsForcePerCubicMillimeter</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToKilogramsForcePerCubicMillimeter property.")]
        public double KilogramsForcePerCubicMillimeter => As(SpecificWeightUnit.KilogramForcePerCubicMillimeter);

        /// <summary>
        ///     Gets this <see cref="SpecificWeight"/> converted into <see cref="SpecificWeightUnit.KilonewtonPerCubicCentimeter">KilonewtonsPerCubicCentimeter</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToKilonewtonsPerCubicCentimeter property.")]
        public double KilonewtonsPerCubicCentimeter => As(SpecificWeightUnit.KilonewtonPerCubicCentimeter);

        /// <summary>
        ///     Gets this <see cref="SpecificWeight"/> converted into <see cref="SpecificWeightUnit.KilonewtonPerCubicMeter">KilonewtonsPerCubicMeter</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToKilonewtonsPerCubicMeter property.")]
        public double KilonewtonsPerCubicMeter => As(SpecificWeightUnit.KilonewtonPerCubicMeter);

        /// <summary>
        ///     Gets this <see cref="SpecificWeight"/> converted into <see cref="SpecificWeightUnit.KilonewtonPerCubicMillimeter">KilonewtonsPerCubicMillimeter</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToKilonewtonsPerCubicMillimeter property.")]
        public double KilonewtonsPerCubicMillimeter => As(SpecificWeightUnit.KilonewtonPerCubicMillimeter);

        /// <summary>
        ///     Gets this <see cref="SpecificWeight"/> converted into <see cref="SpecificWeightUnit.KilopoundForcePerCubicFoot">KilopoundsForcePerCubicFoot</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToKilopoundsForcePerCubicFoot property.")]
        public double KilopoundsForcePerCubicFoot => As(SpecificWeightUnit.KilopoundForcePerCubicFoot);

        /// <summary>
        ///     Gets this <see cref="SpecificWeight"/> converted into <see cref="SpecificWeightUnit.KilopoundForcePerCubicInch">KilopoundsForcePerCubicInch</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToKilopoundsForcePerCubicInch property.")]
        public double KilopoundsForcePerCubicInch => As(SpecificWeightUnit.KilopoundForcePerCubicInch);

        /// <summary>
        ///     Gets this <see cref="SpecificWeight"/> converted into <see cref="SpecificWeightUnit.MeganewtonPerCubicMeter">MeganewtonsPerCubicMeter</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToMeganewtonsPerCubicMeter property.")]
        public double MeganewtonsPerCubicMeter => As(SpecificWeightUnit.MeganewtonPerCubicMeter);

        /// <summary>
        ///     Gets this <see cref="SpecificWeight"/> converted into <see cref="SpecificWeightUnit.NewtonPerCubicCentimeter">NewtonsPerCubicCentimeter</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToNewtonsPerCubicCentimeter property.")]
        public double NewtonsPerCubicCentimeter => As(SpecificWeightUnit.NewtonPerCubicCentimeter);

        /// <summary>
        ///     Gets this <see cref="SpecificWeight"/> converted into <see cref="SpecificWeightUnit.NewtonPerCubicMeter">NewtonsPerCubicMeter</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToNewtonsPerCubicMeter property.")]
        public double NewtonsPerCubicMeter => As(SpecificWeightUnit.NewtonPerCubicMeter);

        /// <summary>
        ///     Gets this <see cref="SpecificWeight"/> converted into <see cref="SpecificWeightUnit.NewtonPerCubicMillimeter">NewtonsPerCubicMillimeter</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToNewtonsPerCubicMillimeter property.")]
        public double NewtonsPerCubicMillimeter => As(SpecificWeightUnit.NewtonPerCubicMillimeter);

        /// <summary>
        ///     Gets this <see cref="SpecificWeight"/> converted into <see cref="SpecificWeightUnit.PoundForcePerCubicFoot">PoundsForcePerCubicFoot</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToPoundsForcePerCubicFoot property.")]
        public double PoundsForcePerCubicFoot => As(SpecificWeightUnit.PoundForcePerCubicFoot);

        /// <summary>
        ///     Gets this <see cref="SpecificWeight"/> converted into <see cref="SpecificWeightUnit.PoundForcePerCubicInch">PoundsForcePerCubicInch</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToPoundsForcePerCubicInch property.")]
        public double PoundsForcePerCubicInch => As(SpecificWeightUnit.PoundForcePerCubicInch);

        /// <summary>
        ///     Gets this <see cref="SpecificWeight"/> converted into <see cref="SpecificWeightUnit.TonneForcePerCubicCentimeter">TonnesForcePerCubicCentimeter</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToTonnesForcePerCubicCentimeter property.")]
        public double TonnesForcePerCubicCentimeter => As(SpecificWeightUnit.TonneForcePerCubicCentimeter);

        /// <summary>
        ///     Gets this <see cref="SpecificWeight"/> converted into <see cref="SpecificWeightUnit.TonneForcePerCubicMeter">TonnesForcePerCubicMeter</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToTonnesForcePerCubicMeter property.")]
        public double TonnesForcePerCubicMeter => As(SpecificWeightUnit.TonneForcePerCubicMeter);

        /// <summary>
        ///     Gets this <see cref="SpecificWeight"/> converted into <see cref="SpecificWeightUnit.TonneForcePerCubicMillimeter">TonnesForcePerCubicMillimeter</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToTonnesForcePerCubicMillimeter property.")]
        public double TonnesForcePerCubicMillimeter => As(SpecificWeightUnit.TonneForcePerCubicMillimeter);

        /// <summary>
        ///     Gets this <see cref="SpecificWeight"/> converted into <see cref="SpecificWeightUnit.KilogramForcePerCubicCentimeter">KilogramsForcePerCubicCentimeter</see>.
        /// </summary>
        public SpecificWeight ToKilogramsForcePerCubicCentimeter => ToUnit(SpecificWeightUnit.KilogramForcePerCubicCentimeter);

        /// <summary>
        ///     Gets this <see cref="SpecificWeight"/> converted into <see cref="SpecificWeightUnit.KilogramForcePerCubicMeter">KilogramsForcePerCubicMeter</see>.
        /// </summary>
        public SpecificWeight ToKilogramsForcePerCubicMeter => ToUnit(SpecificWeightUnit.KilogramForcePerCubicMeter);

        /// <summary>
        ///     Gets this <see cref="SpecificWeight"/> converted into <see cref="SpecificWeightUnit.KilogramForcePerCubicMillimeter">KilogramsForcePerCubicMillimeter</see>.
        /// </summary>
        public SpecificWeight ToKilogramsForcePerCubicMillimeter => ToUnit(SpecificWeightUnit.KilogramForcePerCubicMillimeter);

        /// <summary>
        ///     Gets this <see cref="SpecificWeight"/> converted into <see cref="SpecificWeightUnit.KilonewtonPerCubicCentimeter">KilonewtonsPerCubicCentimeter</see>.
        /// </summary>
        public SpecificWeight ToKilonewtonsPerCubicCentimeter => ToUnit(SpecificWeightUnit.KilonewtonPerCubicCentimeter);

        /// <summary>
        ///     Gets this <see cref="SpecificWeight"/> converted into <see cref="SpecificWeightUnit.KilonewtonPerCubicMeter">KilonewtonsPerCubicMeter</see>.
        /// </summary>
        public SpecificWeight ToKilonewtonsPerCubicMeter => ToUnit(SpecificWeightUnit.KilonewtonPerCubicMeter);

        /// <summary>
        ///     Gets this <see cref="SpecificWeight"/> converted into <see cref="SpecificWeightUnit.KilonewtonPerCubicMillimeter">KilonewtonsPerCubicMillimeter</see>.
        /// </summary>
        public SpecificWeight ToKilonewtonsPerCubicMillimeter => ToUnit(SpecificWeightUnit.KilonewtonPerCubicMillimeter);

        /// <summary>
        ///     Gets this <see cref="SpecificWeight"/> converted into <see cref="SpecificWeightUnit.KilopoundForcePerCubicFoot">KilopoundsForcePerCubicFoot</see>.
        /// </summary>
        public SpecificWeight ToKilopoundsForcePerCubicFoot => ToUnit(SpecificWeightUnit.KilopoundForcePerCubicFoot);

        /// <summary>
        ///     Gets this <see cref="SpecificWeight"/> converted into <see cref="SpecificWeightUnit.KilopoundForcePerCubicInch">KilopoundsForcePerCubicInch</see>.
        /// </summary>
        public SpecificWeight ToKilopoundsForcePerCubicInch => ToUnit(SpecificWeightUnit.KilopoundForcePerCubicInch);

        /// <summary>
        ///     Gets this <see cref="SpecificWeight"/> converted into <see cref="SpecificWeightUnit.MeganewtonPerCubicMeter">MeganewtonsPerCubicMeter</see>.
        /// </summary>
        public SpecificWeight ToMeganewtonsPerCubicMeter => ToUnit(SpecificWeightUnit.MeganewtonPerCubicMeter);

        /// <summary>
        ///     Gets this <see cref="SpecificWeight"/> converted into <see cref="SpecificWeightUnit.NewtonPerCubicCentimeter">NewtonsPerCubicCentimeter</see>.
        /// </summary>
        public SpecificWeight ToNewtonsPerCubicCentimeter => ToUnit(SpecificWeightUnit.NewtonPerCubicCentimeter);

        /// <summary>
        ///     Gets this <see cref="SpecificWeight"/> converted into <see cref="SpecificWeightUnit.NewtonPerCubicMeter">NewtonsPerCubicMeter</see>.
        /// </summary>
        public SpecificWeight ToNewtonsPerCubicMeter => ToUnit(SpecificWeightUnit.NewtonPerCubicMeter);

        /// <summary>
        ///     Gets this <see cref="SpecificWeight"/> converted into <see cref="SpecificWeightUnit.NewtonPerCubicMillimeter">NewtonsPerCubicMillimeter</see>.
        /// </summary>
        public SpecificWeight ToNewtonsPerCubicMillimeter => ToUnit(SpecificWeightUnit.NewtonPerCubicMillimeter);

        /// <summary>
        ///     Gets this <see cref="SpecificWeight"/> converted into <see cref="SpecificWeightUnit.PoundForcePerCubicFoot">PoundsForcePerCubicFoot</see>.
        /// </summary>
        public SpecificWeight ToPoundsForcePerCubicFoot => ToUnit(SpecificWeightUnit.PoundForcePerCubicFoot);

        /// <summary>
        ///     Gets this <see cref="SpecificWeight"/> converted into <see cref="SpecificWeightUnit.PoundForcePerCubicInch">PoundsForcePerCubicInch</see>.
        /// </summary>
        public SpecificWeight ToPoundsForcePerCubicInch => ToUnit(SpecificWeightUnit.PoundForcePerCubicInch);

        /// <summary>
        ///     Gets this <see cref="SpecificWeight"/> converted into <see cref="SpecificWeightUnit.TonneForcePerCubicCentimeter">TonnesForcePerCubicCentimeter</see>.
        /// </summary>
        public SpecificWeight ToTonnesForcePerCubicCentimeter => ToUnit(SpecificWeightUnit.TonneForcePerCubicCentimeter);

        /// <summary>
        ///     Gets this <see cref="SpecificWeight"/> converted into <see cref="SpecificWeightUnit.TonneForcePerCubicMeter">TonnesForcePerCubicMeter</see>.
        /// </summary>
        public SpecificWeight ToTonnesForcePerCubicMeter => ToUnit(SpecificWeightUnit.TonneForcePerCubicMeter);

        /// <summary>
        ///     Gets this <see cref="SpecificWeight"/> converted into <see cref="SpecificWeightUnit.TonneForcePerCubicMillimeter">TonnesForcePerCubicMillimeter</see>.
        /// </summary>
        public SpecificWeight ToTonnesForcePerCubicMillimeter => ToUnit(SpecificWeightUnit.TonneForcePerCubicMillimeter);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="SpecificWeight"/> from <see cref="SpecificWeightUnit.KilogramForcePerCubicCentimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificWeight FromKilogramsForcePerCubicCentimeter(double kilogramsforcepercubiccentimeter) => new SpecificWeight(kilogramsforcepercubiccentimeter, SpecificWeightUnit.KilogramForcePerCubicCentimeter);

        /// <summary>
        ///     Creates a <see cref="SpecificWeight"/> from <see cref="SpecificWeightUnit.KilogramForcePerCubicMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificWeight FromKilogramsForcePerCubicMeter(double kilogramsforcepercubicmeter) => new SpecificWeight(kilogramsforcepercubicmeter, SpecificWeightUnit.KilogramForcePerCubicMeter);

        /// <summary>
        ///     Creates a <see cref="SpecificWeight"/> from <see cref="SpecificWeightUnit.KilogramForcePerCubicMillimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificWeight FromKilogramsForcePerCubicMillimeter(double kilogramsforcepercubicmillimeter) => new SpecificWeight(kilogramsforcepercubicmillimeter, SpecificWeightUnit.KilogramForcePerCubicMillimeter);

        /// <summary>
        ///     Creates a <see cref="SpecificWeight"/> from <see cref="SpecificWeightUnit.KilonewtonPerCubicCentimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificWeight FromKilonewtonsPerCubicCentimeter(double kilonewtonspercubiccentimeter) => new SpecificWeight(kilonewtonspercubiccentimeter, SpecificWeightUnit.KilonewtonPerCubicCentimeter);

        /// <summary>
        ///     Creates a <see cref="SpecificWeight"/> from <see cref="SpecificWeightUnit.KilonewtonPerCubicMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificWeight FromKilonewtonsPerCubicMeter(double kilonewtonspercubicmeter) => new SpecificWeight(kilonewtonspercubicmeter, SpecificWeightUnit.KilonewtonPerCubicMeter);

        /// <summary>
        ///     Creates a <see cref="SpecificWeight"/> from <see cref="SpecificWeightUnit.KilonewtonPerCubicMillimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificWeight FromKilonewtonsPerCubicMillimeter(double kilonewtonspercubicmillimeter) => new SpecificWeight(kilonewtonspercubicmillimeter, SpecificWeightUnit.KilonewtonPerCubicMillimeter);

        /// <summary>
        ///     Creates a <see cref="SpecificWeight"/> from <see cref="SpecificWeightUnit.KilopoundForcePerCubicFoot"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificWeight FromKilopoundsForcePerCubicFoot(double kilopoundsforcepercubicfoot) => new SpecificWeight(kilopoundsforcepercubicfoot, SpecificWeightUnit.KilopoundForcePerCubicFoot);

        /// <summary>
        ///     Creates a <see cref="SpecificWeight"/> from <see cref="SpecificWeightUnit.KilopoundForcePerCubicInch"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificWeight FromKilopoundsForcePerCubicInch(double kilopoundsforcepercubicinch) => new SpecificWeight(kilopoundsforcepercubicinch, SpecificWeightUnit.KilopoundForcePerCubicInch);

        /// <summary>
        ///     Creates a <see cref="SpecificWeight"/> from <see cref="SpecificWeightUnit.MeganewtonPerCubicMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificWeight FromMeganewtonsPerCubicMeter(double meganewtonspercubicmeter) => new SpecificWeight(meganewtonspercubicmeter, SpecificWeightUnit.MeganewtonPerCubicMeter);

        /// <summary>
        ///     Creates a <see cref="SpecificWeight"/> from <see cref="SpecificWeightUnit.NewtonPerCubicCentimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificWeight FromNewtonsPerCubicCentimeter(double newtonspercubiccentimeter) => new SpecificWeight(newtonspercubiccentimeter, SpecificWeightUnit.NewtonPerCubicCentimeter);

        /// <summary>
        ///     Creates a <see cref="SpecificWeight"/> from <see cref="SpecificWeightUnit.NewtonPerCubicMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificWeight FromNewtonsPerCubicMeter(double newtonspercubicmeter) => new SpecificWeight(newtonspercubicmeter, SpecificWeightUnit.NewtonPerCubicMeter);

        /// <summary>
        ///     Creates a <see cref="SpecificWeight"/> from <see cref="SpecificWeightUnit.NewtonPerCubicMillimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificWeight FromNewtonsPerCubicMillimeter(double newtonspercubicmillimeter) => new SpecificWeight(newtonspercubicmillimeter, SpecificWeightUnit.NewtonPerCubicMillimeter);

        /// <summary>
        ///     Creates a <see cref="SpecificWeight"/> from <see cref="SpecificWeightUnit.PoundForcePerCubicFoot"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificWeight FromPoundsForcePerCubicFoot(double poundsforcepercubicfoot) => new SpecificWeight(poundsforcepercubicfoot, SpecificWeightUnit.PoundForcePerCubicFoot);

        /// <summary>
        ///     Creates a <see cref="SpecificWeight"/> from <see cref="SpecificWeightUnit.PoundForcePerCubicInch"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificWeight FromPoundsForcePerCubicInch(double poundsforcepercubicinch) => new SpecificWeight(poundsforcepercubicinch, SpecificWeightUnit.PoundForcePerCubicInch);

        /// <summary>
        ///     Creates a <see cref="SpecificWeight"/> from <see cref="SpecificWeightUnit.TonneForcePerCubicCentimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificWeight FromTonnesForcePerCubicCentimeter(double tonnesforcepercubiccentimeter) => new SpecificWeight(tonnesforcepercubiccentimeter, SpecificWeightUnit.TonneForcePerCubicCentimeter);

        /// <summary>
        ///     Creates a <see cref="SpecificWeight"/> from <see cref="SpecificWeightUnit.TonneForcePerCubicMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificWeight FromTonnesForcePerCubicMeter(double tonnesforcepercubicmeter) => new SpecificWeight(tonnesforcepercubicmeter, SpecificWeightUnit.TonneForcePerCubicMeter);

        /// <summary>
        ///     Creates a <see cref="SpecificWeight"/> from <see cref="SpecificWeightUnit.TonneForcePerCubicMillimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificWeight FromTonnesForcePerCubicMillimeter(double tonnesforcepercubicmillimeter) => new SpecificWeight(tonnesforcepercubicmillimeter, SpecificWeightUnit.TonneForcePerCubicMillimeter);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="SpecificWeightUnit" /> to <see cref="SpecificWeight" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>SpecificWeight unit value.</returns>
        public static SpecificWeight From(double value, SpecificWeightUnit fromUnit)
        {
            return new SpecificWeight(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(SpecificWeightUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public SpecificWeight ToUnit(SpecificWeightUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new SpecificWeight(convertedValue, unit);
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
                SpecificWeightUnit.KilogramForcePerCubicCentimeter => _value * 9.80665e6,
                SpecificWeightUnit.KilogramForcePerCubicMeter => _value * 9.80665,
                SpecificWeightUnit.KilogramForcePerCubicMillimeter => _value * 9.80665e9,
                SpecificWeightUnit.KilonewtonPerCubicCentimeter => (_value * 1000000) * 1e3d,
                SpecificWeightUnit.KilonewtonPerCubicMeter => (_value) * 1e3d,
                SpecificWeightUnit.KilonewtonPerCubicMillimeter => (_value * 1000000000) * 1e3d,
                SpecificWeightUnit.KilopoundForcePerCubicFoot => (_value * 1.570874638462462e2) * 1e3d,
                SpecificWeightUnit.KilopoundForcePerCubicInch => (_value * 2.714471375263134e5) * 1e3d,
                SpecificWeightUnit.MeganewtonPerCubicMeter => (_value) * 1e6d,
                SpecificWeightUnit.NewtonPerCubicCentimeter => _value * 1000000,
                SpecificWeightUnit.NewtonPerCubicMeter => _value,
                SpecificWeightUnit.NewtonPerCubicMillimeter => _value * 1000000000,
                SpecificWeightUnit.PoundForcePerCubicFoot => _value * 1.570874638462462e2,
                SpecificWeightUnit.PoundForcePerCubicInch => _value * 2.714471375263134e5,
                SpecificWeightUnit.TonneForcePerCubicCentimeter => _value * 9.80665e9,
                SpecificWeightUnit.TonneForcePerCubicMeter => _value * 9.80665e3,
                SpecificWeightUnit.TonneForcePerCubicMillimeter => _value * 9.80665e12,
                _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
            };
        }

        private double GetValueAs(SpecificWeightUnit unit)
        {
            if (Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            return unit switch
            {
                SpecificWeightUnit.KilogramForcePerCubicCentimeter => baseUnitValue / 9.80665e6,
                SpecificWeightUnit.KilogramForcePerCubicMeter => baseUnitValue / 9.80665,
                SpecificWeightUnit.KilogramForcePerCubicMillimeter => baseUnitValue / 9.80665e9,
                SpecificWeightUnit.KilonewtonPerCubicCentimeter => (baseUnitValue * 0.000001) / 1e3d,
                SpecificWeightUnit.KilonewtonPerCubicMeter => (baseUnitValue) / 1e3d,
                SpecificWeightUnit.KilonewtonPerCubicMillimeter => (baseUnitValue * 0.000000001) / 1e3d,
                SpecificWeightUnit.KilopoundForcePerCubicFoot => (baseUnitValue / 1.570874638462462e2) / 1e3d,
                SpecificWeightUnit.KilopoundForcePerCubicInch => (baseUnitValue / 2.714471375263134e5) / 1e3d,
                SpecificWeightUnit.MeganewtonPerCubicMeter => (baseUnitValue) / 1e6d,
                SpecificWeightUnit.NewtonPerCubicCentimeter => baseUnitValue * 0.000001,
                SpecificWeightUnit.NewtonPerCubicMeter => baseUnitValue,
                SpecificWeightUnit.NewtonPerCubicMillimeter => baseUnitValue * 0.000000001,
                SpecificWeightUnit.PoundForcePerCubicFoot => baseUnitValue / 1.570874638462462e2,
                SpecificWeightUnit.PoundForcePerCubicInch => baseUnitValue / 2.714471375263134e5,
                SpecificWeightUnit.TonneForcePerCubicCentimeter => baseUnitValue / 9.80665e9,
                SpecificWeightUnit.TonneForcePerCubicMeter => baseUnitValue / 9.80665e3,
                SpecificWeightUnit.TonneForcePerCubicMillimeter => baseUnitValue / 9.80665e12,
                _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
            };
        }

        #endregion
    }
}

